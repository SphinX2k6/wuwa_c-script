using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041D RID: 1053
	public class ConfigHonamiStoryScanMachineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018B5 RID: 6325 RVA: 0x000E8FE7 File Offset: 0x000E71E7
		static ConfigHonamiStoryScanMachineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScanMachineById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScanMachineById.ResetStaticDefaultValue));
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000E9008 File Offset: 0x000E7208
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

		// Token: 0x060018B7 RID: 6327 RVA: 0x000E9087 File Offset: 0x000E7287
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScanMachineById.LogPair = null;
			ConfigHonamiStoryScanMachineById.HandleId = 0;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000E9095 File Offset: 0x000E7295
		public static void Init()
		{
			ConfigHonamiStoryScanMachineById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScanMachineById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScanMachine` where Id=?");
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000E90B0 File Offset: 0x000E72B0
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

		// Token: 0x04001CAF RID: 7343
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CB0 RID: 7344
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001CB1 RID: 7345
		private const string TABLE = "HonamiStoryScanMachine";

		// Token: 0x04001CB2 RID: 7346
		private const string COMMAND = "select BinData from `HonamiStoryScanMachine` where Id=?";

		// Token: 0x04001CB3 RID: 7347
		private const string KEY_PREFIX = "HonamiStoryScanMachineById";

		// Token: 0x04001CB4 RID: 7348
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CB5 RID: 7349
		private static int HandleId;
	}
}
