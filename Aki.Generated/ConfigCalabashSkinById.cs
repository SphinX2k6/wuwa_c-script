using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013B RID: 315
	public class ConfigCalabashSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000763 RID: 1891 RVA: 0x00083657 File Offset: 0x00081857
		static ConfigCalabashSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashSkinById.CreateStaticDefaultValue), new Action(ConfigCalabashSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00083678 File Offset: 0x00081878
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashSkinById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashSkinById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashSkin` where Id = ?")
			});
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000836F7 File Offset: 0x000818F7
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashSkinById.LogPair = null;
			ConfigCalabashSkinById.HandleId = 0;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00083705 File Offset: 0x00081905
		public static void Init()
		{
			ConfigCalabashSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashSkinById.HandleId, "db_calabash.db", "select BinData from `CalabashSkin` where Id = ?");
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00083720 File Offset: 0x00081920
		public static CalabashSkin? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashSkinById.HandleId, ConfigCalabashSkinById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashSkin?(CalabashSkin.GetRootAsCalabashSkin(configBuffer));
				}
			}
			ConfigCalabashSkinById.LogPair.Clear();
			ConfigCalabashSkinById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCalabashSkinById.HandleId, 1, p0Id, ConfigCalabashSkinById.LogPair) || ConfigCommon.Step(ConfigCalabashSkinById.HandleId, true, ConfigCalabashSkinById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashSkinById.HandleId, ConfigCalabashSkinById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashSkinById.HandleId, 0, ConfigCalabashSkinById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashSkinById.HandleId, ConfigCalabashSkinById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashSkin rootAsCalabashSkin = CalabashSkin.GetRootAsCalabashSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashSkinById.HandleId, ConfigCalabashSkinById.LogPair);
			return new CalabashSkin?(rootAsCalabashSkin);
		}

		// Token: 0x04000881 RID: 2177
		private const string DB = "db_calabash.db";

		// Token: 0x04000882 RID: 2178
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04000883 RID: 2179
		private const string TABLE = "CalabashSkin";

		// Token: 0x04000884 RID: 2180
		private const string COMMAND = "select BinData from `CalabashSkin` where Id = ?";

		// Token: 0x04000885 RID: 2181
		private const string KEY_PREFIX = "CalabashSkinById";

		// Token: 0x04000886 RID: 2182
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000887 RID: 2183
		private static int HandleId;
	}
}
