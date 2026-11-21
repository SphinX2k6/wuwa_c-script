using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000249 RID: 585
	public class ConfigDropCatchDropPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x000AAB5C File Offset: 0x000A8D5C
		static ConfigDropCatchDropPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchDropPoolById.CreateStaticDefaultValue), new Action(ConfigDropCatchDropPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000AAB7C File Offset: 0x000A8D7C
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchDropPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchDropPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchDropPool"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchDropPool` where Id=?")
			});
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000AABFB File Offset: 0x000A8DFB
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchDropPoolById.LogPair = null;
			ConfigDropCatchDropPoolById.HandleId = 0;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000AAC09 File Offset: 0x000A8E09
		public static void Init()
		{
			ConfigDropCatchDropPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchDropPoolById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchDropPool` where Id=?");
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000AAC24 File Offset: 0x000A8E24
		public static DropCatchDropPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchDropPoolById.HandleId, ConfigDropCatchDropPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchDropPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropCatchDropPool?(DropCatchDropPool.GetRootAsDropCatchDropPool(configBuffer));
				}
			}
			ConfigDropCatchDropPoolById.LogPair.Clear();
			ConfigDropCatchDropPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropCatchDropPoolById.HandleId, 1, p0Id, ConfigDropCatchDropPoolById.LogPair) || ConfigCommon.Step(ConfigDropCatchDropPoolById.HandleId, true, ConfigDropCatchDropPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropCatchDropPoolById.HandleId, ConfigDropCatchDropPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchDropPoolById.HandleId, 0, ConfigDropCatchDropPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropCatchDropPoolById.HandleId, ConfigDropCatchDropPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropCatchDropPool rootAsDropCatchDropPool = DropCatchDropPool.GetRootAsDropCatchDropPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchDropPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropCatchDropPoolById.HandleId, ConfigDropCatchDropPoolById.LogPair);
			return new DropCatchDropPool?(rootAsDropCatchDropPool);
		}

		// Token: 0x04000FE3 RID: 4067
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000FE4 RID: 4068
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000FE5 RID: 4069
		private const string TABLE = "DropCatchDropPool";

		// Token: 0x04000FE6 RID: 4070
		private const string COMMAND = "select BinData from `DropCatchDropPool` where Id=?";

		// Token: 0x04000FE7 RID: 4071
		private const string KEY_PREFIX = "DropCatchDropPoolById";

		// Token: 0x04000FE8 RID: 4072
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FE9 RID: 4073
		private static int HandleId;
	}
}
