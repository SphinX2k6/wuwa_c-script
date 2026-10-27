using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000129 RID: 297
	public class ConfigBuffItemCdGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x000810AB File Offset: 0x0007F2AB
		static ConfigBuffItemCdGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffItemCdGroupById.CreateStaticDefaultValue), new Action(ConfigBuffItemCdGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000810CC File Offset: 0x0007F2CC
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

		// Token: 0x060006F9 RID: 1785 RVA: 0x0008114B File Offset: 0x0007F34B
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffItemCdGroupById.LogPair = null;
			ConfigBuffItemCdGroupById.HandleId = 0;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00081159 File Offset: 0x0007F359
		public static void Init()
		{
			ConfigBuffItemCdGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffItemCdGroupById.HandleId, "db_itemattributereward.db", "select BinData from `BuffItemCdGroup` where Id=?");
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00081174 File Offset: 0x0007F374
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

		// Token: 0x04000803 RID: 2051
		private const string DB = "db_itemattributereward.db";

		// Token: 0x04000804 RID: 2052
		private const string FILE = "s.属性奖励.xlsx";

		// Token: 0x04000805 RID: 2053
		private const string TABLE = "BuffItemCdGroup";

		// Token: 0x04000806 RID: 2054
		private const string COMMAND = "select BinData from `BuffItemCdGroup` where Id=?";

		// Token: 0x04000807 RID: 2055
		private const string KEY_PREFIX = "BuffItemCdGroupById";

		// Token: 0x04000808 RID: 2056
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000809 RID: 2057
		private static int HandleId;
	}
}
