using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

// Token: 0x020030B5 RID: 12469
public class InputFunctionContext : IParameterContext
{
	// Token: 0x0601AB69 RID: 109417 RVA: 0x0073259F File Offset: 0x0073079F
	[NullableContext(1)]
	public InputFunctionContext(Entity entity, int skillId)
	{
	}

	// Token: 0x0601AB6A RID: 109418 RVA: 0x007325B5 File Offset: 0x007307B5
	public bool IsValid()
	{
		return this.Entity.Valid;
	}

	// Token: 0x0400CE52 RID: 52818
	[Nullable(1)]
	public Entity Entity = entity;

	// Token: 0x0400CE53 RID: 52819
	public int SkillId = skillId;
}
