using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000405 RID: 1029
	public class ConfigHonamiStoryResidentTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001825 RID: 6181 RVA: 0x000E24B7 File Offset: 0x000E06B7
		static ConfigHonamiStoryResidentTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryResidentTaskById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryResidentTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000E24D8 File Offset: 0x000E06D8
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryResidentTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryResidentTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryResidentTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryResidentTask` where Id=?")
			});
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000E2557 File Offset: 0x000E0757
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryResidentTaskById.LogPair = null;
			ConfigHonamiStoryResidentTaskById.HandleId = 0;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000E2565 File Offset: 0x000E0765
		public static void Init()
		{
			ConfigHonamiStoryResidentTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryResidentTaskById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryResidentTask` where Id=?");
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000E2580 File Offset: 0x000E0780
		public static HonamiStoryResidentTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryResidentTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryResidentTask?(HonamiStoryResidentTask.GetRootAsHonamiStoryResidentTask(configBuffer));
				}
			}
			ConfigHonamiStoryResidentTaskById.LogPair.Clear();
			ConfigHonamiStoryResidentTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryResidentTaskById.HandleId, 1, p0Id, ConfigHonamiStoryResidentTaskById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryResidentTaskById.HandleId, true, ConfigHonamiStoryResidentTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryResidentTaskById.HandleId, 0, ConfigHonamiStoryResidentTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryResidentTask rootAsHonamiStoryResidentTask = HonamiStoryResidentTask.GetRootAsHonamiStoryResidentTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryResidentTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryResidentTaskById.HandleId, ConfigHonamiStoryResidentTaskById.LogPair);
			return new HonamiStoryResidentTask?(rootAsHonamiStoryResidentTask);
		}

		// Token: 0x04001C07 RID: 7175
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C08 RID: 7176
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C09 RID: 7177
		private const string TABLE = "HonamiStoryResidentTask";

		// Token: 0x04001C0A RID: 7178
		private const string COMMAND = "select BinData from `HonamiStoryResidentTask` where Id=?";

		// Token: 0x04001C0B RID: 7179
		private const string KEY_PREFIX = "HonamiStoryResidentTaskById";

		// Token: 0x04001C0C RID: 7180
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C0D RID: 7181
		private static int HandleId;
	}
}
