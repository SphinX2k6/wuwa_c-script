using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000403 RID: 1027
	public class ConfigHonamiStoryPropLibraryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x000E2038 File Offset: 0x000E0238
		static ConfigHonamiStoryPropLibraryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPropLibraryById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPropLibraryById.ResetStaticDefaultValue));
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000E2058 File Offset: 0x000E0258
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPropLibraryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPropLibraryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPropLibrary"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPropLibrary` where Id=?")
			});
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x000E20D7 File Offset: 0x000E02D7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPropLibraryById.LogPair = null;
			ConfigHonamiStoryPropLibraryById.HandleId = 0;
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000E20E5 File Offset: 0x000E02E5
		public static void Init()
		{
			ConfigHonamiStoryPropLibraryById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPropLibraryById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPropLibrary` where Id=?");
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000E2100 File Offset: 0x000E0300
		public static HonamiStoryPropLibrary? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPropLibraryById.HandleId, ConfigHonamiStoryPropLibraryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPropLibraryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPropLibrary?(HonamiStoryPropLibrary.GetRootAsHonamiStoryPropLibrary(configBuffer));
				}
			}
			ConfigHonamiStoryPropLibraryById.LogPair.Clear();
			ConfigHonamiStoryPropLibraryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPropLibraryById.HandleId, 1, p0Id, ConfigHonamiStoryPropLibraryById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPropLibraryById.HandleId, true, ConfigHonamiStoryPropLibraryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPropLibraryById.HandleId, ConfigHonamiStoryPropLibraryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPropLibraryById.HandleId, 0, ConfigHonamiStoryPropLibraryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPropLibraryById.HandleId, ConfigHonamiStoryPropLibraryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPropLibrary rootAsHonamiStoryPropLibrary = HonamiStoryPropLibrary.GetRootAsHonamiStoryPropLibrary(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPropLibraryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPropLibraryById.HandleId, ConfigHonamiStoryPropLibraryById.LogPair);
			return new HonamiStoryPropLibrary?(rootAsHonamiStoryPropLibrary);
		}

		// Token: 0x04001BF9 RID: 7161
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BFA RID: 7162
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BFB RID: 7163
		private const string TABLE = "HonamiStoryPropLibrary";

		// Token: 0x04001BFC RID: 7164
		private const string COMMAND = "select BinData from `HonamiStoryPropLibrary` where Id=?";

		// Token: 0x04001BFD RID: 7165
		private const string KEY_PREFIX = "HonamiStoryPropLibraryById";

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
