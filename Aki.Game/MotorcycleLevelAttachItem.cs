using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02002236 RID: 8758
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleLevelAttachItem : AutoAttachItem<IMotorLevelAttachData>
{
	// Token: 0x0601116B RID: 69995 RVA: 0x0042A8C4 File Offset: 0x00428AC4
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

	// Token: 0x0601116C RID: 69996 RVA: 0x0042A999 File Offset: 0x00428B99
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<MotorcycleLevelAttachItem> onClickAttachItem = this.OnClickAttachItem;
		if (onClickAttachItem == null)
		{
			return;
		}
		onClickAttachItem(this);
	}

	// Token: 0x0601116D RID: 69997 RVA: 0x0042A9AC File Offset: 0x00428BAC
	private bool CheckCanClick()
	{
		return this.Data != null && (this.CheckToggleCanClick == null || this.CheckToggleCanClick(this.Data));
	}

	// Token: 0x0601116E RID: 69998 RVA: 0x0042A9D3 File Offset: 0x00428BD3
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x0601116F RID: 69999 RVA: 0x0042A9F4 File Offset: 0x00428BF4
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

	// Token: 0x06011170 RID: 70000 RVA: 0x0042AB2C File Offset: 0x00428D2C
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

	// Token: 0x06011171 RID: 70001 RVA: 0x0042ABB8 File Offset: 0x00428DB8
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

	// Token: 0x06011172 RID: 70002 RVA: 0x0042AC10 File Offset: 0x00428E10
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

	// Token: 0x06011173 RID: 70003 RVA: 0x0042AC78 File Offset: 0x00428E78
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

	// Token: 0x06011174 RID: 70004 RVA: 0x0042ACE0 File Offset: 0x00428EE0
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

	// Token: 0x06011175 RID: 70005 RVA: 0x0042AD3B File Offset: 0x00428F3B
	public MotorcycleLevelAttachItem() : base(null)
	{
	}

	// Token: 0x0400822A RID: 33322
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleLevelAttachItem> OnClickAttachItem;

	// Token: 0x0400822B RID: 33323
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleLevelAttachItem> OnSelectAttachItem;

	// Token: 0x0400822C RID: 33324
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<IMotorLevelAttachData, bool> CheckToggleCanClick;

	// Token: 0x0400822D RID: 33325
	public Func<bool> GetSelectAnimEnable;

	// Token: 0x0400822E RID: 33326
	private IMotorLevelAttachData Data;

	// Token: 0x0400822F RID: 33327
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008230 RID: 33328
	private bool CurrentSelectState;

	// Token: 0x0200876A RID: 34666
	[NullableContext(0)]
	private class EMotorLevelAttachItemComponent
	{
		// Token: 0x0402C039 RID: 180281
		public const int TogLevel = 0;

		// Token: 0x0402C03A RID: 180282
		public const int ArtLevel = 1;

		// Token: 0x0402C03B RID: 180283
		public const int SprProgress = 2;

		// Token: 0x0402C03C RID: 180284
		public const int CurLevelItem = 3;

		// Token: 0x0402C03D RID: 180285
		public const int PassLevelItem = 4;

		// Token: 0x0402C03E RID: 180286
		public const int ArrowItem = 5;

		// Token: 0x0402C03F RID: 180287
		public const int ScaleItem = 6;
	}
}
