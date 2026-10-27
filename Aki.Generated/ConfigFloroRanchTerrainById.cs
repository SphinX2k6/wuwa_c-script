using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000330 RID: 816
	public class ConfigFloroRanchTerrainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001325 RID: 4901 RVA: 0x000C5943 File Offset: 0x000C3B43
		static ConfigFloroRanchTerrainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTerrainById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTerrainById.ResetStaticDefaultValue));
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000C5964 File Offset: 0x000C3B64
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTerrainById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTerrainById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTerrain"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTerrain` where Id=?")
			});
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000C59E3 File Offset: 0x000C3BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTerrainById.LogPair = null;
			ConfigFloroRanchTerrainById.HandleId = 0;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000C59F1 File Offset: 0x000C3BF1
		public static void Init()
		{
			ConfigFloroRanchTerrainById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTerrainById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTerrain` where Id=?");
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000C5A0C File Offset: 0x000C3C0C
		public static FloroRanchTerrain? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTerrainById.HandleId, ConfigFloroRanchTerrainById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTerrainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchTerrain?(FloroRanchTerrain.GetRootAsFloroRanchTerrain(configBuffer));
				}
			}
			ConfigFloroRanchTerrainById.LogPair.Clear();
			ConfigFloroRanchTerrainById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTerrainById.HandleId, 1, p0Id, ConfigFloroRanchTerrainById.LogPair) || ConfigCommon.Step(ConfigFloroRanchTerrainById.HandleId, true, ConfigFloroRanchTerrainById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchTerrainById.HandleId, ConfigFloroRanchTerrainById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTerrainById.HandleId, 0, ConfigFloroRanchTerrainById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchTerrainById.HandleId, ConfigFloroRanchTerrainById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchTerrain rootAsFloroRanchTerrain = FloroRanchTerrain.GetRootAsFloroRanchTerrain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTerrainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchTerrainById.HandleId, ConfigFloroRanchTerrainById.LogPair);
			return new FloroRanchTerrain?(rootAsFloroRanchTerrain);
		}

		// Token: 0x04001634 RID: 5684
		private const string DB = "db_flororanch.db";

		// Token: 0x04001635 RID: 5685
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001636 RID: 5686
		private const string TABLE = "FloroRanchTerrain";

		// Token: 0x04001637 RID: 5687
		private const string COMMAND = "select BinData from `FloroRanchTerrain` where Id=?";

		// Token: 0x04001638 RID: 5688
		private const string KEY_PREFIX = "FloroRanchTerrainById";

		// Token: 0x04001639 RID: 5689
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400163A RID: 5690
		private static int HandleId;
	}
}
