using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085D RID: 2141
	public class ConfigRogueResEffectTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003240 RID: 12864 RVA: 0x00179084 File Offset: 0x00177284
		static ConfigRogueResEffectTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEffectTagById.CreateStaticDefaultValue), new Action(ConfigRogueResEffectTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x001790A4 File Offset: 0x001772A4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEffectTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEffectTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEffectTag"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEffectTag` where Id=?")
			});
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x00179123 File Offset: 0x00177323
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEffectTagById.LogPair = null;
			ConfigRogueResEffectTagById.HandleId = 0;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x00179131 File Offset: 0x00177331
		public static void Init()
		{
			ConfigRogueResEffectTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEffectTagById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEffectTag` where Id=?");
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x0017914C File Offset: 0x0017734C
		public static RogueResEffectTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEffectTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEffectTag?(RogueResEffectTag.GetRootAsRogueResEffectTag(configBuffer));
				}
			}
			ConfigRogueResEffectTagById.LogPair.Clear();
			ConfigRogueResEffectTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEffectTagById.HandleId, 1, p0Id, ConfigRogueResEffectTagById.LogPair) || ConfigCommon.Step(ConfigRogueResEffectTagById.HandleId, true, ConfigRogueResEffectTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEffectTagById.HandleId, 0, ConfigRogueResEffectTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEffectTag rootAsRogueResEffectTag = RogueResEffectTag.GetRootAsRogueResEffectTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEffectTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEffectTagById.HandleId, ConfigRogueResEffectTagById.LogPair);
			return new RogueResEffectTag?(rootAsRogueResEffectTag);
		}

		// Token: 0x04003A71 RID: 14961
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A72 RID: 14962
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A73 RID: 14963
		private const string TABLE = "RogueResEffectTag";

		// Token: 0x04003A74 RID: 14964
		private const string COMMAND = "select BinData from `RogueResEffectTag` where Id=?";

		// Token: 0x04003A75 RID: 14965
		private const string KEY_PREFIX = "RogueResEffectTagById";

		// Token: 0x04003A76 RID: 14966
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A77 RID: 14967
		private static int HandleId;
	}
}
