using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000846 RID: 2118
	public class ConfigRogueParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031B6 RID: 12726 RVA: 0x00175E88 File Offset: 0x00174088
		static ConfigRogueParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueParamById.CreateStaticDefaultValue), new Action(ConfigRogueParamById.ResetStaticDefaultValue));
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00175EA8 File Offset: 0x001740A8
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

		// Token: 0x060031B8 RID: 12728 RVA: 0x00175F27 File Offset: 0x00174127
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueParamById.LogPair = null;
			ConfigRogueParamById.HandleId = 0;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00175F35 File Offset: 0x00174135
		public static void Init()
		{
			ConfigRogueParamById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueParamById.HandleId, "db_rogue.db", "select BinData from `RogueParam` where Id=?");
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x00175F50 File Offset: 0x00174150
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

		// Token: 0x040039D0 RID: 14800
		private const string DB = "db_rogue.db";

		// Token: 0x040039D1 RID: 14801
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040039D2 RID: 14802
		private const string TABLE = "RogueParam";

		// Token: 0x040039D3 RID: 14803
		private const string COMMAND = "select BinData from `RogueParam` where Id=?";

		// Token: 0x040039D4 RID: 14804
		private const string KEY_PREFIX = "RogueParamById";

		// Token: 0x040039D5 RID: 14805
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039D6 RID: 14806
		private static int HandleId;
	}
}
