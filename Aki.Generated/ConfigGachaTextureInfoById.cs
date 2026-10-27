using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000375 RID: 885
	public class ConfigGachaTextureInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x000CEF90 File Offset: 0x000CD190
		static ConfigGachaTextureInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaTextureInfoById.CreateStaticDefaultValue), new Action(ConfigGachaTextureInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x000CEFB0 File Offset: 0x000CD1B0
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaTextureInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaTextureInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaTextureInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaTextureInfo` where Id=?")
			});
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000CF02F File Offset: 0x000CD22F
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaTextureInfoById.LogPair = null;
			ConfigGachaTextureInfoById.HandleId = 0;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000CF03D File Offset: 0x000CD23D
		public static void Init()
		{
			ConfigGachaTextureInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaTextureInfoById.HandleId, "db_gacha.db", "select BinData from `GachaTextureInfo` where Id=?");
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x000CF058 File Offset: 0x000CD258
		public static GachaTextureInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaTextureInfoById.HandleId, ConfigGachaTextureInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaTextureInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaTextureInfo?(GachaTextureInfo.GetRootAsGachaTextureInfo(configBuffer));
				}
			}
			ConfigGachaTextureInfoById.LogPair.Clear();
			ConfigGachaTextureInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaTextureInfoById.HandleId, 1, p0Id, ConfigGachaTextureInfoById.LogPair) || ConfigCommon.Step(ConfigGachaTextureInfoById.HandleId, true, ConfigGachaTextureInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaTextureInfoById.HandleId, ConfigGachaTextureInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaTextureInfoById.HandleId, 0, ConfigGachaTextureInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaTextureInfoById.HandleId, ConfigGachaTextureInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaTextureInfo rootAsGachaTextureInfo = GachaTextureInfo.GetRootAsGachaTextureInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaTextureInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaTextureInfoById.HandleId, ConfigGachaTextureInfoById.LogPair);
			return new GachaTextureInfo?(rootAsGachaTextureInfo);
		}

		// Token: 0x04001817 RID: 6167
		private const string DB = "db_gacha.db";

		// Token: 0x04001818 RID: 6168
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x04001819 RID: 6169
		private const string TABLE = "GachaTextureInfo";

		// Token: 0x0400181A RID: 6170
		private const string COMMAND = "select BinData from `GachaTextureInfo` where Id=?";

		// Token: 0x0400181B RID: 6171
		private const string KEY_PREFIX = "GachaTextureInfoById";

		// Token: 0x0400181C RID: 6172
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400181D RID: 6173
		private static int HandleId;
	}
}
