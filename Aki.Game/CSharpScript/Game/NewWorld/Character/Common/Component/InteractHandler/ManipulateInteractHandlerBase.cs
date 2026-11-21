using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.InteractHandler
{
	// Token: 0x02006340 RID: 25408
	public abstract class ManipulateInteractHandlerBase : IManipulateInteractHandler
	{
		// Token: 0x0603D8F9 RID: 252153 RVA: 0x011D2FFE File Offset: 0x011D11FE
		[NullableContext(1)]
		protected ManipulateInteractHandlerBase(IManipulateInteractContext context)
		{
		}

		// Token: 0x0603D8FA RID: 252154
		public abstract bool Start();

		// Token: 0x0603D8FB RID: 252155
		public abstract void End();

		// Token: 0x0603D8FC RID: 252156 RVA: 0x011D3010 File Offset: 0x011D1210
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

		// Token: 0x0603D8FD RID: 252157 RVA: 0x011D30C4 File Offset: 0x011D12C4
		protected void RemoveInteractBuffImmediate()
		{
			if (this.Context.BuffComp != null && this.Context.CurBuffId != null)
			{
				this.Context.BuffComp.RemoveBuff(this.Context.CurBuffId.Value, -1, "[CharacterManipulateInteractComponent]", null, null, null);
				this.Context.CurBuffId = null;
			}
		}

		// Token: 0x04020A68 RID: 133736
		[Nullable(1)]
		protected readonly IManipulateInteractContext Context = context;
	}
}
