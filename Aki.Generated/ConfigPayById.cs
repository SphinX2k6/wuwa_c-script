using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000639 RID: 1593
	public class ConfigPayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002566 RID: 9574 RVA: 0x0012D221 File Offset: 0x0012B421
		static ConfigPayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayById.CreateStaticDefaultValue), new Action(ConfigPayById.ResetStaticDefaultValue));
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0012D240 File Offset: 0x0012B440
		public static void CreateStaticDefaultValue()
		{
			ConfigPayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_paycurrency.db"),
				new ValueTuple<string, object>("文件", "c.充值.xlsx"),
				new ValueTuple<string, object>("表名", "Pay"),
				new ValueTuple<string, object>("语句", "select BinData from `Pay` where Id=?")
			});
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0012D2BF File Offset: 0x0012B4BF
		public static void ResetStaticDefaultValue()
		{
			ConfigPayById.LogPair = null;
			ConfigPayById.HandleId = 0;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0012D2CD File Offset: 0x0012B4CD
		public static void Init()
		{
			ConfigPayById.HandleId = ConfigCommon.InitDataStatement(ConfigPayById.HandleId, "db_paycurrency.db", "select BinData from `Pay` where Id=?");
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x0012D2E8 File Offset: 0x0012B4E8
		public static Pay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayById.HandleId, ConfigPayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Pay?(Pay.GetRootAsPay(configBuffer));
				}
			}
			ConfigPayById.LogPair.Clear();
			ConfigPayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPayById.HandleId, 1, p0Id, ConfigPayById.LogPair) || ConfigCommon.Step(ConfigPayById.HandleId, true, ConfigPayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayById.HandleId, ConfigPayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayById.HandleId, 0, ConfigPayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayById.HandleId, ConfigPayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Pay rootAsPay = Pay.GetRootAsPay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayById.HandleId, ConfigPayById.LogPair);
			return new Pay?(rootAsPay);
		}

		// Token: 0x04002B75 RID: 11125
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002B76 RID: 11126
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002B77 RID: 11127
		private const string TABLE = "Pay";

		// Token: 0x04002B78 RID: 11128
		private const string COMMAND = "select BinData from `Pay` where Id=?";

		// Token: 0x04002B79 RID: 11129
		private const string KEY_PREFIX = "PayById";

		// Token: 0x04002B7A RID: 11130
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B7B RID: 11131
		private static int HandleId;
	}
}
