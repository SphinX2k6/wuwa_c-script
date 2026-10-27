using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000718 RID: 1816
	public class ConfigPinballDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AA0 RID: 10912 RVA: 0x0014A44D File Offset: 0x0014864D
		static ConfigPinballDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDeathrattleById.CreateStaticDefaultValue), new Action(ConfigPinballDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x0014A46C File Offset: 0x0014866C
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

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0014A4EB File Offset: 0x001486EB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDeathrattleById.LogPair = null;
			ConfigPinballDeathrattleById.HandleId = 0;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0014A4F9 File Offset: 0x001486F9
		public static void Init()
		{
			ConfigPinballDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDeathrattleById.HandleId, "db_pinballbattle.db", "select BinData from `PinballDeathrattle` where Id=?");
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0014A514 File Offset: 0x00148714
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

		// Token: 0x0400318E RID: 12686
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400318F RID: 12687
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x04003190 RID: 12688
		private const string TABLE = "PinballDeathrattle";

		// Token: 0x04003191 RID: 12689
		private const string COMMAND = "select BinData from `PinballDeathrattle` where Id=?";

		// Token: 0x04003192 RID: 12690
		private const string KEY_PREFIX = "PinballDeathrattleById";

		// Token: 0x04003193 RID: 12691
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003194 RID: 12692
		private static int HandleId;
	}
}
