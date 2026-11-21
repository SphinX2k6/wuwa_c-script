using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076C RID: 1900
	public class ConfigPrefabTextItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C99 RID: 11417 RVA: 0x00158F17 File Offset: 0x00157117
		static ConfigPrefabTextItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPrefabTextItemByItemId.CreateStaticDefaultValue), new Action(ConfigPrefabTextItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x00158F38 File Offset: 0x00157138
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

		// Token: 0x06002C9B RID: 11419 RVA: 0x00158FB7 File Offset: 0x001571B7
		public static void ResetStaticDefaultValue()
		{
			ConfigPrefabTextItemByItemId.LogPair = null;
			ConfigPrefabTextItemByItemId.HandleId = 0;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x00158FC5 File Offset: 0x001571C5
		public static void Init()
		{
			ConfigPrefabTextItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPrefabTextItemByItemId.HandleId, "db_ui_prefabtextitem.db", "select BinData from `PrefabTextItem` where ItemId = ?");
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00158FE0 File Offset: 0x001571E0
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

		// Token: 0x040033DA RID: 13274
		private const string DB = "db_ui_prefabtextitem.db";

		// Token: 0x040033DB RID: 13275
		private const string FILE = "u.UiTextCollect/u.预制体文本收集.csv";

		// Token: 0x040033DC RID: 13276
		private const string TABLE = "PrefabTextItem";

		// Token: 0x040033DD RID: 13277
		private const string COMMAND = "select BinData from `PrefabTextItem` where ItemId = ?";

		// Token: 0x040033DE RID: 13278
		private const string KEY_PREFIX = "PrefabTextItemByItemId";

		// Token: 0x040033DF RID: 13279
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033E0 RID: 13280
		private static int HandleId;
	}
}
