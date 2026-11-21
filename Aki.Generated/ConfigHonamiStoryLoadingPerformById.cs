using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000406 RID: 1030
	public class ConfigHonamiStoryLoadingPerformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600182B RID: 6187 RVA: 0x000E5D99 File Offset: 0x000E3F99
		static ConfigHonamiStoryLoadingPerformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformById.ResetStaticDefaultValue));
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000E5DB8 File Offset: 0x000E3FB8
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

		// Token: 0x0600182D RID: 6189 RVA: 0x000E5E37 File Offset: 0x000E4037
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformById.LogPair = null;
			ConfigHonamiStoryLoadingPerformById.HandleId = 0;
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000E5E45 File Offset: 0x000E4045
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where Id=?");
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x000E5E60 File Offset: 0x000E4060
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

		// Token: 0x04001C0E RID: 7182
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C0F RID: 7183
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C10 RID: 7184
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001C11 RID: 7185
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where Id=?";

		// Token: 0x04001C12 RID: 7186
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformById";

		// Token: 0x04001C13 RID: 7187
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C14 RID: 7188
		private static int HandleId;
	}
}
