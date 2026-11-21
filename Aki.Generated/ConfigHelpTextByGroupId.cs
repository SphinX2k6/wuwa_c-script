using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E9 RID: 1001
	public class ConfigHelpTextByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600177D RID: 6013 RVA: 0x000E1D04 File Offset: 0x000DFF04
		static ConfigHelpTextByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHelpTextByGroupId.CreateStaticDefaultValue), new Action(ConfigHelpTextByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000E1D24 File Offset: 0x000DFF24
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

		// Token: 0x0600177F RID: 6015 RVA: 0x000E1DA3 File Offset: 0x000DFFA3
		public static void ResetStaticDefaultValue()
		{
			ConfigHelpTextByGroupId.LogPair = null;
			ConfigHelpTextByGroupId.HandleId = 0;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000E1DB1 File Offset: 0x000DFFB1
		public static void Init()
		{
			ConfigHelpTextByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigHelpTextByGroupId.HandleId, "db_help.db", "select BinData from `HelpText` where GroupId=? Order By Id");
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000E1DCC File Offset: 0x000DFFCC
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

		// Token: 0x04001B43 RID: 6979
		private const string DB = "db_help.db";

		// Token: 0x04001B44 RID: 6980
		private const string FILE = "b.帮助.xlsx";

		// Token: 0x04001B45 RID: 6981
		private const string TABLE = "HelpText";

		// Token: 0x04001B46 RID: 6982
		private const string COMMAND = "select BinData from `HelpText` where GroupId=? Order By Id";

		// Token: 0x04001B47 RID: 6983
		private const string KEY_PREFIX = "HelpTextByGroupId";

		// Token: 0x04001B48 RID: 6984
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B49 RID: 6985
		private static int HandleId;
	}
}
