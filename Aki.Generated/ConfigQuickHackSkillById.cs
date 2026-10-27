using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000798 RID: 1944
	public class ConfigQuickHackSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DA2 RID: 11682 RVA: 0x0015B11C File Offset: 0x0015931C
		static ConfigQuickHackSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuickHackSkillById.CreateStaticDefaultValue), new Action(ConfigQuickHackSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0015B13C File Offset: 0x0015933C
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

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0015B1BB File Offset: 0x001593BB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuickHackSkillById.LogPair = null;
			ConfigQuickHackSkillById.HandleId = 0;
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0015B1C9 File Offset: 0x001593C9
		public static void Init()
		{
			ConfigQuickHackSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigQuickHackSkillById.HandleId, "db_quickhack.db", "select BinData from `QuickHackSkill` where Id = ?");
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x0015B1E4 File Offset: 0x001593E4
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

		// Token: 0x0400350E RID: 13582
		private const string DB = "db_quickhack.db";

		// Token: 0x0400350F RID: 13583
		private const string FILE = "k.快速破解.xlsx";

		// Token: 0x04003510 RID: 13584
		private const string TABLE = "QuickHackSkill";

		// Token: 0x04003511 RID: 13585
		private const string COMMAND = "select BinData from `QuickHackSkill` where Id = ?";

		// Token: 0x04003512 RID: 13586
		private const string KEY_PREFIX = "QuickHackSkillById";

		// Token: 0x04003513 RID: 13587
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003514 RID: 13588
		private static int HandleId;
	}
}
