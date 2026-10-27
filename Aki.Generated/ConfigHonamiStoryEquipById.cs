using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E4 RID: 996
	public class ConfigHonamiStoryEquipById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x000DDB84 File Offset: 0x000DBD84
		static ConfigHonamiStoryEquipById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryEquipById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryEquipById.ResetStaticDefaultValue));
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000DDBA4 File Offset: 0x000DBDA4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryEquipById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryEquipById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryEquip"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryEquip` where Id=?")
			});
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000DDC23 File Offset: 0x000DBE23
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryEquipById.LogPair = null;
			ConfigHonamiStoryEquipById.HandleId = 0;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000DDC31 File Offset: 0x000DBE31
		public static void Init()
		{
			ConfigHonamiStoryEquipById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryEquipById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryEquip` where Id=?");
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000DDC4C File Offset: 0x000DBE4C
		public static HonamiStoryEquip? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryEquipById.HandleId, ConfigHonamiStoryEquipById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryEquipById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryEquip?(HonamiStoryEquip.GetRootAsHonamiStoryEquip(configBuffer));
				}
			}
			ConfigHonamiStoryEquipById.LogPair.Clear();
			ConfigHonamiStoryEquipById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryEquipById.HandleId, 1, p0Id, ConfigHonamiStoryEquipById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryEquipById.HandleId, true, ConfigHonamiStoryEquipById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryEquipById.HandleId, ConfigHonamiStoryEquipById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryEquipById.HandleId, 0, ConfigHonamiStoryEquipById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryEquipById.HandleId, ConfigHonamiStoryEquipById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryEquip rootAsHonamiStoryEquip = HonamiStoryEquip.GetRootAsHonamiStoryEquip(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryEquipById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryEquipById.HandleId, ConfigHonamiStoryEquipById.LogPair);
			return new HonamiStoryEquip?(rootAsHonamiStoryEquip);
		}

		// Token: 0x04001B20 RID: 6944
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B21 RID: 6945
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001B22 RID: 6946
		private const string TABLE = "HonamiStoryEquip";

		// Token: 0x04001B23 RID: 6947
		private const string COMMAND = "select BinData from `HonamiStoryEquip` where Id=?";

		// Token: 0x04001B24 RID: 6948
		private const string KEY_PREFIX = "HonamiStoryEquipById";

		// Token: 0x04001B25 RID: 6949
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B26 RID: 6950
		private static int HandleId;
	}
}
