using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A65 RID: 2661
	public class ConfigUiDynamicTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E72 RID: 15986 RVA: 0x001BB0B5 File Offset: 0x001B92B5
		static ConfigUiDynamicTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiDynamicTabById.CreateStaticDefaultValue), new Action(ConfigUiDynamicTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x001BB0D4 File Offset: 0x001B92D4
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

		// Token: 0x06003E74 RID: 15988 RVA: 0x001BB153 File Offset: 0x001B9353
		public static void ResetStaticDefaultValue()
		{
			ConfigUiDynamicTabById.LogPair = null;
			ConfigUiDynamicTabById.HandleId = 0;
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x001BB161 File Offset: 0x001B9361
		public static void Init()
		{
			ConfigUiDynamicTabById.HandleId = ConfigCommon.InitDataStatement(ConfigUiDynamicTabById.HandleId, "db_ui.db", "select BinData from `UiDynamicTab` where Id = ?");
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x001BB17C File Offset: 0x001B937C
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

		// Token: 0x040048A9 RID: 18601
		private const string DB = "db_ui.db";

		// Token: 0x040048AA RID: 18602
		private const string FILE = "u.UI动态页签.csv";

		// Token: 0x040048AB RID: 18603
		private const string TABLE = "UiDynamicTab";

		// Token: 0x040048AC RID: 18604
		private const string COMMAND = "select BinData from `UiDynamicTab` where Id = ?";

		// Token: 0x040048AD RID: 18605
		private const string KEY_PREFIX = "UiDynamicTabById";

		// Token: 0x040048AE RID: 18606
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048AF RID: 18607
		private static int HandleId;
	}
}
