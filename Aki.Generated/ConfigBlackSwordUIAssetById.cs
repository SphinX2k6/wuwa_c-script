using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000100 RID: 256
	public class ConfigBlackSwordUIAssetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0007B9CB File Offset: 0x00079BCB
		static ConfigBlackSwordUIAssetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordUIAssetById.CreateStaticDefaultValue), new Action(ConfigBlackSwordUIAssetById.ResetStaticDefaultValue));
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0007B9EC File Offset: 0x00079BEC
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

		// Token: 0x06000603 RID: 1539 RVA: 0x0007BA6B File Offset: 0x00079C6B
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordUIAssetById.LogPair = null;
			ConfigBlackSwordUIAssetById.HandleId = 0;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0007BA79 File Offset: 0x00079C79
		public static void Init()
		{
			ConfigBlackSwordUIAssetById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordUIAssetById.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordUIAsset` where Id=?");
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0007BA94 File Offset: 0x00079C94
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

		// Token: 0x040006E4 RID: 1764
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x040006E5 RID: 1765
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x040006E6 RID: 1766
		private const string TABLE = "BlackSwordUIAsset";

		// Token: 0x040006E7 RID: 1767
		private const string COMMAND = "select BinData from `BlackSwordUIAsset` where Id=?";

		// Token: 0x040006E8 RID: 1768
		private const string KEY_PREFIX = "BlackSwordUIAssetById";

		// Token: 0x040006E9 RID: 1769
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006EA RID: 1770
		private static int HandleId;
	}
}
