using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C16 RID: 19478
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class SkillButtonAxisKey
	{
		// Token: 0x06032649 RID: 206409 RVA: 0x00BBB67C File Offset: 0x00BB987C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public SkillButtonAxisKey()
		{
		}

		// Token: 0x0401AD2F RID: 109871
		[RequiredMember]
		public string AxisName;

		// Token: 0x0401AD30 RID: 109872
		[RequiredMember]
		public string KeyName;

		// Token: 0x0401AD31 RID: 109873
		[RequiredMember]
		public float Scale;
	}
}
