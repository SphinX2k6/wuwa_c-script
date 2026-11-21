using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B2 RID: 1970
	public class ConfigQuickHackSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E3E RID: 11838 RVA: 0x00162028 File Offset: 0x00160228
		static ConfigQuickHackSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuickHackSkillById.CreateStaticDefaultValue), new Action(ConfigQuickHackSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x00162048 File Offset: 0x00160248
		public static void CreateStaticDefaultValue()
		{
			ConfigQuickHackSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuickHackSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_quickhack.db"),
				new ValueTuple<string, object>("文件", "k.快速破解.xlsx"),
				new ValueTuple<string, object>("表名", "QuickHackSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `QuickHackSkill` where Id = ?")
			});
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x001620C7 File Offset: 0x001602C7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuickHackSkillById.LogPair = null;
			ConfigQuickHackSkillById.HandleId = 0;
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x001620D5 File Offset: 0x001602D5
		public static void Init()
		{
			ConfigQuickHackSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigQuickHackSkillById.HandleId, "db_quickhack.db", "select BinData from `QuickHackSkill` where Id = ?");
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x001620F0 File Offset: 0x001602F0
		public static QuickHackSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuickHackSkillById.HandleId, ConfigQuickHackSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuickHackSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuickHackSkill?(QuickHackSkill.GetRootAsQuickHackSkill(configBuffer));
				}
			}
			ConfigQuickHackSkillById.LogPair.Clear();
			ConfigQuickHackSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuickHackSkillById.HandleId, 1, p0Id, ConfigQuickHackSkillById.LogPair) || ConfigCommon.Step(ConfigQuickHackSkillById.HandleId, true, ConfigQuickHackSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuickHackSkillById.HandleId, ConfigQuickHackSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuickHackSkillById.HandleId, 0, ConfigQuickHackSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuickHackSkillById.HandleId, ConfigQuickHackSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuickHackSkill rootAsQuickHackSkill = QuickHackSkill.GetRootAsQuickHackSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuickHackSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuickHackSkillById.HandleId, ConfigQuickHackSkillById.LogPair);
			return new QuickHackSkill?(rootAsQuickHackSkill);
		}

		// Token: 0x040035C4 RID: 13764
		private const string DB = "db_quickhack.db";

		// Token: 0x040035C5 RID: 13765
		private const string FILE = "k.快速破解.xlsx";

		// Token: 0x040035C6 RID: 13766
		private const string TABLE = "QuickHackSkill";

		// Token: 0x040035C7 RID: 13767
		private const string COMMAND = "select BinData from `QuickHackSkill` where Id = ?";

		// Token: 0x040035C8 RID: 13768
		private const string KEY_PREFIX = "QuickHackSkillById";

		// Token: 0x040035C9 RID: 13769
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035CA RID: 13770
		private static int HandleId;
	}
}
