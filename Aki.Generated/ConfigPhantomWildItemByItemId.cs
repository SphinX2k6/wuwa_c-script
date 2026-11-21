using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D2 RID: 1746
	public class ConfigPhantomWildItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028FC RID: 10492 RVA: 0x00144CAF File Offset: 0x00142EAF
		static ConfigPhantomWildItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomWildItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomWildItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00144CD0 File Offset: 0x00142ED0
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

		// Token: 0x060028FE RID: 10494 RVA: 0x00144D4F File Offset: 0x00142F4F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomWildItemByItemId.LogPair = null;
			ConfigPhantomWildItemByItemId.HandleId = 0;
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00144D5D File Offset: 0x00142F5D
		public static void Init()
		{
			ConfigPhantomWildItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomWildItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomWildItem` where ItemId=?");
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00144D78 File Offset: 0x00142F78
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

		// Token: 0x04002FA4 RID: 12196
		private const string DB = "db_phantom.db";

		// Token: 0x04002FA5 RID: 12197
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002FA6 RID: 12198
		private const string TABLE = "PhantomWildItem";

		// Token: 0x04002FA7 RID: 12199
		private const string COMMAND = "select BinData from `PhantomWildItem` where ItemId=?";

		// Token: 0x04002FA8 RID: 12200
		private const string KEY_PREFIX = "PhantomWildItemByItemId";

		// Token: 0x04002FA9 RID: 12201
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FAA RID: 12202
		private static int HandleId;
	}
}
