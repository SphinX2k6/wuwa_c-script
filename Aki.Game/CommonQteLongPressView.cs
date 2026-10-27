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

// Token: 0x0200262E RID: 9774
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteLongPressView : CommonQteViewBase<CommonQteLongPressContext>
{
	// Token: 0x06013F96 RID: 81814 RVA: 0x00506282 File Offset: 0x00504482
	public CommonQteLongPressView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013F97 RID: 81815 RVA: 0x0050628C File Offset: 0x0050448C
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

	// Token: 0x06013F98 RID: 81816 RVA: 0x005062DC File Offset: 0x005044DC
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteLongPressView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteLongPressView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F99 RID: 81817 RVA: 0x00506320 File Offset: 0x00504520
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

	// Token: 0x06013F9A RID: 81818 RVA: 0x0050636F File Offset: 0x0050456F
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

	// Token: 0x06013F9B RID: 81819 RVA: 0x00506399 File Offset: 0x00504599
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteLongPressContext;
	}

	// Token: 0x06013F9C RID: 81820 RVA: 0x005063A4 File Offset: 0x005045A4
	protected override void OnRefreshActionUi(string action)
	{
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.RefreshAction(action);
	}

	// Token: 0x06013F9D RID: 81821 RVA: 0x005063B7 File Offset: 0x005045B7
	protected override void OnRefreshIcon(ULGUITexturePackerSpriteData sprite)
	{
		CommonQteLongPressView.CommonQteLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.RefreshIcon(sprite);
	}

	// Token: 0x06013F9E RID: 81822 RVA: 0x005063CC File Offset: 0x005045CC
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

	// Token: 0x06013F9F RID: 81823 RVA: 0x0050640C File Offset: 0x0050460C
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

	// Token: 0x06013FA0 RID: 81824 RVA: 0x0050646C File Offset: 0x0050466C
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

	// Token: 0x06013FA1 RID: 81825 RVA: 0x005064D4 File Offset: 0x005046D4
	public void OnPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x06013FA2 RID: 81826 RVA: 0x005064E4 File Offset: 0x005046E4
	public void OnRelease()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Release, null);
	}

	// Token: 0x06013FA3 RID: 81827 RVA: 0x005064F4 File Offset: 0x005046F4
	protected override void OnInputPress()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013FA4 RID: 81828 RVA: 0x00506515 File Offset: 0x00504715
	protected override void OnInputRelease()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.ResponseEnd();
		}
	}

	// Token: 0x06013FA5 RID: 81829 RVA: 0x00506538 File Offset: 0x00504738
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

	// Token: 0x06013FA6 RID: 81830 RVA: 0x00506589 File Offset: 0x00504789
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

	// Token: 0x06013FA7 RID: 81831 RVA: 0x005065B4 File Offset: 0x005047B4
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

	// Token: 0x040096AE RID: 38574
	[Nullable(2)]
	private CommonQteLongPressView.CommonQteLongPressPanelItem QteItem;

	// Token: 0x040096AF RID: 38575
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008C74 RID: 35956
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D980 RID: 186752
		PanelItem
	}

	// Token: 0x02008C75 RID: 35957
	[NullableContext(0)]
	private enum EItemChildType
	{
		// Token: 0x0402D982 RID: 186754
		BtnMain,
		// Token: 0x0402D983 RID: 186755
		ProgressBar,
		// Token: 0x0402D984 RID: 186756
		Icon,
		// Token: 0x0402D985 RID: 186757
		KeyItem,
		// Token: 0x0402D986 RID: 186758
		TextPanel,
		// Token: 0x0402D987 RID: 186759
		Text
	}

	// Token: 0x02008C76 RID: 35958
	[NullableContext(0)]
	private enum EItemChildPadType
	{
		// Token: 0x0402D989 RID: 186761
		BtnMain,
		// Token: 0x0402D98A RID: 186762
		ProgressBar,
		// Token: 0x0402D98B RID: 186763
		Icon,
		// Token: 0x0402D98C RID: 186764
		TextPanel,
		// Token: 0x0402D98D RID: 186765
		Text
	}

	// Token: 0x02008C77 RID: 35959
	[NullableContext(2)]
	[Nullable(0)]
	private class CommonQteLongPressPanelItem : UiPanelBase
	{
		// Token: 0x0604B418 RID: 308248 RVA: 0x013BEB74 File Offset: 0x013BCD74
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

		// Token: 0x0604B419 RID: 308249 RVA: 0x013BED3C File Offset: 0x013BCF3C
		protected override UniTask OnBeforeStartAsync()
		{
			CommonQteLongPressView.CommonQteLongPressPanelItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteLongPressView.CommonQteLongPressPanelItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604B41A RID: 308250 RVA: 0x013BED80 File Offset: 0x013BCF80
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

		// Token: 0x0604B41B RID: 308251 RVA: 0x013BEE74 File Offset: 0x013BD074
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

		// Token: 0x0604B41C RID: 308252 RVA: 0x013BEECA File Offset: 0x013BD0CA
		public void SetQteView(UiViewBase view)
		{
			if (view != null)
			{
				this.QteView = (view as CommonQteLongPressView);
				return;
			}
			this.QteView = null;
		}

		// Token: 0x0604B41D RID: 308253 RVA: 0x013BEEE4 File Offset: 0x013BD0E4
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

		// Token: 0x0604B41E RID: 308254 RVA: 0x013BEF18 File Offset: 0x013BD118
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

		// Token: 0x0604B41F RID: 308255 RVA: 0x013BEF3E File Offset: 0x013BD13E
		public void RefreshProgress(float progress)
		{
			UUITexture progressBar = this.ProgressBar;
			if (progressBar == null)
			{
				return;
			}
			progressBar.SetFillAmount(progress);
		}

		// Token: 0x0604B420 RID: 308256 RVA: 0x013BEF51 File Offset: 0x013BD151
		public void ShowKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}

		// Token: 0x0604B421 RID: 308257 RVA: 0x013BEF64 File Offset: 0x013BD164
		public void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Hide(null);
		}

		// Token: 0x0604B422 RID: 308258 RVA: 0x013BEF78 File Offset: 0x013BD178
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

		// Token: 0x0604B423 RID: 308259 RVA: 0x013BEFF6 File Offset: 0x013BD1F6
		private void OnPress()
		{
			CommonQteLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnPress();
		}

		// Token: 0x0604B424 RID: 308260 RVA: 0x013BF008 File Offset: 0x013BD208
		private void OnRelease()
		{
			CommonQteLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnRelease();
		}

		// Token: 0x0402D98E RID: 186766
		private UUIButtonComponent BtnMain;

		// Token: 0x0402D98F RID: 186767
		private UUITexture ProgressBar;

		// Token: 0x0402D990 RID: 186768
		private UUISprite IconItem;

		// Token: 0x0402D991 RID: 186769
		private InputMultiKeyItem KeyItem;

		// Token: 0x0402D992 RID: 186770
		private CommonQteLongPressView QteView;

		// Token: 0x0402D993 RID: 186771
		private bool IsMobile;
	}
}
