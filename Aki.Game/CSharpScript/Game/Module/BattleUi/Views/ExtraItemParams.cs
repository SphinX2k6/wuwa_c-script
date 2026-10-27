using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E35 RID: 24117
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ExtraItemParams
	{
		// Token: 0x0603D536 RID: 251190 RVA: 0x00EC8B65 File Offset: 0x00EC6D65
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ExtraItemParams()
		{
		}

		// Token: 0x0401FFCD RID: 131021
		[RequiredMember]
		public Func<StateExtraItemBase> Creator;

		// Token: 0x0401FFCE RID: 131022
		[RequiredMember]
		public EExtraItemType Type;

		// Token: 0x0401FFCF RID: 131023
		[RequiredMember]
		public string ResourceId;
	}
}
