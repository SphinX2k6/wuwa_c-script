using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038B RID: 907
	public class ConfigGachaViewInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001548 RID: 5448 RVA: 0x000D56E4 File Offset: 0x000D38E4
		static ConfigGachaViewInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaViewInfoById.CreateStaticDefaultValue), new Action(ConfigGachaViewInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000D5704 File Offset: 0x000D3904
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaViewInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaViewInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaViewInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaViewInfo` where Id=?")
			});
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000D5783 File Offset: 0x000D3983
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaViewInfoById.LogPair = null;
			ConfigGachaViewInfoById.HandleId = 0;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000D5791 File Offset: 0x000D3991
		public static void Init()
		{
			ConfigGachaViewInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaViewInfoById.HandleId, "db_gacha.db", "select BinData from `GachaViewInfo` where Id=?");
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000D57AC File Offset: 0x000D39AC
		public static GachaViewInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaViewInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaViewInfo?(GachaViewInfo.GetRootAsGachaViewInfo(configBuffer));
				}
			}
			ConfigGachaViewInfoById.LogPair.Clear();
			ConfigGachaViewInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaViewInfoById.HandleId, 1, p0Id, ConfigGachaViewInfoById.LogPair) || ConfigCommon.Step(ConfigGachaViewInfoById.HandleId, true, ConfigGachaViewInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaViewInfoById.HandleId, 0, ConfigGachaViewInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaViewInfo rootAsGachaViewInfo = GachaViewInfo.GetRootAsGachaViewInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaViewInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair);
			return new GachaViewInfo?(rootAsGachaViewInfo);
		}

		// Token: 0x040018B1 RID: 6321
		private const string DB = "db_gacha.db";

		// Token: 0x040018B2 RID: 6322
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040018B3 RID: 6323
		private const string TABLE = "GachaViewInfo";

		// Token: 0x040018B4 RID: 6324
		private const string COMMAND = "select BinData from `GachaViewInfo` where Id=?";

		// Token: 0x040018B5 RID: 6325
		private const string KEY_PREFIX = "GachaViewInfoById";

		// Token: 0x040018B6 RID: 6326
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018B7 RID: 6327
		private static int HandleId;
	}
}
