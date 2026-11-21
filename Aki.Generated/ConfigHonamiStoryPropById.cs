using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000418 RID: 1048
	public class ConfigHonamiStoryPropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001897 RID: 6295 RVA: 0x000E8544 File Offset: 0x000E6744
		static ConfigHonamiStoryPropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPropById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPropById.ResetStaticDefaultValue));
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000E8564 File Offset: 0x000E6764
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPropById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPropById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryProp"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryProp` where Id=?")
			});
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x000E85E3 File Offset: 0x000E67E3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPropById.LogPair = null;
			ConfigHonamiStoryPropById.HandleId = 0;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000E85F1 File Offset: 0x000E67F1
		public static void Init()
		{
			ConfigHonamiStoryPropById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPropById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryProp` where Id=?");
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000E860C File Offset: 0x000E680C
		public static HonamiStoryProp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryProp?(HonamiStoryProp.GetRootAsHonamiStoryProp(configBuffer));
				}
			}
			ConfigHonamiStoryPropById.LogPair.Clear();
			ConfigHonamiStoryPropById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPropById.HandleId, 1, p0Id, ConfigHonamiStoryPropById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPropById.HandleId, true, ConfigHonamiStoryPropById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPropById.HandleId, 0, ConfigHonamiStoryPropById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryProp rootAsHonamiStoryProp = HonamiStoryProp.GetRootAsHonamiStoryProp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPropById.HandleId, ConfigHonamiStoryPropById.LogPair);
			return new HonamiStoryProp?(rootAsHonamiStoryProp);
		}

		// Token: 0x04001C8C RID: 7308
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C8D RID: 7309
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001C8E RID: 7310
		private const string TABLE = "HonamiStoryProp";

		// Token: 0x04001C8F RID: 7311
		private const string COMMAND = "select BinData from `HonamiStoryProp` where Id=?";

		// Token: 0x04001C90 RID: 7312
		private const string KEY_PREFIX = "HonamiStoryPropById";

		// Token: 0x04001C91 RID: 7313
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C92 RID: 7314
		private static int HandleId;
	}
}
