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

// Token: 0x0200262F RID: 9775
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteNoIconLongPressView : CommonQteViewBase<CommonQteLongPressContext>
{
	// Token: 0x06013FA8 RID: 81832 RVA: 0x00506624 File Offset: 0x00504824
	public CommonQteNoIconLongPressView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013FA9 RID: 81833 RVA: 0x00506630 File Offset: 0x00504830
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

	// Token: 0x06013FAA RID: 81834 RVA: 0x00506680 File Offset: 0x00504880
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteNoIconLongPressView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteNoIconLongPressView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013FAB RID: 81835 RVA: 0x005066C4 File Offset: 0x005048C4
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

	// Token: 0x06013FAC RID: 81836 RVA: 0x00506713 File Offset: 0x00504913
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

	// Token: 0x06013FAD RID: 81837 RVA: 0x0050673D File Offset: 0x0050493D
	protected override void OnRefreshActionUi(string action)
	{
		CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem qteItem = this.QteItem;
		if (qteItem == null)
		{
			return;
		}
		qteItem.RefreshAction(action);
	}

	// Token: 0x06013FAE RID: 81838 RVA: 0x00506750 File Offset: 0x00504950
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteLongPressContext;
	}

	// Token: 0x06013FAF RID: 81839 RVA: 0x0050675B File Offset: 0x0050495B
	protected override void TryApplyQteIcon(CommonQteContextBase context)
	{
	}

	// Token: 0x06013FB0 RID: 81840 RVA: 0x00506760 File Offset: 0x00504960
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

	// Token: 0x06013FB1 RID: 81841 RVA: 0x005067A0 File Offset: 0x005049A0
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

	// Token: 0x06013FB2 RID: 81842 RVA: 0x00506800 File Offset: 0x00504A00
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

	// Token: 0x06013FB3 RID: 81843 RVA: 0x00506868 File Offset: 0x00504A68
	public void OnPress()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
	}

	// Token: 0x06013FB4 RID: 81844 RVA: 0x00506878 File Offset: 0x00504A78
	public void OnRelease()
	{
		base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Release, null);
	}

	// Token: 0x06013FB5 RID: 81845 RVA: 0x00506888 File Offset: 0x00504A88
	protected override void OnInputPress()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
	}

	// Token: 0x06013FB6 RID: 81846 RVA: 0x005068A9 File Offset: 0x00504AA9
	protected override void OnInputRelease()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.ResponseEnd();
		}
	}

	// Token: 0x06013FB7 RID: 81847 RVA: 0x005068CC File Offset: 0x00504ACC
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

	// Token: 0x06013FB8 RID: 81848 RVA: 0x0050691D File Offset: 0x00504B1D
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

	// Token: 0x06013FB9 RID: 81849 RVA: 0x00506948 File Offset: 0x00504B48
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

	// Token: 0x040096B0 RID: 38576
	[Nullable(2)]
	private CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem QteItem;

	// Token: 0x040096B1 RID: 38577
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008C79 RID: 35961
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D999 RID: 186777
		PanelItem
	}

	// Token: 0x02008C7A RID: 35962
	[NullableContext(0)]
	private enum EItemChildType
	{
		// Token: 0x0402D99B RID: 186779
		BtnMain,
		// Token: 0x0402D99C RID: 186780
		ProgressBar,
		// Token: 0x0402D99D RID: 186781
		Icon,
		// Token: 0x0402D99E RID: 186782
		KeyItem,
		// Token: 0x0402D99F RID: 186783
		TextPanel,
		// Token: 0x0402D9A0 RID: 186784
		Text
	}

	// Token: 0x02008C7B RID: 35963
	[NullableContext(0)]
	private enum EItemChildPadType
	{
		// Token: 0x0402D9A2 RID: 186786
		BtnMain,
		// Token: 0x0402D9A3 RID: 186787
		ProgressBar,
		// Token: 0x0402D9A4 RID: 186788
		Icon,
		// Token: 0x0402D9A5 RID: 186789
		TextPanel,
		// Token: 0x0402D9A6 RID: 186790
		Text
	}

	// Token: 0x02008C7C RID: 35964
	[NullableContext(2)]
	[Nullable(0)]
	private class CommonQteNoIconLongPressPanelItem : UiPanelBase
	{
		// Token: 0x0604B428 RID: 308264 RVA: 0x013BF11C File Offset: 0x013BD31C
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

		// Token: 0x0604B429 RID: 308265 RVA: 0x013BF2E4 File Offset: 0x013BD4E4
		protected override UniTask OnBeforeStartAsync()
		{
			CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteNoIconLongPressView.CommonQteNoIconLongPressPanelItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604B42A RID: 308266 RVA: 0x013BF328 File Offset: 0x013BD528
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

		// Token: 0x0604B42B RID: 308267 RVA: 0x013BF428 File Offset: 0x013BD628
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

		// Token: 0x0604B42C RID: 308268 RVA: 0x013BF47E File Offset: 0x013BD67E
		public void SetQteView(UiViewBase view)
		{
			if (view != null)
			{
				this.QteView = (view as CommonQteNoIconLongPressView);
				return;
			}
			this.QteView = null;
		}

		// Token: 0x0604B42D RID: 308269 RVA: 0x013BF498 File Offset: 0x013BD698
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

		// Token: 0x0604B42E RID: 308270 RVA: 0x013BF4CC File Offset: 0x013BD6CC
		public void RefreshProgress(float progress)
		{
			UUITexture progressBar = this.ProgressBar;
			if (progressBar == null)
			{
				return;
			}
			progressBar.SetFillAmount(progress);
		}

		// Token: 0x0604B42F RID: 308271 RVA: 0x013BF4DF File Offset: 0x013BD6DF
		public void ShowKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}

		// Token: 0x0604B430 RID: 308272 RVA: 0x013BF4F2 File Offset: 0x013BD6F2
		public void HideKeyItem()
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Hide(null);
		}

		// Token: 0x0604B431 RID: 308273 RVA: 0x013BF508 File Offset: 0x013BD708
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

		// Token: 0x0604B432 RID: 308274 RVA: 0x013BF586 File Offset: 0x013BD786
		private void OnPress()
		{
			CommonQteNoIconLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnPress();
		}

		// Token: 0x0604B433 RID: 308275 RVA: 0x013BF598 File Offset: 0x013BD798
		private void OnRelease()
		{
			CommonQteNoIconLongPressView qteView = this.QteView;
			if (qteView == null)
			{
				return;
			}
			qteView.OnRelease();
		}

		// Token: 0x0402D9A7 RID: 186791
		private UUIButtonComponent BtnMain;

		// Token: 0x0402D9A8 RID: 186792
		private UUITexture ProgressBar;

		// Token: 0x0402D9A9 RID: 186793
		private UUISprite IconItem;

		// Token: 0x0402D9AA RID: 186794
		private InputMultiKeyItem KeyItem;

		// Token: 0x0402D9AB RID: 186795
		private CommonQteNoIconLongPressView QteView;

		// Token: 0x0402D9AC RID: 186796
		private bool IsMobile;
	}
}
