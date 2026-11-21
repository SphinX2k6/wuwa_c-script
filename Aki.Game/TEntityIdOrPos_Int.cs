using System;
using System.Runtime.CompilerServices;

// Token: 0x0200121F RID: 4639
[NullableContext(1)]
[Nullable(0)]
public class TEntityIdOrPos_Int : TEntityIdOrPos
{
	// Token: 0x0600B8A7 RID: 47271 RVA: 0x0036707D File Offset: 0x0036527D
	public TEntityIdOrPos_Int(int value)
	{
	}

	// Token: 0x0600B8A8 RID: 47272 RVA: 0x0036708C File Offset: 0x0036528C
	public static implicit operator int(TEntityIdOrPos_Int target)
	{
		return target.Value;
	}

	// Token: 0x0600B8A9 RID: 47273 RVA: 0x00367094 File Offset: 0x00365294
	public new static implicit operator TEntityIdOrPos_Int(int value)
	{
		return new TEntityIdOrPos_Int(value);
	}

	// Token: 0x04006A3D RID: 27197
	public int Value = value;
}
