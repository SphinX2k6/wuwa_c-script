using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D3 RID: 979
	public class ConfigHelpTextByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x000DB5B0 File Offset: 0x000D97B0
		static ConfigHelpTextByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHelpTextByGroupId.CreateStaticDefaultValue), new Action(ConfigHelpTextByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000DB5D0 File Offset: 0x000D97D0
		public static void CreateStaticDefaultValue()
		{
			ConfigHelpTextByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHelpTextByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_help.db"),
				new ValueTuple<string, object>("文件", "b.帮助.xlsx"),
				new ValueTuple<string, object>("表名", "HelpText"),
				new ValueTuple<string, object>("语句", "select BinData from `HelpText` where GroupId=? Order By Id")
			});
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000DB64F File Offset: 0x000D984F
		public static void ResetStaticDefaultValue()
		{
			ConfigHelpTextByGroupId.LogPair = null;
			ConfigHelpTextByGroupId.HandleId = 0;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000DB65D File Offset: 0x000D985D
		public static void Init()
		{
			ConfigHelpTextByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigHelpTextByGroupId.HandleId, "db_help.db", "select BinData from `HelpText` where GroupId=? Order By Id");
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x000DB678 File Offset: 0x000D9878
		[NullableContext(2)]
		public static IReadOnlyList<HelpText> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHelpTextByGroupId.HandleId, ConfigHelpTextByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HelpTextByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<HelpText> readOnlyList = (IReadOnlyList<HelpText>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHelpTextByGroupId.LogPair.Clear();
			ConfigHelpTextByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigHelpTextByGroupId.HandleId, 1, p0GroupId, ConfigHelpTextByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigHelpTextByGroupId.HandleId, ConfigHelpTextByGroupId.LogPair);
				return null;
			}
			List<HelpText> list = new List<HelpText>();
			while (ConfigCommon.Step(ConfigHelpTextByGroupId.HandleId, false, ConfigHelpTextByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHelpTextByGroupId.HandleId, 0, ConfigHelpTextByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHelpTextByGroupId.HandleId, ConfigHelpTextByGroupId.LogPair);
					return null;
				}
				HelpText rootAsHelpText = HelpText.GetRootAsHelpText(new ByteBuffer(item2));
				list.Add(rootAsHelpText);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HelpTextByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHelpTextByGroupId.HandleId, ConfigHelpTextByGroupId.LogPair);
			return list;
		}

		// Token: 0x04001AA9 RID: 6825
		private const string DB = "db_help.db";

		// Token: 0x04001AAA RID: 6826
		private const string FILE = "b.帮助.xlsx";

		// Token: 0x04001AAB RID: 6827
		private const string TABLE = "HelpText";

		// Token: 0x04001AAC RID: 6828
		private const string COMMAND = "select BinData from `HelpText` where GroupId=? Order By Id";

		// Token: 0x04001AAD RID: 6829
		private const string KEY_PREFIX = "HelpTextByGroupId";

		// Token: 0x04001AAE RID: 6830
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AAF RID: 6831
		private static int HandleId;
	}
}
