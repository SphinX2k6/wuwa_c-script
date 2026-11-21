using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F6 RID: 1014
	public class ConfigHonamiStoryBuffTempById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017CB RID: 6091 RVA: 0x000E39B8 File Offset: 0x000E1BB8
		static ConfigHonamiStoryBuffTempById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryBuffTempById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryBuffTempById.ResetStaticDefaultValue));
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000E39D8 File Offset: 0x000E1BD8
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryBuffTempById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryBuffTempById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryBuffTemp"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryBuffTemp` where Id=?")
			});
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000E3A57 File Offset: 0x000E1C57
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryBuffTempById.LogPair = null;
			ConfigHonamiStoryBuffTempById.HandleId = 0;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000E3A65 File Offset: 0x000E1C65
		public static void Init()
		{
			ConfigHonamiStoryBuffTempById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryBuffTempById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryBuffTemp` where Id=?");
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x000E3A80 File Offset: 0x000E1C80
		public static HonamiStoryBuffTemp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBuffTempById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryBuffTemp?(HonamiStoryBuffTemp.GetRootAsHonamiStoryBuffTemp(configBuffer));
				}
			}
			ConfigHonamiStoryBuffTempById.LogPair.Clear();
			ConfigHonamiStoryBuffTempById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryBuffTempById.HandleId, 1, p0Id, ConfigHonamiStoryBuffTempById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryBuffTempById.HandleId, true, ConfigHonamiStoryBuffTempById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryBuffTempById.HandleId, 0, ConfigHonamiStoryBuffTempById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryBuffTemp rootAsHonamiStoryBuffTemp = HonamiStoryBuffTemp.GetRootAsHonamiStoryBuffTemp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryBuffTempById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryBuffTempById.HandleId, ConfigHonamiStoryBuffTempById.LogPair);
			return new HonamiStoryBuffTemp?(rootAsHonamiStoryBuffTemp);
		}

		// Token: 0x04001B9E RID: 7070
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B9F RID: 7071
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BA0 RID: 7072
		private const string TABLE = "HonamiStoryBuffTemp";

		// Token: 0x04001BA1 RID: 7073
		private const string COMMAND = "select BinData from `HonamiStoryBuffTemp` where Id=?";

		// Token: 0x04001BA2 RID: 7074
		private const string KEY_PREFIX = "HonamiStoryBuffTempById";

		// Token: 0x04001BA3 RID: 7075
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BA4 RID: 7076
		private static int HandleId;
	}
}
