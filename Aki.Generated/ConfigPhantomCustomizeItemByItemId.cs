using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068D RID: 1677
	public class ConfigPhantomCustomizeItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600275E RID: 10078 RVA: 0x0013854C File Offset: 0x0013674C
		static ConfigPhantomCustomizeItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomCustomizeItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomCustomizeItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x0013856C File Offset: 0x0013676C
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

		// Token: 0x06002760 RID: 10080 RVA: 0x001385EB File Offset: 0x001367EB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomCustomizeItemByItemId.LogPair = null;
			ConfigPhantomCustomizeItemByItemId.HandleId = 0;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x001385F9 File Offset: 0x001367F9
		public static void Init()
		{
			ConfigPhantomCustomizeItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomCustomizeItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomCustomizeItem` where ItemId=?");
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00138614 File Offset: 0x00136814
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

		// Token: 0x04002DC1 RID: 11713
		private const string DB = "db_phantom.db";

		// Token: 0x04002DC2 RID: 11714
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002DC3 RID: 11715
		private const string TABLE = "PhantomCustomizeItem";

		// Token: 0x04002DC4 RID: 11716
		private const string COMMAND = "select BinData from `PhantomCustomizeItem` where ItemId=?";

		// Token: 0x04002DC5 RID: 11717
		private const string KEY_PREFIX = "PhantomCustomizeItemByItemId";

		// Token: 0x04002DC6 RID: 11718
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DC7 RID: 11719
		private static int HandleId;
	}
}
