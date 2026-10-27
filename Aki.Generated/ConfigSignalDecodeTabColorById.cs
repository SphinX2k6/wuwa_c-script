using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092A RID: 2346
	public class ConfigSignalDecodeTabColorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600370F RID: 14095 RVA: 0x00190A85 File Offset: 0x0018EC85
		static ConfigSignalDecodeTabColorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSignalDecodeTabColorById.CreateStaticDefaultValue), new Action(ConfigSignalDecodeTabColorById.ResetStaticDefaultValue));
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00190AA4 File Offset: 0x0018ECA4
		public static void CreateStaticDefaultValue()
		{
			ConfigSignalDecodeTabColorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSignalDecodeTabColorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_signaldecodetabcolor.db"),
				new ValueTuple<string, object>("文件", "x.信号破译页签颜色.csv"),
				new ValueTuple<string, object>("表名", "SignalDecodeTabColor"),
				new ValueTuple<string, object>("语句", "select BinData from `SignalDecodeTabColor` where Id=?")
			});
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00190B23 File Offset: 0x0018ED23
		public static void ResetStaticDefaultValue()
		{
			ConfigSignalDecodeTabColorById.LogPair = null;
			ConfigSignalDecodeTabColorById.HandleId = 0;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00190B31 File Offset: 0x0018ED31
		public static void Init()
		{
			ConfigSignalDecodeTabColorById.HandleId = ConfigCommon.InitDataStatement(ConfigSignalDecodeTabColorById.HandleId, "db_signaldecodetabcolor.db", "select BinData from `SignalDecodeTabColor` where Id=?");
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00190B4C File Offset: 0x0018ED4C
		public static SignalDecodeTabColor? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignalDecodeTabColorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SignalDecodeTabColor?(SignalDecodeTabColor.GetRootAsSignalDecodeTabColor(configBuffer));
				}
			}
			ConfigSignalDecodeTabColorById.LogPair.Clear();
			ConfigSignalDecodeTabColorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSignalDecodeTabColorById.HandleId, 1, p0Id, ConfigSignalDecodeTabColorById.LogPair) || ConfigCommon.Step(ConfigSignalDecodeTabColorById.HandleId, true, ConfigSignalDecodeTabColorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSignalDecodeTabColorById.HandleId, 0, ConfigSignalDecodeTabColorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SignalDecodeTabColor rootAsSignalDecodeTabColor = SignalDecodeTabColor.GetRootAsSignalDecodeTabColor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignalDecodeTabColorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSignalDecodeTabColorById.HandleId, ConfigSignalDecodeTabColorById.LogPair);
			return new SignalDecodeTabColor?(rootAsSignalDecodeTabColor);
		}

		// Token: 0x0400400C RID: 16396
		private const string DB = "db_signaldecodetabcolor.db";

		// Token: 0x0400400D RID: 16397
		private const string FILE = "x.信号破译页签颜色.csv";

		// Token: 0x0400400E RID: 16398
		private const string TABLE = "SignalDecodeTabColor";

		// Token: 0x0400400F RID: 16399
		private const string COMMAND = "select BinData from `SignalDecodeTabColor` where Id=?";

		// Token: 0x04004010 RID: 16400
		private const string KEY_PREFIX = "SignalDecodeTabColorById";

		// Token: 0x04004011 RID: 16401
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004012 RID: 16402
		private static int HandleId;
	}
}
