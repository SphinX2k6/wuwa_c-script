using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000407 RID: 1031
	public class ConfigHonamiStoryScanMachineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001831 RID: 6193 RVA: 0x000E2893 File Offset: 0x000E0A93
		static ConfigHonamiStoryScanMachineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScanMachineById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScanMachineById.ResetStaticDefaultValue));
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000E28B4 File Offset: 0x000E0AB4
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryScanMachineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryScanMachineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryScanMachine"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryScanMachine` where Id=?")
			});
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000E2933 File Offset: 0x000E0B33
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScanMachineById.LogPair = null;
			ConfigHonamiStoryScanMachineById.HandleId = 0;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000E2941 File Offset: 0x000E0B41
		public static void Init()
		{
			ConfigHonamiStoryScanMachineById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScanMachineById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScanMachine` where Id=?");
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x000E295C File Offset: 0x000E0B5C
		public static HonamiStoryScanMachine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryScanMachineById.HandleId, ConfigHonamiStoryScanMachineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryScanMachineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryScanMachine?(HonamiStoryScanMachine.GetRootAsHonamiStoryScanMachine(configBuffer));
				}
			}
			ConfigHonamiStoryScanMachineById.LogPair.Clear();
			ConfigHonamiStoryScanMachineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryScanMachineById.HandleId, 1, p0Id, ConfigHonamiStoryScanMachineById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryScanMachineById.HandleId, true, ConfigHonamiStoryScanMachineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryScanMachineById.HandleId, ConfigHonamiStoryScanMachineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryScanMachineById.HandleId, 0, ConfigHonamiStoryScanMachineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryScanMachineById.HandleId, ConfigHonamiStoryScanMachineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryScanMachine rootAsHonamiStoryScanMachine = HonamiStoryScanMachine.GetRootAsHonamiStoryScanMachine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryScanMachineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryScanMachineById.HandleId, ConfigHonamiStoryScanMachineById.LogPair);
			return new HonamiStoryScanMachine?(rootAsHonamiStoryScanMachine);
		}

		// Token: 0x04001C15 RID: 7189
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C16 RID: 7190
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001C17 RID: 7191
		private const string TABLE = "HonamiStoryScanMachine";

		// Token: 0x04001C18 RID: 7192
		private const string COMMAND = "select BinData from `HonamiStoryScanMachine` where Id=?";

		// Token: 0x04001C19 RID: 7193
		private const string KEY_PREFIX = "HonamiStoryScanMachineById";

		// Token: 0x04001C1A RID: 7194
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C1B RID: 7195
		private static int HandleId;
	}
}
