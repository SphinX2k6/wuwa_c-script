using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083B RID: 2107
	public class ConfigRogueResCollectionByIdKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003174 RID: 12660 RVA: 0x00170FEC File Offset: 0x0016F1EC
		static ConfigRogueResCollectionByIdKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionByIdKey.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionByIdKey.ResetStaticDefaultValue));
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x0017100C File Offset: 0x0016F20C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCollectionByIdKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCollectionByIdKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCollection` where IdKey=?")
			});
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0017108B File Offset: 0x0016F28B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionByIdKey.LogPair = null;
			ConfigRogueResCollectionByIdKey.HandleId = 0;
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00171099 File Offset: 0x0016F299
		public static void Init()
		{
			ConfigRogueResCollectionByIdKey.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionByIdKey.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection` where IdKey=?");
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x001710B4 File Offset: 0x0016F2B4
		public static RogueResCollection? GetConfig(int p0IdKey, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCollectionByIdKey.HandleId, ConfigRogueResCollectionByIdKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionByIdKey");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0IdKey);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCollection?(RogueResCollection.GetRootAsRogueResCollection(configBuffer));
				}
			}
			ConfigRogueResCollectionByIdKey.LogPair.Clear();
			ConfigRogueResCollectionByIdKey.LogPair.Add(new ValueTuple<string, object>("IdKey", p0IdKey));
			if (!ConfigCommon.BindInt(ConfigRogueResCollectionByIdKey.HandleId, 1, p0IdKey, ConfigRogueResCollectionByIdKey.LogPair) || ConfigCommon.Step(ConfigRogueResCollectionByIdKey.HandleId, true, ConfigRogueResCollectionByIdKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionByIdKey.HandleId, ConfigRogueResCollectionByIdKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCollectionByIdKey.HandleId, 0, ConfigRogueResCollectionByIdKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionByIdKey.HandleId, ConfigRogueResCollectionByIdKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCollection rootAsRogueResCollection = RogueResCollection.GetRootAsRogueResCollection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionByIdKey");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0IdKey);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCollectionByIdKey.HandleId, ConfigRogueResCollectionByIdKey.LogPair);
			return new RogueResCollection?(rootAsRogueResCollection);
		}

		// Token: 0x04003983 RID: 14723
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003984 RID: 14724
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003985 RID: 14725
		private const string TABLE = "RogueResCollection";

		// Token: 0x04003986 RID: 14726
		private const string COMMAND = "select BinData from `RogueResCollection` where IdKey=?";

		// Token: 0x04003987 RID: 14727
		private const string KEY_PREFIX = "RogueResCollectionByIdKey";

		// Token: 0x04003988 RID: 14728
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003989 RID: 14729
		private static int HandleId;
	}
}
