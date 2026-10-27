using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000751 RID: 1873
	public class ConfigPrefabConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BF7 RID: 11255 RVA: 0x00151EC7 File Offset: 0x001500C7
		static ConfigPrefabConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabConfigById.CreateStaticDefaultValue), new Action(ConfigPrefabConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00151EE8 File Offset: 0x001500E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPrefabConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPrefabConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_prefab.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/Prefab.csv"),
				new ValueTuple<string, object>("表名", "PrefabConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PrefabConfig` where Id=?")
			});
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00151F67 File Offset: 0x00150167
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabConfigById.LogPair = null;
			ConfigPrefabConfigById.HandleId = 0;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00151F75 File Offset: 0x00150175
		public static void Init()
		{
			ConfigPrefabConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabConfigById.HandleId, "db_prefab.db", "select BinData from `PrefabConfig` where Id=?");
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00151F90 File Offset: 0x00150190
		public static PrefabConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPrefabConfigById.HandleId, ConfigPrefabConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrefabConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PrefabConfig?(PrefabConfig.GetRootAsPrefabConfig(configBuffer));
				}
			}
			ConfigPrefabConfigById.LogPair.Clear();
			ConfigPrefabConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPrefabConfigById.HandleId, 1, p0Id, ConfigPrefabConfigById.LogPair) || ConfigCommon.Step(ConfigPrefabConfigById.HandleId, true, ConfigPrefabConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPrefabConfigById.HandleId, ConfigPrefabConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPrefabConfigById.HandleId, 0, ConfigPrefabConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPrefabConfigById.HandleId, ConfigPrefabConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PrefabConfig rootAsPrefabConfig = PrefabConfig.GetRootAsPrefabConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrefabConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPrefabConfigById.HandleId, ConfigPrefabConfigById.LogPair);
			return new PrefabConfig?(rootAsPrefabConfig);
		}

		// Token: 0x0400331D RID: 13085
		private const string DB = "db_prefab.db";

		// Token: 0x0400331E RID: 13086
		private const string FILE = "UniverseEditor/Entity/Prefab.csv";

		// Token: 0x0400331F RID: 13087
		private const string TABLE = "PrefabConfig";

		// Token: 0x04003320 RID: 13088
		private const string COMMAND = "select BinData from `PrefabConfig` where Id=?";

		// Token: 0x04003321 RID: 13089
		private const string KEY_PREFIX = "PrefabConfigById";

		// Token: 0x04003322 RID: 13090
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003323 RID: 13091
		private static int HandleId;
	}
}
