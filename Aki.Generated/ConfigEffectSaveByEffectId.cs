using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026C RID: 620
	public class ConfigEffectSaveByEffectId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E8C RID: 3724 RVA: 0x000AF3F0 File Offset: 0x000AD5F0
		static ConfigEffectSaveByEffectId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSaveByEffectId.CreateStaticDefaultValue), new Action(ConfigEffectSaveByEffectId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000AF410 File Offset: 0x000AD610
		public static void CreateStaticDefaultValue()
		{
			ConfigEffectSaveByEffectId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEffectSaveByEffectId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_effectsave.db"),
				new ValueTuple<string, object>("文件", "t.特效保留.xlsx"),
				new ValueTuple<string, object>("表名", "EffectSave"),
				new ValueTuple<string, object>("语句", "select BinData from `EffectSave` where EffectId = ?")
			});
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x000AF48F File Offset: 0x000AD68F
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSaveByEffectId.LogPair = null;
			ConfigEffectSaveByEffectId.HandleId = 0;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000AF49D File Offset: 0x000AD69D
		public static void Init()
		{
			ConfigEffectSaveByEffectId.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSaveByEffectId.HandleId, "db_effectsave.db", "select BinData from `EffectSave` where EffectId = ?");
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000AF4B8 File Offset: 0x000AD6B8
		public static EffectSave? GetConfig(int p0EffectId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEffectSaveByEffectId.HandleId, ConfigEffectSaveByEffectId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EffectSaveByEffectId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EffectId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EffectSave?(EffectSave.GetRootAsEffectSave(configBuffer));
				}
			}
			ConfigEffectSaveByEffectId.LogPair.Clear();
			ConfigEffectSaveByEffectId.LogPair.Add(new ValueTuple<string, object>("EffectId", p0EffectId));
			if (!ConfigCommon.BindInt(ConfigEffectSaveByEffectId.HandleId, 1, p0EffectId, ConfigEffectSaveByEffectId.LogPair) || ConfigCommon.Step(ConfigEffectSaveByEffectId.HandleId, true, ConfigEffectSaveByEffectId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEffectSaveByEffectId.HandleId, ConfigEffectSaveByEffectId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEffectSaveByEffectId.HandleId, 0, ConfigEffectSaveByEffectId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEffectSaveByEffectId.HandleId, ConfigEffectSaveByEffectId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EffectSave rootAsEffectSave = EffectSave.GetRootAsEffectSave(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EffectSaveByEffectId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EffectId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEffectSaveByEffectId.HandleId, ConfigEffectSaveByEffectId.LogPair);
			return new EffectSave?(rootAsEffectSave);
		}

		// Token: 0x040010D8 RID: 4312
		private const string DB = "db_effectsave.db";

		// Token: 0x040010D9 RID: 4313
		private const string FILE = "t.特效保留.xlsx";

		// Token: 0x040010DA RID: 4314
		private const string TABLE = "EffectSave";

		// Token: 0x040010DB RID: 4315
		private const string COMMAND = "select BinData from `EffectSave` where EffectId = ?";

		// Token: 0x040010DC RID: 4316
		private const string KEY_PREFIX = "EffectSaveByEffectId";

		// Token: 0x040010DD RID: 4317
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010DE RID: 4318
		private static int HandleId;
	}
}
