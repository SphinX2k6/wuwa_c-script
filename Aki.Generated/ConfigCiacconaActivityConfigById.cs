using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000171 RID: 369
	public class ConfigCiacconaActivityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008A7 RID: 2215 RVA: 0x0008DF84 File Offset: 0x0008C184
		static ConfigCiacconaActivityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaActivityConfigById.CreateStaticDefaultValue), new Action(ConfigCiacconaActivityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0008DFA4 File Offset: 0x0008C1A4
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaActivityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaActivityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaActivityConfig` where Id=?")
			});
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0008E023 File Offset: 0x0008C223
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaActivityConfigById.LogPair = null;
			ConfigCiacconaActivityConfigById.HandleId = 0;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0008E031 File Offset: 0x0008C231
		public static void Init()
		{
			ConfigCiacconaActivityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaActivityConfigById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaActivityConfig` where Id=?");
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0008E04C File Offset: 0x0008C24C
		public static CiacconaActivityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaActivityConfig?(CiacconaActivityConfig.GetRootAsCiacconaActivityConfig(configBuffer));
				}
			}
			ConfigCiacconaActivityConfigById.LogPair.Clear();
			ConfigCiacconaActivityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaActivityConfigById.HandleId, 1, p0Id, ConfigCiacconaActivityConfigById.LogPair) || ConfigCommon.Step(ConfigCiacconaActivityConfigById.HandleId, true, ConfigCiacconaActivityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaActivityConfigById.HandleId, 0, ConfigCiacconaActivityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaActivityConfig rootAsCiacconaActivityConfig = CiacconaActivityConfig.GetRootAsCiacconaActivityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair);
			return new CiacconaActivityConfig?(rootAsCiacconaActivityConfig);
		}

		// Token: 0x040009FB RID: 2555
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009FC RID: 2556
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009FD RID: 2557
		private const string TABLE = "CiacconaActivityConfig";

		// Token: 0x040009FE RID: 2558
		private const string COMMAND = "select BinData from `CiacconaActivityConfig` where Id=?";

		// Token: 0x040009FF RID: 2559
		private const string KEY_PREFIX = "CiacconaActivityConfigById";

		// Token: 0x04000A00 RID: 2560
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A01 RID: 2561
		private static int HandleId;
	}
}
