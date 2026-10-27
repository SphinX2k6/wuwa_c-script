using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082A RID: 2090
	public class ConfigRogueParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600310E RID: 12558 RVA: 0x0016EBA0 File Offset: 0x0016CDA0
		static ConfigRogueParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueParamById.CreateStaticDefaultValue), new Action(ConfigRogueParamById.ResetStaticDefaultValue));
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0016EBC0 File Offset: 0x0016CDC0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueParam"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueParam` where Id=?")
			});
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x0016EC3F File Offset: 0x0016CE3F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueParamById.LogPair = null;
			ConfigRogueParamById.HandleId = 0;
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x0016EC4D File Offset: 0x0016CE4D
		public static void Init()
		{
			ConfigRogueParamById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueParamById.HandleId, "db_rogue.db", "select BinData from `RogueParam` where Id=?");
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0016EC68 File Offset: 0x0016CE68
		public static RogueParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueParamById.HandleId, ConfigRogueParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueParam?(RogueParam.GetRootAsRogueParam(configBuffer));
				}
			}
			ConfigRogueParamById.LogPair.Clear();
			ConfigRogueParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueParamById.HandleId, 1, p0Id, ConfigRogueParamById.LogPair) || ConfigCommon.Step(ConfigRogueParamById.HandleId, true, ConfigRogueParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueParamById.HandleId, ConfigRogueParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueParamById.HandleId, 0, ConfigRogueParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueParamById.HandleId, ConfigRogueParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueParam rootAsRogueParam = RogueParam.GetRootAsRogueParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueParamById.HandleId, ConfigRogueParamById.LogPair);
			return new RogueParam?(rootAsRogueParam);
		}

		// Token: 0x0400390C RID: 14604
		private const string DB = "db_rogue.db";

		// Token: 0x0400390D RID: 14605
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x0400390E RID: 14606
		private const string TABLE = "RogueParam";

		// Token: 0x0400390F RID: 14607
		private const string COMMAND = "select BinData from `RogueParam` where Id=?";

		// Token: 0x04003910 RID: 14608
		private const string KEY_PREFIX = "RogueParamById";

		// Token: 0x04003911 RID: 14609
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003912 RID: 14610
		private static int HandleId;
	}
}
