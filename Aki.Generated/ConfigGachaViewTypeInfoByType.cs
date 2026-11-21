using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038C RID: 908
	public class ConfigGachaViewTypeInfoByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600154E RID: 5454 RVA: 0x000D592C File Offset: 0x000D3B2C
		static ConfigGachaViewTypeInfoByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaViewTypeInfoByType.CreateStaticDefaultValue), new Action(ConfigGachaViewTypeInfoByType.ResetStaticDefaultValue));
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000D594C File Offset: 0x000D3B4C
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaViewTypeInfoByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaViewTypeInfoByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaViewTypeInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaViewTypeInfo` where Type=?")
			});
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x000D59CB File Offset: 0x000D3BCB
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaViewTypeInfoByType.LogPair = null;
			ConfigGachaViewTypeInfoByType.HandleId = 0;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000D59D9 File Offset: 0x000D3BD9
		public static void Init()
		{
			ConfigGachaViewTypeInfoByType.HandleId = ConfigCommon.InitDataStatement(ConfigGachaViewTypeInfoByType.HandleId, "db_gacha.db", "select BinData from `GachaViewTypeInfo` where Type=?");
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000D59F4 File Offset: 0x000D3BF4
		public static GachaViewTypeInfo? GetConfig(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaViewTypeInfoByType.HandleId, ConfigGachaViewTypeInfoByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaViewTypeInfoByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaViewTypeInfo?(GachaViewTypeInfo.GetRootAsGachaViewTypeInfo(configBuffer));
				}
			}
			ConfigGachaViewTypeInfoByType.LogPair.Clear();
			ConfigGachaViewTypeInfoByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigGachaViewTypeInfoByType.HandleId, 1, p0Type, ConfigGachaViewTypeInfoByType.LogPair) || ConfigCommon.Step(ConfigGachaViewTypeInfoByType.HandleId, true, ConfigGachaViewTypeInfoByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaViewTypeInfoByType.HandleId, ConfigGachaViewTypeInfoByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaViewTypeInfoByType.HandleId, 0, ConfigGachaViewTypeInfoByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaViewTypeInfoByType.HandleId, ConfigGachaViewTypeInfoByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaViewTypeInfo rootAsGachaViewTypeInfo = GachaViewTypeInfo.GetRootAsGachaViewTypeInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaViewTypeInfoByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaViewTypeInfoByType.HandleId, ConfigGachaViewTypeInfoByType.LogPair);
			return new GachaViewTypeInfo?(rootAsGachaViewTypeInfo);
		}

		// Token: 0x040018B8 RID: 6328
		private const string DB = "db_gacha.db";

		// Token: 0x040018B9 RID: 6329
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040018BA RID: 6330
		private const string TABLE = "GachaViewTypeInfo";

		// Token: 0x040018BB RID: 6331
		private const string COMMAND = "select BinData from `GachaViewTypeInfo` where Type=?";

		// Token: 0x040018BC RID: 6332
		private const string KEY_PREFIX = "GachaViewTypeInfoByType";

		// Token: 0x040018BD RID: 6333
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018BE RID: 6334
		private static int HandleId;
	}
}
