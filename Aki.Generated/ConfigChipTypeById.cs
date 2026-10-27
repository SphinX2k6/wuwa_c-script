using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000160 RID: 352
	public class ConfigChipTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x000881DF File Offset: 0x000863DF
		static ConfigChipTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipTypeById.CreateStaticDefaultValue), new Action(ConfigChipTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00088200 File Offset: 0x00086400
		public static void CreateStaticDefaultValue()
		{
			ConfigChipTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChipTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChipType"),
				new ValueTuple<string, object>("语句", "select BinData from `ChipType` where Id=?")
			});
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0008827F File Offset: 0x0008647F
		public static void ResetStaticDefaultValue()
		{
			ConfigChipTypeById.LogPair = null;
			ConfigChipTypeById.HandleId = 0;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0008828D File Offset: 0x0008648D
		public static void Init()
		{
			ConfigChipTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigChipTypeById.HandleId, "db_handbook.db", "select BinData from `ChipType` where Id=?");
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000882A8 File Offset: 0x000864A8
		public static ChipType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChipType?(ChipType.GetRootAsChipType(configBuffer));
				}
			}
			ConfigChipTypeById.LogPair.Clear();
			ConfigChipTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChipTypeById.HandleId, 1, p0Id, ConfigChipTypeById.LogPair) || ConfigCommon.Step(ConfigChipTypeById.HandleId, true, ConfigChipTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChipTypeById.HandleId, 0, ConfigChipTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChipType rootAsChipType = ChipType.GetRootAsChipType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChipTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChipTypeById.HandleId, ConfigChipTypeById.LogPair);
			return new ChipType?(rootAsChipType);
		}

		// Token: 0x04000984 RID: 2436
		private const string DB = "db_handbook.db";

		// Token: 0x04000985 RID: 2437
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04000986 RID: 2438
		private const string TABLE = "ChipType";

		// Token: 0x04000987 RID: 2439
		private const string COMMAND = "select BinData from `ChipType` where Id=?";

		// Token: 0x04000988 RID: 2440
		private const string KEY_PREFIX = "ChipTypeById";

		// Token: 0x04000989 RID: 2441
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400098A RID: 2442
		private static int HandleId;
	}
}
