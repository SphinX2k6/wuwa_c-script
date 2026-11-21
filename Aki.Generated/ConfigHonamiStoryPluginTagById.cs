using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000415 RID: 1045
	public class ConfigHonamiStoryPluginTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001885 RID: 6277 RVA: 0x000E7E7C File Offset: 0x000E607C
		static ConfigHonamiStoryPluginTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginTagById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000E7E9C File Offset: 0x000E609C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPluginTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPluginTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPluginTag"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPluginTag` where Id=?")
			});
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000E7F1B File Offset: 0x000E611B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginTagById.LogPair = null;
			ConfigHonamiStoryPluginTagById.HandleId = 0;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000E7F29 File Offset: 0x000E6129
		public static void Init()
		{
			ConfigHonamiStoryPluginTagById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginTagById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginTag` where Id=?");
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000E7F44 File Offset: 0x000E6144
		public static HonamiStoryPluginTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPluginTag?(HonamiStoryPluginTag.GetRootAsHonamiStoryPluginTag(configBuffer));
				}
			}
			ConfigHonamiStoryPluginTagById.LogPair.Clear();
			ConfigHonamiStoryPluginTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPluginTagById.HandleId, 1, p0Id, ConfigHonamiStoryPluginTagById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPluginTagById.HandleId, true, ConfigHonamiStoryPluginTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPluginTagById.HandleId, 0, ConfigHonamiStoryPluginTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPluginTag rootAsHonamiStoryPluginTag = HonamiStoryPluginTag.GetRootAsHonamiStoryPluginTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPluginTagById.HandleId, ConfigHonamiStoryPluginTagById.LogPair);
			return new HonamiStoryPluginTag?(rootAsHonamiStoryPluginTag);
		}

		// Token: 0x04001C77 RID: 7287
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C78 RID: 7288
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001C79 RID: 7289
		private const string TABLE = "HonamiStoryPluginTag";

		// Token: 0x04001C7A RID: 7290
		private const string COMMAND = "select BinData from `HonamiStoryPluginTag` where Id=?";

		// Token: 0x04001C7B RID: 7291
		private const string KEY_PREFIX = "HonamiStoryPluginTagById";

		// Token: 0x04001C7C RID: 7292
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C7D RID: 7293
		private static int HandleId;
	}
}
