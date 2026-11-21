using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B7 RID: 2231
	public class ConfigRoleDevPhantomJumpGroupByPhantomId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600345C RID: 13404 RVA: 0x00184C37 File Offset: 0x00182E37
		static ConfigRoleDevPhantomJumpGroupByPhantomId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevPhantomJumpGroupByPhantomId.CreateStaticDefaultValue), new Action(ConfigRoleDevPhantomJumpGroupByPhantomId.ResetStaticDefaultValue));
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00184C58 File Offset: 0x00182E58
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevPhantomJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevPhantomJumpGroup` where PhantomId=?")
			});
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00184CD7 File Offset: 0x00182ED7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair = null;
			ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId = 0;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00184CE5 File Offset: 0x00182EE5
		public static void Init()
		{
			ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, "db_roledev.db", "select BinData from `RoleDevPhantomJumpGroup` where PhantomId=?");
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00184D00 File Offset: 0x00182F00
		public static RoleDevPhantomJumpGroup? GetConfig(int p0PhantomId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevPhantomJumpGroupByPhantomId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevPhantomJumpGroup?(RoleDevPhantomJumpGroup.GetRootAsRoleDevPhantomJumpGroup(configBuffer));
				}
			}
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair.Clear();
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair.Add(new ValueTuple<string, object>("PhantomId", p0PhantomId));
			if (!ConfigCommon.BindInt(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, 1, p0PhantomId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair) || ConfigCommon.Step(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, true, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, 0, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevPhantomJumpGroup rootAsRoleDevPhantomJumpGroup = RoleDevPhantomJumpGroup.GetRootAsRoleDevPhantomJumpGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevPhantomJumpGroupByPhantomId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
			return new RoleDevPhantomJumpGroup?(rootAsRoleDevPhantomJumpGroup);
		}

		// Token: 0x04003CE7 RID: 15591
		private const string DB = "db_roledev.db";

		// Token: 0x04003CE8 RID: 15592
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CE9 RID: 15593
		private const string TABLE = "RoleDevPhantomJumpGroup";

		// Token: 0x04003CEA RID: 15594
		private const string COMMAND = "select BinData from `RoleDevPhantomJumpGroup` where PhantomId=?";

		// Token: 0x04003CEB RID: 15595
		private const string KEY_PREFIX = "RoleDevPhantomJumpGroupByPhantomId";

		// Token: 0x04003CEC RID: 15596
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CED RID: 15597
		private static int HandleId;
	}
}
