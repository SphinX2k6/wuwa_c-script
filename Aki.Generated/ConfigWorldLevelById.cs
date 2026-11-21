using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6F RID: 2927
	public class ConfigWorldLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044AF RID: 17583 RVA: 0x001E1C10 File Offset: 0x001DFE10
		static ConfigWorldLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldLevelById.CreateStaticDefaultValue), new Action(ConfigWorldLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x001E1C30 File Offset: 0x001DFE30
		public static void CreateStaticDefaultValue()
		{
			ConfigWorldLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWorldLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_worldlevel.db"),
				new ValueTuple<string, object>("文件", "s.世界等级.xlsx"),
				new ValueTuple<string, object>("表名", "WorldLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `WorldLevel` where Id = ?")
			});
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x001E1CAF File Offset: 0x001DFEAF
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldLevelById.LogPair = null;
			ConfigWorldLevelById.HandleId = 0;
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x001E1CBD File Offset: 0x001DFEBD
		public static void Init()
		{
			ConfigWorldLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigWorldLevelById.HandleId, "db_worldlevel.db", "select BinData from `WorldLevel` where Id = ?");
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x001E1CD8 File Offset: 0x001DFED8
		public static WorldLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WorldLevel?(WorldLevel.GetRootAsWorldLevel(configBuffer));
				}
			}
			ConfigWorldLevelById.LogPair.Clear();
			ConfigWorldLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWorldLevelById.HandleId, 1, p0Id, ConfigWorldLevelById.LogPair) || ConfigCommon.Step(ConfigWorldLevelById.HandleId, true, ConfigWorldLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWorldLevelById.HandleId, 0, ConfigWorldLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WorldLevel rootAsWorldLevel = WorldLevel.GetRootAsWorldLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair);
			return new WorldLevel?(rootAsWorldLevel);
		}

		// Token: 0x04004FEF RID: 20463
		private const string DB = "db_worldlevel.db";

		// Token: 0x04004FF0 RID: 20464
		private const string FILE = "s.世界等级.xlsx";

		// Token: 0x04004FF1 RID: 20465
		private const string TABLE = "WorldLevel";

		// Token: 0x04004FF2 RID: 20466
		private const string COMMAND = "select BinData from `WorldLevel` where Id = ?";

		// Token: 0x04004FF3 RID: 20467
		private const string KEY_PREFIX = "WorldLevelById";

		// Token: 0x04004FF4 RID: 20468
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FF5 RID: 20469
		private static int HandleId;
	}
}
