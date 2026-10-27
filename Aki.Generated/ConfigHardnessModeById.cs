using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CF RID: 975
	public class ConfigHardnessModeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016E1 RID: 5857 RVA: 0x000DAD44 File Offset: 0x000D8F44
		static ConfigHardnessModeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHardnessModeById.CreateStaticDefaultValue), new Action(ConfigHardnessModeById.ResetStaticDefaultValue));
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x000DAD64 File Offset: 0x000D8F64
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

		// Token: 0x060016E3 RID: 5859 RVA: 0x000DADE3 File Offset: 0x000D8FE3
		public static void ResetStaticDefaultValue()
		{
			ConfigHardnessModeById.LogPair = null;
			ConfigHardnessModeById.HandleId = 0;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x000DADF1 File Offset: 0x000D8FF1
		public static void Init()
		{
			ConfigHardnessModeById.HandleId = ConfigCommon.InitDataStatement(ConfigHardnessModeById.HandleId, "db_hardness_mode.db", "select BinData from `HardnessMode` where Id=?");
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000DAE0C File Offset: 0x000D900C
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

		// Token: 0x04001A8D RID: 6797
		private const string DB = "db_hardness_mode.db";

		// Token: 0x04001A8E RID: 6798
		private const string FILE = "b.白条.xlsx";

		// Token: 0x04001A8F RID: 6799
		private const string TABLE = "HardnessMode";

		// Token: 0x04001A90 RID: 6800
		private const string COMMAND = "select BinData from `HardnessMode` where Id=?";

		// Token: 0x04001A91 RID: 6801
		private const string KEY_PREFIX = "HardnessModeById";

		// Token: 0x04001A92 RID: 6802
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A93 RID: 6803
		private static int HandleId;
	}
}
