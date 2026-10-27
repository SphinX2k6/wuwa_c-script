using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096E RID: 2414
	public class ConfigSpecialItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038A8 RID: 14504 RVA: 0x00199EB4 File Offset: 0x001980B4
		static ConfigSpecialItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpecialItemById.CreateStaticDefaultValue), new Action(ConfigSpecialItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00199ED4 File Offset: 0x001980D4
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

		// Token: 0x060038AA RID: 14506 RVA: 0x00199F53 File Offset: 0x00198153
		public static void ResetStaticDefaultValue()
		{
			ConfigSpecialItemById.LogPair = null;
			ConfigSpecialItemById.HandleId = 0;
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00199F61 File Offset: 0x00198161
		public static void Init()
		{
			ConfigSpecialItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSpecialItemById.HandleId, "db_special_item.db", "select BinData from `SpecialItem` where Id = ?");
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00199F7C File Offset: 0x0019817C
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

		// Token: 0x040041E8 RID: 16872
		private const string DB = "db_special_item.db";

		// Token: 0x040041E9 RID: 16873
		private const string FILE = "t.特殊道具.xlsx";

		// Token: 0x040041EA RID: 16874
		private const string TABLE = "SpecialItem";

		// Token: 0x040041EB RID: 16875
		private const string COMMAND = "select BinData from `SpecialItem` where Id = ?";

		// Token: 0x040041EC RID: 16876
		private const string KEY_PREFIX = "SpecialItemById";

		// Token: 0x040041ED RID: 16877
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041EE RID: 16878
		private static int HandleId;
	}
}
