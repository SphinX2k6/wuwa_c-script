using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006FAF RID: 28591
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LevelEntityAbilityBase
	{
		// Token: 0x060457C0 RID: 284608 RVA: 0x0113CAD0 File Offset: 0x0113ACD0
		public LevelEntityAbilityBase(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate)
		{
			this.Type = Type;
			this.TickPhase = TickPhase;
			this.TickOrder = TickOrder;
			this.NeedTickActivate = NeedTickActivate;
			MethodInfo method = base.GetType().GetMethod("OnTick", BindingFlags.Instance | BindingFlags.Public);
			this.NeedTick = (method != null && method.DeclaringType != typeof(LevelEntityAbilityBase));
		}

		// Token: 0x060457C1 RID: 284609 RVA: 0x0113CB3A File Offset: 0x0113AD3A
		public virtual bool OnAddAbility(Entity entity)
		{
			return true;
		}

		// Token: 0x060457C2 RID: 284610 RVA: 0x0113CB3D File Offset: 0x0113AD3D
		public virtual bool ShouldActivate(Entity entity)
		{
			return true;
		}

		// Token: 0x060457C3 RID: 284611 RVA: 0x0113CB40 File Offset: 0x0113AD40
		public virtual bool ShouldDeactivate(Entity entity)
		{
			return false;
		}

		// Token: 0x060457C4 RID: 284612 RVA: 0x0113CB43 File Offset: 0x0113AD43
		public virtual void OnTick(Entity entity, float deltaMilliseconds)
		{
		}

		// Token: 0x060457C5 RID: 284613
		public abstract void OnActivated(Entity entity);

		// Token: 0x060457C6 RID: 284614
		public abstract void OnDeactivated(Entity entity);

		// Token: 0x060457C7 RID: 284615 RVA: 0x0113CB45 File Offset: 0x0113AD45
		public virtual void OnDestroy(Entity entity)
		{
		}

		// Token: 0x04024412 RID: 148498
		public readonly bool NeedTick;

		// Token: 0x04024413 RID: 148499
		public readonly ELevelEntityAbilityType Type;

		// Token: 0x04024414 RID: 148500
		public readonly EAbilityTickPhase TickPhase;

		// Token: 0x04024415 RID: 148501
		public readonly int TickOrder;

		// Token: 0x04024416 RID: 148502
		public readonly bool NeedTickActivate;
	}
}
