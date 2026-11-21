using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BC7 RID: 15303
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SkillButtonAxisKey
	{
		// Token: 0x060273F9 RID: 160761 RVA: 0x00B00200 File Offset: 0x00AFE400
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SkillButtonAxisKey()
		{
		}

		// Token: 0x0401568B RID: 87691
		[RequiredMember]
		public string AxisName;

		// Token: 0x0401568C RID: 87692
		[RequiredMember]
		public string KeyName;

		// Token: 0x0401568D RID: 87693
		[RequiredMember]
		public float Scale;
	}
}
