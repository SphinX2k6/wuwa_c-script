using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F6 RID: 1270
	public class ConfigLinkPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DCF RID: 7631 RVA: 0x00105484 File Offset: 0x00103684
		static ConfigLinkPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkPreloadById.CreateStaticDefaultValue), new Action(ConfigLinkPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x001054A4 File Offset: 0x001036A4
		public static void CreateStaticDefaultValue()
		{
			ConfigLinkPreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLinkPreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_link.db"),
				new ValueTuple<string, object>("文件", "l.Link功能.xlsx"),
				new ValueTuple<string, object>("表名", "LinkPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `LinkPreload` where Id=?")
			});
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00105523 File Offset: 0x00103723
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkPreloadById.LogPair = null;
			ConfigLinkPreloadById.HandleId = 0;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00105531 File Offset: 0x00103731
		public static void Init()
		{
			ConfigLinkPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkPreloadById.HandleId, "db_link.db", "select BinData from `LinkPreload` where Id=?");
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0010554C File Offset: 0x0010374C
		public static LinkPreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLinkPreloadById.HandleId, ConfigLinkPreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LinkPreload?(LinkPreload.GetRootAsLinkPreload(configBuffer));
				}
			}
			ConfigLinkPreloadById.LogPair.Clear();
			ConfigLinkPreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLinkPreloadById.HandleId, 1, p0Id, ConfigLinkPreloadById.LogPair) || ConfigCommon.Step(ConfigLinkPreloadById.HandleId, true, ConfigLinkPreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLinkPreloadById.HandleId, ConfigLinkPreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLinkPreloadById.HandleId, 0, ConfigLinkPreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLinkPreloadById.HandleId, ConfigLinkPreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LinkPreload rootAsLinkPreload = LinkPreload.GetRootAsLinkPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLinkPreloadById.HandleId, ConfigLinkPreloadById.LogPair);
			return new LinkPreload?(rootAsLinkPreload);
		}

		// Token: 0x0400229E RID: 8862
		private const string DB = "db_link.db";

		// Token: 0x0400229F RID: 8863
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x040022A0 RID: 8864
		private const string TABLE = "LinkPreload";

		// Token: 0x040022A1 RID: 8865
		private const string COMMAND = "select BinData from `LinkPreload` where Id=?";

		// Token: 0x040022A2 RID: 8866
		private const string KEY_PREFIX = "LinkPreloadById";

		// Token: 0x040022A3 RID: 8867
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022A4 RID: 8868
		private static int HandleId;
	}
}
