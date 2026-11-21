using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E6 RID: 486
	public class ConfigDangoBrawlOccupationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B67 RID: 2919 RVA: 0x0009D8F3 File Offset: 0x0009BAF3
		static ConfigDangoBrawlOccupationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOccupationById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOccupationById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0009D914 File Offset: 0x0009BB14
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

		// Token: 0x06000B69 RID: 2921 RVA: 0x0009D993 File Offset: 0x0009BB93
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationById.LogPair = null;
			ConfigDangoBrawlOccupationById.HandleId = 0;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0009D9A1 File Offset: 0x0009BBA1
		public static void Init()
		{
			ConfigDangoBrawlOccupationById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOccupationById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOccupation` where Id=?");
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0009D9BC File Offset: 0x0009BBBC
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

		// Token: 0x04000D2E RID: 3374
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D2F RID: 3375
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D30 RID: 3376
		private const string TABLE = "DangoBrawlOccupation";

		// Token: 0x04000D31 RID: 3377
		private const string COMMAND = "select BinData from `DangoBrawlOccupation` where Id=?";

		// Token: 0x04000D32 RID: 3378
		private const string KEY_PREFIX = "DangoBrawlOccupationById";

		// Token: 0x04000D33 RID: 3379
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D34 RID: 3380
		private static int HandleId;
	}
}
