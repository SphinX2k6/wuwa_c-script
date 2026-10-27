using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E7 RID: 1255
	public class ConfigLoadingTipsTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x000FFB0B File Offset: 0x000FDD0B
		static ConfigLoadingTipsTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingTipsTextById.CreateStaticDefaultValue), new Action(ConfigLoadingTipsTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x000FFB2C File Offset: 0x000FDD2C
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

		// Token: 0x06001D77 RID: 7543 RVA: 0x000FFBAB File Offset: 0x000FDDAB
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingTipsTextById.LogPair = null;
			ConfigLoadingTipsTextById.HandleId = 0;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000FFBB9 File Offset: 0x000FDDB9
		public static void Init()
		{
			ConfigLoadingTipsTextById.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingTipsTextById.HandleId, "db_loadingtips.db", "select BinData from `LoadingTipsText` where Id=?");
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000FFBD4 File Offset: 0x000FDDD4
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

		// Token: 0x04002235 RID: 8757
		private const string DB = "db_loadingtips.db";

		// Token: 0x04002236 RID: 8758
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x04002237 RID: 8759
		private const string TABLE = "LoadingTipsText";

		// Token: 0x04002238 RID: 8760
		private const string COMMAND = "select BinData from `LoadingTipsText` where Id=?";

		// Token: 0x04002239 RID: 8761
		private const string KEY_PREFIX = "LoadingTipsTextById";

		// Token: 0x0400223A RID: 8762
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400223B RID: 8763
		private static int HandleId;
	}
}
