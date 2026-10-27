using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000933 RID: 2355
	public class ConfigSkillBranchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003745 RID: 14149 RVA: 0x00191D33 File Offset: 0x0018FF33
		static ConfigSkillBranchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillBranchById.CreateStaticDefaultValue), new Action(ConfigSkillBranchById.ResetStaticDefaultValue));
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00191D54 File Offset: 0x0018FF54
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

		// Token: 0x06003747 RID: 14151 RVA: 0x00191DD3 File Offset: 0x0018FFD3
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillBranchById.LogPair = null;
			ConfigSkillBranchById.HandleId = 0;
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00191DE1 File Offset: 0x0018FFE1
		public static void Init()
		{
			ConfigSkillBranchById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillBranchById.HandleId, "db_skill.db", "select BinData from `SkillBranch` where Id=?");
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00191DFC File Offset: 0x0018FFFC
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

		// Token: 0x0400404B RID: 16459
		private const string DB = "db_skill.db";

		// Token: 0x0400404C RID: 16460
		private const string FILE = "j.技能.xlsx";

		// Token: 0x0400404D RID: 16461
		private const string TABLE = "SkillBranch";

		// Token: 0x0400404E RID: 16462
		private const string COMMAND = "select BinData from `SkillBranch` where Id=?";

		// Token: 0x0400404F RID: 16463
		private const string KEY_PREFIX = "SkillBranchById";

		// Token: 0x04004050 RID: 16464
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004051 RID: 16465
		private static int HandleId;
	}
}
