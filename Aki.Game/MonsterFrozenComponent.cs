using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x0200273C RID: 10044
public class MonsterFrozenComponent : BaseFrozenComponent
{
	// Token: 0x06019302 RID: 103170 RVA: 0x007AF90C File Offset: 0x007ADB0C
	public override bool IsFrozen()
	{
		return this.IsFrozenInternal;
	}

	// Token: 0x06019303 RID: 103171 RVA: 0x007AF914 File Offset: 0x007ADB14
	protected override void SetFrozen(bool bFrozen)
	{
		if (this.IsFrozenInternal == bFrozen)
		{
			return;
		}
		this.IsFrozenInternal = bFrozen;
		PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
		CharacterGameplayCueComponent cueComponent = base.Entity.GetComponent<CharacterGameplayCueComponent>();
		BaseTagComponent component2 = base.Entity.GetComponent<BaseTagComponent>();
		TagContainer tagContainer = (component2 != null) ? component2.TagContainer : null;
		if (bFrozen)
		{
			int? frozenHandle = this.FrozenHandle;
			this.FrozenHandle = ((frozenHandle != null) ? frozenHandle : ((component != null) ? new int?(component.SetTimeScale(int.MaxValue, 0f, null, float.PositiveInfinity, ETimeScaleSourceType.Buff, false, false)) : null));
			if (this.FrozenCueHandle == 0)
			{
				CharacterGameplayCueComponent cueComponent5 = cueComponent;
				this.FrozenCueHandle = ((cueComponent5 != null) ? cueComponent5.AddCue(1003L, null) : 0);
			}
			if (tagContainer != null)
			{
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["Damage.Frozen"]);
				tagContainer.AddExactTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.霸体"]);
				return;
			}
		}
		else
		{
			if (this.FrozenHandle != null)
			{
				if (component != null)
				{
					component.RemoveTimeScale(this.FrozenHandle.Value);
				}
				this.FrozenHandle = null;
			}
			CharacterGameplayCueComponent cueComponent2 = cueComponent;
			if (cueComponent2 != null)
			{
				cueComponent2.RemoveCueByHandle((long)this.FrozenCueHandle);
			}
			CharacterGameplayCueComponent cueComponent3 = cueComponent;
			this.FrozenCueHandle = ((cueComponent3 != null) ? cueComponent3.AddCue(100302L, new GameplayCueParam?(new GameplayCueParam
			{
				EndCallback = delegate()
				{
					CharacterGameplayCueComponent cueComponent4 = cueComponent;
					if (cueComponent4 != null)
					{
						cueComponent4.RemoveCueByHandle((long)this.FrozenCueHandle);
					}
					this.FrozenCueHandle = 0;
				}
			})) : 0);
			if (tagContainer != null)
			{
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["Damage.Frozen"]);
				tagContainer.RemoveTag(ETagChannel.Frozen, GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.霸体"]);
			}
		}
	}

	// Token: 0x06019304 RID: 103172 RVA: 0x007AFAD8 File Offset: 0x007ADCD8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterFrozenComponent monsterFrozenComponent = (MonsterFrozenComponent)componentTemplate;
		this.FrozenHandle = monsterFrozenComponent.FrozenHandle;
		this.FrozenCueHandle = monsterFrozenComponent.FrozenCueHandle;
		this.IsFrozenInternal = monsterFrozenComponent.IsFrozenInternal;
		return true;
	}

	// Token: 0x17002816 RID: 10262
	// (get) Token: 0x06019305 RID: 103173 RVA: 0x007AFB1C File Offset: 0x007ADD1C
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002817 RID: 10263
	// (get) Token: 0x06019306 RID: 103174 RVA: 0x007AFB1F File Offset: 0x007ADD1F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002818 RID: 10264
	// (get) Token: 0x06019307 RID: 103175 RVA: 0x007AFB22 File Offset: 0x007ADD22
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DC33 RID: 56371
	protected int? FrozenHandle;

	// Token: 0x0400DC34 RID: 56372
	protected int FrozenCueHandle;

	// Token: 0x0400DC35 RID: 56373
	protected bool IsFrozenInternal;
}
