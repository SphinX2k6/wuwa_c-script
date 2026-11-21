using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097E RID: 2430
	public class ConfigSkillBranchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003907 RID: 14599 RVA: 0x0019EF53 File Offset: 0x0019D153
		static ConfigSkillBranchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillBranchById.CreateStaticDefaultValue), new Action(ConfigSkillBranchById.ResetStaticDefaultValue));
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x0019EF74 File Offset: 0x0019D174
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillBranchById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillBranchById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "SkillBranch"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillBranch` where Id=?")
			});
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x0019EFF3 File Offset: 0x0019D1F3
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillBranchById.LogPair = null;
			ConfigSkillBranchById.HandleId = 0;
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x0019F001 File Offset: 0x0019D201
		public static void Init()
		{
			ConfigSkillBranchById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillBranchById.HandleId, "db_skill.db", "select BinData from `SkillBranch` where Id=?");
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0019F01C File Offset: 0x0019D21C
		public static SkillBranch? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillBranchById.HandleId, ConfigSkillBranchById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillBranchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillBranch?(SkillBranch.GetRootAsSkillBranch(configBuffer));
				}
			}
			ConfigSkillBranchById.LogPair.Clear();
			ConfigSkillBranchById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillBranchById.HandleId, 1, p0Id, ConfigSkillBranchById.LogPair) || ConfigCommon.Step(ConfigSkillBranchById.HandleId, true, ConfigSkillBranchById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillBranchById.HandleId, ConfigSkillBranchById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillBranchById.HandleId, 0, ConfigSkillBranchById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillBranchById.HandleId, ConfigSkillBranchById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillBranch rootAsSkillBranch = SkillBranch.GetRootAsSkillBranch(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillBranchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillBranchById.HandleId, ConfigSkillBranchById.LogPair);
			return new SkillBranch?(rootAsSkillBranch);
		}

		// Token: 0x04004258 RID: 16984
		private const string DB = "db_skill.db";

		// Token: 0x04004259 RID: 16985
		private const string FILE = "j.技能.xlsx";

		// Token: 0x0400425A RID: 16986
		private const string TABLE = "SkillBranch";

		// Token: 0x0400425B RID: 16987
		private const string COMMAND = "select BinData from `SkillBranch` where Id=?";

		// Token: 0x0400425C RID: 16988
		private const string KEY_PREFIX = "SkillBranchById";

		// Token: 0x0400425D RID: 16989
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400425E RID: 16990
		private static int HandleId;
	}
}
