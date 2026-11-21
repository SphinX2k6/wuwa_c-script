using System;
using System.Runtime.CompilerServices;

// Token: 0x020024FB RID: 9467
public class LevelBuffSceneItem : LevelBuffBase
{
	// Token: 0x06017707 RID: 96007 RVA: 0x006E9F07 File Offset: 0x006E8107
	[NullableContext(1)]
	public LevelBuffSceneItem(Entity entity, long buffId, string[] @params, float param1, float param2) : base(entity, buffId, @params, param1, param2)
	{
	}

	// Token: 0x06017708 RID: 96008 RVA: 0x006E9F16 File Offset: 0x006E8116
	public override void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06017709 RID: 96009 RVA: 0x006E9F18 File Offset: 0x006E8118
	public override void OnStackChanged(int newCount, int oldCount, bool bPremature)
	{
	}
}
