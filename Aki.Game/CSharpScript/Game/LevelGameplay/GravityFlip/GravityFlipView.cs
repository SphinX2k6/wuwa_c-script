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
	// Token: 0x02005F9E RID: 24478
	[NullableContext(2)]
	[Nullable(0)]
	public class GravityFlipView : UiViewBase
	{
		// Token: 0x0603AD02 RID: 240898 RVA: 0x010A08FF File Offset: 0x0109EAFF
		[NullableContext(1)]
		public GravityFlipView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AD03 RID: 240899 RVA: 0x010A0910 File Offset: 0x0109EB10
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

		// Token: 0x0603AD04 RID: 240900 RVA: 0x010A0AE8 File Offset: 0x0109ECE8
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

		// Token: 0x0603AD05 RID: 240901 RVA: 0x010A0BA3 File Offset: 0x0109EDA3
		protected override void OnBeforeShow()
		{
			this.SetBtnState(true);
		}

		// Token: 0x0603AD06 RID: 240902 RVA: 0x010A0BAC File Offset: 0x0109EDAC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnGravityFlipAnimFinish, new Action(this.OnGravityFlipAnimFinish));
		}

		// Token: 0x0603AD07 RID: 240903 RVA: 0x010A0BCA File Offset: 0x0109EDCA
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnGravityFlipAnimFinish, new Action(this.OnGravityFlipAnimFinish));
		}

		// Token: 0x0603AD08 RID: 240904 RVA: 0x010A0BE8 File Offset: 0x0109EDE8
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

		// Token: 0x0603AD09 RID: 240905 RVA: 0x010A0C44 File Offset: 0x0109EE44
		private void OnUpArrowClick()
		{
			this.OnArrowBtnClick(0);
		}

		// Token: 0x0603AD0A RID: 240906 RVA: 0x010A0C4D File Offset: 0x0109EE4D
		private void OnLeftArrowClick()
		{
			this.OnArrowBtnClick(1);
		}

		// Token: 0x0603AD0B RID: 240907 RVA: 0x010A0C56 File Offset: 0x0109EE56
		private void OnRightArrowClick()
		{
			this.OnArrowBtnClick(2);
		}

		// Token: 0x0603AD0C RID: 240908 RVA: 0x010A0C5F File Offset: 0x0109EE5F
		private void OnDownArrowClick()
		{
			this.OnArrowBtnClick(4);
		}

		// Token: 0x0603AD0D RID: 240909 RVA: 0x010A0C68 File Offset: 0x0109EE68
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

		// Token: 0x0603AD0E RID: 240910 RVA: 0x010A0D70 File Offset: 0x0109EF70
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

		// Token: 0x0603AD0F RID: 240911 RVA: 0x010A0DCC File Offset: 0x0109EFCC
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

		// Token: 0x0603AD10 RID: 240912 RVA: 0x010A0FC8 File Offset: 0x0109F1C8
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

		// Token: 0x0603AD11 RID: 240913 RVA: 0x010A107C File Offset: 0x0109F27C
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

		// Token: 0x0603AD12 RID: 240914 RVA: 0x010A1134 File Offset: 0x0109F334
		[NullableContext(1)]
		private void OnPlotNetworkEnd(PlotResultInfo _)
		{
			EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotNetworkEnd));
			GravityFlipModel.Instance.GravityFlipComp.OnNotifyUpdateGravityDirection(GravityFlipModel.Instance.CacheCorrectDirection);
		}

		// Token: 0x0401EE9F RID: 126623
		private UUIButtonComponent BtnUpArrow;

		// Token: 0x0401EEA0 RID: 126624
		private UUIButtonComponent BtnRightArrow;

		// Token: 0x0401EEA1 RID: 126625
		private UUIButtonComponent BtnLeftArrow;

		// Token: 0x0401EEA2 RID: 126626
		private UUIButtonComponent BtnDownArrow;

		// Token: 0x0401EEA3 RID: 126627
		private LevelSequencePlayer DownArrowSeqPlayer;

		// Token: 0x0401EEA4 RID: 126628
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401EEA5 RID: 126629
		private int TargetDirection = -1;

		// Token: 0x0401EEA6 RID: 126630
		private bool IsPlayingTurnAnim;

		// Token: 0x0200B8C5 RID: 47301
		[NullableContext(0)]
		private class EGravityFlipView
		{
			// Token: 0x0403908C RID: 233612
			public const int BtnUpArrow = 0;

			// Token: 0x0403908D RID: 233613
			public const int BtnLeftArrow = 1;

			// Token: 0x0403908E RID: 233614
			public const int BtnRightArrow = 2;

			// Token: 0x0403908F RID: 233615
			public const int BtnClose = 3;

			// Token: 0x04039090 RID: 233616
			public const int BtnDownArrow = 4;

			// Token: 0x04039091 RID: 233617
			public const int ArrowPanel = 5;

			// Token: 0x04039092 RID: 233618
			public const int TargetArrow = 6;
		}
	}
}
