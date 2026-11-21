using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000403 RID: 1027
	public class ConfigHonamiStoryLimitTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x000E567B File Offset: 0x000E387B
		static ConfigHonamiStoryLimitTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLimitTaskById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLimitTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000E569C File Offset: 0x000E389C
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

		// Token: 0x0600181B RID: 6171 RVA: 0x000E571B File Offset: 0x000E391B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLimitTaskById.LogPair = null;
			ConfigHonamiStoryLimitTaskById.HandleId = 0;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000E5729 File Offset: 0x000E3929
		public static void Init()
		{
			ConfigHonamiStoryLimitTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLimitTaskById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLimitTask` where Id=?");
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000E5744 File Offset: 0x000E3944
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

		// Token: 0x04001BF9 RID: 7161
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BFA RID: 7162
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001BFB RID: 7163
		private const string TABLE = "HonamiStoryLimitTask";

		// Token: 0x04001BFC RID: 7164
		private const string COMMAND = "select BinData from `HonamiStoryLimitTask` where Id=?";

		// Token: 0x04001BFD RID: 7165
		private const string KEY_PREFIX = "HonamiStoryLimitTaskById";

		// Token: 0x04001BFE RID: 7166
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BFF RID: 7167
		private static int HandleId;
	}
}
