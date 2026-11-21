using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001755 RID: 5973
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleTechTreeInfoPanel : UiPanelBase
{
	// Token: 0x17001628 RID: 5672
	// (get) Token: 0x0600E809 RID: 59401 RVA: 0x0043F50C File Offset: 0x0043D70C
	private bool IsLockByPlayerStatus
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreePlayerLocked();
		}
	}

	// Token: 0x0600E80A RID: 59402 RVA: 0x0043F518 File Offset: 0x0043D718
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUITexture)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(14, new Action<EToggleState>(this.OnTogEachLevelClick))
		};
	}

	// Token: 0x0600E80B RID: 59403 RVA: 0x0043F6A4 File Offset: 0x0043D8A4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeInfoPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeInfoPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E80C RID: 59404 RVA: 0x0043F6E7 File Offset: 0x0043D8E7
	protected override void OnBeforeDestroy()
	{
		MediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.Clear();
		}
		this.MediaPlayer = null;
		this.CancelLoad();
	}

	// Token: 0x0600E80D RID: 59405 RVA: 0x0043F708 File Offset: 0x0043D908
	[NullableContext(1)]
	public UniTask RefreshAsync(MotorTechTreeNode treeNode)
	{
		MotorcycleTechTreeInfoPanel.<RefreshAsync>d__13 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.treeNode = treeNode;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<MotorcycleTechTreeInfoPanel.<RefreshAsync>d__13>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E80E RID: 59406 RVA: 0x0043F754 File Offset: 0x0043D954
	public void PlayChangeTween()
	{
		this.SeqPlayer.StopSequenceByKey("Change", false, false);
		this.SeqPlayer.PlayLevelSequenceByName("Change", false, null, false);
	}

	// Token: 0x0600E80F RID: 59407 RVA: 0x0043F790 File Offset: 0x0043D990
	private UniTask LoadMaterial()
	{
		MotorcycleTechTreeInfoPanel.<LoadMaterial>d__15 <LoadMaterial>d__;
		<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMaterial>d__.<>4__this = this;
		<LoadMaterial>d__.<>1__state = -1;
		<LoadMaterial>d__.<>t__builder.Start<MotorcycleTechTreeInfoPanel.<LoadMaterial>d__15>(ref <LoadMaterial>d__);
		return <LoadMaterial>d__.<>t__builder.Task;
	}

	// Token: 0x0600E810 RID: 59408 RVA: 0x0043F7D3 File Offset: 0x0043D9D3
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = -1;
		}
	}

	// Token: 0x0600E811 RID: 59409 RVA: 0x0043F7F8 File Offset: 0x0043D9F8
	private void OnTogEachLevelClick(EToggleState toggleState)
	{
		if (this.Node == null)
		{
			return;
		}
		MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(this.Node.NodeId);
		if (motorTechConfig == null)
		{
			return;
		}
		List<IMotorTechLevelPoint> list = new List<IMotorTechLevelPoint>();
		for (int i = 0; i < motorTechConfig.Value.GetTechLvArray().Length; i++)
		{
			MotorTechLevelPoint motorTechLevelPoint = new MotorTechLevelPoint
			{
				TargetLevel = i + 1,
				CurLevel = this.Node.NodeLevel,
				Title = motorTechConfig.Value.Title
			};
			motorTechLevelPoint.Desc = MotorConfig.Instance.GetMotorTechLvConfig(motorTechConfig.Value.GetTechLvArray()[i]).Value.Desc;
			list.Add(motorTechLevelPoint);
		}
		UiManager.Instance.OpenView(EUiViewName.MotorcycleTechTreeLevelDetailView, list, null);
	}

	// Token: 0x0600E812 RID: 59410 RVA: 0x0043F8D8 File Offset: 0x0043DAD8
	private void OnConfirmBtnClick(int _)
	{
		if (this.Node == null)
		{
			return;
		}
		if (!MotorcycleDevelopModel.Instance.CanUpgradeNode(this.Node))
		{
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.SelectMotorDevelopTab, EUiTabViewName.MotorcycleTaskTabView);
			return;
		}
		if (this.IsLockByPlayerStatus)
		{
			return;
		}
		MotorcycleDevelopController.Instance.RequestMotorTechLevelUp(this.Node.NodeId);
	}

	// Token: 0x0600E813 RID: 59411 RVA: 0x0043F934 File Offset: 0x0043DB34
	private void OnHelpBtnClick()
	{
		HelpController.Instance.OpenHelpById(470);
	}

	// Token: 0x0400843E RID: 33854
	private const float TAG_BG_ALPHA = 0.3f;

	// Token: 0x0400843F RID: 33855
	private MotorTechTreeNode Node;

	// Token: 0x04008440 RID: 33856
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04008441 RID: 33857
	private FunctionalPanelConditionLock LockTipsItem;

	// Token: 0x04008442 RID: 33858
	private MediaPlayer MediaPlayer;

	// Token: 0x04008443 RID: 33859
	private int HandleId = -1;

	// Token: 0x04008444 RID: 33860
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0200792F RID: 31023
	[NullableContext(0)]
	private class EMotorTechTreeInfoComponent
	{
		// Token: 0x0402746C RID: 160876
		public const int TexSkillIcon = 0;

		// Token: 0x0402746D RID: 160877
		public const int TxtName = 1;

		// Token: 0x0402746E RID: 160878
		public const int SprTagIcon = 2;

		// Token: 0x0402746F RID: 160879
		public const int SprTagBg = 3;

		// Token: 0x04027470 RID: 160880
		public const int TxtTagName = 4;

		// Token: 0x04027471 RID: 160881
		public const int TxtDesc = 5;

		// Token: 0x04027472 RID: 160882
		public const int BtnConfirm = 6;

		// Token: 0x04027473 RID: 160883
		public const int TxtCostNum = 7;

		// Token: 0x04027474 RID: 160884
		public const int TexCostItemIcon = 8;

		// Token: 0x04027475 RID: 160885
		public const int PnlVideo = 9;

		// Token: 0x04027476 RID: 160886
		public const int TexVideo = 10;

		// Token: 0x04027477 RID: 160887
		public const int PnlHint = 11;

		// Token: 0x04027478 RID: 160888
		public const int PnlLockTips = 12;

		// Token: 0x04027479 RID: 160889
		public const int PnlMaxTips = 13;

		// Token: 0x0402747A RID: 160890
		public const int TogEachLevel = 14;
	}
}
