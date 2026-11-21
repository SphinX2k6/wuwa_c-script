using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000474 RID: 1140
	public class ConfigItemInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AC2 RID: 6850 RVA: 0x000F434F File Offset: 0x000F254F
		static ConfigItemInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemInfoById.CreateStaticDefaultValue), new Action(ConfigItemInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000F4370 File Offset: 0x000F2570
		public static void CreateStaticDefaultValue()
		{
			ConfigItemInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "ItemInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemInfo` where Id=?")
			});
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000F43EF File Offset: 0x000F25EF
		public static void ResetStaticDefaultValue()
		{
			ConfigItemInfoById.LogPair = null;
			ConfigItemInfoById.HandleId = 0;
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000F43FD File Offset: 0x000F25FD
		public static void Init()
		{
			ConfigItemInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigItemInfoById.HandleId, "db_item.db", "select BinData from `ItemInfo` where Id=?");
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x000F4418 File Offset: 0x000F2618
		public static ItemInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemInfo?(ItemInfo.GetRootAsItemInfo(configBuffer));
				}
			}
			ConfigItemInfoById.LogPair.Clear();
			ConfigItemInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemInfoById.HandleId, 1, p0Id, ConfigItemInfoById.LogPair) || ConfigCommon.Step(ConfigItemInfoById.HandleId, true, ConfigItemInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemInfoById.HandleId, 0, ConfigItemInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemInfo rootAsItemInfo = ItemInfo.GetRootAsItemInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemInfoById.HandleId, ConfigItemInfoById.LogPair);
			return new ItemInfo?(rootAsItemInfo);
		}

		// Token: 0x04001F10 RID: 7952
		private const string DB = "db_item.db";

		// Token: 0x04001F11 RID: 7953
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001F12 RID: 7954
		private const string TABLE = "ItemInfo";

		// Token: 0x04001F13 RID: 7955
		private const string COMMAND = "select BinData from `ItemInfo` where Id=?";

		// Token: 0x04001F14 RID: 7956
		private const string KEY_PREFIX = "ItemInfoById";

		// Token: 0x04001F15 RID: 7957
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F16 RID: 7958
		private static int HandleId;
	}
}
