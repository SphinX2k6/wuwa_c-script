using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024B RID: 587
	public class ConfigDropCatchGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x000AAFDB File Offset: 0x000A91DB
		static ConfigDropCatchGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchGameplayById.CreateStaticDefaultValue), new Action(ConfigDropCatchGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000AAFFC File Offset: 0x000A91FC
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchGameplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchGameplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchGameplay` where Id=?")
			});
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000AB07B File Offset: 0x000A927B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchGameplayById.LogPair = null;
			ConfigDropCatchGameplayById.HandleId = 0;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000AB089 File Offset: 0x000A9289
		public static void Init()
		{
			ConfigDropCatchGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchGameplayById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchGameplay` where Id=?");
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000AB0A4 File Offset: 0x000A92A4
		public static DropCatchGameplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropCatchGameplay?(DropCatchGameplay.GetRootAsDropCatchGameplay(configBuffer));
				}
			}
			ConfigDropCatchGameplayById.LogPair.Clear();
			ConfigDropCatchGameplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropCatchGameplayById.HandleId, 1, p0Id, ConfigDropCatchGameplayById.LogPair) || ConfigCommon.Step(ConfigDropCatchGameplayById.HandleId, true, ConfigDropCatchGameplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchGameplayById.HandleId, 0, ConfigDropCatchGameplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropCatchGameplay rootAsDropCatchGameplay = DropCatchGameplay.GetRootAsDropCatchGameplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair);
			return new DropCatchGameplay?(rootAsDropCatchGameplay);
		}

		// Token: 0x04000FF1 RID: 4081
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000FF2 RID: 4082
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000FF3 RID: 4083
		private const string TABLE = "DropCatchGameplay";

		// Token: 0x04000FF4 RID: 4084
		private const string COMMAND = "select BinData from `DropCatchGameplay` where Id=?";

		// Token: 0x04000FF5 RID: 4085
		private const string KEY_PREFIX = "DropCatchGameplayById";

		// Token: 0x04000FF6 RID: 4086
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FF7 RID: 4087
		private static int HandleId;
	}
}
