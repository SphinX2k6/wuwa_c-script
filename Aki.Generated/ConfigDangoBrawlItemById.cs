using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C9 RID: 457
	public class ConfigDangoBrawlItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x00096373 File Offset: 0x00094573
		static ConfigDangoBrawlItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00096394 File Offset: 0x00094594
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗局内.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItem"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItem` where Id=?")
			});
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00096413 File Offset: 0x00094613
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemById.LogPair = null;
			ConfigDangoBrawlItemById.HandleId = 0;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00096421 File Offset: 0x00094621
		public static void Init()
		{
			ConfigDangoBrawlItemById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItem` where Id=?");
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0009643C File Offset: 0x0009463C
		public static DangoBrawlItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemById.HandleId, ConfigDangoBrawlItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlItem?(DangoBrawlItem.GetRootAsDangoBrawlItem(configBuffer));
				}
			}
			ConfigDangoBrawlItemById.LogPair.Clear();
			ConfigDangoBrawlItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlItemById.HandleId, 1, p0Id, ConfigDangoBrawlItemById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlItemById.HandleId, true, ConfigDangoBrawlItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemById.HandleId, ConfigDangoBrawlItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemById.HandleId, 0, ConfigDangoBrawlItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlItemById.HandleId, ConfigDangoBrawlItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlItem rootAsDangoBrawlItem = DangoBrawlItem.GetRootAsDangoBrawlItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemById.HandleId, ConfigDangoBrawlItemById.LogPair);
			return new DangoBrawlItem?(rootAsDangoBrawlItem);
		}

		// Token: 0x04000C63 RID: 3171
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C64 RID: 3172
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000C65 RID: 3173
		private const string TABLE = "DangoBrawlItem";

		// Token: 0x04000C66 RID: 3174
		private const string COMMAND = "select BinData from `DangoBrawlItem` where Id=?";

		// Token: 0x04000C67 RID: 3175
		private const string KEY_PREFIX = "DangoBrawlItemById";

		// Token: 0x04000C68 RID: 3176
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C69 RID: 3177
		private static int HandleId;
	}
}
