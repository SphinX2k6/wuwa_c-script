using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E1A RID: 19994
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ExtraItemParams
	{
		// Token: 0x060324C6 RID: 206022 RVA: 0x00E1A0D1 File Offset: 0x00E182D1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ExtraItemParams()
		{
		}

		// Token: 0x0401AA94 RID: 109204
		[RequiredMember]
		public Func<StateExtraItemBase> Creator;

		// Token: 0x0401AA95 RID: 109205
		[RequiredMember]
		public EExtraItemType Type;

		// Token: 0x0401AA96 RID: 109206
		[RequiredMember]
		public string ResourceId;
	}
}
