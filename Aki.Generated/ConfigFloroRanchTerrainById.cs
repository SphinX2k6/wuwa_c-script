using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000345 RID: 837
	public class ConfigFloroRanchTerrainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x000CBE4F File Offset: 0x000CA04F
		static ConfigFloroRanchTerrainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTerrainById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTerrainById.ResetStaticDefaultValue));
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x000CBE70 File Offset: 0x000CA070
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

		// Token: 0x060013A5 RID: 5029 RVA: 0x000CBEEF File Offset: 0x000CA0EF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTerrainById.LogPair = null;
			ConfigFloroRanchTerrainById.HandleId = 0;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x000CBEFD File Offset: 0x000CA0FD
		public static void Init()
		{
			ConfigFloroRanchTerrainById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTerrainById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTerrain` where Id=?");
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000CBF18 File Offset: 0x000CA118
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

		// Token: 0x040016C7 RID: 5831
		private const string DB = "db_flororanch.db";

		// Token: 0x040016C8 RID: 5832
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016C9 RID: 5833
		private const string TABLE = "FloroRanchTerrain";

		// Token: 0x040016CA RID: 5834
		private const string COMMAND = "select BinData from `FloroRanchTerrain` where Id=?";

		// Token: 0x040016CB RID: 5835
		private const string KEY_PREFIX = "FloroRanchTerrainById";

		// Token: 0x040016CC RID: 5836
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016CD RID: 5837
		private static int HandleId;
	}
}
