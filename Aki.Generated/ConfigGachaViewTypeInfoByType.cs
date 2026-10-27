using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000377 RID: 887
	public class ConfigGachaViewTypeInfoByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014D0 RID: 5328 RVA: 0x000CF420 File Offset: 0x000CD620
		static ConfigGachaViewTypeInfoByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaViewTypeInfoByType.CreateStaticDefaultValue), new Action(ConfigGachaViewTypeInfoByType.ResetStaticDefaultValue));
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000CF440 File Offset: 0x000CD640
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

		// Token: 0x060014D2 RID: 5330 RVA: 0x000CF4BF File Offset: 0x000CD6BF
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaViewTypeInfoByType.LogPair = null;
			ConfigGachaViewTypeInfoByType.HandleId = 0;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000CF4CD File Offset: 0x000CD6CD
		public static void Init()
		{
			ConfigGachaViewTypeInfoByType.HandleId = ConfigCommon.InitDataStatement(ConfigGachaViewTypeInfoByType.HandleId, "db_gacha.db", "select BinData from `GachaViewTypeInfo` where Type=?");
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000CF4E8 File Offset: 0x000CD6E8
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

		// Token: 0x04001825 RID: 6181
		private const string DB = "db_gacha.db";

		// Token: 0x04001826 RID: 6182
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x04001827 RID: 6183
		private const string TABLE = "GachaViewTypeInfo";

		// Token: 0x04001828 RID: 6184
		private const string COMMAND = "select BinData from `GachaViewTypeInfo` where Type=?";

		// Token: 0x04001829 RID: 6185
		private const string KEY_PREFIX = "GachaViewTypeInfoByType";

		// Token: 0x0400182A RID: 6186
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400182B RID: 6187
		private static int HandleId;
	}
}
