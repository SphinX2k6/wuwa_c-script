using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F7 RID: 1015
	public class ConfigHonamiStoryBuffTempLibraryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017D1 RID: 6097 RVA: 0x000E3C00 File Offset: 0x000E1E00
		static ConfigHonamiStoryBuffTempLibraryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryBuffTempLibraryById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryBuffTempLibraryById.ResetStaticDefaultValue));
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x000E3C20 File Offset: 0x000E1E20
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryBuffTempLibraryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryBuffTempLibraryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryBuffTempLibrary"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryBuffTempLibrary` where Id=?")
			});
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000E3C9F File Offset: 0x000E1E9F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryBuffTempLibraryById.LogPair = null;
			ConfigHonamiStoryBuffTempLibraryById.HandleId = 0;
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x000E3CAD File Offset: 0x000E1EAD
		public static void Init()
		{
			ConfigHonamiStoryBuffTempLibraryById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryBuffTempLibraryById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryBuffTempLibrary` where Id=?");
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000E3CC8 File Offset: 0x000E1EC8
		public static HonamiStoryBuffTempLibrary? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryBuffTempLibraryById.HandleId, ConfigHonamiStoryBuffTempLibraryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBuffTempLibraryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryBuffTempLibrary?(HonamiStoryBuffTempLibrary.GetRootAsHonamiStoryBuffTempLibrary(configBuffer));
				}
			}
			ConfigHonamiStoryBuffTempLibraryById.LogPair.Clear();
			ConfigHonamiStoryBuffTempLibraryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryBuffTempLibraryById.HandleId, 1, p0Id, ConfigHonamiStoryBuffTempLibraryById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryBuffTempLibraryById.HandleId, true, ConfigHonamiStoryBuffTempLibraryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBuffTempLibraryById.HandleId, ConfigHonamiStoryBuffTempLibraryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryBuffTempLibraryById.HandleId, 0, ConfigHonamiStoryBuffTempLibraryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBuffTempLibraryById.HandleId, ConfigHonamiStoryBuffTempLibraryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryBuffTempLibrary rootAsHonamiStoryBuffTempLibrary = HonamiStoryBuffTempLibrary.GetRootAsHonamiStoryBuffTempLibrary(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBuffTempLibraryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryBuffTempLibraryById.HandleId, ConfigHonamiStoryBuffTempLibraryById.LogPair);
			return new HonamiStoryBuffTempLibrary?(rootAsHonamiStoryBuffTempLibrary);
		}

		// Token: 0x04001BA5 RID: 7077
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BA6 RID: 7078
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BA7 RID: 7079
		private const string TABLE = "HonamiStoryBuffTempLibrary";

		// Token: 0x04001BA8 RID: 7080
		private const string COMMAND = "select BinData from `HonamiStoryBuffTempLibrary` where Id=?";

		// Token: 0x04001BA9 RID: 7081
		private const string KEY_PREFIX = "HonamiStoryBuffTempLibraryById";

		// Token: 0x04001BAA RID: 7082
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BAB RID: 7083
		private static int HandleId;
	}
}
