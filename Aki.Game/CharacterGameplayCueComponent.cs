using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;

// Token: 0x02002EC1 RID: 11969
[NullableContext(1)]
[Nullable(0)]
public class CharacterGameplayCueComponent : BaseGameplayCueComponent
{
	// Token: 0x060198D3 RID: 104659 RVA: 0x0069C08E File Offset: 0x0069A28E
	protected override bool OnStart()
	{
		base.OnStart();
		this.TimeScaleComponent = base.Entity.GetComponent<PawnTimeScaleComponent>();
		return true;
	}

	// Token: 0x060198D4 RID: 104660 RVA: 0x0069C0A9 File Offset: 0x0069A2A9
	protected override void OnEnable()
	{
		this.SetHidden(false);
	}

	// Token: 0x060198D5 RID: 104661 RVA: 0x0069C0B2 File Offset: 0x0069A2B2
	protected override void OnDisable(string reason)
	{
		this.SetHidden(true);
	}

	// Token: 0x060198D6 RID: 104662 RVA: 0x0069C0BC File Offset: 0x0069A2BC
	protected override void OnChangeTimeDilation(float timeDilation)
	{
		foreach (int num in this.EffectMap.Keys.ToArray<int>())
		{
			if (EffectSystem.Instance.IsValid(num))
			{
				if (this.TimeScaleComponent != null)
				{
					CharacterGameplayCueComponent.CueEffectInfo cueEffectInfo = this.EffectMap[num];
					EffectUtil.SetEffectTimeScale(num, this.TimeScaleComponent, timeDilation, cueEffectInfo.TimeScaleType);
				}
			}
			else
			{
				this.EffectMap.Remove(num);
			}
		}
	}

	// Token: 0x060198D7 RID: 104663 RVA: 0x0069C131 File Offset: 0x0069A331
	[NullableContext(2)]
	protected override EntityHandle GetEntityHandle()
	{
		return CharacterModel.Instance.GetHandleByEntity(base.Entity);
	}

	// Token: 0x060198D8 RID: 104664 RVA: 0x0069C144 File Offset: 0x0069A344
	public override void AddCueEffectToSet(int effectViewHandle, ETimeScaleType timeScaleType, ECueHideRule hideRule)
	{
		this.EffectMap[effectViewHandle] = new CharacterGameplayCueComponent.CueEffectInfo(timeScaleType, hideRule);
		EffectSystem.Instance.AddFinishCallback(effectViewHandle, delegate(int finishedHandle)
		{
			this.EffectMap.Remove(finishedHandle);
		});
		if (this.TimeScaleComponent != null)
		{
			EffectUtil.SetEffectTimeScale(effectViewHandle, this.TimeScaleComponent, base.Entity.TimeDilation, timeScaleType);
		}
		if (!base.Active && hideRule != ECueHideRule.NotFollowEntity)
		{
			EffectSystem.Instance.SetEffectHidden(effectViewHandle, true, "CharacterGameplayCueComponent.AddCueEffectToSet", false);
		}
	}

	// Token: 0x060198D9 RID: 104665 RVA: 0x0069C1BC File Offset: 0x0069A3BC
	public void SetHidden(bool hidden)
	{
		foreach (GameplayCueBase gameplayCueBase in base.GetAllCurrentCueRef())
		{
			if (hidden)
			{
				gameplayCueBase.OnDisable();
			}
			else
			{
				gameplayCueBase.OnEnable();
			}
		}
		foreach (int num in this.EffectMap.Keys.ToArray<int>())
		{
			if (EffectSystem.Instance.IsValid(num))
			{
				if (this.EffectMap[num].HideRule != ECueHideRule.NotFollowEntity)
				{
					EffectSystem.Instance.SetEffectHidden(num, hidden, "CharacterGameplayCueComponent.SetHidden", false);
				}
			}
			else
			{
				this.EffectMap.Remove(num);
			}
		}
	}

	// Token: 0x060198DA RID: 104666 RVA: 0x0069C284 File Offset: 0x0069A484
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterGameplayCueComponent characterGameplayCueComponent = (CharacterGameplayCueComponent)componentTemplate;
		if (base.CanResetComponentProperty("TimeScaleComponent"))
		{
			if (characterGameplayCueComponent.TimeScaleComponent == null)
			{
				this.TimeScaleComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.TimeScaleComponent), "TimeScaleComponent"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("EffectMap") || characterGameplayCueComponent.EffectMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, CharacterGameplayCueComponent.CueEffectInfo>>(this.EffectMap), "EffectMap");
	}

	// Token: 0x0400BEF8 RID: 48888
	[Nullable(2)]
	private PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400BEF9 RID: 48889
	private readonly Dictionary<int, CharacterGameplayCueComponent.CueEffectInfo> EffectMap = new Dictionary<int, CharacterGameplayCueComponent.CueEffectInfo>();

	// Token: 0x020095ED RID: 38381
	[NullableContext(0)]
	private readonly struct CueEffectInfo
	{
		// Token: 0x0604C159 RID: 311641 RVA: 0x0140E50E File Offset: 0x0140C70E
		public CueEffectInfo(ETimeScaleType timeScaleType, ECueHideRule hideRule)
		{
			this.TimeScaleType = timeScaleType;
			this.HideRule = hideRule;
		}

		// Token: 0x1700A109 RID: 41225
		// (get) Token: 0x0604C15A RID: 311642 RVA: 0x0140E51E File Offset: 0x0140C71E
		public ETimeScaleType TimeScaleType { get; }

		// Token: 0x1700A10A RID: 41226
		// (get) Token: 0x0604C15B RID: 311643 RVA: 0x0140E526 File Offset: 0x0140C726
		public ECueHideRule HideRule { get; }
	}
}
