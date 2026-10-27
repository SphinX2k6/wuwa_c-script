using System;
using System.Runtime.CompilerServices;

// Token: 0x02002FA7 RID: 12199
public class LevelBuffSceneItem : LevelBuffBase
{
	// Token: 0x06019DF5 RID: 105973 RVA: 0x006C366B File Offset: 0x006C186B
	[NullableContext(1)]
	public LevelBuffSceneItem(Entity entity, long buffId, string[] @params, float param1, float param2) : base(entity, buffId, @params, param1, param2)
	{
	}

	// Token: 0x06019DF6 RID: 105974 RVA: 0x006C367A File Offset: 0x006C187A
	public override void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06019DF7 RID: 105975 RVA: 0x006C367C File Offset: 0x006C187C
	public override void OnStackChanged(int newCount, int oldCount, bool bPremature)
	{
	}
}
