using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B4 RID: 1716
	public class ConfigPhantomSkillByPhantomSkillId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002848 RID: 10312 RVA: 0x0013D60C File Offset: 0x0013B80C
		static ConfigPhantomSkillByPhantomSkillId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSkillByPhantomSkillId.CreateStaticDefaultValue), new Action(ConfigPhantomSkillByPhantomSkillId.ResetStaticDefaultValue));
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0013D62C File Offset: 0x0013B82C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomSkillByPhantomSkillId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomSkillByPhantomSkillId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomSkill` where PhantomSkillId=?")
			});
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x0013D6AB File Offset: 0x0013B8AB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSkillByPhantomSkillId.LogPair = null;
			ConfigPhantomSkillByPhantomSkillId.HandleId = 0;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0013D6B9 File Offset: 0x0013B8B9
		public static void Init()
		{
			ConfigPhantomSkillByPhantomSkillId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSkillByPhantomSkillId.HandleId, "db_phantom.db", "select BinData from `PhantomSkill` where PhantomSkillId=?");
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0013D6D4 File Offset: 0x0013B8D4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomSkill> GetConfigList(int p0PhantomSkillId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomSkillByPhantomSkillId.HandleId, ConfigPhantomSkillByPhantomSkillId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSkillByPhantomSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomSkillId);
				IReadOnlyList<PhantomSkill> readOnlyList = (IReadOnlyList<PhantomSkill>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomSkillByPhantomSkillId.LogPair.Clear();
			ConfigPhantomSkillByPhantomSkillId.LogPair.Add(new ValueTuple<string, object>("PhantomSkillId", p0PhantomSkillId));
			if (!ConfigCommon.BindInt(ConfigPhantomSkillByPhantomSkillId.HandleId, 1, p0PhantomSkillId, ConfigPhantomSkillByPhantomSkillId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomSkillByPhantomSkillId.HandleId, ConfigPhantomSkillByPhantomSkillId.LogPair);
				return null;
			}
			List<PhantomSkill> list = new List<PhantomSkill>();
			while (ConfigCommon.Step(ConfigPhantomSkillByPhantomSkillId.HandleId, false, ConfigPhantomSkillByPhantomSkillId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomSkillByPhantomSkillId.HandleId, 0, ConfigPhantomSkillByPhantomSkillId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomSkillByPhantomSkillId.HandleId, ConfigPhantomSkillByPhantomSkillId.LogPair);
					return null;
				}
				PhantomSkill rootAsPhantomSkill = PhantomSkill.GetRootAsPhantomSkill(new ByteBuffer(item2));
				list.Add(rootAsPhantomSkill);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSkillByPhantomSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomSkillId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomSkillByPhantomSkillId.HandleId, ConfigPhantomSkillByPhantomSkillId.LogPair);
			return list;
		}

		// Token: 0x04002ED2 RID: 11986
		private const string DB = "db_phantom.db";

		// Token: 0x04002ED3 RID: 11987
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002ED4 RID: 11988
		private const string TABLE = "PhantomSkill";

		// Token: 0x04002ED5 RID: 11989
		private const string COMMAND = "select BinData from `PhantomSkill` where PhantomSkillId=?";

		// Token: 0x04002ED6 RID: 11990
		private const string KEY_PREFIX = "PhantomSkillByPhantomSkillId";

		// Token: 0x04002ED7 RID: 11991
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ED8 RID: 11992
		private static int HandleId;
	}
}
