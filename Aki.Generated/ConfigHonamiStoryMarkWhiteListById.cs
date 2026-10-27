using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F5 RID: 1013
	public class ConfigHonamiStoryMarkWhiteListById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017C5 RID: 6085 RVA: 0x000E0033 File Offset: 0x000DE233
		static ConfigHonamiStoryMarkWhiteListById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryMarkWhiteListById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryMarkWhiteListById.ResetStaticDefaultValue));
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x000E0054 File Offset: 0x000DE254
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryMarkWhiteListById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryMarkWhiteListById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryMarkWhiteList"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryMarkWhiteList` where Id=?")
			});
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000E00D3 File Offset: 0x000DE2D3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryMarkWhiteListById.LogPair = null;
			ConfigHonamiStoryMarkWhiteListById.HandleId = 0;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000E00E1 File Offset: 0x000DE2E1
		public static void Init()
		{
			ConfigHonamiStoryMarkWhiteListById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryMarkWhiteListById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryMarkWhiteList` where Id=?");
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000E00FC File Offset: 0x000DE2FC
		public static HonamiStoryMarkWhiteList? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMarkWhiteListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryMarkWhiteList?(HonamiStoryMarkWhiteList.GetRootAsHonamiStoryMarkWhiteList(configBuffer));
				}
			}
			ConfigHonamiStoryMarkWhiteListById.LogPair.Clear();
			ConfigHonamiStoryMarkWhiteListById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryMarkWhiteListById.HandleId, 1, p0Id, ConfigHonamiStoryMarkWhiteListById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryMarkWhiteListById.HandleId, true, ConfigHonamiStoryMarkWhiteListById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryMarkWhiteListById.HandleId, 0, ConfigHonamiStoryMarkWhiteListById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryMarkWhiteList rootAsHonamiStoryMarkWhiteList = HonamiStoryMarkWhiteList.GetRootAsHonamiStoryMarkWhiteList(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryMarkWhiteListById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryMarkWhiteListById.HandleId, ConfigHonamiStoryMarkWhiteListById.LogPair);
			return new HonamiStoryMarkWhiteList?(rootAsHonamiStoryMarkWhiteList);
		}

		// Token: 0x04001B97 RID: 7063
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B98 RID: 7064
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001B99 RID: 7065
		private const string TABLE = "HonamiStoryMarkWhiteList";

		// Token: 0x04001B9A RID: 7066
		private const string COMMAND = "select BinData from `HonamiStoryMarkWhiteList` where Id=?";

		// Token: 0x04001B9B RID: 7067
		private const string KEY_PREFIX = "HonamiStoryMarkWhiteListById";

		// Token: 0x04001B9C RID: 7068
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B9D RID: 7069
		private static int HandleId;
	}
}
