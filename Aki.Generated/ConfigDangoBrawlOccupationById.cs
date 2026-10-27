using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D4 RID: 468
	public class ConfigDangoBrawlOccupationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x000979BB File Offset: 0x00095BBB
		static ConfigDangoBrawlOccupationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOccupationById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOccupationById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000979DC File Offset: 0x00095BDC
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlOccupationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlOccupation"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlOccupation` where Id=?")
			});
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00097A5B File Offset: 0x00095C5B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationById.LogPair = null;
			ConfigDangoBrawlOccupationById.HandleId = 0;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00097A69 File Offset: 0x00095C69
		public static void Init()
		{
			ConfigDangoBrawlOccupationById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOccupationById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOccupation` where Id=?");
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00097A84 File Offset: 0x00095C84
		public static DangoBrawlOccupation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlOccupationById.HandleId, ConfigDangoBrawlOccupationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOccupationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlOccupation?(DangoBrawlOccupation.GetRootAsDangoBrawlOccupation(configBuffer));
				}
			}
			ConfigDangoBrawlOccupationById.LogPair.Clear();
			ConfigDangoBrawlOccupationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlOccupationById.HandleId, 1, p0Id, ConfigDangoBrawlOccupationById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlOccupationById.HandleId, true, ConfigDangoBrawlOccupationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOccupationById.HandleId, ConfigDangoBrawlOccupationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlOccupationById.HandleId, 0, ConfigDangoBrawlOccupationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOccupationById.HandleId, ConfigDangoBrawlOccupationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlOccupation rootAsDangoBrawlOccupation = DangoBrawlOccupation.GetRootAsDangoBrawlOccupation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOccupationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlOccupationById.HandleId, ConfigDangoBrawlOccupationById.LogPair);
			return new DangoBrawlOccupation?(rootAsDangoBrawlOccupation);
		}

		// Token: 0x04000CB0 RID: 3248
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CB1 RID: 3249
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CB2 RID: 3250
		private const string TABLE = "DangoBrawlOccupation";

		// Token: 0x04000CB3 RID: 3251
		private const string COMMAND = "select BinData from `DangoBrawlOccupation` where Id=?";

		// Token: 0x04000CB4 RID: 3252
		private const string KEY_PREFIX = "DangoBrawlOccupationById";

		// Token: 0x04000CB5 RID: 3253
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CB6 RID: 3254
		private static int HandleId;
	}
}
