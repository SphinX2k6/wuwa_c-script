using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038A RID: 906
	public class ConfigGachaTextureInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x000D549C File Offset: 0x000D369C
		static ConfigGachaTextureInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaTextureInfoById.CreateStaticDefaultValue), new Action(ConfigGachaTextureInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000D54BC File Offset: 0x000D36BC
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

		// Token: 0x06001544 RID: 5444 RVA: 0x000D553B File Offset: 0x000D373B
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaTextureInfoById.LogPair = null;
			ConfigGachaTextureInfoById.HandleId = 0;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000D5549 File Offset: 0x000D3749
		public static void Init()
		{
			ConfigGachaTextureInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaTextureInfoById.HandleId, "db_gacha.db", "select BinData from `GachaTextureInfo` where Id=?");
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000D5564 File Offset: 0x000D3764
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

		// Token: 0x040018AA RID: 6314
		private const string DB = "db_gacha.db";

		// Token: 0x040018AB RID: 6315
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040018AC RID: 6316
		private const string TABLE = "GachaTextureInfo";

		// Token: 0x040018AD RID: 6317
		private const string COMMAND = "select BinData from `GachaTextureInfo` where Id=?";

		// Token: 0x040018AE RID: 6318
		private const string KEY_PREFIX = "GachaTextureInfoById";

		// Token: 0x040018AF RID: 6319
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018B0 RID: 6320
		private static int HandleId;
	}
}
