using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000401 RID: 1025
	public class ConfigHonamiStoryLifeSupportById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600180D RID: 6157 RVA: 0x000E51FB File Offset: 0x000E33FB
		static ConfigHonamiStoryLifeSupportById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLifeSupportById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLifeSupportById.ResetStaticDefaultValue));
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000E521C File Offset: 0x000E341C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLifeSupportById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLifeSupportById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLifeSupport"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLifeSupport` where Id=?")
			});
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000E529B File Offset: 0x000E349B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLifeSupportById.LogPair = null;
			ConfigHonamiStoryLifeSupportById.HandleId = 0;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000E52A9 File Offset: 0x000E34A9
		public static void Init()
		{
			ConfigHonamiStoryLifeSupportById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLifeSupportById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLifeSupport` where Id=?");
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000E52C4 File Offset: 0x000E34C4
		public static HonamiStoryLifeSupport? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLifeSupportById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryLifeSupport?(HonamiStoryLifeSupport.GetRootAsHonamiStoryLifeSupport(configBuffer));
				}
			}
			ConfigHonamiStoryLifeSupportById.LogPair.Clear();
			ConfigHonamiStoryLifeSupportById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLifeSupportById.HandleId, 1, p0Id, ConfigHonamiStoryLifeSupportById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryLifeSupportById.HandleId, true, ConfigHonamiStoryLifeSupportById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLifeSupportById.HandleId, 0, ConfigHonamiStoryLifeSupportById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryLifeSupport rootAsHonamiStoryLifeSupport = HonamiStoryLifeSupport.GetRootAsHonamiStoryLifeSupport(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLifeSupportById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLifeSupportById.HandleId, ConfigHonamiStoryLifeSupportById.LogPair);
			return new HonamiStoryLifeSupport?(rootAsHonamiStoryLifeSupport);
		}

		// Token: 0x04001BEB RID: 7147
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BEC RID: 7148
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001BED RID: 7149
		private const string TABLE = "HonamiStoryLifeSupport";

		// Token: 0x04001BEE RID: 7150
		private const string COMMAND = "select BinData from `HonamiStoryLifeSupport` where Id=?";

		// Token: 0x04001BEF RID: 7151
		private const string KEY_PREFIX = "HonamiStoryLifeSupportById";

		// Token: 0x04001BF0 RID: 7152
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BF1 RID: 7153
		private static int HandleId;
	}
}
