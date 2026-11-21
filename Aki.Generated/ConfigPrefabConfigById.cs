using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000769 RID: 1897
	public class ConfigPrefabConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C87 RID: 11399 RVA: 0x00158943 File Offset: 0x00156B43
		static ConfigPrefabConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabConfigById.CreateStaticDefaultValue), new Action(ConfigPrefabConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00158964 File Offset: 0x00156B64
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

		// Token: 0x06002C89 RID: 11401 RVA: 0x001589E3 File Offset: 0x00156BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabConfigById.LogPair = null;
			ConfigPrefabConfigById.HandleId = 0;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x001589F1 File Offset: 0x00156BF1
		public static void Init()
		{
			ConfigPrefabConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabConfigById.HandleId, "db_prefab.db", "select BinData from `PrefabConfig` where Id=?");
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00158A0C File Offset: 0x00156C0C
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

		// Token: 0x040033C5 RID: 13253
		private const string DB = "db_prefab.db";

		// Token: 0x040033C6 RID: 13254
		private const string FILE = "UniverseEditor/Entity/Prefab.csv";

		// Token: 0x040033C7 RID: 13255
		private const string TABLE = "PrefabConfig";

		// Token: 0x040033C8 RID: 13256
		private const string COMMAND = "select BinData from `PrefabConfig` where Id=?";

		// Token: 0x040033C9 RID: 13257
		private const string KEY_PREFIX = "PrefabConfigById";

		// Token: 0x040033CA RID: 13258
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033CB RID: 13259
		private static int HandleId;
	}
}
