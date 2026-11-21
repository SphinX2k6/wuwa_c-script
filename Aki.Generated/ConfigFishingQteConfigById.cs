using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FC RID: 764
	public class ConfigFishingQteConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011ED RID: 4589 RVA: 0x000C25E0 File Offset: 0x000C07E0
		static ConfigFishingQteConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingQteConfigById.CreateStaticDefaultValue), new Action(ConfigFishingQteConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000C2600 File Offset: 0x000C0800
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingQteConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingQteConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishingqteconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/b.捕鱼转盘/*.csv*"),
				new ValueTuple<string, object>("表名", "FishingQteConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingQteConfig` where Id=?")
			});
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000C267F File Offset: 0x000C087F
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingQteConfigById.LogPair = null;
			ConfigFishingQteConfigById.HandleId = 0;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000C268D File Offset: 0x000C088D
		public static void Init()
		{
			ConfigFishingQteConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingQteConfigById.HandleId, "db_fishingqteconfig.db", "select BinData from `FishingQteConfig` where Id=?");
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x000C26A8 File Offset: 0x000C08A8
		public static FishingQteConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingQteConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingQteConfig?(FishingQteConfig.GetRootAsFishingQteConfig(configBuffer));
				}
			}
			ConfigFishingQteConfigById.LogPair.Clear();
			ConfigFishingQteConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingQteConfigById.HandleId, 1, p0Id, ConfigFishingQteConfigById.LogPair) || ConfigCommon.Step(ConfigFishingQteConfigById.HandleId, true, ConfigFishingQteConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingQteConfigById.HandleId, 0, ConfigFishingQteConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingQteConfig rootAsFishingQteConfig = FishingQteConfig.GetRootAsFishingQteConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingQteConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingQteConfigById.HandleId, ConfigFishingQteConfigById.LogPair);
			return new FishingQteConfig?(rootAsFishingQteConfig);
		}

		// Token: 0x040014C8 RID: 5320
		private const string DB = "db_fishingqteconfig.db";

		// Token: 0x040014C9 RID: 5321
		private const string FILE = "k.可视化编辑/c.Csv/b.捕鱼转盘/*.csv*";

		// Token: 0x040014CA RID: 5322
		private const string TABLE = "FishingQteConfig";

		// Token: 0x040014CB RID: 5323
		private const string COMMAND = "select BinData from `FishingQteConfig` where Id=?";

		// Token: 0x040014CC RID: 5324
		private const string KEY_PREFIX = "FishingQteConfigById";

		// Token: 0x040014CD RID: 5325
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014CE RID: 5326
		private static int HandleId;
	}
}
