using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EE RID: 238
	public class ConfigBackgroundCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x0007CBC7 File Offset: 0x0007ADC7
		static ConfigBackgroundCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBackgroundCardById.CreateStaticDefaultValue), new Action(ConfigBackgroundCardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0007CBE8 File Offset: 0x0007ADE8
		public static void CreateStaticDefaultValue()
		{
			ConfigBackgroundCardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBackgroundCardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_personal_card.db"),
				new ValueTuple<string, object>("文件", "m.名片.xlsx"),
				new ValueTuple<string, object>("表名", "BackgroundCard"),
				new ValueTuple<string, object>("语句", "select BinData from `BackgroundCard` where Id = ?")
			});
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0007CC67 File Offset: 0x0007AE67
		public static void ResetStaticDefaultValue()
		{
			ConfigBackgroundCardById.LogPair = null;
			ConfigBackgroundCardById.HandleId = 0;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0007CC75 File Offset: 0x0007AE75
		public static void Init()
		{
			ConfigBackgroundCardById.HandleId = ConfigCommon.InitDataStatement(ConfigBackgroundCardById.HandleId, "db_personal_card.db", "select BinData from `BackgroundCard` where Id = ?");
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0007CC90 File Offset: 0x0007AE90
		public static BackgroundCard? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBackgroundCardById.HandleId, ConfigBackgroundCardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BackgroundCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BackgroundCard?(BackgroundCard.GetRootAsBackgroundCard(configBuffer));
				}
			}
			ConfigBackgroundCardById.LogPair.Clear();
			ConfigBackgroundCardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBackgroundCardById.HandleId, 1, p0Id, ConfigBackgroundCardById.LogPair) || ConfigCommon.Step(ConfigBackgroundCardById.HandleId, true, ConfigBackgroundCardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBackgroundCardById.HandleId, ConfigBackgroundCardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBackgroundCardById.HandleId, 0, ConfigBackgroundCardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBackgroundCardById.HandleId, ConfigBackgroundCardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BackgroundCard rootAsBackgroundCard = BackgroundCard.GetRootAsBackgroundCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BackgroundCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBackgroundCardById.HandleId, ConfigBackgroundCardById.LogPair);
			return new BackgroundCard?(rootAsBackgroundCard);
		}

		// Token: 0x04000666 RID: 1638
		private const string DB = "db_personal_card.db";

		// Token: 0x04000667 RID: 1639
		private const string FILE = "m.名片.xlsx";

		// Token: 0x04000668 RID: 1640
		private const string TABLE = "BackgroundCard";

		// Token: 0x04000669 RID: 1641
		private const string COMMAND = "select BinData from `BackgroundCard` where Id = ?";

		// Token: 0x0400066A RID: 1642
		private const string KEY_PREFIX = "BackgroundCardById";

		// Token: 0x0400066B RID: 1643
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400066C RID: 1644
		private static int HandleId;
	}
}
