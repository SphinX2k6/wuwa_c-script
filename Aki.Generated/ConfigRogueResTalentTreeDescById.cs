using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085B RID: 2139
	public class ConfigRogueResTalentTreeDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003234 RID: 12852 RVA: 0x00175518 File Offset: 0x00173718
		static ConfigRogueResTalentTreeDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTalentTreeDescById.CreateStaticDefaultValue), new Action(ConfigRogueResTalentTreeDescById.ResetStaticDefaultValue));
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00175538 File Offset: 0x00173738
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTalentTreeDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTalentTreeDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTalentTreeDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTalentTreeDesc` where Id=?")
			});
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x001755B7 File Offset: 0x001737B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTalentTreeDescById.LogPair = null;
			ConfigRogueResTalentTreeDescById.HandleId = 0;
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x001755C5 File Offset: 0x001737C5
		public static void Init()
		{
			ConfigRogueResTalentTreeDescById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTalentTreeDescById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTalentTreeDesc` where Id=?");
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x001755E0 File Offset: 0x001737E0
		public static RogueResTalentTreeDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResTalentTreeDesc?(RogueResTalentTreeDesc.GetRootAsRogueResTalentTreeDesc(configBuffer));
				}
			}
			ConfigRogueResTalentTreeDescById.LogPair.Clear();
			ConfigRogueResTalentTreeDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResTalentTreeDescById.HandleId, 1, p0Id, ConfigRogueResTalentTreeDescById.LogPair) || ConfigCommon.Step(ConfigRogueResTalentTreeDescById.HandleId, true, ConfigRogueResTalentTreeDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTalentTreeDescById.HandleId, 0, ConfigRogueResTalentTreeDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResTalentTreeDesc rootAsRogueResTalentTreeDesc = RogueResTalentTreeDesc.GetRootAsRogueResTalentTreeDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResTalentTreeDescById.HandleId, ConfigRogueResTalentTreeDescById.LogPair);
			return new RogueResTalentTreeDesc?(rootAsRogueResTalentTreeDesc);
		}

		// Token: 0x04003A63 RID: 14947
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A64 RID: 14948
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A65 RID: 14949
		private const string TABLE = "RogueResTalentTreeDesc";

		// Token: 0x04003A66 RID: 14950
		private const string COMMAND = "select BinData from `RogueResTalentTreeDesc` where Id=?";

		// Token: 0x04003A67 RID: 14951
		private const string KEY_PREFIX = "RogueResTalentTreeDescById";

		// Token: 0x04003A68 RID: 14952
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A69 RID: 14953
		private static int HandleId;
	}
}
