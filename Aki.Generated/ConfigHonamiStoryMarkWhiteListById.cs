using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040B RID: 1035
	public class ConfigHonamiStoryMarkWhiteListById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x000E6787 File Offset: 0x000E4987
		static ConfigHonamiStoryMarkWhiteListById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMarkWhiteListById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMarkWhiteListById.ResetStaticDefaultValue));
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x000E67A8 File Offset: 0x000E49A8
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryMarkWhiteListById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryMarkWhiteListById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryMarkWhiteList"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryMarkWhiteList` where Id=?")
			});
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000E6827 File Offset: 0x000E4A27
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMarkWhiteListById.LogPair = null;
			ConfigHonamiStoryMarkWhiteListById.HandleId = 0;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000E6835 File Offset: 0x000E4A35
		public static void Init()
		{
			ConfigHonamiStoryMarkWhiteListById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMarkWhiteListById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMarkWhiteList` where Id=?");
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x000E6850 File Offset: 0x000E4A50
		public static HonamiStoryMarkWhiteList? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMarkWhiteListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryMarkWhiteList?(HonamiStoryMarkWhiteList.GetRootAsHonamiStoryMarkWhiteList(configBuffer));
				}
			}
			ConfigHonamiStoryMarkWhiteListById.LogPair.Clear();
			ConfigHonamiStoryMarkWhiteListById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryMarkWhiteListById.HandleId, 1, p0Id, ConfigHonamiStoryMarkWhiteListById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryMarkWhiteListById.HandleId, true, ConfigHonamiStoryMarkWhiteListById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryMarkWhiteListById.HandleId, 0, ConfigHonamiStoryMarkWhiteListById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryMarkWhiteList rootAsHonamiStoryMarkWhiteList = HonamiStoryMarkWhiteList.GetRootAsHonamiStoryMarkWhiteList(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMarkWhiteListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair);
			return new HonamiStoryMarkWhiteList?(rootAsHonamiStoryMarkWhiteList);
		}

		// Token: 0x04001C31 RID: 7217
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C32 RID: 7218
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001C33 RID: 7219
		private const string TABLE = "HonamiStoryMarkWhiteList";

		// Token: 0x04001C34 RID: 7220
		private const string COMMAND = "select BinData from `HonamiStoryMarkWhiteList` where Id=?";

		// Token: 0x04001C35 RID: 7221
		private const string KEY_PREFIX = "HonamiStoryMarkWhiteListById";

		// Token: 0x04001C36 RID: 7222
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C37 RID: 7223
		private static int HandleId;
	}
}
