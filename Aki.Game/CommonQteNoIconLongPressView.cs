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

// Token: 0x02001B1A RID: 6938
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteNoIconLongPressView : CommonQteViewBase<CommonQteLongPressContext>
{
	// Token: 0x0601148A RID: 70794 RVA: 0x00515504 File Offset: 0x00513704
	public CommonQteNoIconLongPressView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601148B RID: 70795 RVA: 0x00515510 File Offset: 0x00513710
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

	// Token: 0x0601148C RID: 70796 RVA: 0x00515560 File Offset: 0x00513760
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteNoIconLongPressView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteNoIconLongPressView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601148D RID: 70797 RVA: 0x005155A4 File Offset: 0x005137A4
	protected override void OnStart()
	{
		base.OnStart();
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
		if (qteItem != null)
		{
			qteItem.SetUiActive(false);
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(0));
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x0601148E RID: 70798 RVA: 0x005155F3 File Offset: 0x005137F3
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.SetQteView(null);
	}

	// Token: 0x0601148F RID: 70799 RVA: 0x0051561D File Offset: 0x0051381D
	protected override void OnRefreshActionUi(string action)
	{
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.RefreshAction(action);
	}

	// Token: 0x06011490 RID: 70800 RVA: 0x00515630 File Offset: 0x00513830
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteLongPressContext;
	}

	// Token: 0x06011491 RID: 70801 RVA: 0x0051563B File Offset: 0x0051383B
	protected override void TryApplyQteIcon(CommonQteContextBase context)
	{
	}

	// Token: 0x06011492 RID: 70802 RVA: 0x00515640 File Offset: 0x00513840
	[NullableContext(2)]
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_LongPress scommonQte_LongPress = uiConfig as SCommonQte_LongPress;
		string qteText = ((scommonQte_LongPress != null) ? scommonQte_LongPress.UIConfig.TextId : null) ?? "";
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.SetQteText(qteText);
	}

	// Token: 0x06011493 RID: 70803 RVA: 0x00515680 File Offset: 0x00513880
	protected override void OnPlayQteStart()
	{
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
		if (qteItem != null)
		{
			qteItem.SetUiActive(true);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("StartHaste", false, null, false);
		}
		if (!this.IsMobile && this.IsQteInteractive)
		{
			CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem2 = this.QteItem;
			if (qteItem2 == null)
			{
				return;
			}
			qteItem2.ShowKeyItem();
		}
	}

	// Token: 0x06011494 RID: 70804 RVA: 0x005156E0 File Offset: 0x005138E0
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (!(sequenceName == "StartHaste"))
		{
			if (sequenceName == "Close")
			{
				UiManager.Instance.CloseView(EUiViewName.CommonQteNoIconLongPressView, null);
			}
			return;
		}
		if (this.IsQteEnd)
		{
			return;
		}
		if (!this.IsMobile)
		{
			CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
			if (qteItem != null)
			{
				qteItem.ShowKeyItem();
			}
		}
		this.IsQteStart = true;
		this.IsQteInteractive = true;
	}

	// Token: 0x06011495 RID: 70805 RVA: 0x00515748 File Offset: 0x00513948
	public void OnPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x06011496 RID: 70806 RVA: 0x00515758 File Offset: 0x00513958
	public void OnRelease()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Release, null);
	}

	// Token: 0x06011497 RID: 70807 RVA: 0x00515768 File Offset: 0x00513968
	protected override void OnInputPress()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06011498 RID: 70808 RVA: 0x00515789 File Offset: 0x00513989
	protected override void OnInputRelease()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.ResponseEnd();
		}
	}

	// Token: 0x06011499 RID: 70809 RVA: 0x005157AC File Offset: 0x005139AC
	protected override void OnHandleQteEnd()
	{
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
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

	// Token: 0x0601149A RID: 70810 RVA: 0x005157FD File Offset: 0x005139FD
	protected override void OnTickQteView(float delta)
	{
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		qteItem.RefreshProgress((commonQteContext != null) ? commonQteContext.GetProgress() : 0f);
	}

	// Token: 0x0601149B RID: 70811 RVA: 0x00515828 File Offset: 0x00513A28
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_LongPress scommonQte_LongPress = this.CommonQteContext.GetUiConfig() as SCommonQte_LongPress;
			if (scommonQte_LongPress != null)
			{
				SCommonQteButton uiconfig = scommonQte_LongPress.UIConfig;
				CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
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

	// Token: 0x04009808 RID: 38920
	[Nullable(2)]
	private CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem QteItem;

	// Token: 0x04009809 RID: 38921
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007E02 RID: 32258
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028CB0 RID: 167088
		PanelItem
	}

	// Token: 0x02007E03 RID: 32259
	[NullableContext(0)]
	private enum EItemChildType
	{
		// Token: 0x04028CB2 RID: 167090
		BtnMain,
		// Token: 0x04028CB3 RID: 167091
		ProgressBar,
		// Token: 0x04028CB4 RID: 167092
		Icon,
		// Token: 0x04028CB5 RID: 167093
		KeyItem,
		// Token: 0x04028CB6 RID: 167094
		TextPanel,
		// Token: 0x04028CB7 RID: 167095
		Text
	}

	// Token: 0x02007E04 RID: 32260
	[NullableContext(0)]
	private enum EItemChildPadType
	{
		// Token: 0x04028CB9 RID: 167097
		BtnMain,
		// Token: 0x04028CBA RID: 167098
		ProgressBar,
		// Token: 0x04028CBB RID: 167099
		Icon,
		// Token: 0x04028CBC RID: 167100
		TextPanel,
		// Token: 0x04028CBD RID: 167101
		Text
	}

	// Token: 0x02007E05 RID: 32261
	[NullableContext(2)]
	[Nullable(0)]
	private class CommonQteNoIconLongPressPanelItem : UiPanelBase
	{
		// Token: 0x060417FA RID: 268282 RVA: 0x01362BD8 File Offset: 0x01360DD8
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

		// Token: 0x060417FB RID: 268283 RVA: 0x01362DA0 File Offset: 0x01360FA0
		protected override UniTask OnBeforeStartAsync()
		{
			CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060417FC RID: 268284 RVA: 0x01362DE4 File Offset: 0x01360FE4
		protected override void OnStart()
		{
			if (this.IsMobile)
			{
				this.BtnMain = base.GetButton(0);
				this.ProgressBar = base.GetTexture(1);
				UUISprite sprite = base.GetSprite(2);
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
			}
			else
			{
				this.BtnMain = base.GetButton(0);
				this.ProgressBar = base.GetTexture(1);
				UUISprite sprite2 = base.GetSprite(2);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(false);
				}
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

		// Token: 0x060417FD RID: 268285 RVA: 0x01362EE4 File Offset: 0x013610E4
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

		// Token: 0x060417FE RID: 268286 RVA: 0x01362F3A File Offset: 0x0136113A
		public void SetQteView(UiViewBase view)
		{
			if (view != null)
			{
				this.QteView = (view as CommonQteNoIconLongPressView);
				return;
			}
			this.QteView = null;
		}

		// Token: 0x060417FF RID: 268287 RVA: 0x01362F54 File Offset: 0x01361154
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

		// Token: 0x06041800 RID: 268288 RVA: 0x01362F88 File Offset: 0x01361188
		public void RefreshProgress(float progress)
		{
			UUITexture progressBar = this.ProgressBar;
			if (progressBar == null)
			{
				return;
			}
			progressBar.SetFillAmount(progress);
		}

		// Token: 0x06041801 RID: 268289 RVA: 0x01362F9B File Offset: 0x0136119B
		public void ShowKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}

		// Token: 0x06041802 RID: 268290 RVA: 0x01362FAE File Offset: 0x013611AE
		public void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Hide(null);
		}

		// Token: 0x06041803 RID: 268291 RVA: 0x01362FC4 File Offset: 0x013611C4
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

		// Token: 0x06041804 RID: 268292 RVA: 0x01363042 File Offset: 0x01361242
		private void OnPress()
		{
			CommonQteNoIconLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnPress();
		}

		// Token: 0x06041805 RID: 268293 RVA: 0x01363054 File Offset: 0x01361254
		private void OnRelease()
		{
			CommonQteNoIconLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnRelease();
		}

		// Token: 0x04028CBE RID: 167102
		private UUIButtonComponent BtnMain;

		// Token: 0x04028CBF RID: 167103
		private UUITexture ProgressBar;

		// Token: 0x04028CC0 RID: 167104
		private UUISprite IconItem;

		// Token: 0x04028CC1 RID: 167105
		private InputMultiKeyItem KeyItem;

		// Token: 0x04028CC2 RID: 167106
		private CommonQteNoIconLongPressView QteView;

		// Token: 0x04028CC3 RID: 167107
		private bool IsMobile;
	}
}
