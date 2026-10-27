using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000754 RID: 1876
	public class ConfigPrefabTextItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C09 RID: 11273 RVA: 0x0015249B File Offset: 0x0015069B
		static ConfigPrefabTextItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabTextItemByItemId.CreateStaticDefaultValue), new Action(ConfigPrefabTextItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x001524BC File Offset: 0x001506BC
		public static void CreateStaticDefaultValue()
		{
			ConfigPrefabTextItemByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPrefabTextItemByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui_prefabtextitem.db"),
				new ValueTuple<string, object>("文件", "u.UiTextCollect/u.预制体文本收集.csv"),
				new ValueTuple<string, object>("表名", "PrefabTextItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PrefabTextItem` where ItemId = ?")
			});
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x0015253B File Offset: 0x0015073B
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabTextItemByItemId.LogPair = null;
			ConfigPrefabTextItemByItemId.HandleId = 0;
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00152549 File Offset: 0x00150749
		public static void Init()
		{
			ConfigPrefabTextItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabTextItemByItemId.HandleId, "db_ui_prefabtextitem.db", "select BinData from `PrefabTextItem` where ItemId = ?");
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00152564 File Offset: 0x00150764
		public static PrefabTextItem? GetConfig(long p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPrefabTextItemByItemId.HandleId, ConfigPrefabTextItemByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrefabTextItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PrefabTextItem?(PrefabTextItem.GetRootAsPrefabTextItem(configBuffer));
				}
			}
			ConfigPrefabTextItemByItemId.LogPair.Clear();
			ConfigPrefabTextItemByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindBigInt(ConfigPrefabTextItemByItemId.HandleId, 1, p0ItemId, ConfigPrefabTextItemByItemId.LogPair) || ConfigCommon.Step(ConfigPrefabTextItemByItemId.HandleId, true, ConfigPrefabTextItemByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPrefabTextItemByItemId.HandleId, ConfigPrefabTextItemByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPrefabTextItemByItemId.HandleId, 0, ConfigPrefabTextItemByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPrefabTextItemByItemId.HandleId, ConfigPrefabTextItemByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PrefabTextItem rootAsPrefabTextItem = PrefabTextItem.GetRootAsPrefabTextItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PrefabTextItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPrefabTextItemByItemId.HandleId, ConfigPrefabTextItemByItemId.LogPair);
			return new PrefabTextItem?(rootAsPrefabTextItem);
		}

		// Token: 0x04003332 RID: 13106
		private const string DB = "db_ui_prefabtextitem.db";

		// Token: 0x04003333 RID: 13107
		private const string FILE = "u.UiTextCollect/u.预制体文本收集.csv";

		// Token: 0x04003334 RID: 13108
		private const string TABLE = "PrefabTextItem";

		// Token: 0x04003335 RID: 13109
		private const string COMMAND = "select BinData from `PrefabTextItem` where ItemId = ?";

		// Token: 0x04003336 RID: 13110
		private const string KEY_PREFIX = "PrefabTextItemByItemId";

		// Token: 0x04003337 RID: 13111
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003338 RID: 13112
		private static int HandleId;
	}
}
