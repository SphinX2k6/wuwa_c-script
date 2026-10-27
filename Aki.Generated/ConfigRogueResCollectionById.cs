using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083A RID: 2106
	public class ConfigRogueResCollectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600316E RID: 12654 RVA: 0x00170DA3 File Offset: 0x0016EFA3
		static ConfigRogueResCollectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionById.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x00170DC4 File Offset: 0x0016EFC4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCollectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCollectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCollection` where Id=?")
			});
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00170E43 File Offset: 0x0016F043
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionById.LogPair = null;
			ConfigRogueResCollectionById.HandleId = 0;
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00170E51 File Offset: 0x0016F051
		public static void Init()
		{
			ConfigRogueResCollectionById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection` where Id=?");
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x00170E6C File Offset: 0x0016F06C
		public static RogueResCollection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCollectionById.HandleId, ConfigRogueResCollectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCollection?(RogueResCollection.GetRootAsRogueResCollection(configBuffer));
				}
			}
			ConfigRogueResCollectionById.LogPair.Clear();
			ConfigRogueResCollectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResCollectionById.HandleId, 1, p0Id, ConfigRogueResCollectionById.LogPair) || ConfigCommon.Step(ConfigRogueResCollectionById.HandleId, true, ConfigRogueResCollectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionById.HandleId, ConfigRogueResCollectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCollectionById.HandleId, 0, ConfigRogueResCollectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionById.HandleId, ConfigRogueResCollectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCollection rootAsRogueResCollection = RogueResCollection.GetRootAsRogueResCollection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCollectionById.HandleId, ConfigRogueResCollectionById.LogPair);
			return new RogueResCollection?(rootAsRogueResCollection);
		}

		// Token: 0x0400397C RID: 14716
		private const string DB = "db_permanentrogue.db";

		// Token: 0x0400397D RID: 14717
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x0400397E RID: 14718
		private const string TABLE = "RogueResCollection";

		// Token: 0x0400397F RID: 14719
		private const string COMMAND = "select BinData from `RogueResCollection` where Id=?";

		// Token: 0x04003980 RID: 14720
		private const string KEY_PREFIX = "RogueResCollectionById";

		// Token: 0x04003981 RID: 14721
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003982 RID: 14722
		private static int HandleId;
	}
}
