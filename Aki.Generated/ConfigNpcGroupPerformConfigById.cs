using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000619 RID: 1561
	public class ConfigNpcGroupPerformConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024A6 RID: 9382 RVA: 0x00128C98 File Offset: 0x00126E98
		static ConfigNpcGroupPerformConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcGroupPerformConfigById.CreateStaticDefaultValue), new Action(ConfigNpcGroupPerformConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00128CB8 File Offset: 0x00126EB8
		public static void CreateStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNpcGroupPerformConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_npcgroupperformconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*"),
				new ValueTuple<string, object>("表名", "NpcGroupPerformConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `NpcGroupPerformConfig` where Id=?")
			});
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00128D37 File Offset: 0x00126F37
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigById.LogPair = null;
			ConfigNpcGroupPerformConfigById.HandleId = 0;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00128D45 File Offset: 0x00126F45
		public static void Init()
		{
			ConfigNpcGroupPerformConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigNpcGroupPerformConfigById.HandleId, "db_npcgroupperformconfig.db", "select BinData from `NpcGroupPerformConfig` where Id=?");
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00128D60 File Offset: 0x00126F60
		public static NpcGroupPerformConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNpcGroupPerformConfigById.HandleId, ConfigNpcGroupPerformConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcGroupPerformConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NpcGroupPerformConfig?(NpcGroupPerformConfig.GetRootAsNpcGroupPerformConfig(configBuffer));
				}
			}
			ConfigNpcGroupPerformConfigById.LogPair.Clear();
			ConfigNpcGroupPerformConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNpcGroupPerformConfigById.HandleId, 1, p0Id, ConfigNpcGroupPerformConfigById.LogPair) || ConfigCommon.Step(ConfigNpcGroupPerformConfigById.HandleId, true, ConfigNpcGroupPerformConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNpcGroupPerformConfigById.HandleId, ConfigNpcGroupPerformConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNpcGroupPerformConfigById.HandleId, 0, ConfigNpcGroupPerformConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNpcGroupPerformConfigById.HandleId, ConfigNpcGroupPerformConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NpcGroupPerformConfig rootAsNpcGroupPerformConfig = NpcGroupPerformConfig.GetRootAsNpcGroupPerformConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcGroupPerformConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNpcGroupPerformConfigById.HandleId, ConfigNpcGroupPerformConfigById.LogPair);
			return new NpcGroupPerformConfig?(rootAsNpcGroupPerformConfig);
		}

		// Token: 0x04002A95 RID: 10901
		private const string DB = "db_npcgroupperformconfig.db";

		// Token: 0x04002A96 RID: 10902
		private const string FILE = "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*";

		// Token: 0x04002A97 RID: 10903
		private const string TABLE = "NpcGroupPerformConfig";

		// Token: 0x04002A98 RID: 10904
		private const string COMMAND = "select BinData from `NpcGroupPerformConfig` where Id=?";

		// Token: 0x04002A99 RID: 10905
		private const string KEY_PREFIX = "NpcGroupPerformConfigById";

		// Token: 0x04002A9A RID: 10906
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A9B RID: 10907
		private static int HandleId;
	}
}
