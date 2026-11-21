using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011A7 RID: 4519
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleBarItem : UiPanelBase, IStaticVariableResetter
{
	// Token: 0x0600B430 RID: 46128 RVA: 0x003537C4 File Offset: 0x003519C4
	static PinballBattleBarItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleBarItem.CreateStaticDefaultValue), new Action(PinballBattleBarItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600B431 RID: 46129 RVA: 0x003537E3 File Offset: 0x003519E3
	public static void CreateStaticDefaultValue()
	{
		PinballBattleBarItem.CurBarChargeType = EKSC_AttrType.SpecialEnergy3;
		PinballBattleBarItem.MaxBarChargeType = EKSC_AttrType.SpecialEnergy3Max;
		PinballBattleBarItem.LevelCompList = new int[]
		{
			0,
			1,
			2,
			3
		};
	}

	// Token: 0x0600B432 RID: 46130 RVA: 0x00353809 File Offset: 0x00351A09
	public static void ResetStaticDefaultValue()
	{
		PinballBattleBarItem.CurBarChargeType = EKSC_AttrType.EAttributeType_None;
		PinballBattleBarItem.MaxBarChargeType = EKSC_AttrType.EAttributeType_None;
		PinballBattleBarItem.LevelCompList = null;
	}

	// Token: 0x0600B433 RID: 46131 RVA: 0x00353820 File Offset: 0x00351A20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B434 RID: 46132 RVA: 0x003538CB File Offset: 0x00351ACB
	protected override void OnStart()
	{
		this.TryBindTeamEntity();
		EventSystem.Instance.Add<int>(EEventName.OnPinballEntityCreated, new Action<int>(this.OnEntityCreated));
	}

	// Token: 0x0600B435 RID: 46133 RVA: 0x003538EF File Offset: 0x00351AEF
	protected override void OnBeforeDestroy()
	{
		this.UnBindAttrDelegate();
		EventSystem.Instance.Remove(EEventName.OnPinballEntityCreated, new Action<int>(this.OnEntityCreated));
	}

	// Token: 0x0600B436 RID: 46134 RVA: 0x00353913 File Offset: 0x00351B13
	private void OnEntityCreated(int entityId)
	{
		if (entityId == 10001)
		{
			this.TryBindTeamEntity();
		}
	}

	// Token: 0x0600B437 RID: 46135 RVA: 0x00353924 File Offset: 0x00351B24
	private void TryBindTeamEntity()
	{
		AKSC_Shape2D_Entity_TeamPlayer kscTeamPlayer = (KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController).KscTeamPlayer;
		if (kscTeamPlayer != null)
		{
			UKSC_SkillComp skillComp_ = kscTeamPlayer.SkillComp_;
			int? num;
			if (skillComp_ == null)
			{
				num = null;
			}
			else
			{
				UKSC_AttrSet attrSet_ = skillComp_.AttrSet_;
				if (attrSet_ == null)
				{
					num = null;
				}
				else
				{
					TMap<EKSC_AttrType, int> attrs_ = attrSet_.Attrs_;
					num = ((attrs_ != null) ? attrs_.GetValueOrNull(PinballBattleBarItem.MaxBarChargeType) : null);
				}
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			int num3 = 3;
			List<float> list = new List<float>();
			for (int i = 0; i <= num3; i++)
			{
				list.Add((float)(i * valueOrDefault / num3));
			}
			this.Init(kscTeamPlayer, list);
		}
	}

	// Token: 0x0600B438 RID: 46136 RVA: 0x003539D0 File Offset: 0x00351BD0
	[NullableContext(1)]
	public void Init(AKSC_Entity kscEntity, List<float> barLevelChargeRequestList)
	{
		this.BarLevelChargeRequestList.Clear();
		foreach (float item in barLevelChargeRequestList)
		{
			this.BarLevelChargeRequestList.Add(item);
		}
		UKSC_SkillComp skillComp = kscEntity.GetSkillComp();
		UKSC_AttrSet uksc_AttrSet = (skillComp != null) ? skillComp.AttrSet_ : null;
		if (uksc_AttrSet == null)
		{
			return;
		}
		TMap<EKSC_AttrType, int> attrs_ = uksc_AttrSet.Attrs_;
		int valueOrDefault = ((attrs_ != null) ? attrs_.GetValueOrNull(PinballBattleBarItem.CurBarChargeType) : null).GetValueOrDefault();
		int curLevel;
		float percent;
		this.GetBarLevelAndPercent((float)valueOrDefault, out curLevel, out percent);
		this.SetProgress(curLevel, percent);
		this.BindAttrDelegate(uksc_AttrSet);
	}

	// Token: 0x0600B439 RID: 46137 RVA: 0x00353A90 File Offset: 0x00351C90
	[NullableContext(1)]
	public void BindAttrDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindAttrDelegate();
		this.DelegateAttrChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnBarChargeChange));
		this.DelegateMaxAttrChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnBarMaxChargeChange));
		attrSet.AssignAttrListen(PinballBattleBarItem.CurBarChargeType, this.DelegateAttrChange);
		attrSet.AssignAttrListen(PinballBattleBarItem.MaxBarChargeType, this.DelegateMaxAttrChange);
		this.OwnerAttrSet = attrSet;
	}

	// Token: 0x0600B43A RID: 46138 RVA: 0x00353AFC File Offset: 0x00351CFC
	public void UnBindAttrDelegate()
	{
		if (this.OwnerAttrSet != null)
		{
			if (this.DelegateAttrChange != null)
			{
				this.OwnerAttrSet.RemoveAttrListen(PinballBattleBarItem.CurBarChargeType, this.DelegateAttrChange);
			}
			if (this.DelegateMaxAttrChange != null)
			{
				this.OwnerAttrSet.RemoveAttrListen(PinballBattleBarItem.MaxBarChargeType, this.DelegateMaxAttrChange);
			}
			this.DelegateAttrChange = null;
			this.DelegateMaxAttrChange = null;
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnBarChargeChange));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnBarMaxChargeChange));
			this.OwnerAttrSet = null;
		}
	}

	// Token: 0x0600B43B RID: 46139 RVA: 0x00353B84 File Offset: 0x00351D84
	private void OnBarChargeChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateBarChargeDisplay();
	}

	// Token: 0x0600B43C RID: 46140 RVA: 0x00353B8C File Offset: 0x00351D8C
	private void OnBarMaxChargeChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateBarChargeDisplay();
	}

	// Token: 0x0600B43D RID: 46141 RVA: 0x00353B94 File Offset: 0x00351D94
	private void UpdateBarChargeDisplay()
	{
		if (this.OwnerAttrSet == null)
		{
			return;
		}
		TMap<EKSC_AttrType, int> attrs_ = this.OwnerAttrSet.Attrs_;
		int valueOrDefault = ((attrs_ != null) ? attrs_.GetValueOrNull(PinballBattleBarItem.CurBarChargeType) : null).GetValueOrDefault();
		int curLevel;
		float percent;
		this.GetBarLevelAndPercent((float)valueOrDefault, out curLevel, out percent);
		this.SetProgress(curLevel, percent);
	}

	// Token: 0x0600B43E RID: 46142 RVA: 0x00353BEB File Offset: 0x00351DEB
	private void SetProgress(int curLevel, float percent)
	{
		if (this.CurLevel != -1 && this.CurLevel != curLevel)
		{
			this.ClearPreviousProgress();
		}
		this.CurLevel = curLevel;
		this.SetLevelFillAmount(curLevel, 1f);
		if (curLevel < this.GetMaxBarLevel())
		{
			this.SetLevelFillAmount(curLevel + 1, percent);
		}
	}

	// Token: 0x0600B43F RID: 46143 RVA: 0x00353C2B File Offset: 0x00351E2B
	private void ClearPreviousProgress()
	{
		this.SetLevelFillAmount(this.CurLevel, 0f);
		if (this.CurLevel < this.GetMaxBarLevel())
		{
			this.SetLevelFillAmount(this.CurLevel + 1, 0f);
		}
	}

	// Token: 0x0600B440 RID: 46144 RVA: 0x00353C5F File Offset: 0x00351E5F
	private void SetLevelFillAmount(int level, float amount)
	{
		if (level < 0 || level >= PinballBattleBarItem.LevelCompList.Length)
		{
			return;
		}
		UUITexture texture = base.GetTexture(PinballBattleBarItem.LevelCompList[level]);
		if (texture == null)
		{
			return;
		}
		texture.SetFillAmount(amount);
	}

	// Token: 0x0600B441 RID: 46145 RVA: 0x00353C88 File Offset: 0x00351E88
	private int GetMaxBarLevel()
	{
		return this.BarLevelChargeRequestList.Count;
	}

	// Token: 0x0600B442 RID: 46146 RVA: 0x00353C98 File Offset: 0x00351E98
	public void GetBarLevelAndPercent(float newValue, out int curLevel, out float percentToNextLevel)
	{
		curLevel = 0;
		foreach (float num in this.BarLevelChargeRequestList)
		{
			if (newValue < num)
			{
				break;
			}
			curLevel++;
		}
		curLevel = Math.Min(curLevel, this.GetMaxBarLevel());
		percentToNextLevel = 0f;
		if (curLevel < this.GetMaxBarLevel() && curLevel < this.BarLevelChargeRequestList.Count)
		{
			float num2 = (curLevel > 0) ? this.BarLevelChargeRequestList[curLevel - 1] : 0f;
			float num3 = this.BarLevelChargeRequestList[curLevel];
			float num4 = newValue - num2;
			float num5 = num3 - num2;
			percentToNextLevel = ((num5 > 0f) ? (num4 / num5) : 0f);
		}
	}

	// Token: 0x04006811 RID: 26641
	private static EKSC_AttrType CurBarChargeType;

	// Token: 0x04006812 RID: 26642
	private static EKSC_AttrType MaxBarChargeType;

	// Token: 0x04006813 RID: 26643
	private static int[] LevelCompList;

	// Token: 0x04006814 RID: 26644
	private int CurLevel = -1;

	// Token: 0x04006815 RID: 26645
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x04006816 RID: 26646
	[Nullable(1)]
	private readonly List<float> BarLevelChargeRequestList = new List<float>();

	// Token: 0x04006817 RID: 26647
	private FOnKSCAttrChange DelegateAttrChange;

	// Token: 0x04006818 RID: 26648
	private FOnKSCAttrChange DelegateMaxAttrChange;
}
