using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000204 RID: 516
	public class ConfigDangoSkillEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C1B RID: 3099 RVA: 0x000A1B8C File Offset: 0x0009FD8C
		static ConfigDangoSkillEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoSkillEffectById.CreateStaticDefaultValue), new Action(ConfigDangoSkillEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000A1BAC File Offset: 0x0009FDAC
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoSkillEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoSkillEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dango.db"),
				new ValueTuple<string, object>("文件", "t.团子.xlsx"),
				new ValueTuple<string, object>("表名", "DangoSkillEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoSkillEffect` where Id=?")
			});
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000A1C2B File Offset: 0x0009FE2B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoSkillEffectById.LogPair = null;
			ConfigDangoSkillEffectById.HandleId = 0;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000A1C39 File Offset: 0x0009FE39
		public static void Init()
		{
			ConfigDangoSkillEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoSkillEffectById.HandleId, "db_dango.db", "select BinData from `DangoSkillEffect` where Id=?");
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000A1C54 File Offset: 0x0009FE54
		public static DangoSkillEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoSkillEffectById.HandleId, ConfigDangoSkillEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoSkillEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoSkillEffect?(DangoSkillEffect.GetRootAsDangoSkillEffect(configBuffer));
				}
			}
			ConfigDangoSkillEffectById.LogPair.Clear();
			ConfigDangoSkillEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoSkillEffectById.HandleId, 1, p0Id, ConfigDangoSkillEffectById.LogPair) || ConfigCommon.Step(ConfigDangoSkillEffectById.HandleId, true, ConfigDangoSkillEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoSkillEffectById.HandleId, ConfigDangoSkillEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoSkillEffectById.HandleId, 0, ConfigDangoSkillEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoSkillEffectById.HandleId, ConfigDangoSkillEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoSkillEffect rootAsDangoSkillEffect = DangoSkillEffect.GetRootAsDangoSkillEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoSkillEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoSkillEffectById.HandleId, ConfigDangoSkillEffectById.LogPair);
			return new DangoSkillEffect?(rootAsDangoSkillEffect);
		}

		// Token: 0x04000E00 RID: 3584
		private const string DB = "db_dango.db";

		// Token: 0x04000E01 RID: 3585
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000E02 RID: 3586
		private const string TABLE = "DangoSkillEffect";

		// Token: 0x04000E03 RID: 3587
		private const string COMMAND = "select BinData from `DangoSkillEffect` where Id=?";

		// Token: 0x04000E04 RID: 3588
		private const string KEY_PREFIX = "DangoSkillEffectById";

		// Token: 0x04000E05 RID: 3589
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E06 RID: 3590
		private static int HandleId;
	}
}
