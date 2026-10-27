using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E2 RID: 1506
	public class ConfigNewbieCarnivalRoleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600235B RID: 9051 RVA: 0x00121734 File Offset: 0x0011F934
		static ConfigNewbieCarnivalRoleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalRoleByRoleId.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalRoleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00121754 File Offset: 0x0011F954
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalRoleByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalRoleByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalRole"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalRole` where RoleId=?")
			});
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x001217D3 File Offset: 0x0011F9D3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalRoleByRoleId.LogPair = null;
			ConfigNewbieCarnivalRoleByRoleId.HandleId = 0;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x001217E1 File Offset: 0x0011F9E1
		public static void Init()
		{
			ConfigNewbieCarnivalRoleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalRoleByRoleId.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalRole` where RoleId=?");
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x001217FC File Offset: 0x0011F9FC
		public static NewbieCarnivalRole? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCarnivalRole?(NewbieCarnivalRole.GetRootAsNewbieCarnivalRole(configBuffer));
				}
			}
			ConfigNewbieCarnivalRoleByRoleId.LogPair.Clear();
			ConfigNewbieCarnivalRoleByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalRoleByRoleId.HandleId, 1, p0RoleId, ConfigNewbieCarnivalRoleByRoleId.LogPair) || ConfigCommon.Step(ConfigNewbieCarnivalRoleByRoleId.HandleId, true, ConfigNewbieCarnivalRoleByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalRoleByRoleId.HandleId, 0, ConfigNewbieCarnivalRoleByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCarnivalRole rootAsNewbieCarnivalRole = NewbieCarnivalRole.GetRootAsNewbieCarnivalRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalRoleByRoleId.HandleId, ConfigNewbieCarnivalRoleByRoleId.LogPair);
			return new NewbieCarnivalRole?(rootAsNewbieCarnivalRole);
		}

		// Token: 0x04002914 RID: 10516
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x04002915 RID: 10517
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x04002916 RID: 10518
		private const string TABLE = "NewbieCarnivalRole";

		// Token: 0x04002917 RID: 10519
		private const string COMMAND = "select BinData from `NewbieCarnivalRole` where RoleId=?";

		// Token: 0x04002918 RID: 10520
		private const string KEY_PREFIX = "NewbieCarnivalRoleByRoleId";

		// Token: 0x04002919 RID: 10521
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400291A RID: 10522
		private static int HandleId;
	}
}
