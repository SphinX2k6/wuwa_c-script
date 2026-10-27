using System;
using System.Runtime.CompilerServices;

// Token: 0x02000077 RID: 119
[NullableContext(1)]
[Nullable(0)]
public readonly struct EntityArgs<[Nullable(2)] T1> : IEntityArgs
{
	// Token: 0x06000384 RID: 900 RVA: 0x00015CE0 File Offset: 0x00013EE0
	public EntityArgs(T1 p1)
	{
		this.<p1>P = p1;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00015CEC File Offset: 0x00013EEC
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

	// Token: 0x06000386 RID: 902 RVA: 0x00015D8D File Offset: 0x00013F8D
	public T GetP2<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00015D99 File Offset: 0x00013F99
	public T GetP3<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00015DA5 File Offset: 0x00013FA5
	public T GetP4<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00015DB1 File Offset: 0x00013FB1
	public T GetP5<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x0400037F RID: 895
	[CompilerGenerated]
	private readonly T1 <p1>P;
}
