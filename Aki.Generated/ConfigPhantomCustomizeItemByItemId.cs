using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A5 RID: 1701
	public class ConfigPhantomCustomizeItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027EE RID: 10222 RVA: 0x0013EFC8 File Offset: 0x0013D1C8
		static ConfigPhantomCustomizeItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomCustomizeItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomCustomizeItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0013EFE8 File Offset: 0x0013D1E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomCustomizeItemByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomCustomizeItemByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomCustomizeItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomCustomizeItem` where ItemId=?")
			});
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0013F067 File Offset: 0x0013D267
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomCustomizeItemByItemId.LogPair = null;
			ConfigPhantomCustomizeItemByItemId.HandleId = 0;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0013F075 File Offset: 0x0013D275
		public static void Init()
		{
			ConfigPhantomCustomizeItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomCustomizeItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomCustomizeItem` where ItemId=?");
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0013F090 File Offset: 0x0013D290
		public static PhantomCustomizeItem? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomCustomizeItemByItemId.HandleId, ConfigPhantomCustomizeItemByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCustomizeItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomCustomizeItem?(PhantomCustomizeItem.GetRootAsPhantomCustomizeItem(configBuffer));
				}
			}
			ConfigPhantomCustomizeItemByItemId.LogPair.Clear();
			ConfigPhantomCustomizeItemByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigPhantomCustomizeItemByItemId.HandleId, 1, p0ItemId, ConfigPhantomCustomizeItemByItemId.LogPair) || ConfigCommon.Step(ConfigPhantomCustomizeItemByItemId.HandleId, true, ConfigPhantomCustomizeItemByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomCustomizeItemByItemId.HandleId, ConfigPhantomCustomizeItemByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomCustomizeItemByItemId.HandleId, 0, ConfigPhantomCustomizeItemByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomCustomizeItemByItemId.HandleId, ConfigPhantomCustomizeItemByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomCustomizeItem rootAsPhantomCustomizeItem = PhantomCustomizeItem.GetRootAsPhantomCustomizeItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCustomizeItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomCustomizeItemByItemId.HandleId, ConfigPhantomCustomizeItemByItemId.LogPair);
			return new PhantomCustomizeItem?(rootAsPhantomCustomizeItem);
		}

		// Token: 0x04002E69 RID: 11881
		private const string DB = "db_phantom.db";

		// Token: 0x04002E6A RID: 11882
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E6B RID: 11883
		private const string TABLE = "PhantomCustomizeItem";

		// Token: 0x04002E6C RID: 11884
		private const string COMMAND = "select BinData from `PhantomCustomizeItem` where ItemId=?";

		// Token: 0x04002E6D RID: 11885
		private const string KEY_PREFIX = "PhantomCustomizeItemByItemId";

		// Token: 0x04002E6E RID: 11886
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E6F RID: 11887
		private static int HandleId;
	}
}
