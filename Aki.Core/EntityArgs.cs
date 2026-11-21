using System;
using System.Runtime.CompilerServices;

// Token: 0x02000078 RID: 120
[NullableContext(1)]
[Nullable(0)]
public readonly struct EntityArgs<[Nullable(2)] T1> : IEntityArgs
{
	// Token: 0x060003BD RID: 957 RVA: 0x000166BC File Offset: 0x000148BC
	public EntityArgs(T1 p1)
	{
		this.<p1>P = p1;
	}

	// Token: 0x060003BE RID: 958 RVA: 0x000166C8 File Offset: 0x000148C8
	public T GetP1<[Nullable(2)] T>()
	{
		T1 t = this.<p1>P;
		if (t is T)
		{
			return t as T;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
		defaultInterpolatedStringHandler.AppendLiteral("无法将 ");
		t = this.<p1>P;
		defaultInterpolatedStringHandler.AppendFormatted<Type>((t != null) ? t.GetType() : null);
		defaultInterpolatedStringHandler.AppendLiteral(" 转换为 ");
		defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T));
		throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00016769 File Offset: 0x00014969
	public T GetP2<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00016775 File Offset: 0x00014975
	public T GetP3<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00016781 File Offset: 0x00014981
	public T GetP4<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x0001678D File Offset: 0x0001498D
	public T GetP5<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x04000397 RID: 919
	[CompilerGenerated]
	private readonly T1 <p1>P;
}
