using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SignalDeviceControl.SiganalDeviceUIItem;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SignalDeviceControl
{
	// Token: 0x02005BAE RID: 23470
	[NullableContext(2)]
	[Nullable(0)]
	public class SignalDeviceView : UiViewBase
	{
		// Token: 0x06039B3E RID: 236350 RVA: 0x0103367A File Offset: 0x0103187A
		[NullableContext(1)]
		public SignalDeviceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039B3F RID: 236351 RVA: 0x0103369C File Offset: 0x0103189C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnResetClicked)),
				new ValueTuple<int, Delegate>(1, new Action(this.OnBtnBackClicked)),
				new ValueTuple<int, Delegate>(2, new Action(this.OnBtnHelpClicked))
			};
		}

		// Token: 0x06039B40 RID: 236352 RVA: 0x0103382C File Offset: 0x01031A2C
		protected override UniTask OnCreateAsync()
		{
			SignalDeviceView.<OnCreateAsync>d__13 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<SignalDeviceView.<OnCreateAsync>d__13>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039B41 RID: 236353 RVA: 0x01033870 File Offset: 0x01031A70
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			LinkingEmptyToggle linkingEmptyToggle = new LinkingEmptyToggle();
			linkingEmptyToggle.CreateThenShowByActor(base.GetExtendToggle(5).GetOwner(), null);
			this.GridToggleList.Add(linkingEmptyToggle);
			UUIItem item = base.GetItem(6);
			TWeakObjectPtr<UUIItem> rootUIComp = base.GetExtendToggle(5).RootUIComp;
			this.GridUiItemList.Add(rootUIComp);
			for (int i = 1; i < SignalDeviceViewConstants.GRIDNUM; i++)
			{
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(rootUIComp, item);
				this.GridUiItemList.Add(uuiitem);
				LinkingEmptyToggle linkingEmptyToggle2 = new LinkingEmptyToggle();
				linkingEmptyToggle2.CreateThenShowByActor(uuiitem.GetOwner(), null);
				linkingEmptyToggle2.InitData(i);
				this.GridToggleList.Add(linkingEmptyToggle2);
			}
			linkingEmptyToggle.InitData(0);
			base.GetButton(0).SetSelfInteractive(false);
			this.InitTemp();
			AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_open");
		}

		// Token: 0x06039B42 RID: 236354 RVA: 0x01033960 File Offset: 0x01031B60
		private void InitTemp()
		{
			EventSystem.Instance.Add(EEventName.OnSignalDeviceLinking, new Action<bool, int, bool, int, bool>(this.OnSignalDeviceLinking));
			EventSystem.Instance.Add<bool, IReadOnlyList<int>>(EEventName.OnSignalDeviceLinkingCheck, new Action<bool, IReadOnlyList<int>>(this.OnSignalDeviceLinkingCheck));
			EventSystem.Instance.Add(EEventName.OnSignalDeviceReset, new Action(this.OnSignalDeviceReset));
			EventSystem.Instance.Add(EEventName.OnSignalDeviceFinish, new Action(this.OnSignalDeviceFinish));
			this.Config = (this.OpenParam as List<IColorPiece>);
			if (this.Config == null || this.Config.Count != SignalDeviceViewConstants.GRIDNUM)
			{
				return;
			}
			for (int i = 0; i < SignalDeviceViewConstants.GRIDNUM; i++)
			{
				if (this.Config[i].Color != EPieceColorType.White)
				{
					this.LoadDotNode(i, this.Config[i].Color);
				}
			}
			base.GetText(3).SetText(TextConfig.Instance.GetTextById("SignalDeviceTitleText") ?? "???", true);
			base.GetText(4).SetText(TextConfig.Instance.GetTextById("SignalDeviceDescriptionText") ?? "???", true);
			base.GetText(7).SetText(TextConfig.Instance.GetTextById("SignalDeviceResetText") ?? "???", true);
		}

		// Token: 0x06039B43 RID: 236355 RVA: 0x01033AB4 File Offset: 0x01031CB4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceLinking, new Action<bool, int, bool, int, bool>(this.OnSignalDeviceLinking));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceLinkingCheck, new Action<bool, IReadOnlyList<int>>(this.OnSignalDeviceLinkingCheck));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceReset, new Action(this.OnSignalDeviceReset));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceFinish, new Action(this.OnSignalDeviceFinish));
		}

		// Token: 0x06039B44 RID: 236356 RVA: 0x01033B34 File Offset: 0x01031D34
		private void OnBtnBackClicked()
		{
			if (!this.NeedTipExit)
			{
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ButtonReset);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06039B45 RID: 236357 RVA: 0x01033B8C File Offset: 0x01031D8C
		private void OnBtnResetClicked()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ButtonReset);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Signal, ELoadingPerform.CameraFade, "SignalDeviceReset", delegate
				{
					SignalDeviceController.Instance.ResetAll();
					base.GetButton(0).SetSelfInteractive(false);
					this.NeedTipExit = false;
					LevelLoadingController.Instance.CloseLoading(ELoadingReason.Signal, "SignalDeviceReset", null, null);
				}, Array.Empty<object>());
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06039B46 RID: 236358 RVA: 0x01033BC5 File Offset: 0x01031DC5
		private void OnBtnHelpClicked()
		{
			UiManager.Instance.OpenView(EUiViewName.SignalDeviceGuideView, null, null);
		}

		// Token: 0x06039B47 RID: 236359 RVA: 0x01033BD8 File Offset: 0x01031DD8
		private void LoadDotNode(int index, EPieceColorType color)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.LinkingDotItem.GetRootItem(), this.GridUiItemList[index]);
			uuiitem.SetHierarchyIndex(0);
			this.GridToggleList[index].SetDotData(uuiitem, color);
		}

		// Token: 0x06039B48 RID: 236360 RVA: 0x01033C24 File Offset: 0x01031E24
		private unsafe void OnSignalDeviceLinking(bool isAdd, int from, bool isFromDot, int to, bool isToDot)
		{
			this.SetDotUpper(isAdd, from, isFromDot, to, isToDot);
			if (isAdd)
			{
				if (this.Config[to].Color == EPieceColorType.White)
				{
					UUIItem item = isFromDot ? this.LinkingLineWithDotStraight.GetRootItem() : this.LinkingLineStraight.GetRootItem();
					UUIItem item2 = LguiUtil.Instance.CopyItem(item, this.GridUiItemList[to]);
					LinkingLineItem itemClass = isFromDot ? LinkingLineItem.Create(ELineType.LinkingLineWithDotStraight) : LinkingLineItem.Create(ELineType.LinkingLineStraight);
					ENeighborType neighborType = SignalDeviceModel.Instance.NeighboringType(from, to);
					this.GridToggleList[to].SetLineData(item2, itemClass, neighborType, from, isFromDot);
				}
				if (this.Config[from].Color == EPieceColorType.White)
				{
					int fromIndex = this.GridToggleList[from].FromIndex;
					bool isFromDot2 = this.GridToggleList[from].IsFromDot;
					if (Math.Abs(fromIndex - to) == SignalDeviceModel.ROWNUM * 2 || Math.Abs(fromIndex - to) == 2)
					{
						bool flag = isFromDot2 || isToDot;
						UUIItem item3 = flag ? this.LinkingLineWithDotStraight.GetRootItem() : this.LinkingLineStraight.GetRootItem();
						UUIItem item4 = LguiUtil.Instance.CopyItem(item3, this.GridUiItemList[from]);
						LinkingLineItem itemClass2 = flag ? LinkingLineItem.Create(ELineType.LinkingLineWithDotStraight) : LinkingLineItem.Create(ELineType.LinkingLineWithDotStraight);
						this.GridToggleList[from].ResetStraightLineData(item4, itemClass2, to);
						return;
					}
					if (Math.Abs(fromIndex - to) == SignalDeviceModel.ROWNUM - 1 || Math.Abs(fromIndex - to) == SignalDeviceModel.ROWNUM + 1)
					{
						bool flag2 = isFromDot2 || isToDot;
						UUIItem item5 = flag2 ? (this.IsCornerLeftOrRight(fromIndex, isFromDot2, from, to, isToDot) ? this.LinkingLineWithDotCornerLeft.GetRootItem() : this.LinkingLineWithDotCornerRight.GetRootItem()) : this.LinkingLineCorner.GetRootItem();
						UUIItem item6 = LguiUtil.Instance.CopyItem(item5, this.GridUiItemList[from]);
						LinkingLineItem itemClass3 = flag2 ? (this.IsCornerLeftOrRight(fromIndex, isFromDot2, from, to, isToDot) ? LinkingLineItem.Create(ELineType.LinkingLineWithDotCornerLeft) : LinkingLineItem.Create(ELineType.LinkingLineWithDotCornerRight)) : LinkingLineItem.Create(ELineType.LinkingLineCorner);
						this.GridToggleList[from].ResetCornerLineData(item6, itemClass3, from, to, isToDot);
						return;
					}
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Temp;
					ELogAuthor author = ELogAuthor.ZFJ;
					string message = "OnSignalDeviceLinking From Error";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("from", from);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("beforeIndex", fromIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("to", to);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
			}
			else
			{
				this.GridToggleList[from].ClearLineData();
				if (this.Config[to].Color == EPieceColorType.White)
				{
					this.GridToggleList[to].SetLineHalf();
				}
			}
		}

		// Token: 0x06039B49 RID: 236361 RVA: 0x01033F04 File Offset: 0x01032104
		private void SetDotUpper(bool isAdd, int from, bool isFromDot, int to, bool isToDot)
		{
			if (isAdd)
			{
				if (isFromDot)
				{
					ENeighborType neighborType = SignalDeviceModel.Instance.NeighboringType(to, from);
					this.GridToggleList[from].SetDotRay(true, neighborType);
				}
				if (isToDot)
				{
					ENeighborType neighborType2 = SignalDeviceModel.Instance.NeighboringType(from, to);
					this.GridToggleList[to].SetDotRay(true, neighborType2);
					return;
				}
			}
			else
			{
				if (isFromDot)
				{
					this.GridToggleList[from].SetDotRay(false, ENeighborType.None);
				}
				if (isToDot)
				{
					this.GridToggleList[to].SetDotRay(false, ENeighborType.None);
				}
			}
		}

		// Token: 0x06039B4A RID: 236362 RVA: 0x01033F90 File Offset: 0x01032190
		private bool IsCornerLeftOrRight(int beforeIndex, bool isBeforeDot, int from, int to, bool isToDot)
		{
			if (isBeforeDot)
			{
				if (Math.Abs(from - beforeIndex) == SignalDeviceModel.ROWNUM)
				{
					return (from - beforeIndex) * (to - from) == -SignalDeviceModel.ROWNUM;
				}
				if (Math.Abs(from - beforeIndex) == 1)
				{
					return (from - beforeIndex) * (to - from) == SignalDeviceModel.ROWNUM;
				}
				global::Log.Instance.Warn(ELogModule.Temp, ELogAuthor.ZFJ, "IsCornerLeftOrRight Error", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			else
			{
				if (!isToDot)
				{
					global::Log.Instance.Warn(ELogModule.Temp, ELogAuthor.ZFJ, "IsCornerLeftOrRight no dot", default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				if (Math.Abs(from - beforeIndex) == 1)
				{
					return (from - beforeIndex) * (to - from) == -SignalDeviceModel.ROWNUM;
				}
				if (Math.Abs(from - beforeIndex) == SignalDeviceModel.ROWNUM)
				{
					return (from - beforeIndex) * (to - from) == SignalDeviceModel.ROWNUM;
				}
				global::Log.Instance.Warn(ELogModule.Temp, ELogAuthor.ZFJ, "IsCornerLeftOrRight Error", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}

		// Token: 0x06039B4B RID: 236363 RVA: 0x01034070 File Offset: 0x01032270
		[NullableContext(1)]
		private void OnSignalDeviceLinkingCheck(bool isSuccess, IReadOnlyList<int> indexArray)
		{
			if (isSuccess)
			{
				base.GetButton(0).SetSelfInteractive(true);
				AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_conncet");
			}
		}

		// Token: 0x06039B4C RID: 236364 RVA: 0x01034092 File Offset: 0x01032292
		private void OnSignalDeviceReset()
		{
			AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_reset");
		}

		// Token: 0x06039B4D RID: 236365 RVA: 0x010340A4 File Offset: 0x010322A4
		private void OnSignalDeviceFinish()
		{
			base.GetButton(0).SetSelfInteractive(false);
			this.SetBgFx(true);
		}

		// Token: 0x06039B4E RID: 236366 RVA: 0x010340BC File Offset: 0x010322BC
		private UniTask SetBgFx(bool isOpen)
		{
			SignalDeviceView.<SetBgFx>d__27 <SetBgFx>d__;
			<SetBgFx>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetBgFx>d__.<>4__this = this;
			<SetBgFx>d__.isOpen = isOpen;
			<SetBgFx>d__.<>1__state = -1;
			<SetBgFx>d__.<>t__builder.Start<SignalDeviceView.<SetBgFx>d__27>(ref <SetBgFx>d__);
			return <SetBgFx>d__.<>t__builder.Task;
		}

		// Token: 0x0401E75B RID: 124763
		private LinkingDotItem LinkingDotItem;

		// Token: 0x0401E75C RID: 124764
		private LinkingLineItem LinkingLineCorner;

		// Token: 0x0401E75D RID: 124765
		private LinkingLineItem LinkingLineStraight;

		// Token: 0x0401E75E RID: 124766
		private LinkingLineItem LinkingLineWithDotCornerLeft;

		// Token: 0x0401E75F RID: 124767
		private LinkingLineItem LinkingLineWithDotCornerRight;

		// Token: 0x0401E760 RID: 124768
		private LinkingLineItem LinkingLineWithDotStraight;

		// Token: 0x0401E761 RID: 124769
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E762 RID: 124770
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IColorPiece> Config;

		// Token: 0x0401E763 RID: 124771
		[Nullable(1)]
		private readonly List<UUIItem> GridUiItemList = new List<UUIItem>();

		// Token: 0x0401E764 RID: 124772
		[Nullable(1)]
		private readonly List<LinkingEmptyToggle> GridToggleList = new List<LinkingEmptyToggle>();

		// Token: 0x0401E765 RID: 124773
		private bool NeedTipExit;
	}
}
