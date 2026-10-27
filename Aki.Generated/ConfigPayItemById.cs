using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063F RID: 1599
	public class ConfigPayItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600258A RID: 9610 RVA: 0x0012DE47 File Offset: 0x0012C047
		static ConfigPayItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayItemById.CreateStaticDefaultValue), new Action(ConfigPayItemById.ResetStaticDefaultValue));
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x0012DE68 File Offset: 0x0012C068
		public static void CreateStaticDefaultValue()
		{
			ConfigPayItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPayItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_paycurrency.db"),
				new ValueTuple<string, object>("文件", "c.充值.xlsx"),
				new ValueTuple<string, object>("表名", "PayItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PayItem` where Id=?")
			});
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x0012DEE7 File Offset: 0x0012C0E7
		public static void ResetStaticDefaultValue()
		{
			ConfigPayItemById.LogPair = null;
			ConfigPayItemById.HandleId = 0;
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x0012DEF5 File Offset: 0x0012C0F5
		public static void Init()
		{
			ConfigPayItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPayItemById.HandleId, "db_paycurrency.db", "select BinData from `PayItem` where Id=?");
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x0012DF10 File Offset: 0x0012C110
		public static PayItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPayItemById.HandleId, ConfigPayItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PayItem?(PayItem.GetRootAsPayItem(configBuffer));
				}
			}
			ConfigPayItemById.LogPair.Clear();
			ConfigPayItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPayItemById.HandleId, 1, p0Id, ConfigPayItemById.LogPair) || ConfigCommon.Step(ConfigPayItemById.HandleId, true, ConfigPayItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPayItemById.HandleId, ConfigPayItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPayItemById.HandleId, 0, ConfigPayItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPayItemById.HandleId, ConfigPayItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PayItem rootAsPayItem = PayItem.GetRootAsPayItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PayItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPayItemById.HandleId, ConfigPayItemById.LogPair);
			return new PayItem?(rootAsPayItem);
		}

		// Token: 0x04002B9F RID: 11167
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002BA0 RID: 11168
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002BA1 RID: 11169
		private const string TABLE = "PayItem";

		// Token: 0x04002BA2 RID: 11170
		private const string COMMAND = "select BinData from `PayItem` where Id=?";

		// Token: 0x04002BA3 RID: 11171
		private const string KEY_PREFIX = "PayItemById";

		// Token: 0x04002BA4 RID: 11172
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BA5 RID: 11173
		private static int HandleId;
	}
}
