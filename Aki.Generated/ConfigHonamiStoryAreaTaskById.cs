using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DE RID: 990
	public class ConfigHonamiStoryAreaTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600173B RID: 5947 RVA: 0x000DCDD3 File Offset: 0x000DAFD3
		static ConfigHonamiStoryAreaTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryAreaTaskById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryAreaTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x000DCDF4 File Offset: 0x000DAFF4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryAreaTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryAreaTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryAreaTask"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryAreaTask` where Id=?")
			});
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x000DCE73 File Offset: 0x000DB073
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryAreaTaskById.LogPair = null;
			ConfigHonamiStoryAreaTaskById.HandleId = 0;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x000DCE81 File Offset: 0x000DB081
		public static void Init()
		{
			ConfigHonamiStoryAreaTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryAreaTaskById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryAreaTask` where Id=?");
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x000DCE9C File Offset: 0x000DB09C
		public static HonamiStoryAreaTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryAreaTask?(HonamiStoryAreaTask.GetRootAsHonamiStoryAreaTask(configBuffer));
				}
			}
			ConfigHonamiStoryAreaTaskById.LogPair.Clear();
			ConfigHonamiStoryAreaTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryAreaTaskById.HandleId, 1, p0Id, ConfigHonamiStoryAreaTaskById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryAreaTaskById.HandleId, true, ConfigHonamiStoryAreaTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryAreaTaskById.HandleId, 0, ConfigHonamiStoryAreaTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryAreaTask rootAsHonamiStoryAreaTask = HonamiStoryAreaTask.GetRootAsHonamiStoryAreaTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryAreaTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryAreaTaskById.HandleId, ConfigHonamiStoryAreaTaskById.LogPair);
			return new HonamiStoryAreaTask?(rootAsHonamiStoryAreaTask);
		}

		// Token: 0x04001AF6 RID: 6902
		private const string DB = "db_honamistory.db";

		// Token: 0x04001AF7 RID: 6903
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001AF8 RID: 6904
		private const string TABLE = "HonamiStoryAreaTask";

		// Token: 0x04001AF9 RID: 6905
		private const string COMMAND = "select BinData from `HonamiStoryAreaTask` where Id=?";

		// Token: 0x04001AFA RID: 6906
		private const string KEY_PREFIX = "HonamiStoryAreaTaskById";

		// Token: 0x04001AFB RID: 6907
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AFC RID: 6908
		private static int HandleId;
	}
}
