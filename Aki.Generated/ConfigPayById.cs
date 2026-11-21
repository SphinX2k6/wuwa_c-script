using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000651 RID: 1617
	public class ConfigPayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025F6 RID: 9718 RVA: 0x00133C9D File Offset: 0x00131E9D
		static ConfigPayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayById.CreateStaticDefaultValue), new Action(ConfigPayById.ResetStaticDefaultValue));
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00133CBC File Offset: 0x00131EBC
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

		// Token: 0x060025F8 RID: 9720 RVA: 0x00133D3B File Offset: 0x00131F3B
		public static void ResetStaticDefaultValue()
		{
			ConfigPayById.LogPair = null;
			ConfigPayById.HandleId = 0;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00133D49 File Offset: 0x00131F49
		public static void Init()
		{
			ConfigPayById.HandleId = ConfigCommon.InitDataStatement(ConfigPayById.HandleId, "db_paycurrency.db", "select BinData from `Pay` where Id=?");
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00133D64 File Offset: 0x00131F64
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

		// Token: 0x04002C1D RID: 11293
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002C1E RID: 11294
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002C1F RID: 11295
		private const string TABLE = "Pay";

		// Token: 0x04002C20 RID: 11296
		private const string COMMAND = "select BinData from `Pay` where Id=?";

		// Token: 0x04002C21 RID: 11297
		private const string KEY_PREFIX = "PayById";

		// Token: 0x04002C22 RID: 11298
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C23 RID: 11299
		private static int HandleId;
	}
}
