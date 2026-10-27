using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003ED RID: 1005
	public class ConfigHonamiStoryLimitTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001795 RID: 6037 RVA: 0x000DEF27 File Offset: 0x000DD127
		static ConfigHonamiStoryLimitTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLimitTaskById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLimitTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000DEF48 File Offset: 0x000DD148
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLimitTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLimitTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波物语活动奖励.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLimitTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLimitTask` where Id=?")
			});
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x000DEFC7 File Offset: 0x000DD1C7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLimitTaskById.LogPair = null;
			ConfigHonamiStoryLimitTaskById.HandleId = 0;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000DEFD5 File Offset: 0x000DD1D5
		public static void Init()
		{
			ConfigHonamiStoryLimitTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLimitTaskById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLimitTask` where Id=?");
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000DEFF0 File Offset: 0x000DD1F0
		public static HonamiStoryLimitTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLimitTaskById.HandleId, ConfigHonamiStoryLimitTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLimitTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryLimitTask?(HonamiStoryLimitTask.GetRootAsHonamiStoryLimitTask(configBuffer));
				}
			}
			ConfigHonamiStoryLimitTaskById.LogPair.Clear();
			ConfigHonamiStoryLimitTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLimitTaskById.HandleId, 1, p0Id, ConfigHonamiStoryLimitTaskById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryLimitTaskById.HandleId, true, ConfigHonamiStoryLimitTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLimitTaskById.HandleId, ConfigHonamiStoryLimitTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLimitTaskById.HandleId, 0, ConfigHonamiStoryLimitTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLimitTaskById.HandleId, ConfigHonamiStoryLimitTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryLimitTask rootAsHonamiStoryLimitTask = HonamiStoryLimitTask.GetRootAsHonamiStoryLimitTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLimitTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLimitTaskById.HandleId, ConfigHonamiStoryLimitTaskById.LogPair);
			return new HonamiStoryLimitTask?(rootAsHonamiStoryLimitTask);
		}

		// Token: 0x04001B5F RID: 7007
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B60 RID: 7008
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001B61 RID: 7009
		private const string TABLE = "HonamiStoryLimitTask";

		// Token: 0x04001B62 RID: 7010
		private const string COMMAND = "select BinData from `HonamiStoryLimitTask` where Id=?";

		// Token: 0x04001B63 RID: 7011
		private const string KEY_PREFIX = "HonamiStoryLimitTaskById";

		// Token: 0x04001B64 RID: 7012
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B65 RID: 7013
		private static int HandleId;
	}
}
