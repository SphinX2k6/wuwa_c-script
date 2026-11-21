using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000414 RID: 1044
	public class ConfigHonamiStoryPluginSubTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600187F RID: 6271 RVA: 0x000E7C34 File Offset: 0x000E5E34
		static ConfigHonamiStoryPluginSubTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginSubTypeById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginSubTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000E7C54 File Offset: 0x000E5E54
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPluginSubTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPluginSubTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPluginSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPluginSubType` where Id=?")
			});
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000E7CD3 File Offset: 0x000E5ED3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginSubTypeById.LogPair = null;
			ConfigHonamiStoryPluginSubTypeById.HandleId = 0;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000E7CE1 File Offset: 0x000E5EE1
		public static void Init()
		{
			ConfigHonamiStoryPluginSubTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginSubTypeById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginSubType` where Id=?");
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000E7CFC File Offset: 0x000E5EFC
		public static HonamiStoryPluginSubType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPluginSubType?(HonamiStoryPluginSubType.GetRootAsHonamiStoryPluginSubType(configBuffer));
				}
			}
			ConfigHonamiStoryPluginSubTypeById.LogPair.Clear();
			ConfigHonamiStoryPluginSubTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPluginSubTypeById.HandleId, 1, p0Id, ConfigHonamiStoryPluginSubTypeById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPluginSubTypeById.HandleId, true, ConfigHonamiStoryPluginSubTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPluginSubTypeById.HandleId, 0, ConfigHonamiStoryPluginSubTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPluginSubType rootAsHonamiStoryPluginSubType = HonamiStoryPluginSubType.GetRootAsHonamiStoryPluginSubType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPluginSubTypeById.HandleId, ConfigHonamiStoryPluginSubTypeById.LogPair);
			return new HonamiStoryPluginSubType?(rootAsHonamiStoryPluginSubType);
		}

		// Token: 0x04001C70 RID: 7280
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C71 RID: 7281
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001C72 RID: 7282
		private const string TABLE = "HonamiStoryPluginSubType";

		// Token: 0x04001C73 RID: 7283
		private const string COMMAND = "select BinData from `HonamiStoryPluginSubType` where Id=?";

		// Token: 0x04001C74 RID: 7284
		private const string KEY_PREFIX = "HonamiStoryPluginSubTypeById";

		// Token: 0x04001C75 RID: 7285
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C76 RID: 7286
		private static int HandleId;
	}
}
