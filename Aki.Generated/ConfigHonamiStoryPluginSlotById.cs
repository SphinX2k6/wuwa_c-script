using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000413 RID: 1043
	public class ConfigHonamiStoryPluginSlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001879 RID: 6265 RVA: 0x000E79EC File Offset: 0x000E5BEC
		static ConfigHonamiStoryPluginSlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginSlotById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginSlotById.ResetStaticDefaultValue));
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000E7A0C File Offset: 0x000E5C0C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPluginSlotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPluginSlotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPluginSlot"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPluginSlot` where Id=?")
			});
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000E7A8B File Offset: 0x000E5C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginSlotById.LogPair = null;
			ConfigHonamiStoryPluginSlotById.HandleId = 0;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000E7A99 File Offset: 0x000E5C99
		public static void Init()
		{
			ConfigHonamiStoryPluginSlotById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginSlotById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginSlot` where Id=?");
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000E7AB4 File Offset: 0x000E5CB4
		public static HonamiStoryPluginSlot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPluginSlotById.HandleId, ConfigHonamiStoryPluginSlotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryPluginSlot?(HonamiStoryPluginSlot.GetRootAsHonamiStoryPluginSlot(configBuffer));
				}
			}
			ConfigHonamiStoryPluginSlotById.LogPair.Clear();
			ConfigHonamiStoryPluginSlotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPluginSlotById.HandleId, 1, p0Id, ConfigHonamiStoryPluginSlotById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryPluginSlotById.HandleId, true, ConfigHonamiStoryPluginSlotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginSlotById.HandleId, ConfigHonamiStoryPluginSlotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPluginSlotById.HandleId, 0, ConfigHonamiStoryPluginSlotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginSlotById.HandleId, ConfigHonamiStoryPluginSlotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryPluginSlot rootAsHonamiStoryPluginSlot = HonamiStoryPluginSlot.GetRootAsHonamiStoryPluginSlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPluginSlotById.HandleId, ConfigHonamiStoryPluginSlotById.LogPair);
			return new HonamiStoryPluginSlot?(rootAsHonamiStoryPluginSlot);
		}

		// Token: 0x04001C69 RID: 7273
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C6A RID: 7274
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001C6B RID: 7275
		private const string TABLE = "HonamiStoryPluginSlot";

		// Token: 0x04001C6C RID: 7276
		private const string COMMAND = "select BinData from `HonamiStoryPluginSlot` where Id=?";

		// Token: 0x04001C6D RID: 7277
		private const string KEY_PREFIX = "HonamiStoryPluginSlotById";

		// Token: 0x04001C6E RID: 7278
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C6F RID: 7279
		private static int HandleId;
	}
}
