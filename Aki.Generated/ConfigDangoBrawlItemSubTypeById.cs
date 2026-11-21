using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E0 RID: 480
	public class ConfigDangoBrawlItemSubTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x0009CCAB File Offset: 0x0009AEAB
		static ConfigDangoBrawlItemSubTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemSubTypeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemSubTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0009CCCC File Offset: 0x0009AECC
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemSubTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemSubTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemSubType` where Id=?")
			});
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0009CD4B File Offset: 0x0009AF4B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemSubTypeById.LogPair = null;
			ConfigDangoBrawlItemSubTypeById.HandleId = 0;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0009CD59 File Offset: 0x0009AF59
		public static void Init()
		{
			ConfigDangoBrawlItemSubTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemSubTypeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemSubType` where Id=?");
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0009CD74 File Offset: 0x0009AF74
		public static DangoBrawlItemSubType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlItemSubType?(DangoBrawlItemSubType.GetRootAsDangoBrawlItemSubType(configBuffer));
				}
			}
			ConfigDangoBrawlItemSubTypeById.LogPair.Clear();
			ConfigDangoBrawlItemSubTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlItemSubTypeById.HandleId, 1, p0Id, ConfigDangoBrawlItemSubTypeById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlItemSubTypeById.HandleId, true, ConfigDangoBrawlItemSubTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemSubTypeById.HandleId, 0, ConfigDangoBrawlItemSubTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlItemSubType rootAsDangoBrawlItemSubType = DangoBrawlItemSubType.GetRootAsDangoBrawlItemSubType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeById.HandleId, ConfigDangoBrawlItemSubTypeById.LogPair);
			return new DangoBrawlItemSubType?(rootAsDangoBrawlItemSubType);
		}

		// Token: 0x04000D04 RID: 3332
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D05 RID: 3333
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D06 RID: 3334
		private const string TABLE = "DangoBrawlItemSubType";

		// Token: 0x04000D07 RID: 3335
		private const string COMMAND = "select BinData from `DangoBrawlItemSubType` where Id=?";

		// Token: 0x04000D08 RID: 3336
		private const string KEY_PREFIX = "DangoBrawlItemSubTypeById";

		// Token: 0x04000D09 RID: 3337
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D0A RID: 3338
		private static int HandleId;
	}
}
