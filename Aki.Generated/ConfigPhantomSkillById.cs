using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B3 RID: 1715
	public class ConfigPhantomSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002842 RID: 10306 RVA: 0x0013D3C4 File Offset: 0x0013B5C4
		static ConfigPhantomSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSkillById.CreateStaticDefaultValue), new Action(ConfigPhantomSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0013D3E4 File Offset: 0x0013B5E4
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

		// Token: 0x06002844 RID: 10308 RVA: 0x0013D463 File Offset: 0x0013B663
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSkillById.LogPair = null;
			ConfigPhantomSkillById.HandleId = 0;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0013D471 File Offset: 0x0013B671
		public static void Init()
		{
			ConfigPhantomSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSkillById.HandleId, "db_phantom.db", "select BinData from `PhantomSkill` where Id=?");
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0013D48C File Offset: 0x0013B68C
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

		// Token: 0x04002ECB RID: 11979
		private const string DB = "db_phantom.db";

		// Token: 0x04002ECC RID: 11980
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002ECD RID: 11981
		private const string TABLE = "PhantomSkill";

		// Token: 0x04002ECE RID: 11982
		private const string COMMAND = "select BinData from `PhantomSkill` where Id=?";

		// Token: 0x04002ECF RID: 11983
		private const string KEY_PREFIX = "PhantomSkillById";

		// Token: 0x04002ED0 RID: 11984
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ED1 RID: 11985
		private static int HandleId;
	}
}
