using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200261D RID: 9757
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteSingleTap37View : CommonQteItemBase<CommonQteLongPressContext>
{
	// Token: 0x06013F14 RID: 81684 RVA: 0x00503CD4 File Offset: 0x00501ED4
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
	}

	// Token: 0x06013F15 RID: 81685 RVA: 0x00503D48 File Offset: 0x00501F48
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteSingleTap37View.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteSingleTap37View.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F16 RID: 81686 RVA: 0x00503D8C File Offset: 0x00501F8C
	protected override void OnStart()
	{
		base.OnStart();
		this.BtnMain = base.GetButton(0);
		this.ProgressBar = base.GetTexture(1);
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
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		base.SetUiActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
	}

	// Token: 0x06013F17 RID: 81687 RVA: 0x00503E80 File Offset: 0x00502080
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

	// Token: 0x06013F18 RID: 81688 RVA: 0x00503EE5 File Offset: 0x005020E5
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteLongPressContext;
	}

	// Token: 0x06013F19 RID: 81689 RVA: 0x00503EF0 File Offset: 0x005020F0
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

	// Token: 0x06013F1A RID: 81690 RVA: 0x00503F28 File Offset: 0x00502128
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

	// Token: 0x06013F1B RID: 81691 RVA: 0x00503F80 File Offset: 0x00502180
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

	// Token: 0x06013F1C RID: 81692 RVA: 0x00504001 File Offset: 0x00502201
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

	// Token: 0x06013F1D RID: 81693 RVA: 0x00504033 File Offset: 0x00502233
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

	// Token: 0x06013F1E RID: 81694 RVA: 0x00504068 File Offset: 0x00502268
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

	// Token: 0x06013F1F RID: 81695 RVA: 0x005040BA File Offset: 0x005022BA
	protected override void OnTickQteItem(float delta)
	{
		this.CurrentProgress = this.CommonQteContext.GetProgress();
		UUITexture progressBar = this.ProgressBar;
		if (progressBar == null)
		{
			return;
		}
		progressBar.SetFillAmount(this.CurrentProgress);
	}

	// Token: 0x06013F20 RID: 81696 RVA: 0x005040E4 File Offset: 0x005022E4
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
				UUIItem rootItem3 = this.RootItem;
				if (rootItem3 != null)
				{
					FRotator anchorRotation = uiconfig.AnchorRotation;
					rootItem3.SetUIRelativeRotation(anchorRotation);
				}
				if (this.IsAttaching)
				{
					this.Reattach(this.CommonQteContext);
				}
			}
		}
	}

	// Token: 0x04009647 RID: 38471
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009648 RID: 38472
	private float CurrentProgress;

	// Token: 0x04009649 RID: 38473
	private UUIButtonComponent BtnMain;

	// Token: 0x0400964A RID: 38474
	private UUITexture ProgressBar;

	// Token: 0x0400964B RID: 38475
	private InputMultiKeyItem KeyItem;

	// Token: 0x02008C6A RID: 35946
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D94F RID: 186703
		BtnMain,
		// Token: 0x0402D950 RID: 186704
		ProgressBar,
		// Token: 0x0402D951 RID: 186705
		KeyItem
	}
}
