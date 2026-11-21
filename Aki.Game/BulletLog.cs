using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200233D RID: 9021
[NullableContext(2)]
[Nullable(0)]
public class BulletLog
{
	// Token: 0x0601632A RID: 90922 RVA: 0x006781A3 File Offset: 0x006763A3
	public static void Debug(bool gasDebug, ELogAuthor author, Entity owner, [Nullable(1)] string message, BulletInfo bulletInfo, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		BulletLog.LogImpl(gasDebug, ELogLevel.Debug, author, owner, message, bulletInfo, pairs);
	}

	// Token: 0x0601632B RID: 90923 RVA: 0x006781B3 File Offset: 0x006763B3
	public static void Info(bool gasDebug, ELogAuthor author, Entity owner, [Nullable(1)] string message, BulletInfo bulletInfo, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		BulletLog.LogImpl(gasDebug, ELogLevel.Info, author, owner, message, bulletInfo, pairs);
	}

	// Token: 0x0601632C RID: 90924 RVA: 0x006781C3 File Offset: 0x006763C3
	public static void Warn(bool gasDebug, ELogAuthor author, Entity owner, [Nullable(1)] string message, BulletInfo bulletInfo, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		BulletLog.LogImpl(gasDebug, ELogLevel.Warn, author, owner, message, bulletInfo, pairs);
	}

	// Token: 0x0601632D RID: 90925 RVA: 0x006781D3 File Offset: 0x006763D3
	public static void Error(bool gasDebug, ELogAuthor author, Entity owner, [Nullable(1)] string message, BulletInfo bulletInfo, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		BulletLog.LogImpl(gasDebug, ELogLevel.Error, author, owner, message, bulletInfo, pairs);
	}

	// Token: 0x0601632E RID: 90926 RVA: 0x006781E4 File Offset: 0x006763E4
	private static void LogImpl(bool gasDebug, ELogLevel logLevel, ELogAuthor author, Entity owner, [Nullable(1)] string message, BulletInfo bulletInfo, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		if (bulletInfo != null)
		{
			int bulletEntityId = bulletInfo.BulletEntityId;
			ActiveBulletHandle bulletHandleById = BulletModel.Instance.GetBulletHandleById(bulletEntityId);
			ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
			int num = 0;
			ValueTuple<string, object>[] array = new ValueTuple<string, object>[5 + readOnlySpan.Length];
			readOnlySpan.CopyTo(new Span<ValueTuple<string, object>>(array).Slice(num, readOnlySpan.Length));
			num += readOnlySpan.Length;
			array[num] = new ValueTuple<string, object>("子弹表ID", bulletInfo.BulletRowName);
			num++;
			array[num] = new ValueTuple<string, object>("子弹实体ID", bulletEntityId);
			num++;
			ValueTuple<string, object>[] array2 = array;
			int num2 = num;
			string item = "发射者实体ID";
			CreatureDataComponent attackerCreatureDataComp = bulletInfo.AttackerCreatureDataComp;
			array2[num2] = new ValueTuple<string, object>(item, (attackerCreatureDataComp != null) ? new long?(attackerCreatureDataComp.GetCreatureDataId()) : null);
			num++;
			ValueTuple<string, object>[] array3 = array;
			int num3 = num;
			string item2 = "发射者名称";
			BaseActorComponent attackerActorComp = bulletInfo.AttackerActorComp;
			array3[num3] = new ValueTuple<string, object>(item2, (attackerActorComp != null) ? attackerActorComp.Owner : null);
			num++;
			ValueTuple<string, object>[] array4 = array;
			int num4 = num;
			string item3 = "子弹服务器ID";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int?>((bulletHandleById != null) ? new int?(bulletHandleById.PlayerId) : null);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<int?>((bulletHandleById != null) ? new int?(bulletHandleById.HandleId) : null);
			array4[num4] = new ValueTuple<string, object>(item3, defaultInterpolatedStringHandler.ToStringAndClear());
			ReadOnlySpan<ValueTuple<string, object>> pairs2 = new ReadOnlySpan<ValueTuple<string, object>>(array);
			if (gasDebug)
			{
			}
			Log.Instance.LogWithLevel(logLevel, ELogModule.Bullet, author, message, pairs2);
			return;
		}
		if (gasDebug)
		{
		}
		Log.Instance.LogWithLevel(logLevel, ELogModule.Bullet, author, message, pairs);
	}
}
