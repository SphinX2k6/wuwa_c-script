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
	// Token: 0x02006A51 RID: 27217
	[NullableContext(2)]
	[Nullable(0)]
	public class SignalDeviceView : UiViewBase
	{
		// Token: 0x06043AF0 RID: 277232 RVA: 0x0108EE56 File Offset: 0x0108D056
		[NullableContext(1)]
		public SignalDeviceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043AF1 RID: 277233 RVA: 0x0108EE78 File Offset: 0x0108D078
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

		// Token: 0x06043AF2 RID: 277234 RVA: 0x0108F008 File Offset: 0x0108D208
		protected override UniTask OnCreateAsync()
		{
			SignalDeviceView.<OnCreateAsync>d__13 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<SignalDeviceView.<OnCreateAsync>d__13>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043AF3 RID: 277235 RVA: 0x0108F04C File Offset: 0x0108D24C
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

		// Token: 0x06043AF4 RID: 277236 RVA: 0x0108F13C File Offset: 0x0108D33C
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

		// Token: 0x06043AF5 RID: 277237 RVA: 0x0108F290 File Offset: 0x0108D490
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceLinking, new Action<bool, int, bool, int, bool>(this.OnSignalDeviceLinking));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceLinkingCheck, new Action<bool, IReadOnlyList<int>>(this.OnSignalDeviceLinkingCheck));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceReset, new Action(this.OnSignalDeviceReset));
			EventSystem.Instance.Remove(EEventName.OnSignalDeviceFinish, new Action(this.OnSignalDeviceFinish));
		}

		// Token: 0x06043AF6 RID: 277238 RVA: 0x0108F310 File Offset: 0x0108D510
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

		// Token: 0x06043AF7 RID: 277239 RVA: 0x0108F368 File Offset: 0x0108D568
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

		// Token: 0x06043AF8 RID: 277240 RVA: 0x0108F3A1 File Offset: 0x0108D5A1
		private void OnBtnHelpClicked()
		{
			UiManager.Instance.OpenView(EUiViewName.SignalDeviceGuideView, null, null);
		}

		// Token: 0x06043AF9 RID: 277241 RVA: 0x0108F3B4 File Offset: 0x0108D5B4
		private void LoadDotNode(int index, EPieceColorType color)
		{
			UUIItem uuiitem = LguiUtil.Instance.CopyItem(this.LinkingDotItem.GetRootItem(), this.GridUiItemList[index]);
			uuiitem.SetHierarchyIndex(0);
			this.GridToggleList[index].SetDotData(uuiitem, color);
		}

		// Token: 0x06043AFA RID: 277242 RVA: 0x0108F400 File Offset: 0x0108D600
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

		// Token: 0x06043AFB RID: 277243 RVA: 0x0108F6E0 File Offset: 0x0108D8E0
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

		// Token: 0x06043AFC RID: 277244 RVA: 0x0108F76C File Offset: 0x0108D96C
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

		// Token: 0x06043AFD RID: 277245 RVA: 0x0108F84C File Offset: 0x0108DA4C
		[NullableContext(1)]
		private void OnSignalDeviceLinkingCheck(bool isSuccess, IReadOnlyList<int> indexArray)
		{
			if (isSuccess)
			{
				base.GetButton(0).SetSelfInteractive(true);
				AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_conncet");
			}
		}

		// Token: 0x06043AFE RID: 277246 RVA: 0x0108F86E File Offset: 0x0108DA6E
		private void OnSignalDeviceReset()
		{
			AudioSystem.Instance.PostEvent("play_amb_interact_signal_ui_reset");
		}

		// Token: 0x06043AFF RID: 277247 RVA: 0x0108F880 File Offset: 0x0108DA80
		private void OnSignalDeviceFinish()
		{
			base.GetButton(0).SetSelfInteractive(false);
			this.SetBgFx(true);
		}

		// Token: 0x06043B00 RID: 277248 RVA: 0x0108F898 File Offset: 0x0108DA98
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

		// Token: 0x04023569 RID: 144745
		private LinkingDotItem LinkingDotItem;

		// Token: 0x0402356A RID: 144746
		private LinkingLineItem LinkingLineCorner;

		// Token: 0x0402356B RID: 144747
		private LinkingLineItem LinkingLineStraight;

		// Token: 0x0402356C RID: 144748
		private LinkingLineItem LinkingLineWithDotCornerLeft;

		// Token: 0x0402356D RID: 144749
		private LinkingLineItem LinkingLineWithDotCornerRight;

		// Token: 0x0402356E RID: 144750
		private LinkingLineItem LinkingLineWithDotStraight;

		// Token: 0x0402356F RID: 144751
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04023570 RID: 144752
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IColorPiece> Config;

		// Token: 0x04023571 RID: 144753
		[Nullable(1)]
		private readonly List<UUIItem> GridUiItemList = new List<UUIItem>();

		// Token: 0x04023572 RID: 144754
		[Nullable(1)]
		private readonly List<LinkingEmptyToggle> GridToggleList = new List<LinkingEmptyToggle>();

		// Token: 0x04023573 RID: 144755
		private bool NeedTipExit;
	}
}
