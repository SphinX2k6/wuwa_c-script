using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02006383 RID: 25475
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalFire : BuffEffect
	{
		// Token: 0x0603DB9F RID: 252831 RVA: 0x011E2D87 File Offset: 0x011E0F87
		public AbnormalFire(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
		{
		}

		// Token: 0x0603DBA0 RID: 252832 RVA: 0x011E2D96 File Offset: 0x011E0F96
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}

		// Token: 0x0603DBA1 RID: 252833 RVA: 0x011E2D99 File Offset: 0x011E0F99
		public override void OnPeriodCallback()
		{
		}
	}
}
