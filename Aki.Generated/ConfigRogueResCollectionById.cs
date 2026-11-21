using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000856 RID: 2134
	public class ConfigRogueResCollectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003216 RID: 12822 RVA: 0x0017808B File Offset: 0x0017628B
		static ConfigRogueResCollectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCollectionById.CreateStaticDefaultValue), new Action(ConfigRogueResCollectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x001780AC File Offset: 0x001762AC
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

		// Token: 0x06003218 RID: 12824 RVA: 0x0017812B File Offset: 0x0017632B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCollectionById.LogPair = null;
			ConfigRogueResCollectionById.HandleId = 0;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00178139 File Offset: 0x00176339
		public static void Init()
		{
			ConfigRogueResCollectionById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCollectionById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCollection` where Id=?");
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x00178154 File Offset: 0x00176354
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

		// Token: 0x04003A40 RID: 14912
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A41 RID: 14913
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A42 RID: 14914
		private const string TABLE = "RogueResCollection";

		// Token: 0x04003A43 RID: 14915
		private const string COMMAND = "select BinData from `RogueResCollection` where Id=?";

		// Token: 0x04003A44 RID: 14916
		private const string KEY_PREFIX = "RogueResCollectionById";

		// Token: 0x04003A45 RID: 14917
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A46 RID: 14918
		private static int HandleId;
	}
}
