using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DE RID: 2270
	public class ConfigRoleSkillInputById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x00189E3F File Offset: 0x0018803F
		static ConfigRoleSkillInputById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkillInputById.CreateStaticDefaultValue), new Action(ConfigRoleSkillInputById.ResetStaticDefaultValue));
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x00189E60 File Offset: 0x00188060
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkillInputById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkillInputById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkillInput"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkillInput` where RoleId = ?")
			});
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00189EDF File Offset: 0x001880DF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkillInputById.LogPair = null;
			ConfigRoleSkillInputById.HandleId = 0;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00189EED File Offset: 0x001880ED
		public static void Init()
		{
			ConfigRoleSkillInputById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkillInputById.HandleId, "db_skilltree.db", "select BinData from `RoleSkillInput` where RoleId = ?");
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00189F08 File Offset: 0x00188108
		public static RoleSkillInput? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkillInputById.HandleId, ConfigRoleSkillInputById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkillInputById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkillInput?(RoleSkillInput.GetRootAsRoleSkillInput(configBuffer));
				}
			}
			ConfigRoleSkillInputById.LogPair.Clear();
			ConfigRoleSkillInputById.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleSkillInputById.HandleId, 1, p0RoleId, ConfigRoleSkillInputById.LogPair) || ConfigCommon.Step(ConfigRoleSkillInputById.HandleId, true, ConfigRoleSkillInputById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkillInputById.HandleId, ConfigRoleSkillInputById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkillInputById.HandleId, 0, ConfigRoleSkillInputById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkillInputById.HandleId, ConfigRoleSkillInputById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkillInput rootAsRoleSkillInput = RoleSkillInput.GetRootAsRoleSkillInput(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkillInputById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkillInputById.HandleId, ConfigRoleSkillInputById.LogPair);
			return new RoleSkillInput?(rootAsRoleSkillInput);
		}

		// Token: 0x04003DF8 RID: 15864
		private const string DB = "db_skilltree.db";

		// Token: 0x04003DF9 RID: 15865
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x04003DFA RID: 15866
		private const string TABLE = "RoleSkillInput";

		// Token: 0x04003DFB RID: 15867
		private const string COMMAND = "select BinData from `RoleSkillInput` where RoleId = ?";

		// Token: 0x04003DFC RID: 15868
		private const string KEY_PREFIX = "RoleSkillInputById";

		// Token: 0x04003DFD RID: 15869
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DFE RID: 15870
		private static int HandleId;
	}
}
