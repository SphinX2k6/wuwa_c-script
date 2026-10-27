using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C2 RID: 2242
	public class ConfigRoleSkillInputById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600349F RID: 13471 RVA: 0x00182B57 File Offset: 0x00180D57
		static ConfigRoleSkillInputById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkillInputById.CreateStaticDefaultValue), new Action(ConfigRoleSkillInputById.ResetStaticDefaultValue));
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00182B78 File Offset: 0x00180D78
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

		// Token: 0x060034A1 RID: 13473 RVA: 0x00182BF7 File Offset: 0x00180DF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkillInputById.LogPair = null;
			ConfigRoleSkillInputById.HandleId = 0;
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00182C05 File Offset: 0x00180E05
		public static void Init()
		{
			ConfigRoleSkillInputById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkillInputById.HandleId, "db_skilltree.db", "select BinData from `RoleSkillInput` where RoleId = ?");
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00182C20 File Offset: 0x00180E20
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

		// Token: 0x04003D34 RID: 15668
		private const string DB = "db_skilltree.db";

		// Token: 0x04003D35 RID: 15669
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x04003D36 RID: 15670
		private const string TABLE = "RoleSkillInput";

		// Token: 0x04003D37 RID: 15671
		private const string COMMAND = "select BinData from `RoleSkillInput` where RoleId = ?";

		// Token: 0x04003D38 RID: 15672
		private const string KEY_PREFIX = "RoleSkillInputById";

		// Token: 0x04003D39 RID: 15673
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D3A RID: 15674
		private static int HandleId;
	}
}
