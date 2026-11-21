using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006130 RID: 24880
	[NullableContext(1)]
	[Nullable(0)]
	[OverrideFunctionRoot]
	public abstract class LevelEntityAbilityBase
	{
		// Token: 0x0603B96F RID: 244079 RVA: 0x010E6932 File Offset: 0x010E4B32
		public LevelEntityAbilityBase(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate)
		{
			this.Type = Type;
			this.TickPhase = TickPhase;
			this.TickOrder = TickOrder;
			this.NeedTickActivate = NeedTickActivate;
			this.NeedTick = this.NeedTickInternal;
		}

		// Token: 0x0603B970 RID: 244080 RVA: 0x010E6963 File Offset: 0x010E4B63
		public virtual bool OnAddAbility(Entity entity)
		{
			return true;
		}

		// Token: 0x0603B971 RID: 244081 RVA: 0x010E6966 File Offset: 0x010E4B66
		public virtual bool ShouldActivate(Entity entity)
		{
			return true;
		}

		// Token: 0x0603B972 RID: 244082 RVA: 0x010E6969 File Offset: 0x010E4B69
		public virtual bool ShouldDeactivate(Entity entity)
		{
			return false;
		}

		// Token: 0x0603B973 RID: 244083 RVA: 0x010E696C File Offset: 0x010E4B6C
		[OverrideFunction]
		public virtual void OnTick(Entity entity, float deltaMilliseconds)
		{
		}

		// Token: 0x0603B974 RID: 244084
		public abstract void OnActivated(Entity entity);

		// Token: 0x0603B975 RID: 244085
		public abstract void OnDeactivated(Entity entity);

		// Token: 0x0603B976 RID: 244086 RVA: 0x010E696E File Offset: 0x010E4B6E
		public virtual void OnDestroy(Entity entity)
		{
		}

		// Token: 0x170070AE RID: 28846
		// (get) Token: 0x0603B977 RID: 244087 RVA: 0x010E6970 File Offset: 0x010E4B70
		public virtual bool NeedTickInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0401F6C7 RID: 128711
		public readonly bool NeedTick;

		// Token: 0x0401F6C8 RID: 128712
		public readonly ELevelEntityAbilityType Type;

		// Token: 0x0401F6C9 RID: 128713
		public readonly EAbilityTickPhase TickPhase;

		// Token: 0x0401F6CA RID: 128714
		public readonly int TickOrder;

		// Token: 0x0401F6CB RID: 128715
		public readonly bool NeedTickActivate;
	}
}
