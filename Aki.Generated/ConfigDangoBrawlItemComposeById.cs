using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DD RID: 477
	public class ConfigDangoBrawlItemComposeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x0009C687 File Offset: 0x0009A887
		static ConfigDangoBrawlItemComposeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemComposeById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemComposeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemComposeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemComposeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemCompose"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemCompose` where Id=?")
			});
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0009C727 File Offset: 0x0009A927
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemComposeById.LogPair = null;
			ConfigDangoBrawlItemComposeById.HandleId = 0;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0009C735 File Offset: 0x0009A935
		public static void Init()
		{
			ConfigDangoBrawlItemComposeById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemComposeById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemCompose` where Id=?");
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0009C750 File Offset: 0x0009A950
		public static DangoBrawlItemCompose? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemComposeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlItemCompose?(DangoBrawlItemCompose.GetRootAsDangoBrawlItemCompose(configBuffer));
				}
			}
			ConfigDangoBrawlItemComposeById.LogPair.Clear();
			ConfigDangoBrawlItemComposeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlItemComposeById.HandleId, 1, p0Id, ConfigDangoBrawlItemComposeById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlItemComposeById.HandleId, true, ConfigDangoBrawlItemComposeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemComposeById.HandleId, 0, ConfigDangoBrawlItemComposeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlItemCompose rootAsDangoBrawlItemCompose = DangoBrawlItemCompose.GetRootAsDangoBrawlItemCompose(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemComposeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemComposeById.HandleId, ConfigDangoBrawlItemComposeById.LogPair);
			return new DangoBrawlItemCompose?(rootAsDangoBrawlItemCompose);
		}

		// Token: 0x04000CEF RID: 3311
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CF0 RID: 3312
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000CF1 RID: 3313
		private const string TABLE = "DangoBrawlItemCompose";

		// Token: 0x04000CF2 RID: 3314
		private const string COMMAND = "select BinData from `DangoBrawlItemCompose` where Id=?";

		// Token: 0x04000CF3 RID: 3315
		private const string KEY_PREFIX = "DangoBrawlItemComposeById";

		// Token: 0x04000CF4 RID: 3316
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CF5 RID: 3317
		private static int HandleId;
	}
}
