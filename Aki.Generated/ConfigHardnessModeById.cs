using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E5 RID: 997
	public class ConfigHardnessModeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x000E1498 File Offset: 0x000DF698
		static ConfigHardnessModeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHardnessModeById.CreateStaticDefaultValue), new Action(ConfigHardnessModeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000E14B8 File Offset: 0x000DF6B8
		public static void CreateStaticDefaultValue()
		{
			ConfigHardnessModeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHardnessModeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_hardness_mode.db"),
				new ValueTuple<string, object>("文件", "b.白条.xlsx"),
				new ValueTuple<string, object>("表名", "HardnessMode"),
				new ValueTuple<string, object>("语句", "select BinData from `HardnessMode` where Id=?")
			});
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000E1537 File Offset: 0x000DF737
		public static void ResetStaticDefaultValue()
		{
			ConfigHardnessModeById.LogPair = null;
			ConfigHardnessModeById.HandleId = 0;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000E1545 File Offset: 0x000DF745
		public static void Init()
		{
			ConfigHardnessModeById.HandleId = ConfigCommon.InitDataStatement(ConfigHardnessModeById.HandleId, "db_hardness_mode.db", "select BinData from `HardnessMode` where Id=?");
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000E1560 File Offset: 0x000DF760
		public static HardnessMode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHardnessModeById.HandleId, ConfigHardnessModeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HardnessModeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HardnessMode?(HardnessMode.GetRootAsHardnessMode(configBuffer));
				}
			}
			ConfigHardnessModeById.LogPair.Clear();
			ConfigHardnessModeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHardnessModeById.HandleId, 1, p0Id, ConfigHardnessModeById.LogPair) || ConfigCommon.Step(ConfigHardnessModeById.HandleId, true, ConfigHardnessModeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHardnessModeById.HandleId, ConfigHardnessModeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHardnessModeById.HandleId, 0, ConfigHardnessModeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHardnessModeById.HandleId, ConfigHardnessModeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HardnessMode rootAsHardnessMode = HardnessMode.GetRootAsHardnessMode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HardnessModeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHardnessModeById.HandleId, ConfigHardnessModeById.LogPair);
			return new HardnessMode?(rootAsHardnessMode);
		}

		// Token: 0x04001B27 RID: 6951
		private const string DB = "db_hardness_mode.db";

		// Token: 0x04001B28 RID: 6952
		private const string FILE = "b.白条.xlsx";

		// Token: 0x04001B29 RID: 6953
		private const string TABLE = "HardnessMode";

		// Token: 0x04001B2A RID: 6954
		private const string COMMAND = "select BinData from `HardnessMode` where Id=?";

		// Token: 0x04001B2B RID: 6955
		private const string KEY_PREFIX = "HardnessModeById";

		// Token: 0x04001B2C RID: 6956
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B2D RID: 6957
		private static int HandleId;
	}
}
