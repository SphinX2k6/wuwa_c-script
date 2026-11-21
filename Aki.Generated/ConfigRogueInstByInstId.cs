using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000844 RID: 2116
	public class ConfigRogueInstByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031AA RID: 12714 RVA: 0x001759F8 File Offset: 0x00173BF8
		static ConfigRogueInstByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueInstByInstId.CreateStaticDefaultValue), new Action(ConfigRogueInstByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x00175A18 File Offset: 0x00173C18
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

		// Token: 0x060031AC RID: 12716 RVA: 0x00175A97 File Offset: 0x00173C97
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueInstByInstId.LogPair = null;
			ConfigRogueInstByInstId.HandleId = 0;
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x00175AA5 File Offset: 0x00173CA5
		public static void Init()
		{
			ConfigRogueInstByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueInstByInstId.HandleId, "db_rogue.db", "select BinData from `RogueInst` where InstId=?");
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x00175AC0 File Offset: 0x00173CC0
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

		// Token: 0x040039C2 RID: 14786
		private const string DB = "db_rogue.db";

		// Token: 0x040039C3 RID: 14787
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x040039C4 RID: 14788
		private const string TABLE = "RogueInst";

		// Token: 0x040039C5 RID: 14789
		private const string COMMAND = "select BinData from `RogueInst` where InstId=?";

		// Token: 0x040039C6 RID: 14790
		private const string KEY_PREFIX = "RogueInstByInstId";

		// Token: 0x040039C7 RID: 14791
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039C8 RID: 14792
		private static int HandleId;
	}
}
