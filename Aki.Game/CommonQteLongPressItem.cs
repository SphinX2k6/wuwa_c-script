using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002616 RID: 9750
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteLongPressItem : CommonQteItemBase<CommonQteLongPressContext>
{
	// Token: 0x06013E9B RID: 81563 RVA: 0x00500F84 File Offset: 0x004FF184
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISliderComponent))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		}
	}

	// Token: 0x06013E9C RID: 81564 RVA: 0x00501054 File Offset: 0x004FF254
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteLongPressItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteLongPressItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E9D RID: 81565 RVA: 0x00501098 File Offset: 0x004FF298
	protected override void OnStart()
	{
		base.OnStart();
		this.BtnMain = base.GetButton(0);
		this.ProgressBar = base.GetTexture(1);
		this.DurationBar = base.GetSlider(4);
		UUISliderComponent durationBar = this.DurationBar;
		if (durationBar != null)
		{
			durationBar.SetValue(1f, true);
		}
		UUISliderComponent durationBar2 = this.DurationBar;
		if (durationBar2 != null)
		{
			durationBar2.SetSelfInteractive(false);
		}
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain != null)
		{
			btnMain.OnPointDownCallBack.Bind(delegate()
			{
				base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Press, null);
			});
		}
		UUIButtonComponent btnMain2 = this.BtnMain;
		if (btnMain2 != null)
		{
			btnMain2.OnPointUpCallBack.Bind(delegate()
			{
				base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Release, null);
			});
		}
		UUIButtonComponent btnMain3 = this.BtnMain;
		if (btnMain3 != null)
		{
			btnMain3.OnPointCancelCallBack.Bind(delegate()
			{
				base.OnInputCallback(this.QteAction, InputDistributeDefine.EActionType.Release, null);
			});
		}
		if (this.KeyItem != null)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.Hide(null);
			}
		}
		else
		{
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
		base.SetUiActive(false);
		if (Info.Instance.IsInTouch())
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
		else
		{
			UUIItem item3 = base.GetItem(5);
			this.LevelSequencePlayer = new LevelSequencePlayer(item3);
			base.SetAttachRootItem(item3);
		}
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x06013E9E RID: 81566 RVA: 0x00501210 File Offset: 0x004FF410
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
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
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x06013E9F RID: 81567 RVA: 0x00501275 File Offset: 0x004FF475
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteLongPressContext;
	}

	// Token: 0x06013EA0 RID: 81568 RVA: 0x00501280 File Offset: 0x004FF480
	[NullableContext(1)]
	protected override void OnRefreshActionUi(string action)
	{
		if (!Info.Instance.IsInTouch())
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

	// Token: 0x06013EA1 RID: 81569 RVA: 0x005012B8 File Offset: 0x004FF4B8
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_LongPress scommonQte_LongPress = uiConfig as SCommonQte_LongPress;
		string text = (scommonQte_LongPress != null) ? scommonQte_LongPress.UIConfig.TextId : null;
		UUIText text2 = base.GetText(2);
		if (!string.IsNullOrEmpty(text))
		{
			LguiUtil.Instance.SetLocalTextNew(text2, text, Array.Empty<object>());
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
		}
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.CommonQteContext != null && !this.CommonQteContext.IsPermanent);
	}

	// Token: 0x06013EA2 RID: 81570 RVA: 0x00501334 File Offset: 0x004FF534
	protected override void OnPlayQteStart()
	{
		base.SetUiActive(true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		if (this.IsQteInteractive && !this.IsMobile)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}
	}

	// Token: 0x06013EA3 RID: 81571 RVA: 0x0050138C File Offset: 0x004FF58C
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (!(sequenceName == "Start"))
		{
			if (sequenceName == "Close")
			{
				base.Destroy(null);
			}
			return;
		}
		if (this.IsQteEnd)
		{
			return;
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
		}
		if (!this.IsMobile)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.Show(null);
			}
		}
		this.IsQteStart = true;
		this.IsQteInteractive = true;
	}

	// Token: 0x06013EA4 RID: 81572 RVA: 0x0050140D File Offset: 0x004FF60D
	protected override void OnInputPress()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
		}
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain == null)
		{
			return;
		}
		btnMain.SetSelectionState(EUISelectableSelectionState.Pressed);
	}

	// Token: 0x06013EA5 RID: 81573 RVA: 0x0050143F File Offset: 0x004FF63F
	protected override void OnInputRelease()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.ResponseEnd();
		}
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain == null)
		{
			return;
		}
		btnMain.SetSelectionState(EUISelectableSelectionState.Normal);
	}

	// Token: 0x06013EA6 RID: 81574 RVA: 0x00501474 File Offset: 0x004FF674
	protected override void OnHandleQteEnd()
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.Hide(null);
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

	// Token: 0x06013EA7 RID: 81575 RVA: 0x005014C8 File Offset: 0x004FF6C8
	protected override void OnTickQteItem(float delta)
	{
		if (!this.CommonQteContext.IsPermanent)
		{
			UUISliderComponent durationBar = this.DurationBar;
			if (durationBar != null)
			{
				durationBar.SetValue(this.CommonQteContext.GetRemainingTimeProgress(), true);
			}
		}
		this.CurrentProgress = this.CommonQteContext.GetProgress();
		UUITexture progressBar = this.ProgressBar;
		if (progressBar == null)
		{
			return;
		}
		progressBar.SetFillAmount(this.CurrentProgress);
	}

	// Token: 0x06013EA8 RID: 81576 RVA: 0x00501528 File Offset: 0x004FF728
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_LongPress scommonQte_LongPress = this.CommonQteContext.GetUiConfig() as SCommonQte_LongPress;
			if (scommonQte_LongPress != null)
			{
				SCommonQteButton uiconfig = scommonQte_LongPress.UIConfig;
				UUIItem rootItem = this.RootItem;
				if (rootItem != null)
				{
					rootItem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
				}
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 != null)
				{
					rootItem2.SetAnchorOffset(uiconfig.AnchorOffset);
				}
				if (this.IsAttaching)
				{
					this.Reattach(this.CommonQteContext);
				}
			}
		}
	}

	// Token: 0x04009612 RID: 38418
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009613 RID: 38419
	private float CurrentProgress;

	// Token: 0x04009614 RID: 38420
	private UUIButtonComponent BtnMain;

	// Token: 0x04009615 RID: 38421
	private UUITexture ProgressBar;

	// Token: 0x04009616 RID: 38422
	private UUISliderComponent DurationBar;

	// Token: 0x04009617 RID: 38423
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C5A RID: 35930
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8F3 RID: 186611
		BtnMain,
		// Token: 0x0402D8F4 RID: 186612
		ProgressBar,
		// Token: 0x0402D8F5 RID: 186613
		DescText,
		// Token: 0x0402D8F6 RID: 186614
		DurationPanel,
		// Token: 0x0402D8F7 RID: 186615
		DurationBar,
		// Token: 0x0402D8F8 RID: 186616
		AnimItem,
		// Token: 0x0402D8F9 RID: 186617
		KeyItem
	}
}
