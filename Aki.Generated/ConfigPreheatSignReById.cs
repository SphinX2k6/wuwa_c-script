using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075B RID: 1883
	public class ConfigPreheatSignReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C33 RID: 11315 RVA: 0x00153267 File Offset: 0x00151467
		static ConfigPreheatSignReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatSignReById.CreateStaticDefaultValue), new Action(ConfigPreheatSignReById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00153288 File Offset: 0x00151488
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatSignReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatSignReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatSignRe"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatSignRe` where Id=?")
			});
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x00153307 File Offset: 0x00151507
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatSignReById.LogPair = null;
			ConfigPreheatSignReById.HandleId = 0;
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00153315 File Offset: 0x00151515
		public static void Init()
		{
			ConfigPreheatSignReById.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatSignReById.HandleId, "db_preheat.db", "select BinData from `PreheatSignRe` where Id=?");
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00153330 File Offset: 0x00151530
		public static PreheatSignRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatSignReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PreheatSignRe?(PreheatSignRe.GetRootAsPreheatSignRe(configBuffer));
				}
			}
			ConfigPreheatSignReById.LogPair.Clear();
			ConfigPreheatSignReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPreheatSignReById.HandleId, 1, p0Id, ConfigPreheatSignReById.LogPair) || ConfigCommon.Step(ConfigPreheatSignReById.HandleId, true, ConfigPreheatSignReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatSignReById.HandleId, 0, ConfigPreheatSignReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PreheatSignRe rootAsPreheatSignRe = PreheatSignRe.GetRootAsPreheatSignRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PreheatSignReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPreheatSignReById.HandleId, ConfigPreheatSignReById.LogPair);
			return new PreheatSignRe?(rootAsPreheatSignRe);
		}

		// Token: 0x04003363 RID: 13155
		private const string DB = "db_preheat.db";

		// Token: 0x04003364 RID: 13156
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003365 RID: 13157
		private const string TABLE = "PreheatSignRe";

		// Token: 0x04003366 RID: 13158
		private const string COMMAND = "select BinData from `PreheatSignRe` where Id=?";

		// Token: 0x04003367 RID: 13159
		private const string KEY_PREFIX = "PreheatSignReById";

		// Token: 0x04003368 RID: 13160
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003369 RID: 13161
		private static int HandleId;
	}
}
