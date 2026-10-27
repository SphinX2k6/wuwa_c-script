using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02006E1E RID: 28190
	[NullableContext(2)]
	[Nullable(0)]
	public class GravityFlipView : UiViewBase
	{
		// Token: 0x06044B99 RID: 281497 RVA: 0x010F63C3 File Offset: 0x010F45C3
		[NullableContext(1)]
		public GravityFlipView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06044B9A RID: 281498 RVA: 0x010F63D4 File Offset: 0x010F45D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnUpArrowClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnLeftArrowClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnRightArrowClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnCloseClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnDownArrowClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06044B9B RID: 281499 RVA: 0x010F65AC File Offset: 0x010F47AC
		protected override void OnStart()
		{
			this.BtnUpArrow = base.GetButton(0);
			this.BtnLeftArrow = base.GetButton(1);
			this.BtnRightArrow = base.GetButton(2);
			this.BtnDownArrow = base.GetButton(4);
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.DownArrowSeqPlayer = new LevelSequencePlayer(this.BtnDownArrow.RootUIComp);
			this.TargetDirection = (int)GravityFlipModel.Instance.TargetDirection;
			if (this.TargetDirection == -1)
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(false);
				}
			}
			GravityFlipViewOpenParam gravityFlipViewOpenParam = this.OpenParam as GravityFlipViewOpenParam;
			GravityFlipModel.Instance.ViewCallBackCache = ((gravityFlipViewOpenParam != null) ? gravityFlipViewOpenParam.SelectCallback : null);
		}

		// Token: 0x06044B9C RID: 281500 RVA: 0x010F6667 File Offset: 0x010F4867
		protected override void OnBeforeShow()
		{
			this.SetBtnState(true);
		}

		// Token: 0x06044B9D RID: 281501 RVA: 0x010F6670 File Offset: 0x010F4870
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnGravityFlipAnimFinish, new Action(this.OnGravityFlipAnimFinish));
		}

		// Token: 0x06044B9E RID: 281502 RVA: 0x010F668E File Offset: 0x010F488E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnGravityFlipAnimFinish, new Action(this.OnGravityFlipAnimFinish));
		}

		// Token: 0x06044B9F RID: 281503 RVA: 0x010F66AC File Offset: 0x010F48AC
		private void OnCloseClick()
		{
			if (this.IsPlayingTurnAnim)
			{
				return;
			}
			GravityFlipViewOpenParam gravityFlipViewOpenParam = this.OpenParam as GravityFlipViewOpenParam;
			Action<int> callback = (gravityFlipViewOpenParam != null) ? gravityFlipViewOpenParam.SelectCallback : null;
			GravityFlipController.Instance.ListenTeleportCompleteEvent(callback);
			SceneItemGravityFlipComponent gravityFlipComp = GravityFlipModel.Instance.GravityFlipComp;
			if (gravityFlipComp != null)
			{
				gravityFlipComp.OnExitInteract(false);
			}
			this.RequestGravityFlip();
			base.CloseMe(null);
		}

		// Token: 0x06044BA0 RID: 281504 RVA: 0x010F6708 File Offset: 0x010F4908
		private void OnUpArrowClick()
		{
			this.OnArrowBtnClick(0);
		}

		// Token: 0x06044BA1 RID: 281505 RVA: 0x010F6711 File Offset: 0x010F4911
		private void OnLeftArrowClick()
		{
			this.OnArrowBtnClick(1);
		}

		// Token: 0x06044BA2 RID: 281506 RVA: 0x010F671A File Offset: 0x010F491A
		private void OnRightArrowClick()
		{
			this.OnArrowBtnClick(2);
		}

		// Token: 0x06044BA3 RID: 281507 RVA: 0x010F6723 File Offset: 0x010F4923
		private void OnDownArrowClick()
		{
			this.OnArrowBtnClick(4);
		}

		// Token: 0x06044BA4 RID: 281508 RVA: 0x010F672C File Offset: 0x010F492C
		private void OnArrowBtnClick(int btn)
		{
			if (this.IsPlayingTurnAnim)
			{
				return;
			}
			int num = -1;
			int num2 = 0;
			string sequenceName = "Turn_180";
			switch (btn)
			{
			case 0:
				num2 = 180;
				num = 2;
				sequenceName = "Turn_180";
				break;
			case 1:
				num2 = 90;
				num = 1;
				sequenceName = "Turn_90_Zheng";
				break;
			case 2:
				num2 = 270;
				num = 0;
				sequenceName = "Turn_90_Fu";
				break;
			case 4:
				num2 = 0;
				break;
			}
			EGravityDirection currentGravityDirection = GravityFlipModel.Instance.CurrentGravityDirection;
			GravityFlipModel.Instance.CurrentGravityDirection = (num2 + currentGravityDirection) % (EGravityDirection)360;
			if (num != -1)
			{
				GravityFlipViewOpenParam gravityFlipViewOpenParam = this.OpenParam as GravityFlipViewOpenParam;
				Action<int> action = (gravityFlipViewOpenParam != null) ? gravityFlipViewOpenParam.SelectCallback : null;
				if (action != null)
				{
					action(num);
				}
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer != null)
				{
					seqPlayer.PlayLevelSequenceByName("Turn", false, null, false);
				}
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequence(sequenceName, false, null);
				}
				GravityFlipController.Instance.OnChangeGravityDirection((EGravityDirection)num2);
				this.IsPlayingTurnAnim = true;
			}
			this.SetAllBtnInteractive(false);
		}

		// Token: 0x06044BA5 RID: 281509 RVA: 0x010F6834 File Offset: 0x010F4A34
		private void OnGravityFlipAnimFinish()
		{
			this.SetBtnState(false);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Turn_Finish", false, null, false);
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Turn_Finish", false, null);
			}
			this.IsPlayingTurnAnim = false;
		}

		// Token: 0x06044BA6 RID: 281510 RVA: 0x010F6890 File Offset: 0x010F4A90
		private void SetBtnState(bool isInit = false)
		{
			this.SetAllBtnInteractive(false);
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			int num = (this.TargetDirection == -1) ? 0 : this.TargetDirection;
			EGravityDirection curGravityDirection = GravityFlipModel.Instance.GravityFlipComp.CurGravityDirection;
			int num2 = (360 + curGravityDirection - (EGravityDirection)num) % 360;
			if (isInit && this.TargetDirection != -1)
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					FRotator frotator = new FRotator(0f, (float)num2, 0f);
					item.SetUIRelativeRotation(frotator);
				}
			}
			foreach (EGravityDirection egravityDirection in GravityFlipModel.Instance.ValidGravityDirections)
			{
				int num3 = (int)(((EGravityDirection)360 - (int)GravityFlipModel.Instance.CurrentGravityDirection + (int)egravityDirection) % (EGravityDirection)360);
				if (num3 != 90)
				{
					if (num3 != 180)
					{
						if (num3 == 270)
						{
							flag2 = true;
						}
					}
					else
					{
						flag3 = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (flag2 != this.BtnRightArrow.GetSelfInteractive())
			{
				UUIButtonComponent btnRightArrow = this.BtnRightArrow;
				if (btnRightArrow != null)
				{
					btnRightArrow.SetSelfInteractive(flag2);
				}
				UUIButtonComponent btnRightArrow2 = this.BtnRightArrow;
				if (btnRightArrow2 != null)
				{
					btnRightArrow2.RootUIComp.Get().SetUIActive(flag2);
				}
			}
			if (flag != this.BtnLeftArrow.GetSelfInteractive())
			{
				UUIButtonComponent btnLeftArrow = this.BtnLeftArrow;
				if (btnLeftArrow != null)
				{
					btnLeftArrow.SetSelfInteractive(flag);
				}
				UUIButtonComponent btnLeftArrow2 = this.BtnLeftArrow;
				if (btnLeftArrow2 != null)
				{
					btnLeftArrow2.RootUIComp.Get().SetUIActive(flag);
				}
			}
			if (flag3 != this.BtnUpArrow.GetSelfInteractive())
			{
				UUIButtonComponent btnUpArrow = this.BtnUpArrow;
				if (btnUpArrow != null)
				{
					btnUpArrow.SetSelfInteractive(flag3);
				}
				UUIButtonComponent btnUpArrow2 = this.BtnUpArrow;
				if (btnUpArrow2 != null)
				{
					btnUpArrow2.RootUIComp.Get().SetUIActive(flag3);
				}
			}
			LevelSequencePlayer downArrowSeqPlayer = this.DownArrowSeqPlayer;
			if (downArrowSeqPlayer != null)
			{
				downArrowSeqPlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer downArrowSeqPlayer2 = this.DownArrowSeqPlayer;
			if (downArrowSeqPlayer2 == null)
			{
				return;
			}
			downArrowSeqPlayer2.PlayLevelSequenceByName("Gray", false, null, false);
		}

		// Token: 0x06044BA7 RID: 281511 RVA: 0x010F6A8C File Offset: 0x010F4C8C
		private void SetAllBtnInteractive(bool interactiveEnable)
		{
			UUIButtonComponent btnUpArrow = this.BtnUpArrow;
			if (btnUpArrow != null)
			{
				btnUpArrow.SetSelfInteractive(interactiveEnable);
			}
			UUIButtonComponent btnUpArrow2 = this.BtnUpArrow;
			if (btnUpArrow2 != null)
			{
				btnUpArrow2.RootUIComp.Get().SetUIActive(interactiveEnable);
			}
			UUIButtonComponent btnLeftArrow = this.BtnLeftArrow;
			if (btnLeftArrow != null)
			{
				btnLeftArrow.SetSelfInteractive(interactiveEnable);
			}
			UUIButtonComponent btnLeftArrow2 = this.BtnLeftArrow;
			if (btnLeftArrow2 != null)
			{
				btnLeftArrow2.RootUIComp.Get().SetUIActive(interactiveEnable);
			}
			UUIButtonComponent btnRightArrow = this.BtnRightArrow;
			if (btnRightArrow != null)
			{
				btnRightArrow.SetSelfInteractive(interactiveEnable);
			}
			UUIButtonComponent btnRightArrow2 = this.BtnRightArrow;
			if (btnRightArrow2 != null)
			{
				btnRightArrow2.RootUIComp.Get().SetUIActive(interactiveEnable);
			}
			UUIButtonComponent btnDownArrow = this.BtnDownArrow;
			if (btnDownArrow == null)
			{
				return;
			}
			btnDownArrow.SetSelfInteractive(interactiveEnable);
		}

		// Token: 0x06044BA8 RID: 281512 RVA: 0x010F6B40 File Offset: 0x010F4D40
		private void RequestGravityFlip()
		{
			if (!GravityFlipModel.Instance.NeedChangeGravity())
			{
				GravityFlipController.Instance.CancelWaitTeleport();
				return;
			}
			long gravityFlipEntityCreatureDataId = GravityFlipModel.Instance.GravityFlipEntityCreatureDataId;
			if (gravityFlipEntityCreatureDataId == -1L)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "[GravityFlipView] 未找到重力翻转实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				GravityFlipController.Instance.CancelWaitTeleport();
				return;
			}
			GravityFlipType flipType = GravityFlipModel.Instance.CurGravityFlipType;
			GravityFlipInteractRequest gravityFlipInteractRequest = GravityFlipInteractRequest.Create();
			gravityFlipInteractRequest.GravityFlipEntityId = MathUtils.Instance.NumberToLong(gravityFlipEntityCreatureDataId);
			gravityFlipInteractRequest.TargetGravityFlipType = flipType;
			Net.Instance.Call(ERequestMessageId.GravityFlipInteractRequest, gravityFlipInteractRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				GravityFlipInteractResponse gravityFlipInteractResponse = (GravityFlipInteractResponse)msg;
				ErrorCode errorCode = gravityFlipInteractResponse.ErrorCode;
				if (errorCode != ErrorCode.Success)
				{
					if (errorCode - ErrorCode.ErrOnlineInteractNoPermission <= 1 || errorCode == ErrorCode.GravityFlipLocked)
					{
						GravityFlipController.Instance.CancelWaitTeleport();
					}
					else
					{
						GravityFlipController.Instance.CancelWaitTeleport();
						ErrorCodeController.Instance.OpenErrorCodeTipView(gravityFlipInteractResponse.ErrorCode, EResponseMessageId.BeControlledResponse, null, true, true);
					}
				}
				GravityFlipModel.Instance.GravityFlipComp.SetGravityDirection(new GravityFlipType?(flipType));
				if (flipType != gravityFlipInteractResponse.CurGravityFlipType)
				{
					EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
					GravityFlipModel.Instance.CacheCorrectDirection = gravityFlipInteractResponse.CurGravityFlipType;
				}
			}, 0);
		}

		// Token: 0x06044BA9 RID: 281513 RVA: 0x010F6BF8 File Offset: 0x010F4DF8
		[NullableContext(1)]
		private void OnPlotNetworkEnd(PlotResultInfo _)
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
			GravityFlipModel.Instance.GravityFlipComp.OnNotifyUpdateGravityDirection(GravityFlipModel.Instance.CacheCorrectDirection);
		}

		// Token: 0x04023BFC RID: 146428
		private UUIButtonComponent BtnUpArrow;

		// Token: 0x04023BFD RID: 146429
		private UUIButtonComponent BtnRightArrow;

		// Token: 0x04023BFE RID: 146430
		private UUIButtonComponent BtnLeftArrow;

		// Token: 0x04023BFF RID: 146431
		private UUIButtonComponent BtnDownArrow;

		// Token: 0x04023C00 RID: 146432
		private LevelSequencePlayer DownArrowSeqPlayer;

		// Token: 0x04023C01 RID: 146433
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04023C02 RID: 146434
		private int TargetDirection = -1;

		// Token: 0x04023C03 RID: 146435
		private bool IsPlayingTurnAnim;

		// Token: 0x0200CCD5 RID: 52437
		[NullableContext(0)]
		private class EGravityFlipView
		{
			// Token: 0x0403DC6A RID: 253034
			public const int BtnUpArrow = 0;

			// Token: 0x0403DC6B RID: 253035
			public const int BtnLeftArrow = 1;

			// Token: 0x0403DC6C RID: 253036
			public const int BtnRightArrow = 2;

			// Token: 0x0403DC6D RID: 253037
			public const int BtnClose = 3;

			// Token: 0x0403DC6E RID: 253038
			public const int BtnDownArrow = 4;

			// Token: 0x0403DC6F RID: 253039
			public const int ArrowPanel = 5;

			// Token: 0x0403DC70 RID: 253040
			public const int TargetArrow = 6;
		}
	}
}
