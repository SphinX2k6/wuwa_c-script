using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3A RID: 2874
	public class ConfigUiDynamicTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004370 RID: 17264 RVA: 0x001DA449 File Offset: 0x001D8649
		static ConfigUiDynamicTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiDynamicTabById.CreateStaticDefaultValue), new Action(ConfigUiDynamicTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x001DA468 File Offset: 0x001D8668
		public static void CreateStaticDefaultValue()
		{
			ConfigUiDynamicTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiDynamicTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui.db"),
				new ValueTuple<string, object>("文件", "u.UI动态页签.csv"),
				new ValueTuple<string, object>("表名", "UiDynamicTab"),
				new ValueTuple<string, object>("语句", "select BinData from `UiDynamicTab` where Id = ?")
			});
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x001DA4E7 File Offset: 0x001D86E7
		public static void ResetStaticDefaultValue()
		{
			ConfigUiDynamicTabById.LogPair = null;
			ConfigUiDynamicTabById.HandleId = 0;
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x001DA4F5 File Offset: 0x001D86F5
		public static void Init()
		{
			ConfigUiDynamicTabById.HandleId = ConfigCommon.InitDataStatement(ConfigUiDynamicTabById.HandleId, "db_ui.db", "select BinData from `UiDynamicTab` where Id = ?");
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x001DA510 File Offset: 0x001D8710
		public static UiDynamicTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiDynamicTabById.HandleId, ConfigUiDynamicTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiDynamicTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new UiDynamicTab?(UiDynamicTab.GetRootAsUiDynamicTab(configBuffer));
				}
			}
			ConfigUiDynamicTabById.LogPair.Clear();
			ConfigUiDynamicTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigUiDynamicTabById.HandleId, 1, p0Id, ConfigUiDynamicTabById.LogPair) || ConfigCommon.Step(ConfigUiDynamicTabById.HandleId, true, ConfigUiDynamicTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiDynamicTabById.HandleId, ConfigUiDynamicTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiDynamicTabById.HandleId, 0, ConfigUiDynamicTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiDynamicTabById.HandleId, ConfigUiDynamicTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiDynamicTab rootAsUiDynamicTab = UiDynamicTab.GetRootAsUiDynamicTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiDynamicTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiDynamicTabById.HandleId, ConfigUiDynamicTabById.LogPair);
			return new UiDynamicTab?(rootAsUiDynamicTab);
		}

		// Token: 0x04004E7C RID: 20092
		private const string DB = "db_ui.db";

		// Token: 0x04004E7D RID: 20093
		private const string FILE = "u.UI动态页签.csv";

		// Token: 0x04004E7E RID: 20094
		private const string TABLE = "UiDynamicTab";

		// Token: 0x04004E7F RID: 20095
		private const string COMMAND = "select BinData from `UiDynamicTab` where Id = ?";

		// Token: 0x04004E80 RID: 20096
		private const string KEY_PREFIX = "UiDynamicTabById";

		// Token: 0x04004E81 RID: 20097
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E82 RID: 20098
		private static int HandleId;
	}
}
