using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000657 RID: 1623
	public class ConfigPayItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600261A RID: 9754 RVA: 0x001348C3 File Offset: 0x00132AC3
		static ConfigPayItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPayItemById.CreateStaticDefaultValue), new Action(ConfigPayItemById.ResetStaticDefaultValue));
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x001348E4 File Offset: 0x00132AE4
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

		// Token: 0x0600261C RID: 9756 RVA: 0x00134963 File Offset: 0x00132B63
		public static void ResetStaticDefaultValue()
		{
			ConfigPayItemById.LogPair = null;
			ConfigPayItemById.HandleId = 0;
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00134971 File Offset: 0x00132B71
		public static void Init()
		{
			ConfigPayItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPayItemById.HandleId, "db_paycurrency.db", "select BinData from `PayItem` where Id=?");
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x0013498C File Offset: 0x00132B8C
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

		// Token: 0x04002C47 RID: 11335
		private const string DB = "db_paycurrency.db";

		// Token: 0x04002C48 RID: 11336
		private const string FILE = "c.充值.xlsx";

		// Token: 0x04002C49 RID: 11337
		private const string TABLE = "PayItem";

		// Token: 0x04002C4A RID: 11338
		private const string COMMAND = "select BinData from `PayItem` where Id=?";

		// Token: 0x04002C4B RID: 11339
		private const string KEY_PREFIX = "PayItemById";

		// Token: 0x04002C4C RID: 11340
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C4D RID: 11341
		private static int HandleId;
	}
}
