using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DF RID: 1247
	public class ConfigLinkParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D45 RID: 7493 RVA: 0x000FEAE8 File Offset: 0x000FCCE8
		static ConfigLinkParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkParamById.CreateStaticDefaultValue), new Action(ConfigLinkParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x000FEB08 File Offset: 0x000FCD08
		public static void CreateStaticDefaultValue()
		{
			ConfigLinkParamById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLinkParamById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_link.db"),
				new ValueTuple<string, object>("文件", "l.Link功能.xlsx"),
				new ValueTuple<string, object>("表名", "LinkParam"),
				new ValueTuple<string, object>("语句", "select BinData from `LinkParam` where Id=?")
			});
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x000FEB87 File Offset: 0x000FCD87
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkParamById.LogPair = null;
			ConfigLinkParamById.HandleId = 0;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x000FEB95 File Offset: 0x000FCD95
		public static void Init()
		{
			ConfigLinkParamById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkParamById.HandleId, "db_link.db", "select BinData from `LinkParam` where Id=?");
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000FEBB0 File Offset: 0x000FCDB0
		public static LinkParam? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLinkParamById.HandleId, ConfigLinkParamById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LinkParam?(LinkParam.GetRootAsLinkParam(configBuffer));
				}
			}
			ConfigLinkParamById.LogPair.Clear();
			ConfigLinkParamById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLinkParamById.HandleId, 1, p0Id, ConfigLinkParamById.LogPair) || ConfigCommon.Step(ConfigLinkParamById.HandleId, true, ConfigLinkParamById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLinkParamById.HandleId, ConfigLinkParamById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLinkParamById.HandleId, 0, ConfigLinkParamById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLinkParamById.HandleId, ConfigLinkParamById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LinkParam rootAsLinkParam = LinkParam.GetRootAsLinkParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkParamById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLinkParamById.HandleId, ConfigLinkParamById.LogPair);
			return new LinkParam?(rootAsLinkParam);
		}

		// Token: 0x040021FD RID: 8701
		private const string DB = "db_link.db";

		// Token: 0x040021FE RID: 8702
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x040021FF RID: 8703
		private const string TABLE = "LinkParam";

		// Token: 0x04002200 RID: 8704
		private const string COMMAND = "select BinData from `LinkParam` where Id=?";

		// Token: 0x04002201 RID: 8705
		private const string KEY_PREFIX = "LinkParamById";

		// Token: 0x04002202 RID: 8706
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002203 RID: 8707
		private static int HandleId;
	}
}
