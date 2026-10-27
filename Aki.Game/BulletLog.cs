using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;

// Token: 0x02002DE2 RID: 11746
[NullableContext(2)]
[Nullable(0)]
public class BulletLog
{
	// Token: 0x06018A7D RID: 100989 RVA: 0x00652067 File Offset: 0x00650267
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

	// Token: 0x06018A7E RID: 100990 RVA: 0x00652077 File Offset: 0x00650277
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

	// Token: 0x06018A7F RID: 100991 RVA: 0x00652087 File Offset: 0x00650287
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

	// Token: 0x06018A80 RID: 100992 RVA: 0x00652097 File Offset: 0x00650297
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

	// Token: 0x06018A81 RID: 100993 RVA: 0x006520A8 File Offset: 0x006502A8
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
			if (gasDebug && owner != null && CSharpScript.Core.Common.Info.Instance.IsPlayInEditor)
			{
				CharacterGasDebugComponent component = owner.GetComponent<CharacterGasDebugComponent>();
				if (component != null && component.Valid)
				{
					component.AddBulletDebugLogString(message, pairs2);
				}
			}
			Log.Instance.LogWithLevel(logLevel, ELogModule.Bullet, author, message, pairs2);
			return;
		}
		if (gasDebug && owner != null && CSharpScript.Core.Common.Info.Instance.IsPlayInEditor)
		{
			CharacterGasDebugComponent component2 = owner.GetComponent<CharacterGasDebugComponent>();
			if (component2 != null && component2.Valid)
			{
				component2.AddBulletDebugLogString(message, pairs);
			}
		}
		Log.Instance.LogWithLevel(logLevel, ELogModule.Bullet, author, message, pairs);
	}
}
