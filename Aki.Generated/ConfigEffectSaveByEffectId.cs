using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000258 RID: 600
	public class ConfigEffectSaveByEffectId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x000A912C File Offset: 0x000A732C
		static ConfigEffectSaveByEffectId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSaveByEffectId.CreateStaticDefaultValue), new Action(ConfigEffectSaveByEffectId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000A914C File Offset: 0x000A734C
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

		// Token: 0x06000E16 RID: 3606 RVA: 0x000A91CB File Offset: 0x000A73CB
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSaveByEffectId.LogPair = null;
			ConfigEffectSaveByEffectId.HandleId = 0;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000A91D9 File Offset: 0x000A73D9
		public static void Init()
		{
			ConfigEffectSaveByEffectId.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSaveByEffectId.HandleId, "db_effectsave.db", "select BinData from `EffectSave` where EffectId = ?");
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000A91F4 File Offset: 0x000A73F4
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

		// Token: 0x0400104C RID: 4172
		private const string DB = "db_effectsave.db";

		// Token: 0x0400104D RID: 4173
		private const string FILE = "t.特效保留.xlsx";

		// Token: 0x0400104E RID: 4174
		private const string TABLE = "EffectSave";

		// Token: 0x0400104F RID: 4175
		private const string COMMAND = "select BinData from `EffectSave` where EffectId = ?";

		// Token: 0x04001050 RID: 4176
		private const string KEY_PREFIX = "EffectSaveByEffectId";

		// Token: 0x04001051 RID: 4177
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001052 RID: 4178
		private static int HandleId;
	}
}
