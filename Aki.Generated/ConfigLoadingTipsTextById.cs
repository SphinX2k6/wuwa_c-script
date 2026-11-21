using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FD RID: 1277
	public class ConfigLoadingTipsTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DF9 RID: 7673 RVA: 0x0010625F File Offset: 0x0010445F
		static ConfigLoadingTipsTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingTipsTextById.CreateStaticDefaultValue), new Action(ConfigLoadingTipsTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00106280 File Offset: 0x00104480
		public static void CreateStaticDefaultValue()
		{
			ConfigLoadingTipsTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLoadingTipsTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_loadingtips.db"),
				new ValueTuple<string, object>("文件", "z.载入提示.xlsx"),
				new ValueTuple<string, object>("表名", "LoadingTipsText"),
				new ValueTuple<string, object>("语句", "select BinData from `LoadingTipsText` where Id=?")
			});
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x001062FF File Offset: 0x001044FF
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingTipsTextById.LogPair = null;
			ConfigLoadingTipsTextById.HandleId = 0;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x0010630D File Offset: 0x0010450D
		public static void Init()
		{
			ConfigLoadingTipsTextById.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingTipsTextById.HandleId, "db_loadingtips.db", "select BinData from `LoadingTipsText` where Id=?");
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00106328 File Offset: 0x00104528
		public static LoadingTipsText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLoadingTipsTextById.HandleId, ConfigLoadingTipsTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoadingTipsTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LoadingTipsText?(LoadingTipsText.GetRootAsLoadingTipsText(configBuffer));
				}
			}
			ConfigLoadingTipsTextById.LogPair.Clear();
			ConfigLoadingTipsTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLoadingTipsTextById.HandleId, 1, p0Id, ConfigLoadingTipsTextById.LogPair) || ConfigCommon.Step(ConfigLoadingTipsTextById.HandleId, true, ConfigLoadingTipsTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLoadingTipsTextById.HandleId, ConfigLoadingTipsTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLoadingTipsTextById.HandleId, 0, ConfigLoadingTipsTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLoadingTipsTextById.HandleId, ConfigLoadingTipsTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LoadingTipsText rootAsLoadingTipsText = LoadingTipsText.GetRootAsLoadingTipsText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoadingTipsTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLoadingTipsTextById.HandleId, ConfigLoadingTipsTextById.LogPair);
			return new LoadingTipsText?(rootAsLoadingTipsText);
		}

		// Token: 0x040022CF RID: 8911
		private const string DB = "db_loadingtips.db";

		// Token: 0x040022D0 RID: 8912
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x040022D1 RID: 8913
		private const string TABLE = "LoadingTipsText";

		// Token: 0x040022D2 RID: 8914
		private const string COMMAND = "select BinData from `LoadingTipsText` where Id=?";

		// Token: 0x040022D3 RID: 8915
		private const string KEY_PREFIX = "LoadingTipsTextById";

		// Token: 0x040022D4 RID: 8916
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022D5 RID: 8917
		private static int HandleId;
	}
}
