using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004ED RID: 1261
	public class ConfigLineCrossActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D99 RID: 7577 RVA: 0x0010400C File Offset: 0x0010220C
		static ConfigLineCrossActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigLineCrossActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0010402C File Offset: 0x0010222C
		public static void CreateStaticDefaultValue()
		{
			ConfigLineCrossActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLineCrossActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_linecross.db"),
				new ValueTuple<string, object>("文件", "s.十字连线.xlsx"),
				new ValueTuple<string, object>("表名", "LineCrossActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `LineCrossActivity` where ActivityId=?")
			});
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x001040AB File Offset: 0x001022AB
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossActivityByActivityId.LogPair = null;
			ConfigLineCrossActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x001040B9 File Offset: 0x001022B9
		public static void Init()
		{
			ConfigLineCrossActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossActivityByActivityId.HandleId, "db_linecross.db", "select BinData from `LineCrossActivity` where ActivityId=?");
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x001040D4 File Offset: 0x001022D4
		public static LineCrossActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLineCrossActivityByActivityId.HandleId, ConfigLineCrossActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LineCrossActivity?(LineCrossActivity.GetRootAsLineCrossActivity(configBuffer));
				}
			}
			ConfigLineCrossActivityByActivityId.LogPair.Clear();
			ConfigLineCrossActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigLineCrossActivityByActivityId.HandleId, 1, p0ActivityId, ConfigLineCrossActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigLineCrossActivityByActivityId.HandleId, true, ConfigLineCrossActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLineCrossActivityByActivityId.HandleId, ConfigLineCrossActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLineCrossActivityByActivityId.HandleId, 0, ConfigLineCrossActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLineCrossActivityByActivityId.HandleId, ConfigLineCrossActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LineCrossActivity rootAsLineCrossActivity = LineCrossActivity.GetRootAsLineCrossActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LineCrossActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLineCrossActivityByActivityId.HandleId, ConfigLineCrossActivityByActivityId.LogPair);
			return new LineCrossActivity?(rootAsLineCrossActivity);
		}

		// Token: 0x0400225F RID: 8799
		private const string DB = "db_linecross.db";

		// Token: 0x04002260 RID: 8800
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x04002261 RID: 8801
		private const string TABLE = "LineCrossActivity";

		// Token: 0x04002262 RID: 8802
		private const string COMMAND = "select BinData from `LineCrossActivity` where ActivityId=?";

		// Token: 0x04002263 RID: 8803
		private const string KEY_PREFIX = "LineCrossActivityByActivityId";

		// Token: 0x04002264 RID: 8804
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002265 RID: 8805
		private static int HandleId;
	}
}
