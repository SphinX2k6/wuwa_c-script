using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023F2 RID: 9202
public class CharacterAbilityComponent : BaseAbilityComponent
{
	// Token: 0x060170BA RID: 94394 RVA: 0x006BAE88 File Offset: 0x006B9088
	[NullableContext(2)]
	protected override UBaseAbilitySystemComponent GetAbilitySystemComponent()
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return null;
		}
		component.Actor.TryAddTsAbilitySystemComponent();
		return component.Actor.AbilitySystemComponent;
	}

	// Token: 0x170023BB RID: 9147
	// (get) Token: 0x060170BB RID: 94395 RVA: 0x006BAEBC File Offset: 0x006B90BC
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023BC RID: 9148
	// (get) Token: 0x060170BC RID: 94396 RVA: 0x006BAEBF File Offset: 0x006B90BF
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023BD RID: 9149
	// (get) Token: 0x060170BD RID: 94397 RVA: 0x006BAEC2 File Offset: 0x006B90C2
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170023BE RID: 9150
	// (get) Token: 0x060170BE RID: 94398 RVA: 0x006BAEC5 File Offset: 0x006B90C5
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}
}
