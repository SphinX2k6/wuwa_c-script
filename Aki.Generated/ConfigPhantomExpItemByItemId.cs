using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A9 RID: 1705
	public class ConfigPhantomExpItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x0013F77F File Offset: 0x0013D97F
		static ConfigPhantomExpItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomExpItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomExpItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x0013F7A0 File Offset: 0x0013D9A0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomExpItemByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomExpItemByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomExpItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomExpItem` where ItemId=?")
			});
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x0013F81F File Offset: 0x0013DA1F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomExpItemByItemId.LogPair = null;
			ConfigPhantomExpItemByItemId.HandleId = 0;
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x0013F82D File Offset: 0x0013DA2D
		public static void Init()
		{
			ConfigPhantomExpItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomExpItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomExpItem` where ItemId=?");
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x0013F848 File Offset: 0x0013DA48
		public static PhantomExpItem? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomExpItemByItemId.HandleId, ConfigPhantomExpItemByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomExpItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomExpItem?(PhantomExpItem.GetRootAsPhantomExpItem(configBuffer));
				}
			}
			ConfigPhantomExpItemByItemId.LogPair.Clear();
			ConfigPhantomExpItemByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigPhantomExpItemByItemId.HandleId, 1, p0ItemId, ConfigPhantomExpItemByItemId.LogPair) || ConfigCommon.Step(ConfigPhantomExpItemByItemId.HandleId, true, ConfigPhantomExpItemByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomExpItemByItemId.HandleId, ConfigPhantomExpItemByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomExpItemByItemId.HandleId, 0, ConfigPhantomExpItemByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomExpItemByItemId.HandleId, ConfigPhantomExpItemByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomExpItem rootAsPhantomExpItem = PhantomExpItem.GetRootAsPhantomExpItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomExpItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomExpItemByItemId.HandleId, ConfigPhantomExpItemByItemId.LogPair);
			return new PhantomExpItem?(rootAsPhantomExpItem);
		}

		// Token: 0x04002E85 RID: 11909
		private const string DB = "db_phantom.db";

		// Token: 0x04002E86 RID: 11910
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E87 RID: 11911
		private const string TABLE = "PhantomExpItem";

		// Token: 0x04002E88 RID: 11912
		private const string COMMAND = "select BinData from `PhantomExpItem` where ItemId=?";

		// Token: 0x04002E89 RID: 11913
		private const string KEY_PREFIX = "PhantomExpItemByItemId";

		// Token: 0x04002E8A RID: 11914
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E8B RID: 11915
		private static int HandleId;
	}
}
