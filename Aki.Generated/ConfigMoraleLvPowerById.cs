using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000581 RID: 1409
	public class ConfigMoraleLvPowerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002113 RID: 8467 RVA: 0x00117DC7 File Offset: 0x00115FC7
		static ConfigMoraleLvPowerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLvPowerById.CreateStaticDefaultValue), new Action(ConfigMoraleLvPowerById.ResetStaticDefaultValue));
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00117DE8 File Offset: 0x00115FE8
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

		// Token: 0x06002115 RID: 8469 RVA: 0x00117E67 File Offset: 0x00116067
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLvPowerById.LogPair = null;
			ConfigMoraleLvPowerById.HandleId = 0;
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00117E75 File Offset: 0x00116075
		public static void Init()
		{
			ConfigMoraleLvPowerById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLvPowerById.HandleId, "db_moraleplay.db", "select BinData from `MoraleLvPower` where Id=?");
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00117E90 File Offset: 0x00116090
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

		// Token: 0x0400266B RID: 9835
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400266C RID: 9836
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400266D RID: 9837
		private const string TABLE = "MoraleLvPower";

		// Token: 0x0400266E RID: 9838
		private const string COMMAND = "select BinData from `MoraleLvPower` where Id=?";

		// Token: 0x0400266F RID: 9839
		private const string KEY_PREFIX = "MoraleLvPowerById";

		// Token: 0x04002670 RID: 9840
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002671 RID: 9841
		private static int HandleId;
	}
}
