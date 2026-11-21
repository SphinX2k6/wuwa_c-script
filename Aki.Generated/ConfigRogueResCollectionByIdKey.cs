using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000857 RID: 2135
	public class ConfigRogueResCollectionByIdKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x001782D4 File Offset: 0x001764D4
		static ConfigRogueResCollectionByIdKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionByIdKey.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionByIdKey.ResetStaticDefaultValue));
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x001782F4 File Offset: 0x001764F4
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

		// Token: 0x0600321E RID: 12830 RVA: 0x00178373 File Offset: 0x00176573
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionByIdKey.LogPair = null;
			ConfigRogueResCollectionByIdKey.HandleId = 0;
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00178381 File Offset: 0x00176581
		public static void Init()
		{
			ConfigRogueResCollectionByIdKey.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionByIdKey.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection` where IdKey=?");
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x0017839C File Offset: 0x0017659C
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

		// Token: 0x04003A47 RID: 14919
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A48 RID: 14920
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A49 RID: 14921
		private const string TABLE = "RogueResCollection";

		// Token: 0x04003A4A RID: 14922
		private const string COMMAND = "select BinData from `RogueResCollection` where IdKey=?";

		// Token: 0x04003A4B RID: 14923
		private const string KEY_PREFIX = "RogueResCollectionByIdKey";

		// Token: 0x04003A4C RID: 14924
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A4D RID: 14925
		private static int HandleId;
	}
}
