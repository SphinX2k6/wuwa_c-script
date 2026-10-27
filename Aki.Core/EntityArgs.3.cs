using System;
using System.Runtime.CompilerServices;

// Token: 0x02000079 RID: 121
[NullableContext(1)]
[Nullable(0)]
public readonly struct EntityArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IEntityArgs
{
	// Token: 0x06000390 RID: 912 RVA: 0x00015F39 File Offset: 0x00014139
	public EntityArgs(T1 p1, T2 p2, T3 p3)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00015F50 File Offset: 0x00014150
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

	// Token: 0x06000392 RID: 914 RVA: 0x00015FF4 File Offset: 0x000141F4
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

	// Token: 0x06000393 RID: 915 RVA: 0x00016098 File Offset: 0x00014298
	public T GetP3<[Nullable(2)] T>()
	{
		T3 t = this.<p3>P;
		if (t is T)
		{
			return t as T;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
		defaultInterpolatedStringHandler.AppendLiteral("无法将 ");
		t = this.<p3>P;
		defaultInterpolatedStringHandler.AppendFormatted<Type>((t != null) ? t.GetType() : null);
		defaultInterpolatedStringHandler.AppendLiteral(" 转换为 ");
		defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T));
		throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00016139 File Offset: 0x00014339
	public T GetP4<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00016145 File Offset: 0x00014345
	public T GetP5<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x04000382 RID: 898
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000383 RID: 899
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000384 RID: 900
	[CompilerGenerated]
	private readonly T3 <p3>P;
}
