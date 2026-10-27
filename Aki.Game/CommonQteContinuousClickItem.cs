using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200260E RID: 9742
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteContinuousClickItem : CommonQteItemBase<CommonQteContinuousClickContext>
{
	// Token: 0x06013DF2 RID: 81394 RVA: 0x004FD578 File Offset: 0x004FB778
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

	// Token: 0x06013DF3 RID: 81395 RVA: 0x004FD648 File Offset: 0x004FB848
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteContinuousClickItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteContinuousClickItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013DF4 RID: 81396 RVA: 0x004FD68C File Offset: 0x004FB88C
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

	// Token: 0x06013DF5 RID: 81397 RVA: 0x004FD7BF File Offset: 0x004FB9BF
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

	// Token: 0x06013DF6 RID: 81398 RVA: 0x004FD7ED File Offset: 0x004FB9ED
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteContinuousClickContext;
	}

	// Token: 0x06013DF7 RID: 81399 RVA: 0x004FD7F8 File Offset: 0x004FB9F8
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

	// Token: 0x06013DF8 RID: 81400 RVA: 0x004FD840 File Offset: 0x004FBA40
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

	// Token: 0x06013DF9 RID: 81401 RVA: 0x004FD8D8 File Offset: 0x004FBAD8
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

	// Token: 0x06013DFA RID: 81402 RVA: 0x004FD930 File Offset: 0x004FBB30
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

	// Token: 0x06013DFB RID: 81403 RVA: 0x004FD9B1 File Offset: 0x004FBBB1
	protected override void OnInputPress()
	{
		CommonQteContinuousClickContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			this.CommonQteContext.Response();
			this.RefreshProgress();
		}
	}

	// Token: 0x06013DFC RID: 81404 RVA: 0x004FD9D8 File Offset: 0x004FBBD8
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

	// Token: 0x06013DFD RID: 81405 RVA: 0x004FDA18 File Offset: 0x004FBC18
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

	// Token: 0x06013DFE RID: 81406 RVA: 0x004FDA4C File Offset: 0x004FBC4C
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

	// Token: 0x06013DFF RID: 81407 RVA: 0x004FDA9C File Offset: 0x004FBC9C
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

	// Token: 0x040095C0 RID: 38336
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040095C1 RID: 38337
	private Number CurrentProgress = 0;

	// Token: 0x040095C2 RID: 38338
	private UUIButtonComponent BtnMain;

	// Token: 0x040095C3 RID: 38339
	private UUITexture ProgressBar;

	// Token: 0x040095C4 RID: 38340
	private UUISliderComponent DurationBar;

	// Token: 0x040095C5 RID: 38341
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C4C RID: 35916
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8B4 RID: 186548
		BtnMain,
		// Token: 0x0402D8B5 RID: 186549
		ProgressBar,
		// Token: 0x0402D8B6 RID: 186550
		DescText,
		// Token: 0x0402D8B7 RID: 186551
		DurationPanel,
		// Token: 0x0402D8B8 RID: 186552
		DurationBar,
		// Token: 0x0402D8B9 RID: 186553
		AnimItem,
		// Token: 0x0402D8BA RID: 186554
		KeyItem
	}
}
