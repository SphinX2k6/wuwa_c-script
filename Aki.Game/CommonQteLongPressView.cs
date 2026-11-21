using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Qte.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B19 RID: 6937
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteLongPressView : CommonQteViewBase<CommonQteLongPressContext>
{
	// Token: 0x06011478 RID: 70776 RVA: 0x00515162 File Offset: 0x00513362
	public CommonQteLongPressView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011479 RID: 70777 RVA: 0x0051516C File Offset: 0x0051336C
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601147A RID: 70778 RVA: 0x005151BC File Offset: 0x005133BC
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteLongPressView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteLongPressView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601147B RID: 70779 RVA: 0x00515200 File Offset: 0x00513400
	protected override void OnStart()
	{
		base.OnStart();
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem != null)
		{
			qteItem.SetUiActive(false);
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(0));
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x0601147C RID: 70780 RVA: 0x0051524F File Offset: 0x0051344F
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.SetQteView(null);
	}

	// Token: 0x0601147D RID: 70781 RVA: 0x00515279 File Offset: 0x00513479
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteLongPressContext;
	}

	// Token: 0x0601147E RID: 70782 RVA: 0x00515284 File Offset: 0x00513484
	protected override void OnRefreshActionUi(string action)
	{
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.RefreshAction(action);
	}

	// Token: 0x0601147F RID: 70783 RVA: 0x00515297 File Offset: 0x00513497
	protected override void OnRefreshIcon(ULGUITexturePackerSpriteData sprite)
	{
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.RefreshIcon(sprite);
	}

	// Token: 0x06011480 RID: 70784 RVA: 0x005152AC File Offset: 0x005134AC
	[NullableContext(2)]
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_LongPress scommonQte_LongPress = uiConfig as SCommonQte_LongPress;
		string qteText = ((scommonQte_LongPress != null) ? scommonQte_LongPress.UIConfig.TextId : null) ?? "";
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.SetQteText(qteText);
	}

	// Token: 0x06011481 RID: 70785 RVA: 0x005152EC File Offset: 0x005134EC
	protected override void OnPlayQteStart()
	{
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem != null)
		{
			qteItem.SetUiActive(true);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		if (!this.IsMobile && this.IsQteInteractive)
		{
			CommonQteLongPressView.CommonQteLongPressPanelItem qteItem2 = this.QteItem;
			if (qteItem2 == null)
			{
				return;
			}
			qteItem2.ShowKeyItem();
		}
	}

	// Token: 0x06011482 RID: 70786 RVA: 0x0051534C File Offset: 0x0051354C
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (!(sequenceName == "Start"))
		{
			if (sequenceName == "Close")
			{
				UiManager.Instance.CloseView(EUiViewName.CommonQteLongPressView, null);
			}
			return;
		}
		if (this.IsQteEnd)
		{
			return;
		}
		if (!this.IsMobile)
		{
			CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
			if (qteItem != null)
			{
				qteItem.ShowKeyItem();
			}
		}
		this.IsQteStart = true;
		this.IsQteInteractive = true;
	}

	// Token: 0x06011483 RID: 70787 RVA: 0x005153B4 File Offset: 0x005135B4
	public void OnPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x06011484 RID: 70788 RVA: 0x005153C4 File Offset: 0x005135C4
	public void OnRelease()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Release, null);
	}

	// Token: 0x06011485 RID: 70789 RVA: 0x005153D4 File Offset: 0x005135D4
	protected override void OnInputPress()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06011486 RID: 70790 RVA: 0x005153F5 File Offset: 0x005135F5
	protected override void OnInputRelease()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.ResponseEnd();
		}
	}

	// Token: 0x06011487 RID: 70791 RVA: 0x00515418 File Offset: 0x00513618
	protected override void OnHandleQteEnd()
	{
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem != null)
		{
			qteItem.HideKeyItem();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x06011488 RID: 70792 RVA: 0x00515469 File Offset: 0x00513669
	protected override void OnTickQteView(float delta)
	{
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		qteItem.RefreshProgress((commonQteContext != null) ? commonQteContext.GetProgress() : 0f);
	}

	// Token: 0x06011489 RID: 70793 RVA: 0x00515494 File Offset: 0x00513694
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_LongPress scommonQte_LongPress = this.CommonQteContext.GetUiConfig() as SCommonQte_LongPress;
			if (scommonQte_LongPress != null)
			{
				SCommonQteButton uiconfig = scommonQte_LongPress.UIConfig;
				CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
				UUIItem uuiitem = (qteItem != null) ? qteItem.GetRootItem() : null;
				if (uuiitem != null)
				{
					uuiitem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
				}
				if (uuiitem == null)
				{
					return;
				}
				uuiitem.SetAnchorOffset(uiconfig.AnchorOffset);
			}
		}
	}

	// Token: 0x04009806 RID: 38918
	[Nullable(2)]
	private CommonQteLongPressView.CommonQteLongPressPanelItem QteItem;

	// Token: 0x04009807 RID: 38919
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007DFD RID: 32253
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028C97 RID: 167063
		PanelItem
	}

	// Token: 0x02007DFE RID: 32254
	[NullableContext(0)]
	private enum EItemChildType
	{
		// Token: 0x04028C99 RID: 167065
		BtnMain,
		// Token: 0x04028C9A RID: 167066
		ProgressBar,
		// Token: 0x04028C9B RID: 167067
		Icon,
		// Token: 0x04028C9C RID: 167068
		KeyItem,
		// Token: 0x04028C9D RID: 167069
		TextPanel,
		// Token: 0x04028C9E RID: 167070
		Text
	}

	// Token: 0x02007DFF RID: 32255
	[NullableContext(0)]
	private enum EItemChildPadType
	{
		// Token: 0x04028CA0 RID: 167072
		BtnMain,
		// Token: 0x04028CA1 RID: 167073
		ProgressBar,
		// Token: 0x04028CA2 RID: 167074
		Icon,
		// Token: 0x04028CA3 RID: 167075
		TextPanel,
		// Token: 0x04028CA4 RID: 167076
		Text
	}

	// Token: 0x02007E00 RID: 32256
	[NullableContext(2)]
	[Nullable(0)]
	private class CommonQteLongPressPanelItem : UiPanelBase
	{
		// Token: 0x060417EA RID: 268266 RVA: 0x01362630 File Offset: 0x01360830
		protected unsafe override void OnRegisterComponent()
		{
			this.IsMobile = Info.Instance.IsInTouch();
			int num;
			Span<ValueTuple<int, Type>> span;
			int num2;
			if (this.IsMobile)
			{
				num = 5;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
				this.ComponentRegisterInfos = list;
				return;
			}
			num2 = 6;
			List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
			num = 0;
			*span[num] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num++;
			*span[num] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num++;
			*span[num] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num++;
			*span[num] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num++;
			*span[num] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list2;
		}

		// Token: 0x060417EB RID: 268267 RVA: 0x013627F8 File Offset: 0x013609F8
		protected override UniTask OnBeforeStartAsync()
		{
			CommonQteLongPressView.CommonQteLongPressPanelItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteLongPressView.CommonQteLongPressPanelItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060417EC RID: 268268 RVA: 0x0136283C File Offset: 0x01360A3C
		protected override void OnStart()
		{
			if (this.IsMobile)
			{
				this.BtnMain = base.GetButton(0);
				this.ProgressBar = base.GetTexture(1);
				this.IconItem = base.GetSprite(2);
			}
			else
			{
				this.BtnMain = base.GetButton(0);
				this.ProgressBar = base.GetTexture(1);
				this.IconItem = base.GetSprite(2);
			}
			UUITexture progressBar = this.ProgressBar;
			if (progressBar != null)
			{
				progressBar.SetFillAmount(0f);
			}
			UUIButtonComponent btnMain = this.BtnMain;
			if (btnMain != null)
			{
				btnMain.OnPointDownCallBack.Bind(new Action(this.OnPress));
			}
			UUIButtonComponent btnMain2 = this.BtnMain;
			if (btnMain2 != null)
			{
				btnMain2.OnPointUpCallBack.Bind(new Action(this.OnRelease));
			}
			UUIButtonComponent btnMain3 = this.BtnMain;
			if (btnMain3 != null)
			{
				btnMain3.OnPointCancelCallBack.Bind(new Action(this.OnRelease));
			}
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Hide(null);
		}

		// Token: 0x060417ED RID: 268269 RVA: 0x01362930 File Offset: 0x01360B30
		protected override void OnBeforeDestroy()
		{
			UUIButtonComponent btnMain = this.BtnMain;
			if (btnMain != null)
			{
				btnMain.OnPointDownCallBack.Unbind();
			}
			UUIButtonComponent btnMain2 = this.BtnMain;
			if (btnMain2 != null)
			{
				btnMain2.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent btnMain3 = this.BtnMain;
			if (btnMain3 != null)
			{
				btnMain3.OnPointCancelCallBack.Unbind();
			}
			this.QteView = null;
		}

		// Token: 0x060417EE RID: 268270 RVA: 0x01362986 File Offset: 0x01360B86
		public void SetQteView(UiViewBase view)
		{
			if (view != null)
			{
				this.QteView = (view as CommonQteLongPressView);
				return;
			}
			this.QteView = null;
		}

		// Token: 0x060417EF RID: 268271 RVA: 0x013629A0 File Offset: 0x01360BA0
		[NullableContext(1)]
		public void RefreshAction(string action)
		{
			if (!this.IsMobile)
			{
				InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = action
				};
				InputMultiKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
			}
		}

		// Token: 0x060417F0 RID: 268272 RVA: 0x013629D4 File Offset: 0x01360BD4
		[NullableContext(1)]
		public void RefreshIcon(ULGUITexturePackerSpriteData sprite)
		{
			UUISprite iconItem = this.IconItem;
			if (iconItem != null)
			{
				iconItem.SetSprite(sprite, false);
			}
			UUISprite iconItem2 = this.IconItem;
			if (iconItem2 == null)
			{
				return;
			}
			iconItem2.SetUIActive(true);
		}

		// Token: 0x060417F1 RID: 268273 RVA: 0x013629FA File Offset: 0x01360BFA
		public void RefreshProgress(float progress)
		{
			UUITexture progressBar = this.ProgressBar;
			if (progressBar == null)
			{
				return;
			}
			progressBar.SetFillAmount(progress);
		}

		// Token: 0x060417F2 RID: 268274 RVA: 0x01362A0D File Offset: 0x01360C0D
		public void ShowKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}

		// Token: 0x060417F3 RID: 268275 RVA: 0x01362A20 File Offset: 0x01360C20
		public void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Hide(null);
		}

		// Token: 0x060417F4 RID: 268276 RVA: 0x01362A34 File Offset: 0x01360C34
		[NullableContext(1)]
		public void SetQteText(string textId)
		{
			if (!string.IsNullOrEmpty(textId))
			{
				UUIText text = base.GetText(this.IsMobile ? 4 : 5);
				LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
				if (text != null)
				{
					text.SetUIActive(true);
				}
				UUIItem item = base.GetItem(this.IsMobile ? 3 : 4);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(this.IsMobile ? 3 : 4);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x060417F5 RID: 268277 RVA: 0x01362AB2 File Offset: 0x01360CB2
		private void OnPress()
		{
			CommonQteLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnPress();
		}

		// Token: 0x060417F6 RID: 268278 RVA: 0x01362AC4 File Offset: 0x01360CC4
		private void OnRelease()
		{
			CommonQteLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnRelease();
		}

		// Token: 0x04028CA5 RID: 167077
		private UUIButtonComponent BtnMain;

		// Token: 0x04028CA6 RID: 167078
		private UUITexture ProgressBar;

		// Token: 0x04028CA7 RID: 167079
		private UUISprite IconItem;

		// Token: 0x04028CA8 RID: 167080
		private InputMultiKeyItem KeyItem;

		// Token: 0x04028CA9 RID: 167081
		private CommonQteLongPressView QteView;

		// Token: 0x04028CAA RID: 167082
		private bool IsMobile;
	}
}
