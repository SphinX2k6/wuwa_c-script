using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02007112 RID: 28946
	public abstract class ManipulateInteractHandlerBase : IManipulateInteractHandler
	{
		// Token: 0x06046AB4 RID: 289460 RVA: 0x011CA1FA File Offset: 0x011C83FA
		[NullableContext(1)]
		protected ManipulateInteractHandlerBase(IManipulateInteractContext context)
		{
		}

		// Token: 0x06046AB5 RID: 289461
		public abstract bool Start();

		// Token: 0x06046AB6 RID: 289462
		public abstract void End();

		// Token: 0x06046AB7 RID: 289463 RVA: 0x011CA20C File Offset: 0x011C840C
		protected void ApplyInteractBuff()
		{
			string roleBody = this.Context.ActorComp.CreatureData.GetRoleConfig().Value.RoleBody;
			this.Context.CurBuffId = new long?((roleBody == "MaleXL") ? 640003013L : 640003012L);
			this.Context.BuffComp.AddBuff(this.Context.CurBuffId.Value, new AddBuffParam
			{
				InstigatorId = this.Context.CreatureDataComp.GetCreatureDataId(),
				Level = new int?(1),
				Reason = "[CharacterManipulateInteractComponent]"
			});
		}

		// Token: 0x06046AB8 RID: 289464 RVA: 0x011CA2C0 File Offset: 0x011C84C0
		protected void RemoveInteractBuffImmediate()
		{
			if (this.Context.BuffComp != null && this.Context.CurBuffId != null)
			{
				this.Context.BuffComp.RemoveBuff(this.Context.CurBuffId.Value, -1, "[CharacterManipulateInteractComponent]", null, null, null);
				this.Context.CurBuffId = null;
			}
		}

		// Token: 0x04025188 RID: 151944
		[Nullable(1)]
		protected readonly IManipulateInteractContext Context = context;
	}
}
