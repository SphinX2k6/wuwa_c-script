using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02006A4E RID: 27214
	[NullableContext(1)]
	[Nullable(0)]
	public class SignalDeviceModel : ModelBase
	{
		// Token: 0x17009917 RID: 39191
		// (get) Token: 0x06043AD5 RID: 277205 RVA: 0x0108E81B File Offset: 0x0108CA1B
		public static int ROWNUM
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x06043AD6 RID: 277206 RVA: 0x0108E820 File Offset: 0x0108CA20
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

		// Token: 0x06043AD7 RID: 277207 RVA: 0x0108E880 File Offset: 0x0108CA80
		public void ResetData()
		{
			foreach (IGridState gridState in this.GridStateArray)
			{
				gridState.IsFinished = false;
			}
			this.ResetLinking();
			EventSystem.Instance.Emit(EEventName.OnSignalDeviceReset);
		}

		// Token: 0x06043AD8 RID: 277208 RVA: 0x0108E8E8 File Offset: 0x0108CAE8
		public bool IsGridFinished(int index)
		{
			IGridState gridState = this.GridStateArray.ElementAtOrDefault(index);
			return gridState != null && gridState.IsFinished;
		}

		// Token: 0x06043AD9 RID: 277209 RVA: 0x0108E901 File Offset: 0x0108CB01
		public EPieceColorType GetGridColor(int index)
		{
			IGridState gridState = this.GridStateArray.ElementAtOrDefault(index);
			if (gridState == null)
			{
				return EPieceColorType.White;
			}
			return gridState.Color;
		}

		// Token: 0x06043ADA RID: 277210 RVA: 0x0108E91A File Offset: 0x0108CB1A
		public void LinkingStart(int index, EPieceColorType color)
		{
			this.CurrentColor = color;
			this.LinkingArray = new List<int>
			{
				index
			};
		}

		// Token: 0x06043ADB RID: 277211 RVA: 0x0108E938 File Offset: 0x0108CB38
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

		// Token: 0x06043ADC RID: 277212 RVA: 0x0108EA80 File Offset: 0x0108CC80
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

		// Token: 0x06043ADD RID: 277213 RVA: 0x0108EAC8 File Offset: 0x0108CCC8
		private bool LinkingValid(int index)
		{
			return (this.GridStateArray[index].Color == EPieceColorType.White && !this.GridStateArray[index].IsFinished) || this.GridStateArray[index].Color == this.CurrentColor;
		}

		// Token: 0x06043ADE RID: 277214 RVA: 0x0108EB18 File Offset: 0x0108CD18
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

		// Token: 0x06043ADF RID: 277215 RVA: 0x0108EB78 File Offset: 0x0108CD78
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

		// Token: 0x06043AE0 RID: 277216 RVA: 0x0108EC04 File Offset: 0x0108CE04
		public void CancelCurrentLinking()
		{
			EventSystem.Instance.Emit<bool, IReadOnlyList<int>>(EEventName.OnSignalDeviceLinkingCheck, false, this.LinkingArray);
			this.ResetLinking();
		}

		// Token: 0x06043AE1 RID: 277217 RVA: 0x0108EC24 File Offset: 0x0108CE24
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

		// Token: 0x06043AE2 RID: 277218 RVA: 0x0108EC88 File Offset: 0x0108CE88
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

		// Token: 0x06043AE3 RID: 277219 RVA: 0x0108ECDB File Offset: 0x0108CEDB
		private void ClearData()
		{
			this.GridStateArray.Clear();
			this.ResetLinking();
		}

		// Token: 0x06043AE4 RID: 277220 RVA: 0x0108ECEE File Offset: 0x0108CEEE
		private void ResetLinking()
		{
			this.LinkingArray.Clear();
			this.CurrentColor = EPieceColorType.White;
		}

		// Token: 0x17009918 RID: 39192
		// (get) Token: 0x06043AE5 RID: 277221 RVA: 0x0108ED02 File Offset: 0x0108CF02
		public static SignalDeviceModel Instance
		{
			get
			{
				return SignalDeviceModel._Instance;
			}
		}

		// Token: 0x06043AE6 RID: 277222 RVA: 0x0108ED09 File Offset: 0x0108CF09
		public static SignalDeviceModel GetOrCreateInstance()
		{
			if (SignalDeviceModel._Instance == null)
			{
				SignalDeviceModel.CreateInstance();
			}
			return SignalDeviceModel._Instance;
		}

		// Token: 0x06043AE7 RID: 277223 RVA: 0x0108ED1D File Offset: 0x0108CF1D
		public static bool CreateInstance()
		{
			if (SignalDeviceModel._Instance != null)
			{
				return true;
			}
			SignalDeviceModel._Instance = new SignalDeviceModel();
			return true;
		}

		// Token: 0x06043AE8 RID: 277224 RVA: 0x0108ED33 File Offset: 0x0108CF33
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043AE9 RID: 277225 RVA: 0x0108ED35 File Offset: 0x0108CF35
		public static void ResetStaticDefaultValue()
		{
			SignalDeviceModel._Instance = null;
		}

		// Token: 0x06043AEA RID: 277226 RVA: 0x0108ED3D File Offset: 0x0108CF3D
		static SignalDeviceModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SignalDeviceModel.CreateStaticDefaultValue), new Action(SignalDeviceModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023553 RID: 144723
		public int GridNum = 25;

		// Token: 0x04023554 RID: 144724
		private List<IGridState> GridStateArray = new List<IGridState>();

		// Token: 0x04023555 RID: 144725
		private List<int> LinkingArray = new List<int>();

		// Token: 0x04023556 RID: 144726
		public EPieceColorType CurrentColor;

		// Token: 0x04023557 RID: 144727
		public global::Rotator CacheRotator = global::Rotator.Create(0f, 0f, 0f);

		// Token: 0x04023558 RID: 144728
		public EViewType ViewType;

		// Token: 0x04023559 RID: 144729
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

		// Token: 0x0402355A RID: 144730
		[Nullable(2)]
		private static SignalDeviceModel _Instance;
	}
}
