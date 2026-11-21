using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A43 RID: 2627
	public class ConfigSpecialItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DA6 RID: 15782 RVA: 0x001B9248 File Offset: 0x001B7448
		static ConfigSpecialItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpecialItemById.CreateStaticDefaultValue), new Action(ConfigSpecialItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x001B9268 File Offset: 0x001B7468
		public static void CreateStaticDefaultValue()
		{
			ConfigSpecialItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpecialItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_special_item.db"),
				new ValueTuple<string, object>("文件", "t.特殊道具.xlsx"),
				new ValueTuple<string, object>("表名", "SpecialItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SpecialItem` where Id = ?")
			});
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x001B92E7 File Offset: 0x001B74E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSpecialItemById.LogPair = null;
			ConfigSpecialItemById.HandleId = 0;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x001B92F5 File Offset: 0x001B74F5
		public static void Init()
		{
			ConfigSpecialItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSpecialItemById.HandleId, "db_special_item.db", "select BinData from `SpecialItem` where Id = ?");
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x001B9310 File Offset: 0x001B7510
		public static SpecialItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpecialItemById.HandleId, ConfigSpecialItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpecialItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpecialItem?(SpecialItem.GetRootAsSpecialItem(configBuffer));
				}
			}
			ConfigSpecialItemById.LogPair.Clear();
			ConfigSpecialItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpecialItemById.HandleId, 1, p0Id, ConfigSpecialItemById.LogPair) || ConfigCommon.Step(ConfigSpecialItemById.HandleId, true, ConfigSpecialItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpecialItemById.HandleId, ConfigSpecialItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpecialItemById.HandleId, 0, ConfigSpecialItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpecialItemById.HandleId, ConfigSpecialItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpecialItem rootAsSpecialItem = SpecialItem.GetRootAsSpecialItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpecialItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpecialItemById.HandleId, ConfigSpecialItemById.LogPair);
			return new SpecialItem?(rootAsSpecialItem);
		}

		// Token: 0x040047BB RID: 18363
		private const string DB = "db_special_item.db";

		// Token: 0x040047BC RID: 18364
		private const string FILE = "t.特殊道具.xlsx";

		// Token: 0x040047BD RID: 18365
		private const string TABLE = "SpecialItem";

		// Token: 0x040047BE RID: 18366
		private const string COMMAND = "select BinData from `SpecialItem` where Id = ?";

		// Token: 0x040047BF RID: 18367
		private const string KEY_PREFIX = "SpecialItemById";

		// Token: 0x040047C0 RID: 18368
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047C1 RID: 18369
		private static int HandleId;
	}
}
