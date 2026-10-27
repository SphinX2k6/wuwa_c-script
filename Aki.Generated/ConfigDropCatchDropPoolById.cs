using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000237 RID: 567
	public class ConfigDropCatchDropPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x000A4C24 File Offset: 0x000A2E24
		static ConfigDropCatchDropPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchDropPoolById.CreateStaticDefaultValue), new Action(ConfigDropCatchDropPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000A4C44 File Offset: 0x000A2E44
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

		// Token: 0x06000D50 RID: 3408 RVA: 0x000A4CC3 File Offset: 0x000A2EC3
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchDropPoolById.LogPair = null;
			ConfigDropCatchDropPoolById.HandleId = 0;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000A4CD1 File Offset: 0x000A2ED1
		public static void Init()
		{
			ConfigDropCatchDropPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchDropPoolById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchDropPool` where Id=?");
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000A4CEC File Offset: 0x000A2EEC
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

		// Token: 0x04000F65 RID: 3941
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F66 RID: 3942
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F67 RID: 3943
		private const string TABLE = "DropCatchDropPool";

		// Token: 0x04000F68 RID: 3944
		private const string COMMAND = "select BinData from `DropCatchDropPool` where Id=?";

		// Token: 0x04000F69 RID: 3945
		private const string KEY_PREFIX = "DropCatchDropPoolById";

		// Token: 0x04000F6A RID: 3946
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F6B RID: 3947
		private static int HandleId;
	}
}
