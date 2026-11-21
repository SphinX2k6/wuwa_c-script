using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000388 RID: 904
	public class ConfigGachaSequenceConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001536 RID: 5430 RVA: 0x000D500B File Offset: 0x000D320B
		static ConfigGachaSequenceConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaSequenceConfigById.CreateStaticDefaultValue), new Action(ConfigGachaSequenceConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000D502C File Offset: 0x000D322C
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaSequenceConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaSequenceConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaSequenceConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaSequenceConfig` where Id=?")
			});
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000D50AB File Offset: 0x000D32AB
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaSequenceConfigById.LogPair = null;
			ConfigGachaSequenceConfigById.HandleId = 0;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000D50B9 File Offset: 0x000D32B9
		public static void Init()
		{
			ConfigGachaSequenceConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaSequenceConfigById.HandleId, "db_gacha.db", "select BinData from `GachaSequenceConfig` where Id=?");
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000D50D4 File Offset: 0x000D32D4
		public static GachaSequenceConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaSequenceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaSequenceConfig?(GachaSequenceConfig.GetRootAsGachaSequenceConfig(configBuffer));
				}
			}
			ConfigGachaSequenceConfigById.LogPair.Clear();
			ConfigGachaSequenceConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaSequenceConfigById.HandleId, 1, p0Id, ConfigGachaSequenceConfigById.LogPair) || ConfigCommon.Step(ConfigGachaSequenceConfigById.HandleId, true, ConfigGachaSequenceConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaSequenceConfigById.HandleId, 0, ConfigGachaSequenceConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaSequenceConfig rootAsGachaSequenceConfig = GachaSequenceConfig.GetRootAsGachaSequenceConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaSequenceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair);
			return new GachaSequenceConfig?(rootAsGachaSequenceConfig);
		}

		// Token: 0x0400189C RID: 6300
		private const string DB = "db_gacha.db";

		// Token: 0x0400189D RID: 6301
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x0400189E RID: 6302
		private const string TABLE = "GachaSequenceConfig";

		// Token: 0x0400189F RID: 6303
		private const string COMMAND = "select BinData from `GachaSequenceConfig` where Id=?";

		// Token: 0x040018A0 RID: 6304
		private const string KEY_PREFIX = "GachaSequenceConfigById";

		// Token: 0x040018A1 RID: 6305
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018A2 RID: 6306
		private static int HandleId;
	}
}
