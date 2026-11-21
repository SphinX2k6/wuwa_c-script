using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026D RID: 621
	public class ConfigEffectSaveByEffectPath : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E92 RID: 3730 RVA: 0x000AF638 File Offset: 0x000AD838
		static ConfigEffectSaveByEffectPath()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSaveByEffectPath.CreateStaticDefaultValue), new Action(ConfigEffectSaveByEffectPath.ResetStaticDefaultValue));
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000AF658 File Offset: 0x000AD858
		public static void CreateStaticDefaultValue()
		{
			ConfigEffectSaveByEffectPath.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEffectSaveByEffectPath.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_effectsave.db"),
				new ValueTuple<string, object>("文件", "t.特效保留.xlsx"),
				new ValueTuple<string, object>("表名", "EffectSave"),
				new ValueTuple<string, object>("语句", "select BinData from `EffectSave` where EffectPath = ?")
			});
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000AF6D7 File Offset: 0x000AD8D7
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSaveByEffectPath.LogPair = null;
			ConfigEffectSaveByEffectPath.HandleId = 0;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000AF6E5 File Offset: 0x000AD8E5
		public static void Init()
		{
			ConfigEffectSaveByEffectPath.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSaveByEffectPath.HandleId, "db_effectsave.db", "select BinData from `EffectSave` where EffectPath = ?");
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000AF700 File Offset: 0x000AD900
		public static EffectSave? GetConfig(string p0EffectPath, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEffectSaveByEffectPath.HandleId, ConfigEffectSaveByEffectPath.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("EffectSaveByEffectPath#" + p0EffectPath);
				if (configBuffer != null)
				{
					return new EffectSave?(EffectSave.GetRootAsEffectSave(configBuffer));
				}
			}
			ConfigEffectSaveByEffectPath.LogPair.Clear();
			ConfigEffectSaveByEffectPath.LogPair.Add(new ValueTuple<string, object>("EffectPath", p0EffectPath));
			if (!ConfigCommon.BindString(ConfigEffectSaveByEffectPath.HandleId, 1, p0EffectPath, ConfigEffectSaveByEffectPath.LogPair) || ConfigCommon.Step(ConfigEffectSaveByEffectPath.HandleId, true, ConfigEffectSaveByEffectPath.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEffectSaveByEffectPath.HandleId, ConfigEffectSaveByEffectPath.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEffectSaveByEffectPath.HandleId, 0, ConfigEffectSaveByEffectPath.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEffectSaveByEffectPath.HandleId, ConfigEffectSaveByEffectPath.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EffectSave rootAsEffectSave = EffectSave.GetRootAsEffectSave(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("EffectSaveByEffectPath#" + p0EffectPath, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEffectSaveByEffectPath.HandleId, ConfigEffectSaveByEffectPath.LogPair);
			return new EffectSave?(rootAsEffectSave);
		}

		// Token: 0x040010DF RID: 4319
		private const string DB = "db_effectsave.db";

		// Token: 0x040010E0 RID: 4320
		private const string FILE = "t.特效保留.xlsx";

		// Token: 0x040010E1 RID: 4321
		private const string TABLE = "EffectSave";

		// Token: 0x040010E2 RID: 4322
		private const string COMMAND = "select BinData from `EffectSave` where EffectPath = ?";

		// Token: 0x040010E3 RID: 4323
		private const string KEY_PREFIX = "EffectSaveByEffectPath";

		// Token: 0x040010E4 RID: 4324
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010E5 RID: 4325
		private static int HandleId;
	}
}
