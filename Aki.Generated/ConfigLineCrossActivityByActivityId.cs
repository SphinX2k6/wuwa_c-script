using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D7 RID: 1239
	public class ConfigLineCrossActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x000FD8B8 File Offset: 0x000FBAB8
		static ConfigLineCrossActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLineCrossActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigLineCrossActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000FD8D8 File Offset: 0x000FBAD8
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

		// Token: 0x06001D17 RID: 7447 RVA: 0x000FD957 File Offset: 0x000FBB57
		public static void ResetStaticDefaultValue()
		{
			ConfigLineCrossActivityByActivityId.LogPair = null;
			ConfigLineCrossActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000FD965 File Offset: 0x000FBB65
		public static void Init()
		{
			ConfigLineCrossActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLineCrossActivityByActivityId.HandleId, "db_linecross.db", "select BinData from `LineCrossActivity` where ActivityId=?");
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000FD980 File Offset: 0x000FBB80
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

		// Token: 0x040021C5 RID: 8645
		private const string DB = "db_linecross.db";

		// Token: 0x040021C6 RID: 8646
		private const string FILE = "s.十字连线.xlsx";

		// Token: 0x040021C7 RID: 8647
		private const string TABLE = "LineCrossActivity";

		// Token: 0x040021C8 RID: 8648
		private const string COMMAND = "select BinData from `LineCrossActivity` where ActivityId=?";

		// Token: 0x040021C9 RID: 8649
		private const string KEY_PREFIX = "LineCrossActivityByActivityId";

		// Token: 0x040021CA RID: 8650
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021CB RID: 8651
		private static int HandleId;
	}
}
