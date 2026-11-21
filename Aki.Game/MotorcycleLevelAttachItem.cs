using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x0200171A RID: 5914
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleLevelAttachItem : AutoAttachItem<IMotorLevelAttachData>
{
	// Token: 0x0600E601 RID: 58881 RVA: 0x00437468 File Offset: 0x00435668
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600E602 RID: 58882 RVA: 0x0043753D File Offset: 0x0043573D
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<MotorcycleLevelAttachItem> onClickAttachItem = this.OnClickAttachItem;
		if (onClickAttachItem == null)
		{
			return;
		}
		onClickAttachItem(this);
	}

	// Token: 0x0600E603 RID: 58883 RVA: 0x00437550 File Offset: 0x00435750
	private bool CheckCanClick()
	{
		return this.Data != null && (this.CheckToggleCanClick == null || this.CheckToggleCanClick(this.Data));
	}

	// Token: 0x0600E604 RID: 58884 RVA: 0x00437577 File Offset: 0x00435777
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x0600E605 RID: 58885 RVA: 0x00437598 File Offset: 0x00435798
	protected override void OnRefreshItem(IMotorLevelAttachData data)
	{
		if (data == null)
		{
			return;
		}
		this.Data = data;
		this.TryInitLevelSequencePlayer();
		int curLevel = MotorcycleDevelopModel.Instance.GetCurLevel();
		int curExp = MotorcycleDevelopModel.Instance.GetCurExp();
		int count = MotorConfig.Instance.GetAllMotorLevelList().Count;
		bool flag = curLevel == count;
		bool flag2 = data.Level == curLevel;
		bool flag3 = data.Level < curLevel;
		bool flag4 = flag || flag3;
		UUIArtText artText = base.GetArtText(1);
		artText.SetText(data.Level.ToString());
		artText.SetColor(flag4 ? FColor.FromHex("9E8257") : FColor.FromHex("E1DACE"));
		base.GetItem(5).SetUIActive(flag2);
		base.GetItem(3).SetUIActive(!flag4);
		base.GetItem(4).SetUIActive(flag4);
		double num = 0.12;
		double num2 = 0.88;
		double num3 = num2 - num;
		float fillAmount;
		if (flag2 && !flag)
		{
			fillAmount = (float)(num + (double)((float)curExp / (float)data.Exp) * num3);
		}
		else
		{
			fillAmount = (flag4 ? ((float)num2) : ((float)num));
		}
		base.GetSprite(2).SetUIActive(flag2);
		base.GetSprite(2).SetFillAmount(fillAmount);
	}

	// Token: 0x0600E606 RID: 58886 RVA: 0x004376D0 File Offset: 0x004358D0
	public override void OnSelect()
	{
		if (this.GetSelectAnimEnable == null || this.GetSelectAnimEnable())
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 != null)
			{
				seqPlayer2.PlaySequencePurely("Select", false, false, null, null, false);
			}
		}
		this.CurrentSelectState = true;
		Action<MotorcycleLevelAttachItem> onSelectAttachItem = this.OnSelectAttachItem;
		if (onSelectAttachItem == null)
		{
			return;
		}
		onSelectAttachItem(this);
	}

	// Token: 0x0600E607 RID: 58887 RVA: 0x0043775C File Offset: 0x0043595C
	public void PlaySelectTween()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 == null)
		{
			return;
		}
		seqPlayer2.PlaySequencePurely("Select", false, false, null, null, false);
	}

	// Token: 0x0600E608 RID: 58888 RVA: 0x004377B4 File Offset: 0x004359B4
	protected override void OnUnSelect()
	{
		if (this.CurrentSelectState)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 != null)
			{
				seqPlayer2.PlaySequencePurely("Unselect", false, false, null, null, false);
			}
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectState = false;
	}

	// Token: 0x0600E609 RID: 58889 RVA: 0x0043781C File Offset: 0x00435A1C
	protected override void OnMoveItem()
	{
		if (this.CurrentSelectState)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 != null)
			{
				seqPlayer2.PlaySequencePurely("Unselect", false, false, null, null, false);
			}
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectState = false;
	}

	// Token: 0x0600E60A RID: 58890 RVA: 0x00437884 File Offset: 0x00435A84
	private void TryInitLevelSequencePlayer()
	{
		if (this.SeqPlayer == null)
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 == null)
			{
				return;
			}
			seqPlayer2.PlaySequencePurely("Unselect", true, false, null, null, false);
		}
	}

	// Token: 0x0600E60B RID: 58891 RVA: 0x004378DF File Offset: 0x00435ADF
	public MotorcycleLevelAttachItem() : base(null)
	{
	}

	// Token: 0x04008368 RID: 33640
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleLevelAttachItem> OnClickAttachItem;

	// Token: 0x04008369 RID: 33641
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleLevelAttachItem> OnSelectAttachItem;

	// Token: 0x0400836A RID: 33642
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<IMotorLevelAttachData, bool> CheckToggleCanClick;

	// Token: 0x0400836B RID: 33643
	public Func<bool> GetSelectAnimEnable;

	// Token: 0x0400836C RID: 33644
	private IMotorLevelAttachData Data;

	// Token: 0x0400836D RID: 33645
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400836E RID: 33646
	private bool CurrentSelectState;

	// Token: 0x020078F3 RID: 30963
	[NullableContext(0)]
	private class EMotorLevelAttachItemComponent
	{
		// Token: 0x04027351 RID: 160593
		public const int TogLevel = 0;

		// Token: 0x04027352 RID: 160594
		public const int ArtLevel = 1;

		// Token: 0x04027353 RID: 160595
		public const int SprProgress = 2;

		// Token: 0x04027354 RID: 160596
		public const int CurLevelItem = 3;

		// Token: 0x04027355 RID: 160597
		public const int PassLevelItem = 4;

		// Token: 0x04027356 RID: 160598
		public const int ArrowItem = 5;

		// Token: 0x04027357 RID: 160599
		public const int ScaleItem = 6;
	}
}
