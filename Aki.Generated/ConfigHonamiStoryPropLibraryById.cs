using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000419 RID: 1049
	public class ConfigHonamiStoryPropLibraryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600189D RID: 6301 RVA: 0x000E878C File Offset: 0x000E698C
		static ConfigHonamiStoryPropLibraryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPropLibraryById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPropLibraryById.ResetStaticDefaultValue));
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000E87AC File Offset: 0x000E69AC
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

		// Token: 0x0600189F RID: 6303 RVA: 0x000E882B File Offset: 0x000E6A2B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPropLibraryById.LogPair = null;
			ConfigHonamiStoryPropLibraryById.HandleId = 0;
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000E8839 File Offset: 0x000E6A39
		public static void Init()
		{
			ConfigHonamiStoryPropLibraryById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPropLibraryById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPropLibrary` where Id=?");
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x000E8854 File Offset: 0x000E6A54
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

		// Token: 0x04001C93 RID: 7315
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C94 RID: 7316
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001C95 RID: 7317
		private const string TABLE = "HonamiStoryPropLibrary";

		// Token: 0x04001C96 RID: 7318
		private const string COMMAND = "select BinData from `HonamiStoryPropLibrary` where Id=?";

		// Token: 0x04001C97 RID: 7319
		private const string KEY_PREFIX = "HonamiStoryPropLibraryById";

		// Token: 0x04001C98 RID: 7320
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C99 RID: 7321
		private static int HandleId;
	}
}
