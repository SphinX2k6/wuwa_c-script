using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083C RID: 2108
	public class ConfigRogueResCollectionByIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600317A RID: 12666 RVA: 0x00171234 File Offset: 0x0016F434
		static ConfigRogueResCollectionByIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionByIndex.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionByIndex.ResetStaticDefaultValue));
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x00171254 File Offset: 0x0016F454
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCollectionByIndex.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCollectionByIndex.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCollection` where IdKey=?")
			});
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x001712D3 File Offset: 0x0016F4D3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionByIndex.LogPair = null;
			ConfigRogueResCollectionByIndex.HandleId = 0;
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x001712E1 File Offset: 0x0016F4E1
		public static void Init()
		{
			ConfigRogueResCollectionByIndex.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionByIndex.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection` where IdKey=?");
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x001712FC File Offset: 0x0016F4FC
		public static RogueResCollection? GetConfig(int p0IdKey, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCollectionByIndex.HandleId, ConfigRogueResCollectionByIndex.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionByIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0IdKey);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCollection?(RogueResCollection.GetRootAsRogueResCollection(configBuffer));
				}
			}
			ConfigRogueResCollectionByIndex.LogPair.Clear();
			ConfigRogueResCollectionByIndex.LogPair.Add(new ValueTuple<string, object>("IdKey", p0IdKey));
			if (!ConfigCommon.BindInt(ConfigRogueResCollectionByIndex.HandleId, 1, p0IdKey, ConfigRogueResCollectionByIndex.LogPair) || ConfigCommon.Step(ConfigRogueResCollectionByIndex.HandleId, true, ConfigRogueResCollectionByIndex.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionByIndex.HandleId, ConfigRogueResCollectionByIndex.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCollectionByIndex.HandleId, 0, ConfigRogueResCollectionByIndex.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCollectionByIndex.HandleId, ConfigRogueResCollectionByIndex.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCollection rootAsRogueResCollection = RogueResCollection.GetRootAsRogueResCollection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCollectionByIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0IdKey);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCollectionByIndex.HandleId, ConfigRogueResCollectionByIndex.LogPair);
			return new RogueResCollection?(rootAsRogueResCollection);
		}

		// Token: 0x0400398A RID: 14730
		private const string DB = "db_permanentrogue.db";

		// Token: 0x0400398B RID: 14731
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x0400398C RID: 14732
		private const string TABLE = "RogueResCollection";

		// Token: 0x0400398D RID: 14733
		private const string COMMAND = "select BinData from `RogueResCollection` where IdKey=?";

		// Token: 0x0400398E RID: 14734
		private const string KEY_PREFIX = "RogueResCollectionByIndex";

		// Token: 0x0400398F RID: 14735
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003990 RID: 14736
		private static int HandleId;
	}
}
