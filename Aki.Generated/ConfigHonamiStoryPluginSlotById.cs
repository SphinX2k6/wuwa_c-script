using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FD RID: 1021
	public class ConfigHonamiStoryPluginSlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017F5 RID: 6133 RVA: 0x000E1298 File Offset: 0x000DF498
		static ConfigHonamiStoryPluginSlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginSlotById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginSlotById.ResetStaticDefaultValue));
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000E12B8 File Offset: 0x000DF4B8
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

		// Token: 0x060017F7 RID: 6135 RVA: 0x000E1337 File Offset: 0x000DF537
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginSlotById.LogPair = null;
			ConfigHonamiStoryPluginSlotById.HandleId = 0;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000E1345 File Offset: 0x000DF545
		public static void Init()
		{
			ConfigHonamiStoryPluginSlotById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginSlotById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginSlot` where Id=?");
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x000E1360 File Offset: 0x000DF560
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

		// Token: 0x04001BCF RID: 7119
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BD0 RID: 7120
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001BD1 RID: 7121
		private const string TABLE = "HonamiStoryPluginSlot";

		// Token: 0x04001BD2 RID: 7122
		private const string COMMAND = "select BinData from `HonamiStoryPluginSlot` where Id=?";

		// Token: 0x04001BD3 RID: 7123
		private const string KEY_PREFIX = "HonamiStoryPluginSlotById";

		// Token: 0x04001BD4 RID: 7124
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BD5 RID: 7125
		private static int HandleId;
	}
}
