using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000631 RID: 1585
	public class ConfigNpcGroupPerformConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002536 RID: 9526 RVA: 0x0012F714 File Offset: 0x0012D914
		static ConfigNpcGroupPerformConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcGroupPerformConfigById.CreateStaticDefaultValue), new Action(ConfigNpcGroupPerformConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x0012F734 File Offset: 0x0012D934
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

		// Token: 0x06002538 RID: 9528 RVA: 0x0012F7B3 File Offset: 0x0012D9B3
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigById.LogPair = null;
			ConfigNpcGroupPerformConfigById.HandleId = 0;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0012F7C1 File Offset: 0x0012D9C1
		public static void Init()
		{
			ConfigNpcGroupPerformConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigNpcGroupPerformConfigById.HandleId, "db_npcgroupperformconfig.db", "select BinData from `NpcGroupPerformConfig` where Id=?");
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0012F7DC File Offset: 0x0012D9DC
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

		// Token: 0x04002B3D RID: 11069
		private const string DB = "db_npcgroupperformconfig.db";

		// Token: 0x04002B3E RID: 11070
		private const string FILE = "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*";

		// Token: 0x04002B3F RID: 11071
		private const string TABLE = "NpcGroupPerformConfig";

		// Token: 0x04002B40 RID: 11072
		private const string COMMAND = "select BinData from `NpcGroupPerformConfig` where Id=?";

		// Token: 0x04002B41 RID: 11073
		private const string KEY_PREFIX = "NpcGroupPerformConfigById";

		// Token: 0x04002B42 RID: 11074
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B43 RID: 11075
		private static int HandleId;
	}
}
