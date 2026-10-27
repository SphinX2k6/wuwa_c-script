using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E2 RID: 994
	public class ConfigHonamiStoryDangerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001753 RID: 5971 RVA: 0x000DD6F4 File Offset: 0x000DB8F4
		static ConfigHonamiStoryDangerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryDangerLevelById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryDangerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x000DD714 File Offset: 0x000DB914
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryDangerLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryDangerLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryDangerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryDangerLevel` where Id=?")
			});
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x000DD793 File Offset: 0x000DB993
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryDangerLevelById.LogPair = null;
			ConfigHonamiStoryDangerLevelById.HandleId = 0;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x000DD7A1 File Offset: 0x000DB9A1
		public static void Init()
		{
			ConfigHonamiStoryDangerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryDangerLevelById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryDangerLevel` where Id=?");
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000DD7BC File Offset: 0x000DB9BC
		public static HonamiStoryDangerLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryDangerLevelById.HandleId, ConfigHonamiStoryDangerLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryDangerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryDangerLevel?(HonamiStoryDangerLevel.GetRootAsHonamiStoryDangerLevel(configBuffer));
				}
			}
			ConfigHonamiStoryDangerLevelById.LogPair.Clear();
			ConfigHonamiStoryDangerLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryDangerLevelById.HandleId, 1, p0Id, ConfigHonamiStoryDangerLevelById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryDangerLevelById.HandleId, true, ConfigHonamiStoryDangerLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryDangerLevelById.HandleId, ConfigHonamiStoryDangerLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryDangerLevelById.HandleId, 0, ConfigHonamiStoryDangerLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryDangerLevelById.HandleId, ConfigHonamiStoryDangerLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryDangerLevel rootAsHonamiStoryDangerLevel = HonamiStoryDangerLevel.GetRootAsHonamiStoryDangerLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryDangerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryDangerLevelById.HandleId, ConfigHonamiStoryDangerLevelById.LogPair);
			return new HonamiStoryDangerLevel?(rootAsHonamiStoryDangerLevel);
		}

		// Token: 0x04001B12 RID: 6930
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B13 RID: 6931
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001B14 RID: 6932
		private const string TABLE = "HonamiStoryDangerLevel";

		// Token: 0x04001B15 RID: 6933
		private const string COMMAND = "select BinData from `HonamiStoryDangerLevel` where Id=?";

		// Token: 0x04001B16 RID: 6934
		private const string KEY_PREFIX = "HonamiStoryDangerLevelById";

		// Token: 0x04001B17 RID: 6935
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B18 RID: 6936
		private static int HandleId;
	}
}
