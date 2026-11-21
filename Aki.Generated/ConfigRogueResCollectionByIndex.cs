using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000858 RID: 2136
	public class ConfigRogueResCollectionByIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003222 RID: 12834 RVA: 0x0017851C File Offset: 0x0017671C
		static ConfigRogueResCollectionByIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionByIndex.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionByIndex.ResetStaticDefaultValue));
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x0017853C File Offset: 0x0017673C
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

		// Token: 0x06003224 RID: 12836 RVA: 0x001785BB File Offset: 0x001767BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionByIndex.LogPair = null;
			ConfigRogueResCollectionByIndex.HandleId = 0;
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x001785C9 File Offset: 0x001767C9
		public static void Init()
		{
			ConfigRogueResCollectionByIndex.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionByIndex.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection` where IdKey=?");
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x001785E4 File Offset: 0x001767E4
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

		// Token: 0x04003A4E RID: 14926
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A4F RID: 14927
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A50 RID: 14928
		private const string TABLE = "RogueResCollection";

		// Token: 0x04003A51 RID: 14929
		private const string COMMAND = "select BinData from `RogueResCollection` where IdKey=?";

		// Token: 0x04003A52 RID: 14930
		private const string KEY_PREFIX = "RogueResCollectionByIndex";

		// Token: 0x04003A53 RID: 14931
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A54 RID: 14932
		private static int HandleId;
	}
}
