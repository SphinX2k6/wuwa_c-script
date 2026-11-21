using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000628 RID: 1576
	public class ConfigNewTowerTeamFeatureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002500 RID: 9472 RVA: 0x0012E464 File Offset: 0x0012C664
		static ConfigNewTowerTeamFeatureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerTeamFeatureById.CreateStaticDefaultValue), new Action(ConfigNewTowerTeamFeatureById.ResetStaticDefaultValue));
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x0012E484 File Offset: 0x0012C684
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerTeamFeatureById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerTeamFeatureById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerTeamFeature"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerTeamFeature` where Id=?")
			});
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x0012E503 File Offset: 0x0012C703
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerTeamFeatureById.LogPair = null;
			ConfigNewTowerTeamFeatureById.HandleId = 0;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0012E511 File Offset: 0x0012C711
		public static void Init()
		{
			ConfigNewTowerTeamFeatureById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerTeamFeatureById.HandleId, "db_newtower.db", "select BinData from `NewTowerTeamFeature` where Id=?");
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x0012E52C File Offset: 0x0012C72C
		public static NewTowerTeamFeature? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerTeamFeatureById.HandleId, ConfigNewTowerTeamFeatureById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerTeamFeatureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerTeamFeature?(NewTowerTeamFeature.GetRootAsNewTowerTeamFeature(configBuffer));
				}
			}
			ConfigNewTowerTeamFeatureById.LogPair.Clear();
			ConfigNewTowerTeamFeatureById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerTeamFeatureById.HandleId, 1, p0Id, ConfigNewTowerTeamFeatureById.LogPair) || ConfigCommon.Step(ConfigNewTowerTeamFeatureById.HandleId, true, ConfigNewTowerTeamFeatureById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerTeamFeatureById.HandleId, ConfigNewTowerTeamFeatureById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerTeamFeatureById.HandleId, 0, ConfigNewTowerTeamFeatureById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerTeamFeatureById.HandleId, ConfigNewTowerTeamFeatureById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerTeamFeature rootAsNewTowerTeamFeature = NewTowerTeamFeature.GetRootAsNewTowerTeamFeature(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerTeamFeatureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerTeamFeatureById.HandleId, ConfigNewTowerTeamFeatureById.LogPair);
			return new NewTowerTeamFeature?(rootAsNewTowerTeamFeature);
		}

		// Token: 0x04002AFE RID: 11006
		private const string DB = "db_newtower.db";

		// Token: 0x04002AFF RID: 11007
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002B00 RID: 11008
		private const string TABLE = "NewTowerTeamFeature";

		// Token: 0x04002B01 RID: 11009
		private const string COMMAND = "select BinData from `NewTowerTeamFeature` where Id=?";

		// Token: 0x04002B02 RID: 11010
		private const string KEY_PREFIX = "NewTowerTeamFeatureById";

		// Token: 0x04002B03 RID: 11011
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B04 RID: 11012
		private static int HandleId;
	}
}
