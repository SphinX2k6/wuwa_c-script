using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DF RID: 223
	public class ConfigBackgroundCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x00077263 File Offset: 0x00075463
		static ConfigBackgroundCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBackgroundCardById.CreateStaticDefaultValue), new Action(ConfigBackgroundCardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00077284 File Offset: 0x00075484
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

		// Token: 0x0600053D RID: 1341 RVA: 0x00077303 File Offset: 0x00075503
		public static void ResetStaticDefaultValue()
		{
			ConfigBackgroundCardById.LogPair = null;
			ConfigBackgroundCardById.HandleId = 0;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00077311 File Offset: 0x00075511
		public static void Init()
		{
			ConfigBackgroundCardById.HandleId = ConfigCommon.InitDataStatement(ConfigBackgroundCardById.HandleId, "db_personal_card.db", "select BinData from `BackgroundCard` where Id = ?");
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0007732C File Offset: 0x0007552C
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

		// Token: 0x040005FD RID: 1533
		private const string DB = "db_personal_card.db";

		// Token: 0x040005FE RID: 1534
		private const string FILE = "m.名片.xlsx";

		// Token: 0x040005FF RID: 1535
		private const string TABLE = "BackgroundCard";

		// Token: 0x04000600 RID: 1536
		private const string COMMAND = "select BinData from `BackgroundCard` where Id = ?";

		// Token: 0x04000601 RID: 1537
		private const string KEY_PREFIX = "BackgroundCardById";

		// Token: 0x04000602 RID: 1538
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000603 RID: 1539
		private static int HandleId;
	}
}
