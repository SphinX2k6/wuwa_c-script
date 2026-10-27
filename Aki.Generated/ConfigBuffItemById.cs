using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000127 RID: 295
	public class ConfigBuffItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00080C2C File Offset: 0x0007EE2C
		static ConfigBuffItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffItemById.CreateStaticDefaultValue), new Action(ConfigBuffItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00080C4C File Offset: 0x0007EE4C
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_itemattributereward.db"),
				new ValueTuple<string, object>("文件", "s.属性奖励.xlsx"),
				new ValueTuple<string, object>("表名", "BuffItem"),
				new ValueTuple<string, object>("语句", "select BinData from `BuffItem` where Id=?")
			});
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00080CCB File Offset: 0x0007EECB
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffItemById.LogPair = null;
			ConfigBuffItemById.HandleId = 0;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00080CD9 File Offset: 0x0007EED9
		public static void Init()
		{
			ConfigBuffItemById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffItemById.HandleId, "db_itemattributereward.db", "select BinData from `BuffItem` where Id=?");
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00080CF4 File Offset: 0x0007EEF4
		public static BuffItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffItemById.HandleId, ConfigBuffItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BuffItem?(BuffItem.GetRootAsBuffItem(configBuffer));
				}
			}
			ConfigBuffItemById.LogPair.Clear();
			ConfigBuffItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBuffItemById.HandleId, 1, p0Id, ConfigBuffItemById.LogPair) || ConfigCommon.Step(ConfigBuffItemById.HandleId, true, ConfigBuffItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuffItemById.HandleId, ConfigBuffItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffItemById.HandleId, 0, ConfigBuffItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuffItemById.HandleId, ConfigBuffItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BuffItem rootAsBuffItem = BuffItem.GetRootAsBuffItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuffItemById.HandleId, ConfigBuffItemById.LogPair);
			return new BuffItem?(rootAsBuffItem);
		}

		// Token: 0x040007F5 RID: 2037
		private const string DB = "db_itemattributereward.db";

		// Token: 0x040007F6 RID: 2038
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x040007F7 RID: 2039
		private const string TABLE = "BuffItem";

		// Token: 0x040007F8 RID: 2040
		private const string COMMAND = "select BinData from `BuffItem` where Id=?";

		// Token: 0x040007F9 RID: 2041
		private const string KEY_PREFIX = "BuffItemById";

		// Token: 0x040007FA RID: 2042
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007FB RID: 2043
		private static int HandleId;
	}
}
