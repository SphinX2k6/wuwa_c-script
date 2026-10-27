using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F2 RID: 498
	public class ConfigDangoSkillEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BAF RID: 2991 RVA: 0x0009BC54 File Offset: 0x00099E54
		static ConfigDangoSkillEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoSkillEffectById.CreateStaticDefaultValue), new Action(ConfigDangoSkillEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0009BC74 File Offset: 0x00099E74
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

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0009BCF3 File Offset: 0x00099EF3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoSkillEffectById.LogPair = null;
			ConfigDangoSkillEffectById.HandleId = 0;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0009BD01 File Offset: 0x00099F01
		public static void Init()
		{
			ConfigDangoSkillEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoSkillEffectById.HandleId, "db_dango.db", "select BinData from `DangoSkillEffect` where Id=?");
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0009BD1C File Offset: 0x00099F1C
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

		// Token: 0x04000D82 RID: 3458
		private const string DB = "db_dango.db";

		// Token: 0x04000D83 RID: 3459
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000D84 RID: 3460
		private const string TABLE = "DangoSkillEffect";

		// Token: 0x04000D85 RID: 3461
		private const string COMMAND = "select BinData from `DangoSkillEffect` where Id=?";

		// Token: 0x04000D86 RID: 3462
		private const string KEY_PREFIX = "DangoSkillEffectById";

		// Token: 0x04000D87 RID: 3463
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D88 RID: 3464
		private static int HandleId;
	}
}
