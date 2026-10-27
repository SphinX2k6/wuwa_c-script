using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000604 RID: 1540
	public class ConfigNewTowerRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002428 RID: 9256 RVA: 0x00125FBB File Offset: 0x001241BB
		static ConfigNewTowerRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerRoleById.CreateStaticDefaultValue), new Action(ConfigNewTowerRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00125FDC File Offset: 0x001241DC
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

		// Token: 0x0600242A RID: 9258 RVA: 0x0012605B File Offset: 0x0012425B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerRoleById.LogPair = null;
			ConfigNewTowerRoleById.HandleId = 0;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00126069 File Offset: 0x00124269
		public static void Init()
		{
			ConfigNewTowerRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerRoleById.HandleId, "db_newtower.db", "select BinData from `NewTowerRole` where Id=?");
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00126084 File Offset: 0x00124284
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

		// Token: 0x04002A02 RID: 10754
		private const string DB = "db_newtower.db";

		// Token: 0x04002A03 RID: 10755
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A04 RID: 10756
		private const string TABLE = "NewTowerRole";

		// Token: 0x04002A05 RID: 10757
		private const string COMMAND = "select BinData from `NewTowerRole` where Id=?";

		// Token: 0x04002A06 RID: 10758
		private const string KEY_PREFIX = "NewTowerRoleById";

		// Token: 0x04002A07 RID: 10759
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A08 RID: 10760
		private static int HandleId;
	}
}
