using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007FD RID: 2045
	public class ConfigReignsCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003000 RID: 12288 RVA: 0x0016BFF4 File Offset: 0x0016A1F4
		static ConfigReignsCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReignsCardById.CreateStaticDefaultValue), new Action(ConfigReignsCardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x0016C014 File Offset: 0x0016A214
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

		// Token: 0x06003002 RID: 12290 RVA: 0x0016C093 File Offset: 0x0016A293
		public static void ResetStaticDefaultValue()
		{
			ConfigReignsCardById.LogPair = null;
			ConfigReignsCardById.HandleId = 0;
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x0016C0A1 File Offset: 0x0016A2A1
		public static void Init()
		{
			ConfigReignsCardById.HandleId = ConfigCommon.InitDataStatement(ConfigReignsCardById.HandleId, "db_reignscard.db", "select BinData from `ReignsCard` where Id=?");
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0016C0BC File Offset: 0x0016A2BC
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

		// Token: 0x040037D1 RID: 14289
		private const string DB = "db_reignscard.db";

		// Token: 0x040037D2 RID: 14290
		private const string FILE = "k.可视化编辑/c.Csv/w.王权玩法结果卡片/*.csv*";

		// Token: 0x040037D3 RID: 14291
		private const string TABLE = "ReignsCard";

		// Token: 0x040037D4 RID: 14292
		private const string COMMAND = "select BinData from `ReignsCard` where Id=?";

		// Token: 0x040037D5 RID: 14293
		private const string KEY_PREFIX = "ReignsCardById";

		// Token: 0x040037D6 RID: 14294
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037D7 RID: 14295
		private static int HandleId;
	}
}
