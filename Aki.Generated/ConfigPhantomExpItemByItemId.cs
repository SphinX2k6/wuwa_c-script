using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000691 RID: 1681
	public class ConfigPhantomExpItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002776 RID: 10102 RVA: 0x00138D03 File Offset: 0x00136F03
		static ConfigPhantomExpItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomExpItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomExpItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00138D24 File Offset: 0x00136F24
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

		// Token: 0x06002778 RID: 10104 RVA: 0x00138DA3 File Offset: 0x00136FA3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomExpItemByItemId.LogPair = null;
			ConfigPhantomExpItemByItemId.HandleId = 0;
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00138DB1 File Offset: 0x00136FB1
		public static void Init()
		{
			ConfigPhantomExpItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomExpItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomExpItem` where ItemId=?");
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00138DCC File Offset: 0x00136FCC
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

		// Token: 0x04002DDD RID: 11741
		private const string DB = "db_phantom.db";

		// Token: 0x04002DDE RID: 11742
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002DDF RID: 11743
		private const string TABLE = "PhantomExpItem";

		// Token: 0x04002DE0 RID: 11744
		private const string COMMAND = "select BinData from `PhantomExpItem` where ItemId=?";

		// Token: 0x04002DE1 RID: 11745
		private const string KEY_PREFIX = "PhantomExpItemByItemId";

		// Token: 0x04002DE2 RID: 11746
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DE3 RID: 11747
		private static int HandleId;
	}
}
