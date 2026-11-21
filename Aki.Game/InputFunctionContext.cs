using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

// Token: 0x0200260D RID: 9741
public class InputFunctionContext : IParameterContext
{
	// Token: 0x06018578 RID: 99704 RVA: 0x00757F0B File Offset: 0x0075610B
	[NullableContext(1)]
	public InputFunctionContext(Entity entity, int skillId)
	{
	}

	// Token: 0x06018579 RID: 99705 RVA: 0x00757F21 File Offset: 0x00756121
	public bool IsValid()
	{
		return this.Entity.Valid;
	}

	// Token: 0x0400D23E RID: 53822
	[Nullable(1)]
	public Entity Entity = entity;

	// Token: 0x0400D23F RID: 53823
	public int SkillId = skillId;
}
