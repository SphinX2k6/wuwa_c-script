using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DA RID: 986
	public class ConfigHonamiStoryActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x000DC4D3 File Offset: 0x000DA6D3
		static ConfigHonamiStoryActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000DC4F4 File Offset: 0x000DA6F4
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

		// Token: 0x06001725 RID: 5925 RVA: 0x000DC573 File Offset: 0x000DA773
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryActivityByActivityId.LogPair = null;
			ConfigHonamiStoryActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000DC581 File Offset: 0x000DA781
		public static void Init()
		{
			ConfigHonamiStoryActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryActivityByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryActivity` where ActivityId=?");
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x000DC59C File Offset: 0x000DA79C
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

		// Token: 0x04001ADA RID: 6874
		private const string DB = "db_honamistory.db";

		// Token: 0x04001ADB RID: 6875
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001ADC RID: 6876
		private const string TABLE = "HonamiStoryActivity";

		// Token: 0x04001ADD RID: 6877
		private const string COMMAND = "select BinData from `HonamiStoryActivity` where ActivityId=?";

		// Token: 0x04001ADE RID: 6878
		private const string KEY_PREFIX = "HonamiStoryActivityByActivityId";

		// Token: 0x04001ADF RID: 6879
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AE0 RID: 6880
		private static int HandleId;
	}
}
