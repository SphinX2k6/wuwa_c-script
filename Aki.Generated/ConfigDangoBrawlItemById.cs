using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DB RID: 475
	public class ConfigDangoBrawlItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x0009C2AB File Offset: 0x0009A4AB
		static ConfigDangoBrawlItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0009C2CC File Offset: 0x0009A4CC
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

		// Token: 0x06000B27 RID: 2855 RVA: 0x0009C34B File Offset: 0x0009A54B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemById.LogPair = null;
			ConfigDangoBrawlItemById.HandleId = 0;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0009C359 File Offset: 0x0009A559
		public static void Init()
		{
			ConfigDangoBrawlItemById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItem` where Id=?");
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0009C374 File Offset: 0x0009A574
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

		// Token: 0x04000CE1 RID: 3297
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CE2 RID: 3298
		private const string FILE = "t.团子乱斗局内.xlsx";

		// Token: 0x04000CE3 RID: 3299
		private const string TABLE = "DangoBrawlItem";

		// Token: 0x04000CE4 RID: 3300
		private const string COMMAND = "select BinData from `DangoBrawlItem` where Id=?";

		// Token: 0x04000CE5 RID: 3301
		private const string KEY_PREFIX = "DangoBrawlItemById";

		// Token: 0x04000CE6 RID: 3302
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CE7 RID: 3303
		private static int HandleId;
	}
}
