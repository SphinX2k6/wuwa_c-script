using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AF9 RID: 6905
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteContinuousClickItem : CommonQteItemBase<CommonQteContinuousClickContext>
{
	// Token: 0x060112D4 RID: 70356 RVA: 0x0050C3B4 File Offset: 0x0050A5B4
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

	// Token: 0x060112D5 RID: 70357 RVA: 0x0050C484 File Offset: 0x0050A684
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteContinuousClickItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteContinuousClickItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060112D6 RID: 70358 RVA: 0x0050C4C8 File Offset: 0x0050A6C8
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

	// Token: 0x060112D7 RID: 70359 RVA: 0x0050C5FB File Offset: 0x0050A7FB
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain != null)
		{
			btnMain.OnPointDownCallBack.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x060112D8 RID: 70360 RVA: 0x0050C629 File Offset: 0x0050A829
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteContinuousClickContext;
	}

	// Token: 0x060112D9 RID: 70361 RVA: 0x0050C634 File Offset: 0x0050A834
	[NullableContext(1)]
	protected override void OnRefreshActionUi(string action)
	{
		if (!this.IsMobile)
		{
			InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = action
			};
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
			}
			InputMultiKeyItem keyItem2 = this.KeyItem;
			if (keyItem2 == null)
			{
				return;
			}
			keyItem2.Show(null);
		}
	}

	// Token: 0x060112DA RID: 70362 RVA: 0x0050C67C File Offset: 0x0050A87C
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_ContinuousClick scommonQte_ContinuousClick = uiConfig as SCommonQte_ContinuousClick;
		if (scommonQte_ContinuousClick != null && scommonQte_ContinuousClick.HideProgressBar)
		{
			base.GetItem(1).SetUIActive(false);
		}
		string text = (scommonQte_ContinuousClick != null) ? scommonQte_ContinuousClick.UIConfig.TextId : null;
		UUIText text2 = base.GetText(2);
		if (!StringUtils.IsEmpty(text))
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

	// Token: 0x060112DB RID: 70363 RVA: 0x0050C714 File Offset: 0x0050A914
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

	// Token: 0x060112DC RID: 70364 RVA: 0x0050C76C File Offset: 0x0050A96C
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
			levelSequencePlayer.PlayLevelSequenceByName("Tips", false, null, false);
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

	// Token: 0x060112DD RID: 70365 RVA: 0x0050C7ED File Offset: 0x0050A9ED
	protected override void OnInputPress()
	{
		CommonQteContinuousClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
			this.RefreshProgress();
		}
	}

	// Token: 0x060112DE RID: 70366 RVA: 0x0050C814 File Offset: 0x0050AA14
	protected override void OnHandleQteEnd()
	{
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

	// Token: 0x060112DF RID: 70367 RVA: 0x0050C854 File Offset: 0x0050AA54
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
		this.RefreshProgress();
	}

	// Token: 0x060112E0 RID: 70368 RVA: 0x0050C888 File Offset: 0x0050AA88
	private void RefreshProgress()
	{
		if (this.CommonQteContext != null)
		{
			this.CurrentProgress = this.CommonQteContext.CurrentEnergyPercent * 0.01f;
		}
		UUITexture progressBar = this.ProgressBar;
		if (progressBar == null)
		{
			return;
		}
		progressBar.SetFillAmount(this.CurrentProgress);
	}

	// Token: 0x060112E1 RID: 70369 RVA: 0x0050C8D8 File Offset: 0x0050AAD8
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_ContinuousClick scommonQte_ContinuousClick = this.CommonQteContext.GetUiConfig() as SCommonQte_ContinuousClick;
			if (scommonQte_ContinuousClick != null)
			{
				SCommonQteButton uiconfig = scommonQte_ContinuousClick.UIConfig;
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

	// Token: 0x04009717 RID: 38679
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009718 RID: 38680
	private Number CurrentProgress = 0;

	// Token: 0x04009719 RID: 38681
	private UUIButtonComponent BtnMain;

	// Token: 0x0400971A RID: 38682
	private UUITexture ProgressBar;

	// Token: 0x0400971B RID: 38683
	private UUISliderComponent DurationBar;

	// Token: 0x0400971C RID: 38684
	private InputMultiKeyItem KeyItem;

	// Token: 0x02007DD5 RID: 32213
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028BCB RID: 166859
		BtnMain,
		// Token: 0x04028BCC RID: 166860
		ProgressBar,
		// Token: 0x04028BCD RID: 166861
		DescText,
		// Token: 0x04028BCE RID: 166862
		DurationPanel,
		// Token: 0x04028BCF RID: 166863
		DurationBar,
		// Token: 0x04028BD0 RID: 166864
		AnimItem,
		// Token: 0x04028BD1 RID: 166865
		KeyItem
	}
}
