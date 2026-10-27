using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DC RID: 988
	public class ConfigHonamiStoryAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600172F RID: 5935 RVA: 0x000DC953 File Offset: 0x000DAB53
		static ConfigHonamiStoryAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000DC974 File Offset: 0x000DAB74
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryArea"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryArea` where Id=?")
			});
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000DC9F3 File Offset: 0x000DABF3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaById.LogPair = null;
			ConfigHonamiStoryAreaById.HandleId = 0;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x000DCA01 File Offset: 0x000DAC01
		public static void Init()
		{
			ConfigHonamiStoryAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryArea` where Id=?");
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000DCA1C File Offset: 0x000DAC1C
		public static HonamiStoryArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryAreaById.HandleId, ConfigHonamiStoryAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryArea?(HonamiStoryArea.GetRootAsHonamiStoryArea(configBuffer));
				}
			}
			ConfigHonamiStoryAreaById.LogPair.Clear();
			ConfigHonamiStoryAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryAreaById.HandleId, 1, p0Id, ConfigHonamiStoryAreaById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryAreaById.HandleId, true, ConfigHonamiStoryAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaById.HandleId, ConfigHonamiStoryAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryAreaById.HandleId, 0, ConfigHonamiStoryAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaById.HandleId, ConfigHonamiStoryAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryArea rootAsHonamiStoryArea = HonamiStoryArea.GetRootAsHonamiStoryArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryAreaById.HandleId, ConfigHonamiStoryAreaById.LogPair);
			return new HonamiStoryArea?(rootAsHonamiStoryArea);
		}

		// Token: 0x04001AE8 RID: 6888
		private const string DB = "db_honamistory.db";

		// Token: 0x04001AE9 RID: 6889
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001AEA RID: 6890
		private const string TABLE = "HonamiStoryArea";

		// Token: 0x04001AEB RID: 6891
		private const string COMMAND = "select BinData from `HonamiStoryArea` where Id=?";

		// Token: 0x04001AEC RID: 6892
		private const string KEY_PREFIX = "HonamiStoryAreaById";

		// Token: 0x04001AED RID: 6893
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AEE RID: 6894
		private static int HandleId;
	}
}
