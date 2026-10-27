using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036F RID: 879
	public class ConfigGachaPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014A0 RID: 5280 RVA: 0x000CE1F1 File Offset: 0x000CC3F1
		static ConfigGachaPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaPoolById.CreateStaticDefaultValue), new Action(ConfigGachaPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x000CE210 File Offset: 0x000CC410
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaPool"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaPool` where Id=?")
			});
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000CE28F File Offset: 0x000CC48F
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaPoolById.LogPair = null;
			ConfigGachaPoolById.HandleId = 0;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x000CE29D File Offset: 0x000CC49D
		public static void Init()
		{
			ConfigGachaPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaPoolById.HandleId, "db_gacha.db", "select BinData from `GachaPool` where Id=?");
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000CE2B8 File Offset: 0x000CC4B8
		public static GachaPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaPool?(GachaPool.GetRootAsGachaPool(configBuffer));
				}
			}
			ConfigGachaPoolById.LogPair.Clear();
			ConfigGachaPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaPoolById.HandleId, 1, p0Id, ConfigGachaPoolById.LogPair) || ConfigCommon.Step(ConfigGachaPoolById.HandleId, true, ConfigGachaPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaPoolById.HandleId, 0, ConfigGachaPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaPool rootAsGachaPool = GachaPool.GetRootAsGachaPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair);
			return new GachaPool?(rootAsGachaPool);
		}

		// Token: 0x040017ED RID: 6125
		private const string DB = "db_gacha.db";

		// Token: 0x040017EE RID: 6126
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040017EF RID: 6127
		private const string TABLE = "GachaPool";

		// Token: 0x040017F0 RID: 6128
		private const string COMMAND = "select BinData from `GachaPool` where Id=?";

		// Token: 0x040017F1 RID: 6129
		private const string KEY_PREFIX = "GachaPoolById";

		// Token: 0x040017F2 RID: 6130
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017F3 RID: 6131
		private static int HandleId;
	}
}
