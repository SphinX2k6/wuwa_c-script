using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000016 RID: 22
	public class ConfigAbyssItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000084 RID: 132 RVA: 0x0005CE2B File Offset: 0x0005B02B
		static ConfigAbyssItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssItemById.CreateStaticDefaultValue), new Action(ConfigAbyssItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0005CE4C File Offset: 0x0005B04C
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssItem"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssItem` where Id=?")
			});
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0005CECB File Offset: 0x0005B0CB
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssItemById.LogPair = null;
			ConfigAbyssItemById.HandleId = 0;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0005CED9 File Offset: 0x0005B0D9
		public static void Init()
		{
			ConfigAbyssItemById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssItemById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssItem` where Id=?");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0005CEF4 File Offset: 0x0005B0F4
		public static AbyssItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssItemById.HandleId, ConfigAbyssItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssItem?(AbyssItem.GetRootAsAbyssItem(configBuffer));
				}
			}
			ConfigAbyssItemById.LogPair.Clear();
			ConfigAbyssItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssItemById.HandleId, 1, p0Id, ConfigAbyssItemById.LogPair) || ConfigCommon.Step(ConfigAbyssItemById.HandleId, true, ConfigAbyssItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssItemById.HandleId, ConfigAbyssItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssItemById.HandleId, 0, ConfigAbyssItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssItemById.HandleId, ConfigAbyssItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssItem rootAsAbyssItem = AbyssItem.GetRootAsAbyssItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssItemById.HandleId, ConfigAbyssItemById.LogPair);
			return new AbyssItem?(rootAsAbyssItem);
		}

		// Token: 0x0400007E RID: 126
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x0400007F RID: 127
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x04000080 RID: 128
		private const string TABLE = "AbyssItem";

		// Token: 0x04000081 RID: 129
		private const string COMMAND = "select BinData from `AbyssItem` where Id=?";

		// Token: 0x04000082 RID: 130
		private const string KEY_PREFIX = "AbyssItemById";

		// Token: 0x04000083 RID: 131
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000084 RID: 132
		private static int HandleId;
	}
}
