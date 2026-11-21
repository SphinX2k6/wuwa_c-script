using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FA RID: 1018
	public class ConfigHonamiStoryEquipById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017E3 RID: 6115 RVA: 0x000E42D8 File Offset: 0x000E24D8
		static ConfigHonamiStoryEquipById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryEquipById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryEquipById.ResetStaticDefaultValue));
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x000E42F8 File Offset: 0x000E24F8
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

		// Token: 0x060017E5 RID: 6117 RVA: 0x000E4377 File Offset: 0x000E2577
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryEquipById.LogPair = null;
			ConfigHonamiStoryEquipById.HandleId = 0;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x000E4385 File Offset: 0x000E2585
		public static void Init()
		{
			ConfigHonamiStoryEquipById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryEquipById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryEquip` where Id=?");
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000E43A0 File Offset: 0x000E25A0
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

		// Token: 0x04001BBA RID: 7098
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BBB RID: 7099
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BBC RID: 7100
		private const string TABLE = "HonamiStoryEquip";

		// Token: 0x04001BBD RID: 7101
		private const string COMMAND = "select BinData from `HonamiStoryEquip` where Id=?";

		// Token: 0x04001BBE RID: 7102
		private const string KEY_PREFIX = "HonamiStoryEquipById";

		// Token: 0x04001BBF RID: 7103
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BC0 RID: 7104
		private static int HandleId;
	}
}
