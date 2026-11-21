using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F2 RID: 1010
	public class ConfigHonamiStoryAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017B3 RID: 6067 RVA: 0x000E30A7 File Offset: 0x000E12A7
		static ConfigHonamiStoryAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000E30C8 File Offset: 0x000E12C8
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

		// Token: 0x060017B5 RID: 6069 RVA: 0x000E3147 File Offset: 0x000E1347
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaById.LogPair = null;
			ConfigHonamiStoryAreaById.HandleId = 0;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000E3155 File Offset: 0x000E1355
		public static void Init()
		{
			ConfigHonamiStoryAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryArea` where Id=?");
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000E3170 File Offset: 0x000E1370
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

		// Token: 0x04001B82 RID: 7042
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B83 RID: 7043
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B84 RID: 7044
		private const string TABLE = "HonamiStoryArea";

		// Token: 0x04001B85 RID: 7045
		private const string COMMAND = "select BinData from `HonamiStoryArea` where Id=?";

		// Token: 0x04001B86 RID: 7046
		private const string KEY_PREFIX = "HonamiStoryAreaById";

		// Token: 0x04001B87 RID: 7047
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B88 RID: 7048
		private static int HandleId;
	}
}
