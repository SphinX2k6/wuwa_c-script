using System;
using System.Runtime.CompilerServices;

// Token: 0x0200007A RID: 122
[NullableContext(1)]
[Nullable(0)]
public readonly struct EntityArgs<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4> : IEntityArgs
{
	// Token: 0x06000396 RID: 918 RVA: 0x00016151 File Offset: 0x00014351
	public EntityArgs(T1 p1, T2 p2, T3 p3, T4 p4)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
		this.<p3>P = p3;
		this.<p4>P = p4;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00016170 File Offset: 0x00014370
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

	// Token: 0x06000398 RID: 920 RVA: 0x00016214 File Offset: 0x00014414
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

	// Token: 0x06000399 RID: 921 RVA: 0x000162B8 File Offset: 0x000144B8
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

	// Token: 0x0600039A RID: 922 RVA: 0x0001635C File Offset: 0x0001455C
	public T GetP4<[Nullable(2)] T>()
	{
		T4 t = this.<p4>P;
		if (t is T)
		{
			return t as T;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
		defaultInterpolatedStringHandler.AppendLiteral("无法将 ");
		t = this.<p4>P;
		defaultInterpolatedStringHandler.AppendFormatted<Type>((t != null) ? t.GetType() : null);
		defaultInterpolatedStringHandler.AppendLiteral(" 转换为 ");
		defaultInterpolatedStringHandler.AppendFormatted<Type>(typeof(T));
		throw new InvalidCastException(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x0600039B RID: 923 RVA: 0x000163FD File Offset: 0x000145FD
	public T GetP5<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x04000385 RID: 901
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000386 RID: 902
	[CompilerGenerated]
	private readonly T2 <p2>P;

	// Token: 0x04000387 RID: 903
	[CompilerGenerated]
	private readonly T3 <p3>P;

	// Token: 0x04000388 RID: 904
	[CompilerGenerated]
	private readonly T4 <p4>P;
}
