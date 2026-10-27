using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000336 RID: 822
	public class ConfigFloroRanchWeeklyEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001349 RID: 4937 RVA: 0x000C64D7 File Offset: 0x000C46D7
		static ConfigFloroRanchWeeklyEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyEventById.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyEventById.ResetStaticDefaultValue));
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000C64F8 File Offset: 0x000C46F8
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

		// Token: 0x0600134B RID: 4939 RVA: 0x000C6577 File Offset: 0x000C4777
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyEventById.LogPair = null;
			ConfigFloroRanchWeeklyEventById.HandleId = 0;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x000C6585 File Offset: 0x000C4785
		public static void Init()
		{
			ConfigFloroRanchWeeklyEventById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyEventById.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyEvent` where Id=?");
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000C65A0 File Offset: 0x000C47A0
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

		// Token: 0x0400165E RID: 5726
		private const string DB = "db_flororanchevent.db";

		// Token: 0x0400165F RID: 5727
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x04001660 RID: 5728
		private const string TABLE = "FloroRanchWeeklyEvent";

		// Token: 0x04001661 RID: 5729
		private const string COMMAND = "select BinData from `FloroRanchWeeklyEvent` where Id=?";

		// Token: 0x04001662 RID: 5730
		private const string KEY_PREFIX = "FloroRanchWeeklyEventById";

		// Token: 0x04001663 RID: 5731
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001664 RID: 5732
		private static int HandleId;
	}
}
