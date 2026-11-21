using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E7 RID: 487
	public class ConfigDangoBrawlOccupationTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x0009DB3C File Offset: 0x0009BD3C
		static ConfigDangoBrawlOccupationTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOccupationTagById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOccupationTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0009DB5C File Offset: 0x0009BD5C
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

		// Token: 0x06000B6F RID: 2927 RVA: 0x0009DBDB File Offset: 0x0009BDDB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationTagById.LogPair = null;
			ConfigDangoBrawlOccupationTagById.HandleId = 0;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0009DBE9 File Offset: 0x0009BDE9
		public static void Init()
		{
			ConfigDangoBrawlOccupationTagById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOccupationTagById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOccupationTag` where Id=?");
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0009DC04 File Offset: 0x0009BE04
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

		// Token: 0x04000D35 RID: 3381
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D36 RID: 3382
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D37 RID: 3383
		private const string TABLE = "DangoBrawlOccupationTag";

		// Token: 0x04000D38 RID: 3384
		private const string COMMAND = "select BinData from `DangoBrawlOccupationTag` where Id=?";

		// Token: 0x04000D39 RID: 3385
		private const string KEY_PREFIX = "DangoBrawlOccupationTagById";

		// Token: 0x04000D3A RID: 3386
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D3B RID: 3387
		private static int HandleId;
	}
}
