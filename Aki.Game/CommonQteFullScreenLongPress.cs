using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200261F RID: 9759
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteFullScreenLongPress : CommonQteItemBase<CommonQteLongPressContext>
{
	// Token: 0x06013F42 RID: 81730 RVA: 0x00504CBC File Offset: 0x00502EBC
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
		}
	}

	// Token: 0x06013F43 RID: 81731 RVA: 0x00504D5C File Offset: 0x00502F5C
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteFullScreenLongPress.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteFullScreenLongPress.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F44 RID: 81732 RVA: 0x00504DA0 File Offset: 0x00502FA0
	protected override void OnStart()
	{
		base.OnStart();
		this.BtnMain = base.GetButton(1);
		this.ProgressBar = base.GetTexture(3);
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
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		base.SetUiActive(false);
		UUIItem item2 = base.GetItem(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(item2);
		base.SetAttachRootItem(item2);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x06013F45 RID: 81733 RVA: 0x00504E9C File Offset: 0x0050309C
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

	// Token: 0x06013F46 RID: 81734 RVA: 0x00504F01 File Offset: 0x00503101
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteLongPressContext;
	}

	// Token: 0x06013F47 RID: 81735 RVA: 0x00504F0C File Offset: 0x0050310C
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

	// Token: 0x06013F48 RID: 81736 RVA: 0x00504F44 File Offset: 0x00503144
	protected override void OnPlayQteStart()
	{
		base.SetUiActive(true);
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

	// Token: 0x06013F49 RID: 81737 RVA: 0x00504FA4 File Offset: 0x005031A4
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Close2")
		{
			base.Destroy(null);
			return;
		}
		if (sequenceName == "Close")
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
		}
	}

	// Token: 0x06013F4A RID: 81738 RVA: 0x00504FF4 File Offset: 0x005031F4
	protected override void OnInputPress()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
			this.CommonQteContext.Response();
		}
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain == null)
		{
			return;
		}
		btnMain.SetSelectionState(EUISelectableSelectionState.Pressed);
	}

	// Token: 0x06013F4B RID: 81739 RVA: 0x00505054 File Offset: 0x00503254
	protected override void OnInputRelease()
	{
		CommonQteLongPressContext commonQteContext = this.CommonQteContext;
		if (commonQteContext != null && commonQteContext.IsResponsible())
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
			}
			this.CommonQteContext.ResponseEnd();
		}
		UUIButtonComponent btnMain = this.BtnMain;
		if (btnMain == null)
		{
			return;
		}
		btnMain.SetSelectionState(EUISelectableSelectionState.Normal);
	}

	// Token: 0x06013F4C RID: 81740 RVA: 0x005050B4 File Offset: 0x005032B4
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
		levelSequencePlayer2.PlayLevelSequenceByName("Close2", false, null, false);
	}

	// Token: 0x06013F4D RID: 81741 RVA: 0x00505106 File Offset: 0x00503306
	protected override void OnTickQteItem(float delta)
	{
		if (this.CommonQteContext != null)
		{
			this.CurrentProgress = this.CommonQteContext.GetProgress();
		}
		UUITexture progressBar = this.ProgressBar;
		if (progressBar == null)
		{
			return;
		}
		progressBar.SetFillAmount(this.CurrentProgress);
	}

	// Token: 0x06013F4E RID: 81742 RVA: 0x00505138 File Offset: 0x00503338
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

	// Token: 0x0400965C RID: 38492
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400965D RID: 38493
	private float CurrentProgress;

	// Token: 0x0400965E RID: 38494
	private UUIButtonComponent BtnMain;

	// Token: 0x0400965F RID: 38495
	private UUITexture ProgressBar;

	// Token: 0x04009660 RID: 38496
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C6E RID: 35950
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D95F RID: 186719
		Prefab,
		// Token: 0x0402D960 RID: 186720
		Button,
		// Token: 0x0402D961 RID: 186721
		Offset,
		// Token: 0x0402D962 RID: 186722
		Bar,
		// Token: 0x0402D963 RID: 186723
		KeyItem
	}
}
