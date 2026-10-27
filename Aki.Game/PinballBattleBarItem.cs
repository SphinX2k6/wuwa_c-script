using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CE5 RID: 7397
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleBarItem : UiPanelBase, IStaticVariableResetter
{
	// Token: 0x0600E013 RID: 57363 RVA: 0x00347D9C File Offset: 0x00345F9C
	static PinballBattleBarItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleBarItem.CreateStaticDefaultValue), new Action(PinballBattleBarItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600E014 RID: 57364 RVA: 0x00347DBB File Offset: 0x00345FBB
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

	// Token: 0x0600E015 RID: 57365 RVA: 0x00347DE1 File Offset: 0x00345FE1
	public static void ResetStaticDefaultValue()
	{
		PinballBattleBarItem.CurBarChargeType = EKSC_AttrType.EAttributeType_None;
		PinballBattleBarItem.MaxBarChargeType = EKSC_AttrType.EAttributeType_None;
		PinballBattleBarItem.LevelCompList = null;
	}

	// Token: 0x0600E016 RID: 57366 RVA: 0x00347DF8 File Offset: 0x00345FF8
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

	// Token: 0x0600E017 RID: 57367 RVA: 0x00347EA3 File Offset: 0x003460A3
	protected override void OnStart()
	{
		this.TryBindTeamEntity();
		EventSystem.Instance.Add<int>(EEventName.OnPinballEntityCreated, new Action<int>(this.OnEntityCreated));
	}

	// Token: 0x0600E018 RID: 57368 RVA: 0x00347EC7 File Offset: 0x003460C7
	protected override void OnBeforeDestroy()
	{
		this.UnBindAttrDelegate();
		EventSystem.Instance.Remove(EEventName.OnPinballEntityCreated, new Action<int>(this.OnEntityCreated));
	}

	// Token: 0x0600E019 RID: 57369 RVA: 0x00347EEB File Offset: 0x003460EB
	private void OnEntityCreated(int entityId)
	{
		if (entityId == 10001)
		{
			this.TryBindTeamEntity();
		}
	}

	// Token: 0x0600E01A RID: 57370 RVA: 0x00347EFC File Offset: 0x003460FC
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

	// Token: 0x0600E01B RID: 57371 RVA: 0x00347FA8 File Offset: 0x003461A8
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

	// Token: 0x0600E01C RID: 57372 RVA: 0x00348068 File Offset: 0x00346268
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

	// Token: 0x0600E01D RID: 57373 RVA: 0x003480D4 File Offset: 0x003462D4
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

	// Token: 0x0600E01E RID: 57374 RVA: 0x0034815C File Offset: 0x0034635C
	private void OnBarChargeChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateBarChargeDisplay();
	}

	// Token: 0x0600E01F RID: 57375 RVA: 0x00348164 File Offset: 0x00346364
	private void OnBarMaxChargeChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateBarChargeDisplay();
	}

	// Token: 0x0600E020 RID: 57376 RVA: 0x0034816C File Offset: 0x0034636C
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

	// Token: 0x0600E021 RID: 57377 RVA: 0x003481C3 File Offset: 0x003463C3
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

	// Token: 0x0600E022 RID: 57378 RVA: 0x00348203 File Offset: 0x00346403
	private void ClearPreviousProgress()
	{
		this.SetLevelFillAmount(this.CurLevel, 0f);
		if (this.CurLevel < this.GetMaxBarLevel())
		{
			this.SetLevelFillAmount(this.CurLevel + 1, 0f);
		}
	}

	// Token: 0x0600E023 RID: 57379 RVA: 0x00348237 File Offset: 0x00346437
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

	// Token: 0x0600E024 RID: 57380 RVA: 0x00348260 File Offset: 0x00346460
	private int GetMaxBarLevel()
	{
		return this.BarLevelChargeRequestList.Count;
	}

	// Token: 0x0600E025 RID: 57381 RVA: 0x00348270 File Offset: 0x00346470
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

	// Token: 0x04006732 RID: 26418
	private static EKSC_AttrType CurBarChargeType;

	// Token: 0x04006733 RID: 26419
	private static EKSC_AttrType MaxBarChargeType;

	// Token: 0x04006734 RID: 26420
	private static int[] LevelCompList;

	// Token: 0x04006735 RID: 26421
	private int CurLevel = -1;

	// Token: 0x04006736 RID: 26422
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x04006737 RID: 26423
	[Nullable(1)]
	private readonly List<float> BarLevelChargeRequestList = new List<float>();

	// Token: 0x04006738 RID: 26424
	private FOnKSCAttrChange DelegateAttrChange;

	// Token: 0x04006739 RID: 26425
	private FOnKSCAttrChange DelegateMaxAttrChange;
}
