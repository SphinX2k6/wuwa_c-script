using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000262 RID: 610
	public class ConfigElementInfoById2 : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x000AA540 File Offset: 0x000A8740
		static ConfigElementInfoById2()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementInfoById2.CreateStaticDefaultValue), new Action(ConfigElementInfoById2.ResetStaticDefaultValue));
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000AA560 File Offset: 0x000A8760
		public static void CreateStaticDefaultValue()
		{
			ConfigElementInfoById2.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementInfoById2.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_element_info.db"),
				new ValueTuple<string, object>("文件", "y.元素属性.xlsx"),
				new ValueTuple<string, object>("表名", "ElementInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementInfo` where Id<>?")
			});
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000AA5DF File Offset: 0x000A87DF
		public static void ResetStaticDefaultValue()
		{
			ConfigElementInfoById2.LogPair = null;
			ConfigElementInfoById2.HandleId = 0;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000AA5ED File Offset: 0x000A87ED
		public static void Init()
		{
			ConfigElementInfoById2.HandleId = ConfigCommon.InitDataStatement(ConfigElementInfoById2.HandleId, "db_element_info.db", "select BinData from `ElementInfo` where Id<>?");
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000AA608 File Offset: 0x000A8808
		[NullableContext(2)]
		public static IReadOnlyList<ElementInfo> GetConfigList(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementInfoById2.HandleId, ConfigElementInfoById2.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementInfoById2");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				IReadOnlyList<ElementInfo> readOnlyList = (IReadOnlyList<ElementInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigElementInfoById2.LogPair.Clear();
			ConfigElementInfoById2.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigElementInfoById2.HandleId, 1, p0Id, ConfigElementInfoById2.LogPair))
			{
				ConfigCommon.Reset(ConfigElementInfoById2.HandleId, ConfigElementInfoById2.LogPair);
				return null;
			}
			List<ElementInfo> list = new List<ElementInfo>();
			while (ConfigCommon.Step(ConfigElementInfoById2.HandleId, false, ConfigElementInfoById2.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementInfoById2.HandleId, 0, ConfigElementInfoById2.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigElementInfoById2.HandleId, ConfigElementInfoById2.LogPair);
					return null;
				}
				ElementInfo rootAsElementInfo = ElementInfo.GetRootAsElementInfo(new ByteBuffer(item2));
				list.Add(rootAsElementInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementInfoById2");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigElementInfoById2.HandleId, ConfigElementInfoById2.LogPair);
			return list;
		}

		// Token: 0x04001092 RID: 4242
		private const string DB = "db_element_info.db";

		// Token: 0x04001093 RID: 4243
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x04001094 RID: 4244
		private const string TABLE = "ElementInfo";

		// Token: 0x04001095 RID: 4245
		private const string COMMAND = "select BinData from `ElementInfo` where Id<>?";

		// Token: 0x04001096 RID: 4246
		private const string KEY_PREFIX = "ElementInfoById2";

		// Token: 0x04001097 RID: 4247
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001098 RID: 4248
		private static int HandleId;
	}
}
