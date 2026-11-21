using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;

// Token: 0x02002414 RID: 9236
[NullableContext(1)]
[Nullable(0)]
public class CharacterGameplayCueComponent : BaseGameplayCueComponent
{
	// Token: 0x060171BF RID: 94655 RVA: 0x006C22AA File Offset: 0x006C04AA
	protected override bool OnStart()
	{
		base.OnStart();
		this.TimeScaleComponent = base.Entity.GetComponent<PawnTimeScaleComponent>();
		return true;
	}

	// Token: 0x060171C0 RID: 94656 RVA: 0x006C22C5 File Offset: 0x006C04C5
	protected override void OnEnable()
	{
		this.SetHidden(false);
	}

	// Token: 0x060171C1 RID: 94657 RVA: 0x006C22CE File Offset: 0x006C04CE
	protected override void OnDisable(string reason)
	{
		this.SetHidden(true);
	}

	// Token: 0x060171C2 RID: 94658 RVA: 0x006C22D8 File Offset: 0x006C04D8
	protected override void OnChangeTimeDilation(float timeDilation)
	{
		int[] array = new int[this.EffectMap.Count];
		this.EffectMap.Keys.CopyTo(array, 0);
		foreach (int num in array)
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

	// Token: 0x060171C3 RID: 94659 RVA: 0x006C2362 File Offset: 0x006C0562
	[NullableContext(2)]
	protected override EntityHandle GetEntityHandle()
	{
		return CharacterModel.Instance.GetHandleByEntity(base.Entity);
	}

	// Token: 0x060171C4 RID: 94660 RVA: 0x006C2374 File Offset: 0x006C0574
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

	// Token: 0x060171C5 RID: 94661 RVA: 0x006C23EC File Offset: 0x006C05EC
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
		int[] array = new int[this.EffectMap.Count];
		this.EffectMap.Keys.CopyTo(array, 0);
		foreach (int num in array)
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

	// Token: 0x060171C6 RID: 94662 RVA: 0x006C24CC File Offset: 0x006C06CC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterGameplayCueComponent characterGameplayCueComponent = (CharacterGameplayCueComponent)componentTemplate;
		if (characterGameplayCueComponent.TimeScaleComponent == null)
		{
			this.TimeScaleComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComponent), "TimeScaleComponent"))
		{
			return false;
		}
		return characterGameplayCueComponent.EffectMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.EffectMap), "EffectMap");
	}

	// Token: 0x170023E6 RID: 9190
	// (get) Token: 0x060171C7 RID: 94663 RVA: 0x006C2539 File Offset: 0x006C0739
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023E7 RID: 9191
	// (get) Token: 0x060171C8 RID: 94664 RVA: 0x006C253C File Offset: 0x006C073C
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023E8 RID: 9192
	// (get) Token: 0x060171C9 RID: 94665 RVA: 0x006C253F File Offset: 0x006C073F
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023E9 RID: 9193
	// (get) Token: 0x060171CA RID: 94666 RVA: 0x006C2542 File Offset: 0x006C0742
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023EA RID: 9194
	// (get) Token: 0x060171CB RID: 94667 RVA: 0x006C2545 File Offset: 0x006C0745
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023EB RID: 9195
	// (get) Token: 0x060171CC RID: 94668 RVA: 0x006C2548 File Offset: 0x006C0748
	public override bool NeedAfterTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023EC RID: 9196
	// (get) Token: 0x060171CD RID: 94669 RVA: 0x006C254B File Offset: 0x006C074B
	public override bool NeedChangeTimeDilationInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C293 RID: 49811
	[Nullable(2)]
	private PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400C294 RID: 49812
	private readonly Dictionary<int, CharacterGameplayCueComponent.CueEffectInfo> EffectMap = new Dictionary<int, CharacterGameplayCueComponent.CueEffectInfo>();

	// Token: 0x02008814 RID: 34836
	[NullableContext(0)]
	private readonly struct CueEffectInfo
	{
		// Token: 0x060425EE RID: 271854 RVA: 0x013B90AA File Offset: 0x013B72AA
		public CueEffectInfo(ETimeScaleType timeScaleType, ECueHideRule hideRule)
		{
			this.TimeScaleType = timeScaleType;
			this.HideRule = hideRule;
		}

		// Token: 0x17007898 RID: 30872
		// (get) Token: 0x060425EF RID: 271855 RVA: 0x013B90BA File Offset: 0x013B72BA
		public ETimeScaleType TimeScaleType { get; }

		// Token: 0x17007899 RID: 30873
		// (get) Token: 0x060425F0 RID: 271856 RVA: 0x013B90C2 File Offset: 0x013B72C2
		public ECueHideRule HideRule { get; }
	}
}
