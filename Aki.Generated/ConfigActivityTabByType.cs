using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005D RID: 93
	public class ConfigActivityTabByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600022E RID: 558 RVA: 0x000697C3 File Offset: 0x000679C3
		static ConfigActivityTabByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTabByType.CreateStaticDefaultValue), new Action(ConfigActivityTabByType.ResetStaticDefaultValue));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000697E4 File Offset: 0x000679E4
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityTabByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityTabByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklychallenge.db"),
				new ValueTuple<string, object>("文件", "z.周常框架.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityTab"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityTab` where Type = ?")
			});
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00069863 File Offset: 0x00067A63
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTabByType.LogPair = null;
			ConfigActivityTabByType.HandleId = 0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00069871 File Offset: 0x00067A71
		public static void Init()
		{
			ConfigActivityTabByType.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTabByType.HandleId, "db_weeklychallenge.db", "select BinData from `ActivityTab` where Type = ?");
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0006988C File Offset: 0x00067A8C
		public static ActivityTab? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityTab?(ActivityTab.GetRootAsActivityTab(configBuffer));
				}
			}
			ConfigActivityTabByType.LogPair.Clear();
			ConfigActivityTabByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigActivityTabByType.HandleId, 1, p0Type, ConfigActivityTabByType.LogPair) || ConfigCommon.Step(ConfigActivityTabByType.HandleId, true, ConfigActivityTabByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityTabByType.HandleId, 0, ConfigActivityTabByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityTab rootAsActivityTab = ActivityTab.GetRootAsActivityTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTabByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityTabByType.HandleId, ConfigActivityTabByType.LogPair);
			return new ActivityTab?(rootAsActivityTab);
		}

		// Token: 0x0400026F RID: 623
		private const string DB = "db_weeklychallenge.db";

		// Token: 0x04000270 RID: 624
		private const string FILE = "z.周常框架.xlsx";

		// Token: 0x04000271 RID: 625
		private const string TABLE = "ActivityTab";

		// Token: 0x04000272 RID: 626
		private const string COMMAND = "select BinData from `ActivityTab` where Type = ?";

		// Token: 0x04000273 RID: 627
		private const string KEY_PREFIX = "ActivityTabByType";

		// Token: 0x04000274 RID: 628
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000275 RID: 629
		private static int HandleId;
	}
}
