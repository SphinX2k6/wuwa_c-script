using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000730 RID: 1840
	public class ConfigPinballDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B30 RID: 11056 RVA: 0x00150EC9 File Offset: 0x0014F0C9
		static ConfigPinballDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDeathrattleById.CreateStaticDefaultValue), new Action(ConfigPinballDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00150EE8 File Offset: 0x0014F0E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballDeathrattleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballDeathrattleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballDeathrattle"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballDeathrattle` where Id=?")
			});
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00150F67 File Offset: 0x0014F167
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDeathrattleById.LogPair = null;
			ConfigPinballDeathrattleById.HandleId = 0;
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00150F75 File Offset: 0x0014F175
		public static void Init()
		{
			ConfigPinballDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDeathrattleById.HandleId, "db_pinballbattle.db", "select BinData from `PinballDeathrattle` where Id=?");
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00150F90 File Offset: 0x0014F190
		public static PinballDeathrattle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballDeathrattleById.HandleId, ConfigPinballDeathrattleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballDeathrattle?(PinballDeathrattle.GetRootAsPinballDeathrattle(configBuffer));
				}
			}
			ConfigPinballDeathrattleById.LogPair.Clear();
			ConfigPinballDeathrattleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballDeathrattleById.HandleId, 1, p0Id, ConfigPinballDeathrattleById.LogPair) || ConfigCommon.Step(ConfigPinballDeathrattleById.HandleId, true, ConfigPinballDeathrattleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballDeathrattleById.HandleId, ConfigPinballDeathrattleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballDeathrattleById.HandleId, 0, ConfigPinballDeathrattleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballDeathrattleById.HandleId, ConfigPinballDeathrattleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballDeathrattle rootAsPinballDeathrattle = PinballDeathrattle.GetRootAsPinballDeathrattle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballDeathrattleById.HandleId, ConfigPinballDeathrattleById.LogPair);
			return new PinballDeathrattle?(rootAsPinballDeathrattle);
		}

		// Token: 0x04003236 RID: 12854
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003237 RID: 12855
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x04003238 RID: 12856
		private const string TABLE = "PinballDeathrattle";

		// Token: 0x04003239 RID: 12857
		private const string COMMAND = "select BinData from `PinballDeathrattle` where Id=?";

		// Token: 0x0400323A RID: 12858
		private const string KEY_PREFIX = "PinballDeathrattleById";

		// Token: 0x0400323B RID: 12859
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400323C RID: 12860
		private static int HandleId;
	}
}
