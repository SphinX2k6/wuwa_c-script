using System;
using System.Runtime.CompilerServices;

// Token: 0x02000079 RID: 121
[NullableContext(1)]
[Nullable(0)]
public readonly struct EntityArgs<[Nullable(2)] T1, [Nullable(2)] T2> : IEntityArgs
{
	// Token: 0x060003C3 RID: 963 RVA: 0x00016799 File Offset: 0x00014999
	public EntityArgs(T1 p1, T2 p2)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x000167AC File Offset: 0x000149AC
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

	// Token: 0x060003C5 RID: 965 RVA: 0x00016850 File Offset: 0x00014A50
	public T GetP2<[Nullable(2)] T>()
	{
		T2 t = this.<p2>P;
		if (t is T)
		{
			return t as T;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
		defaultInterpolatedStringHandler.AppendLiteral("无法将 ");
		t = this.<p2>P;
		defaultInterpolatedStringHandler.AppendFormatted<Type>((t != null) ? t.GetType() : null);
		defaultInterpolatedStringHandler.AppendLiteral(" 转换为 ");
		defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T));
		throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x000168F1 File Offset: 0x00014AF1
	public T GetP3<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x000168FD File Offset: 0x00014AFD
	public T GetP4<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00016909 File Offset: 0x00014B09
	public T GetP5<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x04000398 RID: 920
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000399 RID: 921
	[CompilerGenerated]
	private readonly T2 <p2>P;
}
