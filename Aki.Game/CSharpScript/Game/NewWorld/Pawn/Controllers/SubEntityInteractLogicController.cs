using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x020061E4 RID: 25060
	[NullableContext(1)]
	[Nullable(0)]
	public class SubEntityInteractLogicController
	{
		// Token: 0x0603C25F RID: 246367 RVA: 0x0111E46F File Offset: 0x0111C66F
		public SubEntityInteractLogicController(CreatureDataComponent creatureDataComp)
		{
			this.CreatureDataComp = creatureDataComp;
			this.Entity = creatureDataComp.Entity;
			PawnInteractNewComponent component = this.Entity.GetComponent<PawnInteractNewComponent>();
			this.InteractComp = ((component != null) ? component.GetInteractController() : null);
		}

		// Token: 0x0603C260 RID: 246368 RVA: 0x0111E4A7 File Offset: 0x0111C6A7
		public virtual bool Possess(Entity masterEntity, bool force = false)
		{
			return true;
		}

		// Token: 0x0603C261 RID: 246369 RVA: 0x0111E4AA File Offset: 0x0111C6AA
		public virtual bool UnPossess(Entity masterEntity)
		{
			return true;
		}

		// Token: 0x0603C262 RID: 246370 RVA: 0x0111E4AD File Offset: 0x0111C6AD
		public bool IsPossessed()
		{
			return this.MasterEntity != null;
		}

		// Token: 0x0603C263 RID: 246371 RVA: 0x0111E4B8 File Offset: 0x0111C6B8
		public bool IsPossessedBy(Entity masterEntity)
		{
			return this.MasterEntity != null && this.MasterEntity == masterEntity;
		}

		// Token: 0x0603C264 RID: 246372 RVA: 0x0111E4CD File Offset: 0x0111C6CD
		public virtual void Dispose()
		{
			this.MasterEntity = null;
			this.Entity = null;
			this.CreatureDataComp = null;
			this.InteractComp = null;
		}

		// Token: 0x0401FD40 RID: 130368
		[Nullable(2)]
		public Entity MasterEntity;

		// Token: 0x0401FD41 RID: 130369
		[Nullable(2)]
		public Entity Entity;

		// Token: 0x0401FD42 RID: 130370
		[Nullable(2)]
		protected CreatureDataComponent CreatureDataComp;

		// Token: 0x0401FD43 RID: 130371
		[Nullable(2)]
		protected PawnInteractController InteractComp;

		// Token: 0x0401FD44 RID: 130372
		[StaticVariableRuleIgnore]
		protected static Vector TmpVector = Vector.Create();

		// Token: 0x0401FD45 RID: 130373
		[StaticVariableRuleIgnore]
		protected static Vector TmpVector2 = Vector.Create();
	}
}
