using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F5 RID: 1269
	public class ConfigLinkParamById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DC9 RID: 7625 RVA: 0x0010523C File Offset: 0x0010343C
		static ConfigLinkParamById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkParamById.CreateStaticDefaultValue), new Action(ConfigLinkParamById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0010525C File Offset: 0x0010345C
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

		// Token: 0x06001DCB RID: 7627 RVA: 0x001052DB File Offset: 0x001034DB
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkParamById.LogPair = null;
			ConfigLinkParamById.HandleId = 0;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x001052E9 File Offset: 0x001034E9
		public static void Init()
		{
			ConfigLinkParamById.HandleId = ConfigCommon.InitDataStatement(ConfigLinkParamById.HandleId, "db_link.db", "select BinData from `LinkParam` where Id=?");
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00105304 File Offset: 0x00103504
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

		// Token: 0x04002297 RID: 8855
		private const string DB = "db_link.db";

		// Token: 0x04002298 RID: 8856
		private const string FILE = "l.Link功能.xlsx";

		// Token: 0x04002299 RID: 8857
		private const string TABLE = "LinkParam";

		// Token: 0x0400229A RID: 8858
		private const string COMMAND = "select BinData from `LinkParam` where Id=?";

		// Token: 0x0400229B RID: 8859
		private const string KEY_PREFIX = "LinkParamById";

		// Token: 0x0400229C RID: 8860
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400229D RID: 8861
		private static int HandleId;
	}
}
