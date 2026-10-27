using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x02007063 RID: 28771
	[NullableContext(1)]
	[Nullable(0)]
	public class SubEntityInteractLogicController
	{
		// Token: 0x06046064 RID: 286820 RVA: 0x011748AD File Offset: 0x01172AAD
		public SubEntityInteractLogicController(CreatureDataComponent creatureDataComp)
		{
			this.CreatureDataComp = creatureDataComp;
			this.Entity = creatureDataComp.Entity;
			PawnInteractNewComponent component = this.Entity.GetComponent<PawnInteractNewComponent>();
			this.InteractComp = ((component != null) ? component.GetInteractController() : null);
		}

		// Token: 0x06046065 RID: 286821 RVA: 0x011748E5 File Offset: 0x01172AE5
		public virtual bool Possess(Entity masterEntity, bool force = false)
		{
			return true;
		}

		// Token: 0x06046066 RID: 286822 RVA: 0x011748E8 File Offset: 0x01172AE8
		public virtual bool UnPossess(Entity masterEntity)
		{
			return true;
		}

		// Token: 0x06046067 RID: 286823 RVA: 0x011748EB File Offset: 0x01172AEB
		public bool IsPossessed()
		{
			return this.MasterEntity != null;
		}

		// Token: 0x06046068 RID: 286824 RVA: 0x011748F6 File Offset: 0x01172AF6
		public bool IsPossessedBy(Entity masterEntity)
		{
			return this.MasterEntity != null && this.MasterEntity == masterEntity;
		}

		// Token: 0x06046069 RID: 286825 RVA: 0x0117490B File Offset: 0x01172B0B
		public virtual void Dispose()
		{
			this.MasterEntity = null;
			this.Entity = null;
			this.CreatureDataComp = null;
			this.InteractComp = null;
		}

		// Token: 0x04024A8A RID: 150154
		[Nullable(2)]
		public Entity MasterEntity;

		// Token: 0x04024A8B RID: 150155
		[Nullable(2)]
		public Entity Entity;

		// Token: 0x04024A8C RID: 150156
		[Nullable(2)]
		protected CreatureDataComponent CreatureDataComp;

		// Token: 0x04024A8D RID: 150157
		[Nullable(2)]
		protected PawnInteractController InteractComp;

		// Token: 0x04024A8E RID: 150158
		[StaticVariableRuleIgnore]
		protected static Vector TmpVector = Vector.Create();

		// Token: 0x04024A8F RID: 150159
		[StaticVariableRuleIgnore]
		protected static Vector TmpVector2 = Vector.Create();
	}
}
