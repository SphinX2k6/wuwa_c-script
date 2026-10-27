using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069F RID: 1695
	public class ConfigPhantomItemByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027CA RID: 10186 RVA: 0x0013A8FF File Offset: 0x00138AFF
		static ConfigPhantomItemByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemByItemId.CreateStaticDefaultValue), new Action(ConfigPhantomItemByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x0013A920 File Offset: 0x00138B20
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

		// Token: 0x060027CC RID: 10188 RVA: 0x0013A99F File Offset: 0x00138B9F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemByItemId.LogPair = null;
			ConfigPhantomItemByItemId.HandleId = 0;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0013A9AD File Offset: 0x00138BAD
		public static void Init()
		{
			ConfigPhantomItemByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemByItemId.HandleId, "db_phantom.db", "select BinData from `PhantomItem` where ItemId=?");
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0013A9C8 File Offset: 0x00138BC8
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

		// Token: 0x04002E3F RID: 11839
		private const string DB = "db_phantom.db";

		// Token: 0x04002E40 RID: 11840
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E41 RID: 11841
		private const string TABLE = "PhantomItem";

		// Token: 0x04002E42 RID: 11842
		private const string COMMAND = "select BinData from `PhantomItem` where ItemId=?";

		// Token: 0x04002E43 RID: 11843
		private const string KEY_PREFIX = "PhantomItemByItemId";

		// Token: 0x04002E44 RID: 11844
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E45 RID: 11845
		private static int HandleId;
	}
}
