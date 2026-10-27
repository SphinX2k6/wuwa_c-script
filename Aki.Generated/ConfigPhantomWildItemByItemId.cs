using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BA RID: 1722
	public class ConfigPhantomWildItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600286C RID: 10348 RVA: 0x0013E233 File Offset: 0x0013C433
		static ConfigPhantomWildItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomWildItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomWildItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0013E254 File Offset: 0x0013C454
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomWildItemByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomWildItemByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomWildItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomWildItem` where ItemId=?")
			});
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x0013E2D3 File Offset: 0x0013C4D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomWildItemByItemId.LogPair = null;
			ConfigPhantomWildItemByItemId.HandleId = 0;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0013E2E1 File Offset: 0x0013C4E1
		public static void Init()
		{
			ConfigPhantomWildItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomWildItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomWildItem` where ItemId=?");
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0013E2FC File Offset: 0x0013C4FC
		public static PhantomWildItem? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomWildItemByItemId.HandleId, ConfigPhantomWildItemByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomWildItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomWildItem?(PhantomWildItem.GetRootAsPhantomWildItem(configBuffer));
				}
			}
			ConfigPhantomWildItemByItemId.LogPair.Clear();
			ConfigPhantomWildItemByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigPhantomWildItemByItemId.HandleId, 1, p0ItemId, ConfigPhantomWildItemByItemId.LogPair) || ConfigCommon.Step(ConfigPhantomWildItemByItemId.HandleId, true, ConfigPhantomWildItemByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomWildItemByItemId.HandleId, ConfigPhantomWildItemByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomWildItemByItemId.HandleId, 0, ConfigPhantomWildItemByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomWildItemByItemId.HandleId, ConfigPhantomWildItemByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomWildItem rootAsPhantomWildItem = PhantomWildItem.GetRootAsPhantomWildItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomWildItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomWildItemByItemId.HandleId, ConfigPhantomWildItemByItemId.LogPair);
			return new PhantomWildItem?(rootAsPhantomWildItem);
		}

		// Token: 0x04002EFC RID: 12028
		private const string DB = "db_phantom.db";

		// Token: 0x04002EFD RID: 12029
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EFE RID: 12030
		private const string TABLE = "PhantomWildItem";

		// Token: 0x04002EFF RID: 12031
		private const string COMMAND = "select BinData from `PhantomWildItem` where ItemId=?";

		// Token: 0x04002F00 RID: 12032
		private const string KEY_PREFIX = "PhantomWildItemByItemId";

		// Token: 0x04002F01 RID: 12033
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F02 RID: 12034
		private static int HandleId;
	}
}
