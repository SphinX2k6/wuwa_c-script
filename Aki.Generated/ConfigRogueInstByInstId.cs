using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000828 RID: 2088
	public class ConfigRogueInstByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003102 RID: 12546 RVA: 0x0016E710 File Offset: 0x0016C910
		static ConfigRogueInstByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueInstByInstId.CreateStaticDefaultValue), new Action(ConfigRogueInstByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x0016E730 File Offset: 0x0016C930
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueInstByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueInstByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueInst"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueInst` where InstId=?")
			});
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x0016E7AF File Offset: 0x0016C9AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueInstByInstId.LogPair = null;
			ConfigRogueInstByInstId.HandleId = 0;
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0016E7BD File Offset: 0x0016C9BD
		public static void Init()
		{
			ConfigRogueInstByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueInstByInstId.HandleId, "db_rogue.db", "select BinData from `RogueInst` where InstId=?");
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x0016E7D8 File Offset: 0x0016C9D8
		public static RogueInst? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueInstByInstId.HandleId, ConfigRogueInstByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueInstByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueInst?(RogueInst.GetRootAsRogueInst(configBuffer));
				}
			}
			ConfigRogueInstByInstId.LogPair.Clear();
			ConfigRogueInstByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigRogueInstByInstId.HandleId, 1, p0InstId, ConfigRogueInstByInstId.LogPair) || ConfigCommon.Step(ConfigRogueInstByInstId.HandleId, true, ConfigRogueInstByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueInstByInstId.HandleId, ConfigRogueInstByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueInstByInstId.HandleId, 0, ConfigRogueInstByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueInstByInstId.HandleId, ConfigRogueInstByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueInst rootAsRogueInst = RogueInst.GetRootAsRogueInst(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueInstByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueInstByInstId.HandleId, ConfigRogueInstByInstId.LogPair);
			return new RogueInst?(rootAsRogueInst);
		}

		// Token: 0x040038FE RID: 14590
		private const string DB = "db_rogue.db";

		// Token: 0x040038FF RID: 14591
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x04003900 RID: 14592
		private const string TABLE = "RogueInst";

		// Token: 0x04003901 RID: 14593
		private const string COMMAND = "select BinData from `RogueInst` where InstId=?";

		// Token: 0x04003902 RID: 14594
		private const string KEY_PREFIX = "RogueInstByInstId";

		// Token: 0x04003903 RID: 14595
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003904 RID: 14596
		private static int HandleId;
	}
}
