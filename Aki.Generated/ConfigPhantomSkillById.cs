using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CB RID: 1739
	public class ConfigPhantomSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028D2 RID: 10450 RVA: 0x00143E40 File Offset: 0x00142040
		static ConfigPhantomSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSkillById.CreateStaticDefaultValue), new Action(ConfigPhantomSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00143E60 File Offset: 0x00142060
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomSkill` where Id=?")
			});
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00143EDF File Offset: 0x001420DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSkillById.LogPair = null;
			ConfigPhantomSkillById.HandleId = 0;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00143EED File Offset: 0x001420ED
		public static void Init()
		{
			ConfigPhantomSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSkillById.HandleId, "db_phantom.db", "select BinData from `PhantomSkill` where Id=?");
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00143F08 File Offset: 0x00142108
		public static PhantomSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomSkillById.HandleId, ConfigPhantomSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomSkill?(PhantomSkill.GetRootAsPhantomSkill(configBuffer));
				}
			}
			ConfigPhantomSkillById.LogPair.Clear();
			ConfigPhantomSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomSkillById.HandleId, 1, p0Id, ConfigPhantomSkillById.LogPair) || ConfigCommon.Step(ConfigPhantomSkillById.HandleId, true, ConfigPhantomSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomSkillById.HandleId, ConfigPhantomSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomSkillById.HandleId, 0, ConfigPhantomSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomSkillById.HandleId, ConfigPhantomSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomSkill rootAsPhantomSkill = PhantomSkill.GetRootAsPhantomSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomSkillById.HandleId, ConfigPhantomSkillById.LogPair);
			return new PhantomSkill?(rootAsPhantomSkill);
		}

		// Token: 0x04002F73 RID: 12147
		private const string DB = "db_phantom.db";

		// Token: 0x04002F74 RID: 12148
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F75 RID: 12149
		private const string TABLE = "PhantomSkill";

		// Token: 0x04002F76 RID: 12150
		private const string COMMAND = "select BinData from `PhantomSkill` where Id=?";

		// Token: 0x04002F77 RID: 12151
		private const string KEY_PREFIX = "PhantomSkillById";

		// Token: 0x04002F78 RID: 12152
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F79 RID: 12153
		private static int HandleId;
	}
}
