using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02006386 RID: 25478
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalDark : BuffEffect
	{
		// Token: 0x0603DBA6 RID: 252838 RVA: 0x011E2DB3 File Offset: 0x011E0FB3
		public AbnormalDark(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
		{
		}

		// Token: 0x0603DBA7 RID: 252839 RVA: 0x011E2DC2 File Offset: 0x011E0FC2
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}

		// Token: 0x0603DBA8 RID: 252840 RVA: 0x011E2DC5 File Offset: 0x011E0FC5
		public override void OnPeriodCallback()
		{
		}
	}
}
