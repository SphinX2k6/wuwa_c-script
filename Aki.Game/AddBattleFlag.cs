using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002445 RID: 9285
[NullableContext(1)]
[Nullable(0)]
public class AddBattleFlag : BuffEffect
{
	// Token: 0x060173E2 RID: 95202 RVA: 0x006D4680 File Offset: 0x006D2880
	public AddBattleFlag(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060173E3 RID: 95203 RVA: 0x006D46C0 File Offset: 0x006D28C0
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.AddBattleFlagType = (EAddBattleFlagType)int.Parse(parameters.ExtraEffectParameters_[0]);
		this.BattleFlag = parameters.ExtraEffectParameters_[2];
		EAddBattleFlagType addBattleFlagType = this.AddBattleFlagType;
		if (addBattleFlagType != EAddBattleFlagType.SkillId)
		{
			if (addBattleFlagType == EAddBattleFlagType.SkillGenre)
			{
				string[] array = parameters.ExtraEffectParameters_[1].Split('#', StringSplitOptions.None);
				this.SkillGenres = new int[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					this.SkillGenres[i] = int.Parse(array[i]);
				}
			}
		}
		else
		{
			string[] array2 = parameters.ExtraEffectParameters_[1].Split('#', StringSplitOptions.None);
			this.SkillIds = new long[array2.Length];
			for (int j = 0; j < array2.Length; j++)
			{
				this.SkillIds[j] = long.Parse(array2[j]);
			}
		}
		string text = parameters.ExtraEffectParameters_[3];
		if (!string.IsNullOrEmpty(text))
		{
			this.ExcludeSkillIds = new HashSet<long>();
			string[] array3 = text.Split('#', StringSplitOptions.None);
			for (int k = 0; k < array3.Length; k++)
			{
				this.ExcludeSkillIds.Add(long.Parse(array3[k]));
			}
		}
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.IsApplyToVision = (int.Parse(((extraEffectParameters_.Length > 4) ? extraEffectParameters_[4] : null) ?? "1") == 1);
	}

	// Token: 0x060173E4 RID: 95204 RVA: 0x006D4808 File Offset: 0x006D2A08
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		bool flag;
		bool flag2;
		if (parameters.Length != 0)
		{
			object obj = parameters[0];
			if (obj is bool)
			{
				flag = (bool)obj;
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
		}
		else
		{
			flag2 = false;
		}
		if (flag2 && flag && !this.IsApplyToVision)
		{
			return null;
		}
		return this.BattleFlag;
	}

	// Token: 0x060173E5 RID: 95205 RVA: 0x006D4848 File Offset: 0x006D2A48
	public override string GetDebugEffectString()
	{
		string str = string.Empty;
		switch (this.AddBattleFlagType)
		{
		case EAddBattleFlagType.AllSkill:
			str = "所有技能";
			break;
		case EAddBattleFlagType.SkillId:
			str = "技能Id " + string.Join<long>(",", this.SkillIds);
			break;
		case EAddBattleFlagType.SkillGenre:
			str = "技能类型 " + string.Join<int>(",", this.SkillGenres);
			break;
		}
		return "添加战斗标记 " + this.BattleFlag + " 到 " + str;
	}

	// Token: 0x060173E6 RID: 95206 RVA: 0x006D48CE File Offset: 0x006D2ACE
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x060173E7 RID: 95207 RVA: 0x006D48E4 File Offset: 0x006D2AE4
	private static void ApplyEffectsInner(Entity owner, Skill skill, bool isVision, List<string> battleFlags)
	{
		CharacterBuffComponent component = owner.GetComponent<CharacterBuffComponent>();
		ExtraEffectManager extraEffectManager = (component != null) ? component.BuffEffectManager : null;
		if (extraEffectManager != null)
		{
			foreach (AddBattleFlag addBattleFlag in extraEffectManager.FilterById<AddBattleFlag>(EExtraEffectId.AddBattleFlag, null))
			{
				if (addBattleFlag.Check(new Partial_RequirementPayload(), component))
				{
					HashSet<long> excludeSkillIds = addBattleFlag.ExcludeSkillIds;
					if (excludeSkillIds == null || !excludeSkillIds.Contains((long)skill.SkillId))
					{
						string text = null;
						switch (addBattleFlag.AddBattleFlagType)
						{
						case EAddBattleFlagType.AllSkill:
							text = (addBattleFlag.Execute(new object[]
							{
								isVision
							}) as string);
							break;
						case EAddBattleFlagType.SkillId:
							for (int i = 0; i < addBattleFlag.SkillIds.Length; i++)
							{
								if (addBattleFlag.SkillIds[i] == (long)skill.SkillId)
								{
									text = (addBattleFlag.Execute(new object[]
									{
										isVision
									}) as string);
									break;
								}
							}
							break;
						case EAddBattleFlagType.SkillGenre:
						{
							IReadOnlyList<ESkillGenre> skillGenres = skill.SkillGenres;
							for (int j = 0; j < skillGenres.Count; j++)
							{
								for (int k = 0; k < addBattleFlag.SkillGenres.Length; k++)
								{
									if (addBattleFlag.SkillGenres[k] == (int)skillGenres[j])
									{
										text = (addBattleFlag.Execute(new object[]
										{
											isVision
										}) as string);
										break;
									}
								}
								if (text != null)
								{
									break;
								}
							}
							break;
						}
						}
						if (!string.IsNullOrEmpty(text))
						{
							battleFlags.Add(text);
						}
					}
				}
			}
		}
	}

	// Token: 0x060173E8 RID: 95208 RVA: 0x006D4A94 File Offset: 0x006D2C94
	public static void ApplyEffects(Entity owner, Skill skill)
	{
		skill.BattleContext = new SkillBattleContext
		{
			BattleFlags = new List<string>(),
			VisionId = 0
		};
		List<string> battleFlags = skill.BattleContext.BattleFlags;
		AddBattleFlag.ApplyEffectsInner(owner, skill, false, battleFlags);
		CreatureDataComponent component = owner.GetComponent<CreatureDataComponent>();
		bool? flag = (component != null) ? new bool?(component.IsVision()) : null;
		long? num = (component != null) ? new long?(component.GetSummonerId()) : null;
		if (flag.GetValueOrDefault() && num != null)
		{
			long? num2 = num;
			long num3 = 0L;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num.Value);
				WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
				if (worldEntity != null)
				{
					AddBattleFlag.ApplyEffectsInner(worldEntity, skill, true, battleFlags);
				}
			}
		}
		int count = battleFlags.Count;
	}

	// Token: 0x0400C443 RID: 50243
	private EAddBattleFlagType AddBattleFlagType = EAddBattleFlagType.AllSkill;

	// Token: 0x0400C444 RID: 50244
	private long[] SkillIds = Array.Empty<long>();

	// Token: 0x0400C445 RID: 50245
	private int[] SkillGenres = Array.Empty<int>();

	// Token: 0x0400C446 RID: 50246
	[Nullable(2)]
	private HashSet<long> ExcludeSkillIds;

	// Token: 0x0400C447 RID: 50247
	private bool IsApplyToVision = true;

	// Token: 0x0400C448 RID: 50248
	private string BattleFlag = string.Empty;
}
