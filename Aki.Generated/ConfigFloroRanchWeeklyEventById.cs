using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034B RID: 843
	public class ConfigFloroRanchWeeklyEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x000CC9E3 File Offset: 0x000CABE3
		static ConfigFloroRanchWeeklyEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyEventById.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyEventById.ResetStaticDefaultValue));
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000CCA04 File Offset: 0x000CAC04
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchWeeklyEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchevent.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_事件.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchWeeklyEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchWeeklyEvent` where Id=?")
			});
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x000CCA83 File Offset: 0x000CAC83
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyEventById.LogPair = null;
			ConfigFloroRanchWeeklyEventById.HandleId = 0;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000CCA91 File Offset: 0x000CAC91
		public static void Init()
		{
			ConfigFloroRanchWeeklyEventById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyEventById.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyEvent` where Id=?");
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000CCAAC File Offset: 0x000CACAC
		public static FloroRanchWeeklyEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchWeeklyEventById.HandleId, ConfigFloroRanchWeeklyEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchWeeklyEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchWeeklyEvent?(FloroRanchWeeklyEvent.GetRootAsFloroRanchWeeklyEvent(configBuffer));
				}
			}
			ConfigFloroRanchWeeklyEventById.LogPair.Clear();
			ConfigFloroRanchWeeklyEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchWeeklyEventById.HandleId, 1, p0Id, ConfigFloroRanchWeeklyEventById.LogPair) || ConfigCommon.Step(ConfigFloroRanchWeeklyEventById.HandleId, true, ConfigFloroRanchWeeklyEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchWeeklyEventById.HandleId, ConfigFloroRanchWeeklyEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchWeeklyEventById.HandleId, 0, ConfigFloroRanchWeeklyEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchWeeklyEventById.HandleId, ConfigFloroRanchWeeklyEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchWeeklyEvent rootAsFloroRanchWeeklyEvent = FloroRanchWeeklyEvent.GetRootAsFloroRanchWeeklyEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchWeeklyEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchWeeklyEventById.HandleId, ConfigFloroRanchWeeklyEventById.LogPair);
			return new FloroRanchWeeklyEvent?(rootAsFloroRanchWeeklyEvent);
		}

		// Token: 0x040016F1 RID: 5873
		private const string DB = "db_flororanchevent.db";

		// Token: 0x040016F2 RID: 5874
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x040016F3 RID: 5875
		private const string TABLE = "FloroRanchWeeklyEvent";

		// Token: 0x040016F4 RID: 5876
		private const string COMMAND = "select BinData from `FloroRanchWeeklyEvent` where Id=?";

		// Token: 0x040016F5 RID: 5877
		private const string KEY_PREFIX = "FloroRanchWeeklyEventById";

		// Token: 0x040016F6 RID: 5878
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016F7 RID: 5879
		private static int HandleId;
	}
}
