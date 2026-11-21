using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B7 RID: 1719
	public class ConfigPhantomItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600285A RID: 10330 RVA: 0x0014137B File Offset: 0x0013F57B
		static ConfigPhantomItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0014139C File Offset: 0x0013F59C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomItemByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomItemByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomItem` where ItemId=?")
			});
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0014141B File Offset: 0x0013F61B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemByItemId.LogPair = null;
			ConfigPhantomItemByItemId.HandleId = 0;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00141429 File Offset: 0x0013F629
		public static void Init()
		{
			ConfigPhantomItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomItem` where ItemId=?");
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00141444 File Offset: 0x0013F644
		public static PhantomItem? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomItemByItemId.HandleId, ConfigPhantomItemByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomItem?(PhantomItem.GetRootAsPhantomItem(configBuffer));
				}
			}
			ConfigPhantomItemByItemId.LogPair.Clear();
			ConfigPhantomItemByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigPhantomItemByItemId.HandleId, 1, p0ItemId, ConfigPhantomItemByItemId.LogPair) || ConfigCommon.Step(ConfigPhantomItemByItemId.HandleId, true, ConfigPhantomItemByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomItemByItemId.HandleId, ConfigPhantomItemByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomItemByItemId.HandleId, 0, ConfigPhantomItemByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomItemByItemId.HandleId, ConfigPhantomItemByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomItem rootAsPhantomItem = PhantomItem.GetRootAsPhantomItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomItemByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomItemByItemId.HandleId, ConfigPhantomItemByItemId.LogPair);
			return new PhantomItem?(rootAsPhantomItem);
		}

		// Token: 0x04002EE7 RID: 12007
		private const string DB = "db_phantom.db";

		// Token: 0x04002EE8 RID: 12008
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EE9 RID: 12009
		private const string TABLE = "PhantomItem";

		// Token: 0x04002EEA RID: 12010
		private const string COMMAND = "select BinData from `PhantomItem` where ItemId=?";

		// Token: 0x04002EEB RID: 12011
		private const string KEY_PREFIX = "PhantomItemByItemId";

		// Token: 0x04002EEC RID: 12012
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EED RID: 12013
		private static int HandleId;
	}
}
