using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F8 RID: 1016
	public class ConfigHonamiStoryDangerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017D7 RID: 6103 RVA: 0x000E3E48 File Offset: 0x000E2048
		static ConfigHonamiStoryDangerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryDangerLevelById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryDangerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000E3E68 File Offset: 0x000E2068
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

		// Token: 0x060017D9 RID: 6105 RVA: 0x000E3EE7 File Offset: 0x000E20E7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryDangerLevelById.LogPair = null;
			ConfigHonamiStoryDangerLevelById.HandleId = 0;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x000E3EF5 File Offset: 0x000E20F5
		public static void Init()
		{
			ConfigHonamiStoryDangerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryDangerLevelById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryDangerLevel` where Id=?");
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x000E3F10 File Offset: 0x000E2110
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

		// Token: 0x04001BAC RID: 7084
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BAD RID: 7085
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001BAE RID: 7086
		private const string TABLE = "HonamiStoryDangerLevel";

		// Token: 0x04001BAF RID: 7087
		private const string COMMAND = "select BinData from `HonamiStoryDangerLevel` where Id=?";

		// Token: 0x04001BB0 RID: 7088
		private const string KEY_PREFIX = "HonamiStoryDangerLevelById";

		// Token: 0x04001BB1 RID: 7089
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BB2 RID: 7090
		private static int HandleId;
	}
}
