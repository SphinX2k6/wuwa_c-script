using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010F RID: 271
	public class ConfigBlackSwordUIAssetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x0008132F File Offset: 0x0007F52F
		static ConfigBlackSwordUIAssetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordUIAssetById.CreateStaticDefaultValue), new Action(ConfigBlackSwordUIAssetById.ResetStaticDefaultValue));
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00081350 File Offset: 0x0007F550
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackSwordUIAssetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackSwordUIAssetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackswordchallenge.db"),
				new ValueTuple<string, object>("文件", "h.黑剑挑战.xlsx"),
				new ValueTuple<string, object>("表名", "BlackSwordUIAsset"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackSwordUIAsset` where Id=?")
			});
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000813CF File Offset: 0x0007F5CF
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordUIAssetById.LogPair = null;
			ConfigBlackSwordUIAssetById.HandleId = 0;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000813DD File Offset: 0x0007F5DD
		public static void Init()
		{
			ConfigBlackSwordUIAssetById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordUIAssetById.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordUIAsset` where Id=?");
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000813F8 File Offset: 0x0007F5F8
		public static BlackSwordUIAsset? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackSwordUIAssetById.HandleId, ConfigBlackSwordUIAssetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackSwordUIAssetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlackSwordUIAsset?(BlackSwordUIAsset.GetRootAsBlackSwordUIAsset(configBuffer));
				}
			}
			ConfigBlackSwordUIAssetById.LogPair.Clear();
			ConfigBlackSwordUIAssetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBlackSwordUIAssetById.HandleId, 1, p0Id, ConfigBlackSwordUIAssetById.LogPair) || ConfigCommon.Step(ConfigBlackSwordUIAssetById.HandleId, true, ConfigBlackSwordUIAssetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlackSwordUIAssetById.HandleId, ConfigBlackSwordUIAssetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackSwordUIAssetById.HandleId, 0, ConfigBlackSwordUIAssetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlackSwordUIAssetById.HandleId, ConfigBlackSwordUIAssetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlackSwordUIAsset rootAsBlackSwordUIAsset = BlackSwordUIAsset.GetRootAsBlackSwordUIAsset(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackSwordUIAssetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlackSwordUIAssetById.HandleId, ConfigBlackSwordUIAssetById.LogPair);
			return new BlackSwordUIAsset?(rootAsBlackSwordUIAsset);
		}

		// Token: 0x0400074D RID: 1869
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x0400074E RID: 1870
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x0400074F RID: 1871
		private const string TABLE = "BlackSwordUIAsset";

		// Token: 0x04000750 RID: 1872
		private const string COMMAND = "select BinData from `BlackSwordUIAsset` where Id=?";

		// Token: 0x04000751 RID: 1873
		private const string KEY_PREFIX = "BlackSwordUIAssetById";

		// Token: 0x04000752 RID: 1874
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000753 RID: 1875
		private static int HandleId;
	}
}
