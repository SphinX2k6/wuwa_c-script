using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E0 RID: 1248
	public class ConfigLinkPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D4B RID: 7499 RVA: 0x000FED30 File Offset: 0x000FCF30
		static ConfigLinkPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkPreloadById.CreateStaticDefaultValue), new Action(ConfigLinkPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000FED50 File Offset: 0x000FCF50
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

		// Token: 0x06001D4D RID: 7501 RVA: 0x000FEDCF File Offset: 0x000FCFCF
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkPreloadById.LogPair = null;
			ConfigLinkPreloadById.HandleId = 0;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x000FEDDD File Offset: 0x000FCFDD
		public static void Init()
		{
			ConfigLinkPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkPreloadById.HandleId, "db_link.db", "select BinData from `LinkPreload` where Id=?");
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000FEDF8 File Offset: 0x000FCFF8
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

		// Token: 0x04002204 RID: 8708
		private const string DB = "db_link.db";

		// Token: 0x04002205 RID: 8709
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x04002206 RID: 8710
		private const string TABLE = "LinkPreload";

		// Token: 0x04002207 RID: 8711
		private const string COMMAND = "select BinData from `LinkPreload` where Id=?";

		// Token: 0x04002208 RID: 8712
		private const string KEY_PREFIX = "LinkPreloadById";

		// Token: 0x04002209 RID: 8713
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400220A RID: 8714
		private static int HandleId;
	}
}
