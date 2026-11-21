using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AB RID: 1195
	public class ConfigKurotatoHandbookByActivityIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C0D RID: 7181 RVA: 0x000FB7C3 File Offset: 0x000F99C3
		static ConfigKurotatoHandbookByActivityIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoHandbookByActivityIdAndType.CreateStaticDefaultValue), new Action(ConfigKurotatoHandbookByActivityIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000FB7E4 File Offset: 0x000F99E4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoHandbookByActivityIdAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoHandbookByActivityIdAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoHandbook"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoHandbook` where ActivityId=? And Type=?")
			});
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000FB863 File Offset: 0x000F9A63
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoHandbookByActivityIdAndType.LogPair = null;
			ConfigKurotatoHandbookByActivityIdAndType.HandleId = 0;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000FB871 File Offset: 0x000F9A71
		public static void Init()
		{
			ConfigKurotatoHandbookByActivityIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoHandbookByActivityIdAndType.HandleId, "db_kurotato.db", "select BinData from `KurotatoHandbook` where ActivityId=? And Type=?");
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000FB88C File Offset: 0x000F9A8C
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoHandbook> GetConfigList(int p0ActivityId, int p1Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoHandbookByActivityIdAndType.HandleId, ConfigKurotatoHandbookByActivityIdAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoHandbookByActivityIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				IReadOnlyList<KurotatoHandbook> readOnlyList = (IReadOnlyList<KurotatoHandbook>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKurotatoHandbookByActivityIdAndType.LogPair.Clear();
			ConfigKurotatoHandbookByActivityIdAndType.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigKurotatoHandbookByActivityIdAndType.LogPair.Add(new ValueTuple<string, object>("Type", p1Type));
			if (!ConfigCommon.BindInt(ConfigKurotatoHandbookByActivityIdAndType.HandleId, 1, p0ActivityId, ConfigKurotatoHandbookByActivityIdAndType.LogPair) || !ConfigCommon.BindInt(ConfigKurotatoHandbookByActivityIdAndType.HandleId, 2, p1Type, ConfigKurotatoHandbookByActivityIdAndType.LogPair))
			{
				ConfigCommon.Reset(ConfigKurotatoHandbookByActivityIdAndType.HandleId, ConfigKurotatoHandbookByActivityIdAndType.LogPair);
				return null;
			}
			List<KurotatoHandbook> list = new List<KurotatoHandbook>();
			while (ConfigCommon.Step(ConfigKurotatoHandbookByActivityIdAndType.HandleId, false, ConfigKurotatoHandbookByActivityIdAndType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoHandbookByActivityIdAndType.HandleId, 0, ConfigKurotatoHandbookByActivityIdAndType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoHandbookByActivityIdAndType.HandleId, ConfigKurotatoHandbookByActivityIdAndType.LogPair);
					return null;
				}
				KurotatoHandbook rootAsKurotatoHandbook = KurotatoHandbook.GetRootAsKurotatoHandbook(new ByteBuffer(item2));
				list.Add(rootAsKurotatoHandbook);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoHandbookByActivityIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoHandbookByActivityIdAndType.HandleId, ConfigKurotatoHandbookByActivityIdAndType.LogPair);
			return list;
		}

		// Token: 0x04002091 RID: 8337
		private const string DB = "db_kurotato.db";

		// Token: 0x04002092 RID: 8338
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04002093 RID: 8339
		private const string TABLE = "KurotatoHandbook";

		// Token: 0x04002094 RID: 8340
		private const string COMMAND = "select BinData from `KurotatoHandbook` where ActivityId=? And Type=?";

		// Token: 0x04002095 RID: 8341
		private const string KEY_PREFIX = "KurotatoHandbookByActivityIdAndType";

		// Token: 0x04002096 RID: 8342
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002097 RID: 8343
		private static int HandleId;
	}
}
