using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000259 RID: 601
	public class ConfigEffectSaveByEffectPath : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x000A9374 File Offset: 0x000A7574
		static ConfigEffectSaveByEffectPath()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSaveByEffectPath.CreateStaticDefaultValue), new Action(ConfigEffectSaveByEffectPath.ResetStaticDefaultValue));
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x000A9394 File Offset: 0x000A7594
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

		// Token: 0x06000E1C RID: 3612 RVA: 0x000A9413 File Offset: 0x000A7613
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSaveByEffectPath.LogPair = null;
			ConfigEffectSaveByEffectPath.HandleId = 0;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000A9421 File Offset: 0x000A7621
		public static void Init()
		{
			ConfigEffectSaveByEffectPath.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSaveByEffectPath.HandleId, "db_effectsave.db", "select BinData from `EffectSave` where EffectPath = ?");
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000A943C File Offset: 0x000A763C
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

		// Token: 0x04001053 RID: 4179
		private const string DB = "db_effectsave.db";

		// Token: 0x04001054 RID: 4180
		private const string FILE = "t.特效保留.xlsx";

		// Token: 0x04001055 RID: 4181
		private const string TABLE = "EffectSave";

		// Token: 0x04001056 RID: 4182
		private const string COMMAND = "select BinData from `EffectSave` where EffectPath = ?";

		// Token: 0x04001057 RID: 4183
		private const string KEY_PREFIX = "EffectSaveByEffectPath";

		// Token: 0x04001058 RID: 4184
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001059 RID: 4185
		private static int HandleId;
	}
}
