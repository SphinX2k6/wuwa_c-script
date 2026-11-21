using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014A RID: 330
	public class ConfigCalabashSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x00088FBB File Offset: 0x000871BB
		static ConfigCalabashSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashSkinById.CreateStaticDefaultValue), new Action(ConfigCalabashSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00088FDC File Offset: 0x000871DC
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

		// Token: 0x060007BF RID: 1983 RVA: 0x0008905B File Offset: 0x0008725B
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashSkinById.LogPair = null;
			ConfigCalabashSkinById.HandleId = 0;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00089069 File Offset: 0x00087269
		public static void Init()
		{
			ConfigCalabashSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashSkinById.HandleId, "db_calabash.db", "select BinData from `CalabashSkin` where Id = ?");
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00089084 File Offset: 0x00087284
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

		// Token: 0x040008EA RID: 2282
		private const string DB = "db_calabash.db";

		// Token: 0x040008EB RID: 2283
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008EC RID: 2284
		private const string TABLE = "CalabashSkin";

		// Token: 0x040008ED RID: 2285
		private const string COMMAND = "select BinData from `CalabashSkin` where Id = ?";

		// Token: 0x040008EE RID: 2286
		private const string KEY_PREFIX = "CalabashSkinById";

		// Token: 0x040008EF RID: 2287
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008F0 RID: 2288
		private static int HandleId;
	}
}
