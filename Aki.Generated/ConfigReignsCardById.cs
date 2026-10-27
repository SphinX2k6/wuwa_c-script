using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E1 RID: 2017
	public class ConfigReignsCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F58 RID: 12120 RVA: 0x00164D0C File Offset: 0x00162F0C
		static ConfigReignsCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReignsCardById.CreateStaticDefaultValue), new Action(ConfigReignsCardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00164D2C File Offset: 0x00162F2C
		public static void CreateStaticDefaultValue()
		{
			ConfigReignsCardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigReignsCardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_reignscard.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/w.王权玩法结果卡片/*.csv*"),
				new ValueTuple<string, object>("表名", "ReignsCard"),
				new ValueTuple<string, object>("语句", "select BinData from `ReignsCard` where Id=?")
			});
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00164DAB File Offset: 0x00162FAB
		public static void ResetStaticDefaultValue()
		{
			ConfigReignsCardById.LogPair = null;
			ConfigReignsCardById.HandleId = 0;
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00164DB9 File Offset: 0x00162FB9
		public static void Init()
		{
			ConfigReignsCardById.HandleId = ConfigCommon.InitDataStatement(ConfigReignsCardById.HandleId, "db_reignscard.db", "select BinData from `ReignsCard` where Id=?");
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00164DD4 File Offset: 0x00162FD4
		public static ReignsCard? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigReignsCardById.HandleId, ConfigReignsCardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReignsCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ReignsCard?(ReignsCard.GetRootAsReignsCard(configBuffer));
				}
			}
			ConfigReignsCardById.LogPair.Clear();
			ConfigReignsCardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigReignsCardById.HandleId, 1, p0Id, ConfigReignsCardById.LogPair) || ConfigCommon.Step(ConfigReignsCardById.HandleId, true, ConfigReignsCardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigReignsCardById.HandleId, ConfigReignsCardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigReignsCardById.HandleId, 0, ConfigReignsCardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigReignsCardById.HandleId, ConfigReignsCardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ReignsCard rootAsReignsCard = ReignsCard.GetRootAsReignsCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReignsCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigReignsCardById.HandleId, ConfigReignsCardById.LogPair);
			return new ReignsCard?(rootAsReignsCard);
		}

		// Token: 0x0400370D RID: 14093
		private const string DB = "db_reignscard.db";

		// Token: 0x0400370E RID: 14094
		private const string FILE = "k.可视化编辑/c.Csv/w.王权玩法结果卡片/*.csv*";

		// Token: 0x0400370F RID: 14095
		private const string TABLE = "ReignsCard";

		// Token: 0x04003710 RID: 14096
		private const string COMMAND = "select BinData from `ReignsCard` where Id=?";

		// Token: 0x04003711 RID: 14097
		private const string KEY_PREFIX = "ReignsCardById";

		// Token: 0x04003712 RID: 14098
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003713 RID: 14099
		private static int HandleId;
	}
}
