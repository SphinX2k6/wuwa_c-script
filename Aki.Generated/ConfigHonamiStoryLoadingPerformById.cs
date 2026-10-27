using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F0 RID: 1008
	public class ConfigHonamiStoryLoadingPerformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017A7 RID: 6055 RVA: 0x000DF645 File Offset: 0x000DD845
		static ConfigHonamiStoryLoadingPerformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformById.ResetStaticDefaultValue));
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000DF664 File Offset: 0x000DD864
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLoadingPerformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLoadingPerform"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLoadingPerform` where Id=?")
			});
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000DF6E3 File Offset: 0x000DD8E3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformById.LogPair = null;
			ConfigHonamiStoryLoadingPerformById.HandleId = 0;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000DF6F1 File Offset: 0x000DD8F1
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where Id=?");
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x000DF70C File Offset: 0x000DD90C
		public static HonamiStoryLoadingPerform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLoadingPerformById.HandleId, ConfigHonamiStoryLoadingPerformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryLoadingPerform?(HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(configBuffer));
				}
			}
			ConfigHonamiStoryLoadingPerformById.LogPair.Clear();
			ConfigHonamiStoryLoadingPerformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLoadingPerformById.HandleId, 1, p0Id, ConfigHonamiStoryLoadingPerformById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryLoadingPerformById.HandleId, true, ConfigHonamiStoryLoadingPerformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformById.HandleId, ConfigHonamiStoryLoadingPerformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLoadingPerformById.HandleId, 0, ConfigHonamiStoryLoadingPerformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformById.HandleId, ConfigHonamiStoryLoadingPerformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryLoadingPerform rootAsHonamiStoryLoadingPerform = HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformById.HandleId, ConfigHonamiStoryLoadingPerformById.LogPair);
			return new HonamiStoryLoadingPerform?(rootAsHonamiStoryLoadingPerform);
		}

		// Token: 0x04001B74 RID: 7028
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B75 RID: 7029
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B76 RID: 7030
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001B77 RID: 7031
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where Id=?";

		// Token: 0x04001B78 RID: 7032
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformById";

		// Token: 0x04001B79 RID: 7033
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B7A RID: 7034
		private static int HandleId;
	}
}
