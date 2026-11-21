using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000138 RID: 312
	public class ConfigBuffItemCdGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x00086A0F File Offset: 0x00084C0F
		static ConfigBuffItemCdGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffItemCdGroupById.CreateStaticDefaultValue), new Action(ConfigBuffItemCdGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00086A30 File Offset: 0x00084C30
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffItemCdGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffItemCdGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_itemattributereward.db"),
				new ValueTuple<string, object>("文件", "s.属性奖励.xlsx"),
				new ValueTuple<string, object>("表名", "BuffItemCdGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `BuffItemCdGroup` where Id=?")
			});
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00086AAF File Offset: 0x00084CAF
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffItemCdGroupById.LogPair = null;
			ConfigBuffItemCdGroupById.HandleId = 0;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00086ABD File Offset: 0x00084CBD
		public static void Init()
		{
			ConfigBuffItemCdGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffItemCdGroupById.HandleId, "db_itemattributereward.db", "select BinData from `BuffItemCdGroup` where Id=?");
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00086AD8 File Offset: 0x00084CD8
		public static BuffItemCdGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffItemCdGroupById.HandleId, ConfigBuffItemCdGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffItemCdGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BuffItemCdGroup?(BuffItemCdGroup.GetRootAsBuffItemCdGroup(configBuffer));
				}
			}
			ConfigBuffItemCdGroupById.LogPair.Clear();
			ConfigBuffItemCdGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBuffItemCdGroupById.HandleId, 1, p0Id, ConfigBuffItemCdGroupById.LogPair) || ConfigCommon.Step(ConfigBuffItemCdGroupById.HandleId, true, ConfigBuffItemCdGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuffItemCdGroupById.HandleId, ConfigBuffItemCdGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffItemCdGroupById.HandleId, 0, ConfigBuffItemCdGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuffItemCdGroupById.HandleId, ConfigBuffItemCdGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BuffItemCdGroup rootAsBuffItemCdGroup = BuffItemCdGroup.GetRootAsBuffItemCdGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffItemCdGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuffItemCdGroupById.HandleId, ConfigBuffItemCdGroupById.LogPair);
			return new BuffItemCdGroup?(rootAsBuffItemCdGroup);
		}

		// Token: 0x0400086C RID: 2156
		private const string DB = "db_itemattributereward.db";

		// Token: 0x0400086D RID: 2157
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x0400086E RID: 2158
		private const string TABLE = "BuffItemCdGroup";

		// Token: 0x0400086F RID: 2159
		private const string COMMAND = "select BinData from `BuffItemCdGroup` where Id=?";

		// Token: 0x04000870 RID: 2160
		private const string KEY_PREFIX = "BuffItemCdGroupById";

		// Token: 0x04000871 RID: 2161
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000872 RID: 2162
		private static int HandleId;
	}
}
