using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BE RID: 1726
	public class ConfigPhantomMainPropItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002884 RID: 10372 RVA: 0x00142387 File Offset: 0x00140587
		static ConfigPhantomMainPropItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomMainPropItemById.CreateStaticDefaultValue), new Action(ConfigPhantomMainPropItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x001423A8 File Offset: 0x001405A8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomMainPropItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomMainPropItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomMainPropItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomMainPropItem` where Id=?")
			});
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00142427 File Offset: 0x00140627
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomMainPropItemById.LogPair = null;
			ConfigPhantomMainPropItemById.HandleId = 0;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00142435 File Offset: 0x00140635
		public static void Init()
		{
			ConfigPhantomMainPropItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomMainPropItemById.HandleId, "db_phantom.db", "select BinData from `PhantomMainPropItem` where Id=?");
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00142450 File Offset: 0x00140650
		public static PhantomMainPropItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomMainPropItem?(PhantomMainPropItem.GetRootAsPhantomMainPropItem(configBuffer));
				}
			}
			ConfigPhantomMainPropItemById.LogPair.Clear();
			ConfigPhantomMainPropItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomMainPropItemById.HandleId, 1, p0Id, ConfigPhantomMainPropItemById.LogPair) || ConfigCommon.Step(ConfigPhantomMainPropItemById.HandleId, true, ConfigPhantomMainPropItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomMainPropItemById.HandleId, 0, ConfigPhantomMainPropItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomMainPropItem rootAsPhantomMainPropItem = PhantomMainPropItem.GetRootAsPhantomMainPropItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair);
			return new PhantomMainPropItem?(rootAsPhantomMainPropItem);
		}

		// Token: 0x04002F18 RID: 12056
		private const string DB = "db_phantom.db";

		// Token: 0x04002F19 RID: 12057
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F1A RID: 12058
		private const string TABLE = "PhantomMainPropItem";

		// Token: 0x04002F1B RID: 12059
		private const string COMMAND = "select BinData from `PhantomMainPropItem` where Id=?";

		// Token: 0x04002F1C RID: 12060
		private const string KEY_PREFIX = "PhantomMainPropItemById";

		// Token: 0x04002F1D RID: 12061
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F1E RID: 12062
		private static int HandleId;
	}
}
