using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002271 RID: 8817
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleTechTreeInfoPanel : UiPanelBase
{
	// Token: 0x170015F1 RID: 5617
	// (get) Token: 0x06011373 RID: 70515 RVA: 0x00432900 File Offset: 0x00430B00
	private bool IsLockByPlayerStatus
	{
		get
		{
			return MotorcycleDevelopModel.Instance.IsSwitchTechTreePlayerLocked();
		}
	}

	// Token: 0x06011374 RID: 70516 RVA: 0x0043290C File Offset: 0x00430B0C
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

	// Token: 0x06011375 RID: 70517 RVA: 0x00432A98 File Offset: 0x00430C98
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTechTreeInfoPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTechTreeInfoPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011376 RID: 70518 RVA: 0x00432ADB File Offset: 0x00430CDB
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

	// Token: 0x06011377 RID: 70519 RVA: 0x00432AFC File Offset: 0x00430CFC
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

	// Token: 0x06011378 RID: 70520 RVA: 0x00432B48 File Offset: 0x00430D48
	public void PlayChangeTween()
	{
		this.SeqPlayer.StopSequenceByKey("Change", false, false);
		this.SeqPlayer.PlayLevelSequenceByName("Change", false, null, false);
	}

	// Token: 0x06011379 RID: 70521 RVA: 0x00432B84 File Offset: 0x00430D84
	private UniTask LoadMaterial()
	{
		MotorcycleTechTreeInfoPanel.<LoadMaterial>d__15 <LoadMaterial>d__;
		<LoadMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadMaterial>d__.<>4__this = this;
		<LoadMaterial>d__.<>1__state = -1;
		<LoadMaterial>d__.<>t__builder.Start<MotorcycleTechTreeInfoPanel.<LoadMaterial>d__15>(ref <LoadMaterial>d__);
		return <LoadMaterial>d__.<>t__builder.Task;
	}

	// Token: 0x0601137A RID: 70522 RVA: 0x00432BC7 File Offset: 0x00430DC7
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = -1;
		}
	}

	// Token: 0x0601137B RID: 70523 RVA: 0x00432BEC File Offset: 0x00430DEC
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

	// Token: 0x0601137C RID: 70524 RVA: 0x00432CCC File Offset: 0x00430ECC
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

	// Token: 0x0601137D RID: 70525 RVA: 0x00432D28 File Offset: 0x00430F28
	private void OnHelpBtnClick()
	{
		HelpController.Instance.OpenHelpById(470);
	}

	// Token: 0x04008300 RID: 33536
	private const float TAG_BG_ALPHA = 0.3f;

	// Token: 0x04008301 RID: 33537
	private MotorTechTreeNode Node;

	// Token: 0x04008302 RID: 33538
	private ButtonItem ConfirmBtnItem;

	// Token: 0x04008303 RID: 33539
	private FunctionalPanelConditionLock LockTipsItem;

	// Token: 0x04008304 RID: 33540
	private MediaPlayer MediaPlayer;

	// Token: 0x04008305 RID: 33541
	private int HandleId = -1;

	// Token: 0x04008306 RID: 33542
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x020087A6 RID: 34726
	[NullableContext(0)]
	private class EMotorTechTreeInfoComponent
	{
		// Token: 0x0402C154 RID: 180564
		public const int TexSkillIcon = 0;

		// Token: 0x0402C155 RID: 180565
		public const int TxtName = 1;

		// Token: 0x0402C156 RID: 180566
		public const int SprTagIcon = 2;

		// Token: 0x0402C157 RID: 180567
		public const int SprTagBg = 3;

		// Token: 0x0402C158 RID: 180568
		public const int TxtTagName = 4;

		// Token: 0x0402C159 RID: 180569
		public const int TxtDesc = 5;

		// Token: 0x0402C15A RID: 180570
		public const int BtnConfirm = 6;

		// Token: 0x0402C15B RID: 180571
		public const int TxtCostNum = 7;

		// Token: 0x0402C15C RID: 180572
		public const int TexCostItemIcon = 8;

		// Token: 0x0402C15D RID: 180573
		public const int PnlVideo = 9;

		// Token: 0x0402C15E RID: 180574
		public const int TexVideo = 10;

		// Token: 0x0402C15F RID: 180575
		public const int PnlHint = 11;

		// Token: 0x0402C160 RID: 180576
		public const int PnlLockTips = 12;

		// Token: 0x0402C161 RID: 180577
		public const int PnlMaxTips = 13;

		// Token: 0x0402C162 RID: 180578
		public const int TogEachLevel = 14;
	}
}
