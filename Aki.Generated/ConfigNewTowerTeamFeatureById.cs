using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000610 RID: 1552
	public class ConfigNewTowerTeamFeatureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002470 RID: 9328 RVA: 0x001279E8 File Offset: 0x00125BE8
		static ConfigNewTowerTeamFeatureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerTeamFeatureById.CreateStaticDefaultValue), new Action(ConfigNewTowerTeamFeatureById.ResetStaticDefaultValue));
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00127A08 File Offset: 0x00125C08
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

		// Token: 0x06002472 RID: 9330 RVA: 0x00127A87 File Offset: 0x00125C87
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerTeamFeatureById.LogPair = null;
			ConfigNewTowerTeamFeatureById.HandleId = 0;
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00127A95 File Offset: 0x00125C95
		public static void Init()
		{
			ConfigNewTowerTeamFeatureById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerTeamFeatureById.HandleId, "db_newtower.db", "select BinData from `NewTowerTeamFeature` where Id=?");
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00127AB0 File Offset: 0x00125CB0
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

		// Token: 0x04002A56 RID: 10838
		private const string DB = "db_newtower.db";

		// Token: 0x04002A57 RID: 10839
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A58 RID: 10840
		private const string TABLE = "NewTowerTeamFeature";

		// Token: 0x04002A59 RID: 10841
		private const string COMMAND = "select BinData from `NewTowerTeamFeature` where Id=?";

		// Token: 0x04002A5A RID: 10842
		private const string KEY_PREFIX = "NewTowerTeamFeatureById";

		// Token: 0x04002A5B RID: 10843
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A5C RID: 10844
		private static int HandleId;
	}
}
