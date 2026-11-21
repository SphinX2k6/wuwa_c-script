using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000136 RID: 310
	public class ConfigBuffItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00086590 File Offset: 0x00084790
		static ConfigBuffItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffItemById.CreateStaticDefaultValue), new Action(ConfigBuffItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000865B0 File Offset: 0x000847B0
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

		// Token: 0x06000747 RID: 1863 RVA: 0x0008662F File Offset: 0x0008482F
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffItemById.LogPair = null;
			ConfigBuffItemById.HandleId = 0;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0008663D File Offset: 0x0008483D
		public static void Init()
		{
			ConfigBuffItemById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffItemById.HandleId, "db_itemattributereward.db", "select BinData from `BuffItem` where Id=?");
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00086658 File Offset: 0x00084858
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

		// Token: 0x0400085E RID: 2142
		private const string DB = "db_itemattributereward.db";

		// Token: 0x0400085F RID: 2143
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x04000860 RID: 2144
		private const string TABLE = "BuffItem";

		// Token: 0x04000861 RID: 2145
		private const string COMMAND = "select BinData from `BuffItem` where Id=?";

		// Token: 0x04000862 RID: 2146
		private const string KEY_PREFIX = "BuffItemById";

		// Token: 0x04000863 RID: 2147
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000864 RID: 2148
		private static int HandleId;
	}
}
