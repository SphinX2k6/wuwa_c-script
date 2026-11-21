using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F0 RID: 1008
	public class ConfigHonamiStoryActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017A7 RID: 6055 RVA: 0x000E2C27 File Offset: 0x000E0E27
		static ConfigHonamiStoryActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000E2C48 File Offset: 0x000E0E48
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryActivity` where ActivityId=?")
			});
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000E2CC7 File Offset: 0x000E0EC7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryActivityByActivityId.LogPair = null;
			ConfigHonamiStoryActivityByActivityId.HandleId = 0;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000E2CD5 File Offset: 0x000E0ED5
		public static void Init()
		{
			ConfigHonamiStoryActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryActivityByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryActivity` where ActivityId=?");
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x000E2CF0 File Offset: 0x000E0EF0
		public static HonamiStoryActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryActivityByActivityId.HandleId, ConfigHonamiStoryActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryActivity?(HonamiStoryActivity.GetRootAsHonamiStoryActivity(configBuffer));
				}
			}
			ConfigHonamiStoryActivityByActivityId.LogPair.Clear();
			ConfigHonamiStoryActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryActivityByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigHonamiStoryActivityByActivityId.HandleId, true, ConfigHonamiStoryActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryActivityByActivityId.HandleId, ConfigHonamiStoryActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryActivityByActivityId.HandleId, 0, ConfigHonamiStoryActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryActivityByActivityId.HandleId, ConfigHonamiStoryActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryActivity rootAsHonamiStoryActivity = HonamiStoryActivity.GetRootAsHonamiStoryActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryActivityByActivityId.HandleId, ConfigHonamiStoryActivityByActivityId.LogPair);
			return new HonamiStoryActivity?(rootAsHonamiStoryActivity);
		}

		// Token: 0x04001B74 RID: 7028
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B75 RID: 7029
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B76 RID: 7030
		private const string TABLE = "HonamiStoryActivity";

		// Token: 0x04001B77 RID: 7031
		private const string COMMAND = "select BinData from `HonamiStoryActivity` where ActivityId=?";

		// Token: 0x04001B78 RID: 7032
		private const string KEY_PREFIX = "HonamiStoryActivityByActivityId";

		// Token: 0x04001B79 RID: 7033
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B7A RID: 7034
		private static int HandleId;
	}
}
