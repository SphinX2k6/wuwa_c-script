using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CA RID: 202
	public class ConfigAvgShowPrefabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x000781D0 File Offset: 0x000763D0
		static ConfigAvgShowPrefabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgShowPrefabById.CreateStaticDefaultValue), new Action(ConfigAvgShowPrefabById.ResetStaticDefaultValue));
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000781F0 File Offset: 0x000763F0
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgShowPrefabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgShowPrefabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avgshowprefab.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.Avg展示Prefab/*.csv*"),
				new ValueTuple<string, object>("表名", "AvgShowPrefab"),
				new ValueTuple<string, object>("语句", "select BinData from `AvgShowPrefab` where Id=?")
			});
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0007826F File Offset: 0x0007646F
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgShowPrefabById.LogPair = null;
			ConfigAvgShowPrefabById.HandleId = 0;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0007827D File Offset: 0x0007647D
		public static void Init()
		{
			ConfigAvgShowPrefabById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgShowPrefabById.HandleId, "db_avgshowprefab.db", "select BinData from `AvgShowPrefab` where Id=?");
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00078298 File Offset: 0x00076498
		public static AvgShowPrefab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvgShowPrefabById.HandleId, ConfigAvgShowPrefabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgShowPrefabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvgShowPrefab?(AvgShowPrefab.GetRootAsAvgShowPrefab(configBuffer));
				}
			}
			ConfigAvgShowPrefabById.LogPair.Clear();
			ConfigAvgShowPrefabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvgShowPrefabById.HandleId, 1, p0Id, ConfigAvgShowPrefabById.LogPair) || ConfigCommon.Step(ConfigAvgShowPrefabById.HandleId, true, ConfigAvgShowPrefabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvgShowPrefabById.HandleId, ConfigAvgShowPrefabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvgShowPrefabById.HandleId, 0, ConfigAvgShowPrefabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvgShowPrefabById.HandleId, ConfigAvgShowPrefabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvgShowPrefab rootAsAvgShowPrefab = AvgShowPrefab.GetRootAsAvgShowPrefab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgShowPrefabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvgShowPrefabById.HandleId, ConfigAvgShowPrefabById.LogPair);
			return new AvgShowPrefab?(rootAsAvgShowPrefab);
		}

		// Token: 0x0400056A RID: 1386
		private const string DB = "db_avgshowprefab.db";

		// Token: 0x0400056B RID: 1387
		private const string FILE = "k.可视化编辑/c.Csv/a.Avg展示Prefab/*.csv*";

		// Token: 0x0400056C RID: 1388
		private const string TABLE = "AvgShowPrefab";

		// Token: 0x0400056D RID: 1389
		private const string COMMAND = "select BinData from `AvgShowPrefab` where Id=?";

		// Token: 0x0400056E RID: 1390
		private const string KEY_PREFIX = "AvgShowPrefabById";

		// Token: 0x0400056F RID: 1391
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000570 RID: 1392
		private static int HandleId;
	}
}
