using System;
using System.Runtime.CompilerServices;

// Token: 0x02000078 RID: 120
[NullableContext(1)]
[Nullable(0)]
public readonly struct EntityArgs<[Nullable(2)] T1, [Nullable(2)] T2> : IEntityArgs
{
	// Token: 0x0600038A RID: 906 RVA: 0x00015DBD File Offset: 0x00013FBD
	public EntityArgs(T1 p1, T2 p2)
	{
		this.<p1>P = p1;
		this.<p2>P = p2;
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00015DD0 File Offset: 0x00013FD0
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

	// Token: 0x0600038C RID: 908 RVA: 0x00015E74 File Offset: 0x00014074
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

	// Token: 0x0600038D RID: 909 RVA: 0x00015F15 File Offset: 0x00014115
	public T GetP3<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00015F21 File Offset: 0x00014121
	public T GetP4<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00015F2D File Offset: 0x0001412D
	public T GetP5<[Nullable(2)] T>()
	{
		throw new InvalidCastException("无法获取参数");
	}

	// Token: 0x04000380 RID: 896
	[CompilerGenerated]
	private readonly T1 <p1>P;

	// Token: 0x04000381 RID: 897
	[CompilerGenerated]
	private readonly T2 <p2>P;
}
