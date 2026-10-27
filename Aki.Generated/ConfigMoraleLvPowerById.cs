using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056B RID: 1387
	public class ConfigMoraleLvPowerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600208F RID: 8335 RVA: 0x00111673 File Offset: 0x0010F873
		static ConfigMoraleLvPowerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLvPowerById.CreateStaticDefaultValue), new Action(ConfigMoraleLvPowerById.ResetStaticDefaultValue));
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00111694 File Offset: 0x0010F894
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleLvPowerById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleLvPowerById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleLvPower"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleLvPower` where Id=?")
			});
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00111713 File Offset: 0x0010F913
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLvPowerById.LogPair = null;
			ConfigMoraleLvPowerById.HandleId = 0;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00111721 File Offset: 0x0010F921
		public static void Init()
		{
			ConfigMoraleLvPowerById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLvPowerById.HandleId, "db_moraleplay.db", "select BinData from `MoraleLvPower` where Id=?");
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0011173C File Offset: 0x0010F93C
		public static MoraleLvPower? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleLvPowerById.HandleId, ConfigMoraleLvPowerById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLvPowerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleLvPower?(MoraleLvPower.GetRootAsMoraleLvPower(configBuffer));
				}
			}
			ConfigMoraleLvPowerById.LogPair.Clear();
			ConfigMoraleLvPowerById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoraleLvPowerById.HandleId, 1, p0Id, ConfigMoraleLvPowerById.LogPair) || ConfigCommon.Step(ConfigMoraleLvPowerById.HandleId, true, ConfigMoraleLvPowerById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleLvPowerById.HandleId, ConfigMoraleLvPowerById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleLvPowerById.HandleId, 0, ConfigMoraleLvPowerById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleLvPowerById.HandleId, ConfigMoraleLvPowerById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleLvPower rootAsMoraleLvPower = MoraleLvPower.GetRootAsMoraleLvPower(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLvPowerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleLvPowerById.HandleId, ConfigMoraleLvPowerById.LogPair);
			return new MoraleLvPower?(rootAsMoraleLvPower);
		}

		// Token: 0x040025D1 RID: 9681
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025D2 RID: 9682
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025D3 RID: 9683
		private const string TABLE = "MoraleLvPower";

		// Token: 0x040025D4 RID: 9684
		private const string COMMAND = "select BinData from `MoraleLvPower` where Id=?";

		// Token: 0x040025D5 RID: 9685
		private const string KEY_PREFIX = "MoraleLvPowerById";

		// Token: 0x040025D6 RID: 9686
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025D7 RID: 9687
		private static int HandleId;
	}
}
