using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000495 RID: 1173
	public class ConfigKurotatoHandbookByActivityIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B89 RID: 7049 RVA: 0x000F506F File Offset: 0x000F326F
		static ConfigKurotatoHandbookByActivityIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoHandbookByActivityIdAndType.CreateStaticDefaultValue), new Action(ConfigKurotatoHandbookByActivityIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000F5090 File Offset: 0x000F3290
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

		// Token: 0x06001B8B RID: 7051 RVA: 0x000F510F File Offset: 0x000F330F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoHandbookByActivityIdAndType.LogPair = null;
			ConfigKurotatoHandbookByActivityIdAndType.HandleId = 0;
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000F511D File Offset: 0x000F331D
		public static void Init()
		{
			ConfigKurotatoHandbookByActivityIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoHandbookByActivityIdAndType.HandleId, "db_kurotato.db", "select BinData from `KurotatoHandbook` where ActivityId=? And Type=?");
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000F5138 File Offset: 0x000F3338
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

		// Token: 0x04001FF7 RID: 8183
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FF8 RID: 8184
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04001FF9 RID: 8185
		private const string TABLE = "KurotatoHandbook";

		// Token: 0x04001FFA RID: 8186
		private const string COMMAND = "select BinData from `KurotatoHandbook` where ActivityId=? And Type=?";

		// Token: 0x04001FFB RID: 8187
		private const string KEY_PREFIX = "KurotatoHandbookByActivityIdAndType";

		// Token: 0x04001FFC RID: 8188
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FFD RID: 8189
		private static int HandleId;
	}
}
