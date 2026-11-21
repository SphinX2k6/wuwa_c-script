using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000203 RID: 515
	public class ConfigDangoSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C15 RID: 3093 RVA: 0x000A1944 File Offset: 0x0009FB44
		static ConfigDangoSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoSkillById.CreateStaticDefaultValue), new Action(ConfigDangoSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000A1964 File Offset: 0x0009FB64
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dango.db"),
				new ValueTuple<string, object>("文件", "t.团子.xlsx"),
				new ValueTuple<string, object>("表名", "DangoSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoSkill` where Id=?")
			});
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000A19E3 File Offset: 0x0009FBE3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoSkillById.LogPair = null;
			ConfigDangoSkillById.HandleId = 0;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000A19F1 File Offset: 0x0009FBF1
		public static void Init()
		{
			ConfigDangoSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoSkillById.HandleId, "db_dango.db", "select BinData from `DangoSkill` where Id=?");
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000A1A0C File Offset: 0x0009FC0C
		public static DangoSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoSkill?(DangoSkill.GetRootAsDangoSkill(configBuffer));
				}
			}
			ConfigDangoSkillById.LogPair.Clear();
			ConfigDangoSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoSkillById.HandleId, 1, p0Id, ConfigDangoSkillById.LogPair) || ConfigCommon.Step(ConfigDangoSkillById.HandleId, true, ConfigDangoSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoSkillById.HandleId, 0, ConfigDangoSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoSkill rootAsDangoSkill = DangoSkill.GetRootAsDangoSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoSkillById.HandleId, ConfigDangoSkillById.LogPair);
			return new DangoSkill?(rootAsDangoSkill);
		}

		// Token: 0x04000DF9 RID: 3577
		private const string DB = "db_dango.db";

		// Token: 0x04000DFA RID: 3578
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000DFB RID: 3579
		private const string TABLE = "DangoSkill";

		// Token: 0x04000DFC RID: 3580
		private const string COMMAND = "select BinData from `DangoSkill` where Id=?";

		// Token: 0x04000DFD RID: 3581
		private const string KEY_PREFIX = "DangoSkillById";

		// Token: 0x04000DFE RID: 3582
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DFF RID: 3583
		private static int HandleId;
	}
}
