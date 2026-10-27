using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D5 RID: 469
	public class ConfigDangoBrawlOccupationTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x00097C04 File Offset: 0x00095E04
		static ConfigDangoBrawlOccupationTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOccupationTagById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOccupationTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00097C24 File Offset: 0x00095E24
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlOccupationTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlOccupationTag"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlOccupationTag` where Id=?")
			});
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00097CA3 File Offset: 0x00095EA3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationTagById.LogPair = null;
			ConfigDangoBrawlOccupationTagById.HandleId = 0;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00097CB1 File Offset: 0x00095EB1
		public static void Init()
		{
			ConfigDangoBrawlOccupationTagById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOccupationTagById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOccupationTag` where Id=?");
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00097CCC File Offset: 0x00095ECC
		public static DangoBrawlOccupationTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlOccupationTagById.HandleId, ConfigDangoBrawlOccupationTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOccupationTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlOccupationTag?(DangoBrawlOccupationTag.GetRootAsDangoBrawlOccupationTag(configBuffer));
				}
			}
			ConfigDangoBrawlOccupationTagById.LogPair.Clear();
			ConfigDangoBrawlOccupationTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlOccupationTagById.HandleId, 1, p0Id, ConfigDangoBrawlOccupationTagById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlOccupationTagById.HandleId, true, ConfigDangoBrawlOccupationTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOccupationTagById.HandleId, ConfigDangoBrawlOccupationTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlOccupationTagById.HandleId, 0, ConfigDangoBrawlOccupationTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOccupationTagById.HandleId, ConfigDangoBrawlOccupationTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlOccupationTag rootAsDangoBrawlOccupationTag = DangoBrawlOccupationTag.GetRootAsDangoBrawlOccupationTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOccupationTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlOccupationTagById.HandleId, ConfigDangoBrawlOccupationTagById.LogPair);
			return new DangoBrawlOccupationTag?(rootAsDangoBrawlOccupationTag);
		}

		// Token: 0x04000CB7 RID: 3255
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CB8 RID: 3256
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CB9 RID: 3257
		private const string TABLE = "DangoBrawlOccupationTag";

		// Token: 0x04000CBA RID: 3258
		private const string COMMAND = "select BinData from `DangoBrawlOccupationTag` where Id=?";

		// Token: 0x04000CBB RID: 3259
		private const string KEY_PREFIX = "DangoBrawlOccupationTagById";

		// Token: 0x04000CBC RID: 3260
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CBD RID: 3261
		private static int HandleId;
	}
}
