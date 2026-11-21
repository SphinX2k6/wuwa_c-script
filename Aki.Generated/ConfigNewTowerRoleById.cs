using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061C RID: 1564
	public class ConfigNewTowerRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024B8 RID: 9400 RVA: 0x0012CA37 File Offset: 0x0012AC37
		static ConfigNewTowerRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerRoleById.CreateStaticDefaultValue), new Action(ConfigNewTowerRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0012CA58 File Offset: 0x0012AC58
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerRole"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerRole` where Id=?")
			});
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0012CAD7 File Offset: 0x0012ACD7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerRoleById.LogPair = null;
			ConfigNewTowerRoleById.HandleId = 0;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0012CAE5 File Offset: 0x0012ACE5
		public static void Init()
		{
			ConfigNewTowerRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerRoleById.HandleId, "db_newtower.db", "select BinData from `NewTowerRole` where Id=?");
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x0012CB00 File Offset: 0x0012AD00
		public static NewTowerRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerRoleById.HandleId, ConfigNewTowerRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerRole?(NewTowerRole.GetRootAsNewTowerRole(configBuffer));
				}
			}
			ConfigNewTowerRoleById.LogPair.Clear();
			ConfigNewTowerRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerRoleById.HandleId, 1, p0Id, ConfigNewTowerRoleById.LogPair) || ConfigCommon.Step(ConfigNewTowerRoleById.HandleId, true, ConfigNewTowerRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerRoleById.HandleId, ConfigNewTowerRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerRoleById.HandleId, 0, ConfigNewTowerRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerRoleById.HandleId, ConfigNewTowerRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerRole rootAsNewTowerRole = NewTowerRole.GetRootAsNewTowerRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerRoleById.HandleId, ConfigNewTowerRoleById.LogPair);
			return new NewTowerRole?(rootAsNewTowerRole);
		}

		// Token: 0x04002AAA RID: 10922
		private const string DB = "db_newtower.db";

		// Token: 0x04002AAB RID: 10923
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AAC RID: 10924
		private const string TABLE = "NewTowerRole";

		// Token: 0x04002AAD RID: 10925
		private const string COMMAND = "select BinData from `NewTowerRole` where Id=?";

		// Token: 0x04002AAE RID: 10926
		private const string KEY_PREFIX = "NewTowerRoleById";

		// Token: 0x04002AAF RID: 10927
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AB0 RID: 10928
		private static int HandleId;
	}
}
