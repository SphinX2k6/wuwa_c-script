using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02005BAB RID: 23467
	[NullableContext(1)]
	[Nullable(0)]
	public class SignalDeviceModel : ModelBase
	{
		// Token: 0x17006DFC RID: 28156
		// (get) Token: 0x06039B23 RID: 236323 RVA: 0x01033023 File Offset: 0x01031223
		public static int ROWNUM
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x06039B24 RID: 236324 RVA: 0x01033028 File Offset: 0x01031228
		public void InitData(List<IColorPiece> config)
		{
			this.GridStateArray = new List<IGridState>(this.GridNum);
			for (int i = 0; i < this.GridNum; i++)
			{
				this.GridStateArray.Add(new GridState
				{
					IsFinished = false,
					Color = config[i].Color
				});
			}
			this.ResetLinking();
		}

		// Token: 0x06039B25 RID: 236325 RVA: 0x01033088 File Offset: 0x01031288
		public void ResetData()
		{
			foreach (IGridState gridState in this.GridStateArray)
			{
				gridState.IsFinished = false;
			}
			this.ResetLinking();
			EventSystem.Instance.Emit(EEventName.OnSignalDeviceReset);
		}

		// Token: 0x06039B26 RID: 236326 RVA: 0x010330F0 File Offset: 0x010312F0
		public bool IsGridFinished(int index)
		{
			return index >= 0 && index < this.GridStateArray.Count && this.GridStateArray[index].IsFinished;
		}

		// Token: 0x06039B27 RID: 236327 RVA: 0x01033117 File Offset: 0x01031317
		public EPieceColorType GetGridColor(int index)
		{
			if (index < 0 || index >= this.GridStateArray.Count)
			{
				return EPieceColorType.White;
			}
			return this.GridStateArray[index].Color;
		}

		// Token: 0x06039B28 RID: 236328 RVA: 0x0103313E File Offset: 0x0103133E
		public void LinkingStart(int index, EPieceColorType color)
		{
			this.CurrentColor = color;
			this.LinkingArray = new List<int>
			{
				index
			};
		}

		// Token: 0x06039B29 RID: 236329 RVA: 0x0103315C File Offset: 0x0103135C
		public void Linking(int index)
		{
			int num = this.LinkingArray[this.LinkingArray.Count - 1];
			if (!this.LinkingArray.Contains(index) && this.NeighboringType(num, index) != ENeighborType.None && this.LinkingValid(index))
			{
				this.LinkingArray.Add(index);
				EventSystem.Instance.Emit<bool, int, bool, int, bool>(EEventName.OnSignalDeviceLinking, true, num, this.GridStateArray[num].Color == this.CurrentColor, index, this.GridStateArray[index].Color == this.CurrentColor);
				if (this.GridStateArray[index].Color == this.CurrentColor)
				{
					this.CheckLinking(index);
					return;
				}
			}
			else if (this.LinkingArray.Count > 1 && this.LinkingArray.IndexOf(index) == this.LinkingArray.Count - 2)
			{
				this.LinkingArray.RemoveAt(this.LinkingArray.Count - 1);
				EventSystem.Instance.Emit<bool, int, bool, int, bool>(EEventName.OnSignalDeviceLinking, false, num, this.GridStateArray[num].Color == this.CurrentColor, index, this.GridStateArray[index].Color == this.CurrentColor);
			}
		}

		// Token: 0x06039B2A RID: 236330 RVA: 0x010332A4 File Offset: 0x010314A4
		public ENeighborType NeighboringType(int indexFrom, int indexTo)
		{
			int num = indexFrom - indexTo;
			if ((num == -1 && indexTo % 5 == 0) || (num == 1 && indexFrom % 5 == 0))
			{
				return ENeighborType.None;
			}
			if (num <= -1)
			{
				if (num == -5)
				{
					return ENeighborType.ToDown;
				}
				if (num == -1)
				{
					return ENeighborType.ToRight;
				}
			}
			else
			{
				if (num == 1)
				{
					return ENeighborType.ToLeft;
				}
				if (num == 5)
				{
					return ENeighborType.ToUp;
				}
			}
			return ENeighborType.None;
		}

		// Token: 0x06039B2B RID: 236331 RVA: 0x010332EC File Offset: 0x010314EC
		private bool LinkingValid(int index)
		{
			return (this.GridStateArray[index].Color == EPieceColorType.White && !this.GridStateArray[index].IsFinished) || this.GridStateArray[index].Color == this.CurrentColor;
		}

		// Token: 0x06039B2C RID: 236332 RVA: 0x0103333C File Offset: 0x0103153C
		public void CheckLinking(int index)
		{
			if (this.LinkingArray.Count == 0)
			{
				return;
			}
			int index2 = this.LinkingArray[this.LinkingArray.Count - 1];
			if (this.GetGridColor(index2) != this.CurrentColor || this.LinkingArray.Count == 1)
			{
				this.CancelCurrentLinking();
				return;
			}
			this.MarkCurrentLinking();
		}

		// Token: 0x06039B2D RID: 236333 RVA: 0x0103339C File Offset: 0x0103159C
		public void MarkCurrentLinking()
		{
			EventSystem.Instance.Emit<bool, IReadOnlyList<int>>(EEventName.OnSignalDeviceLinkingCheck, true, this.LinkingArray);
			foreach (int index in this.LinkingArray)
			{
				this.GridStateArray[index].IsFinished = true;
			}
			this.ResetLinking();
			if (this.CheckFinished())
			{
				this.RequestFinish();
			}
		}

		// Token: 0x06039B2E RID: 236334 RVA: 0x01033428 File Offset: 0x01031628
		public void CancelCurrentLinking()
		{
			EventSystem.Instance.Emit<bool, IReadOnlyList<int>>(EEventName.OnSignalDeviceLinkingCheck, false, this.LinkingArray);
			this.ResetLinking();
		}

		// Token: 0x06039B2F RID: 236335 RVA: 0x01033448 File Offset: 0x01031648
		private bool CheckFinished()
		{
			foreach (IGridState gridState in this.GridStateArray)
			{
				if (gridState.Color != EPieceColorType.White && !gridState.IsFinished)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06039B30 RID: 236336 RVA: 0x010334AC File Offset: 0x010316AC
		private void RequestFinish()
		{
			EventSystem.Instance.Emit(EEventName.OnSignalDeviceFinish);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UiGamePlayRequest uiGamePlayRequest = UiGamePlayRequest.Create();
				uiGamePlayRequest.GamePlayKey = "0";
				uiGamePlayRequest.Type = UiGamePlayType.SignalDevice;
				Net.Instance.Call(ERequestMessageId.UiGamePlayRequest, uiGamePlayRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					if (((UiGamePlayResponse)msg).ErrorId == ErrorCode.Success)
					{
						this.ClearData();
						SignalDeviceController.Instance.CallFinishCallback();
					}
				}, 0);
			}, (float)((int)(1.7 * (double)TimeUtil.Instance.InverseMillisecond)), null, null, true, 1f);
		}

		// Token: 0x06039B31 RID: 236337 RVA: 0x010334FF File Offset: 0x010316FF
		private void ClearData()
		{
			this.GridStateArray.Clear();
			this.ResetLinking();
		}

		// Token: 0x06039B32 RID: 236338 RVA: 0x01033512 File Offset: 0x01031712
		private void ResetLinking()
		{
			this.LinkingArray.Clear();
			this.CurrentColor = EPieceColorType.White;
		}

		// Token: 0x17006DFD RID: 28157
		// (get) Token: 0x06039B33 RID: 236339 RVA: 0x01033526 File Offset: 0x01031726
		public static SignalDeviceModel Instance
		{
			get
			{
				return SignalDeviceModel._Instance;
			}
		}

		// Token: 0x06039B34 RID: 236340 RVA: 0x0103352D File Offset: 0x0103172D
		public static SignalDeviceModel GetOrCreateInstance()
		{
			if (SignalDeviceModel._Instance == null)
			{
				SignalDeviceModel.CreateInstance();
			}
			return SignalDeviceModel._Instance;
		}

		// Token: 0x06039B35 RID: 236341 RVA: 0x01033541 File Offset: 0x01031741
		public static bool CreateInstance()
		{
			if (SignalDeviceModel._Instance != null)
			{
				return true;
			}
			SignalDeviceModel._Instance = new SignalDeviceModel();
			return true;
		}

		// Token: 0x06039B36 RID: 236342 RVA: 0x01033557 File Offset: 0x01031757
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039B37 RID: 236343 RVA: 0x01033559 File Offset: 0x01031759
		public static void ResetStaticDefaultValue()
		{
			SignalDeviceModel._Instance = null;
		}

		// Token: 0x06039B38 RID: 236344 RVA: 0x01033561 File Offset: 0x01031761
		static SignalDeviceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SignalDeviceModel.CreateStaticDefaultValue), new Action(SignalDeviceModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E745 RID: 124741
		public int GridNum = 25;

		// Token: 0x0401E746 RID: 124742
		private List<IGridState> GridStateArray = new List<IGridState>();

		// Token: 0x0401E747 RID: 124743
		private List<int> LinkingArray = new List<int>();

		// Token: 0x0401E748 RID: 124744
		public EPieceColorType CurrentColor;

		// Token: 0x0401E749 RID: 124745
		public global::Rotator CacheRotator = global::Rotator.Create(0f, 0f, 0f);

		// Token: 0x0401E74A RID: 124746
		public EViewType ViewType;

		// Token: 0x0401E74B RID: 124747
		public readonly Dictionary<ENeighborType, int> RotateMap = new Dictionary<ENeighborType, int>
		{
			{
				ENeighborType.None,
				0
			},
			{
				ENeighborType.ToDown,
				-90
			},
			{
				ENeighborType.ToUp,
				90
			},
			{
				ENeighborType.ToLeft,
				180
			},
			{
				ENeighborType.ToRight,
				0
			}
		};

		// Token: 0x0401E74C RID: 124748
		[Nullable(2)]
		private static SignalDeviceModel _Instance;
	}
}
