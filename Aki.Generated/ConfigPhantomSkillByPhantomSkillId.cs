using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CC RID: 1740
	public class ConfigPhantomSkillByPhantomSkillId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028D8 RID: 10456 RVA: 0x00144088 File Offset: 0x00142288
		static ConfigPhantomSkillByPhantomSkillId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSkillByPhantomSkillId.CreateStaticDefaultValue), new Action(ConfigPhantomSkillByPhantomSkillId.ResetStaticDefaultValue));
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x001440A8 File Offset: 0x001422A8
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

		// Token: 0x060028DA RID: 10458 RVA: 0x00144127 File Offset: 0x00142327
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSkillByPhantomSkillId.LogPair = null;
			ConfigPhantomSkillByPhantomSkillId.HandleId = 0;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00144135 File Offset: 0x00142335
		public static void Init()
		{
			ConfigPhantomSkillByPhantomSkillId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSkillByPhantomSkillId.HandleId, "db_phantom.db", "select BinData from `PhantomSkill` where PhantomSkillId=?");
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00144150 File Offset: 0x00142350
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

		// Token: 0x04002F7A RID: 12154
		private const string DB = "db_phantom.db";

		// Token: 0x04002F7B RID: 12155
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F7C RID: 12156
		private const string TABLE = "PhantomSkill";

		// Token: 0x04002F7D RID: 12157
		private const string COMMAND = "select BinData from `PhantomSkill` where PhantomSkillId=?";

		// Token: 0x04002F7E RID: 12158
		private const string KEY_PREFIX = "PhantomSkillByPhantomSkillId";

		// Token: 0x04002F7F RID: 12159
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F80 RID: 12160
		private static int HandleId;
	}
}
