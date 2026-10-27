using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E1 RID: 993
	public class ConfigHonamiStoryBuffTempLibraryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600174D RID: 5965 RVA: 0x000DD4AC File Offset: 0x000DB6AC
		static ConfigHonamiStoryBuffTempLibraryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryBuffTempLibraryById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryBuffTempLibraryById.ResetStaticDefaultValue));
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000DD4CC File Offset: 0x000DB6CC
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

		// Token: 0x0600174F RID: 5967 RVA: 0x000DD54B File Offset: 0x000DB74B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryBuffTempLibraryById.LogPair = null;
			ConfigHonamiStoryBuffTempLibraryById.HandleId = 0;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x000DD559 File Offset: 0x000DB759
		public static void Init()
		{
			ConfigHonamiStoryBuffTempLibraryById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryBuffTempLibraryById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryBuffTempLibrary` where Id=?");
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x000DD574 File Offset: 0x000DB774
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

		// Token: 0x04001B0B RID: 6923
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B0C RID: 6924
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001B0D RID: 6925
		private const string TABLE = "HonamiStoryBuffTempLibrary";

		// Token: 0x04001B0E RID: 6926
		private const string COMMAND = "select BinData from `HonamiStoryBuffTempLibrary` where Id=?";

		// Token: 0x04001B0F RID: 6927
		private const string KEY_PREFIX = "HonamiStoryBuffTempLibraryById";

		// Token: 0x04001B10 RID: 6928
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B11 RID: 6929
		private static int HandleId;
	}
}
