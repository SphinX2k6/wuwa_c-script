using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FE RID: 510
	public class ConfigDangoMonopolyMapPointByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BF7 RID: 3063 RVA: 0x000A0DFC File Offset: 0x0009EFFC
		static ConfigDangoMonopolyMapPointByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyMapPointByActivityId.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyMapPointByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000A0E1C File Offset: 0x0009F01C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyMapPointByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyMapPointByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyMapPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyMapPoint` where SeasonId=?")
			});
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000A0E9B File Offset: 0x0009F09B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyMapPointByActivityId.LogPair = null;
			ConfigDangoMonopolyMapPointByActivityId.HandleId = 0;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000A0EA9 File Offset: 0x0009F0A9
		public static void Init()
		{
			ConfigDangoMonopolyMapPointByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyMapPointByActivityId.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyMapPoint` where SeasonId=?");
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000A0EC4 File Offset: 0x0009F0C4
		[NullableContext(2)]
		public static IReadOnlyList<DangoMonopolyMapPoint> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyMapPointByActivityId.HandleId, ConfigDangoMonopolyMapPointByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyMapPointByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<DangoMonopolyMapPoint> readOnlyList = (IReadOnlyList<DangoMonopolyMapPoint>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDangoMonopolyMapPointByActivityId.LogPair.Clear();
			ConfigDangoMonopolyMapPointByActivityId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyMapPointByActivityId.HandleId, 1, p0SeasonId, ConfigDangoMonopolyMapPointByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigDangoMonopolyMapPointByActivityId.HandleId, ConfigDangoMonopolyMapPointByActivityId.LogPair);
				return null;
			}
			List<DangoMonopolyMapPoint> list = new List<DangoMonopolyMapPoint>();
			while (ConfigCommon.Step(ConfigDangoMonopolyMapPointByActivityId.HandleId, false, ConfigDangoMonopolyMapPointByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyMapPointByActivityId.HandleId, 0, ConfigDangoMonopolyMapPointByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoMonopolyMapPointByActivityId.HandleId, ConfigDangoMonopolyMapPointByActivityId.LogPair);
					return null;
				}
				DangoMonopolyMapPoint rootAsDangoMonopolyMapPoint = DangoMonopolyMapPoint.GetRootAsDangoMonopolyMapPoint(new ByteBuffer(item2));
				list.Add(rootAsDangoMonopolyMapPoint);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyMapPointByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyMapPointByActivityId.HandleId, ConfigDangoMonopolyMapPointByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000DD6 RID: 3542
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DD7 RID: 3543
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DD8 RID: 3544
		private const string TABLE = "DangoMonopolyMapPoint";

		// Token: 0x04000DD9 RID: 3545
		private const string COMMAND = "select BinData from `DangoMonopolyMapPoint` where SeasonId=?";

		// Token: 0x04000DDA RID: 3546
		private const string KEY_PREFIX = "DangoMonopolyMapPointByActivityId";

		// Token: 0x04000DDB RID: 3547
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DDC RID: 3548
		private static int HandleId;
	}
}
