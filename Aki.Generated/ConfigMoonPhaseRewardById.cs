using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000576 RID: 1398
	public class ConfigMoonPhaseRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020D1 RID: 8401 RVA: 0x00116780 File Offset: 0x00114980
		static ConfigMoonPhaseRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoonPhaseRewardById.CreateStaticDefaultValue), new Action(ConfigMoonPhaseRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x001167A0 File Offset: 0x001149A0
		public static void CreateStaticDefaultValue()
		{
			ConfigMoonPhaseRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoonPhaseRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonsignin.db"),
				new ValueTuple<string, object>("文件", "y.月相活动.xlsx"),
				new ValueTuple<string, object>("表名", "MoonPhaseReward"),
				new ValueTuple<string, object>("语句", "select BinData from `MoonPhaseReward` where Id=?")
			});
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0011681F File Offset: 0x00114A1F
		public static void ResetStaticDefaultValue()
		{
			ConfigMoonPhaseRewardById.LogPair = null;
			ConfigMoonPhaseRewardById.HandleId = 0;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0011682D File Offset: 0x00114A2D
		public static void Init()
		{
			ConfigMoonPhaseRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigMoonPhaseRewardById.HandleId, "db_moonsignin.db", "select BinData from `MoonPhaseReward` where Id=?");
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00116848 File Offset: 0x00114A48
		public static MoonPhaseReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoonPhaseReward?(MoonPhaseReward.GetRootAsMoonPhaseReward(configBuffer));
				}
			}
			ConfigMoonPhaseRewardById.LogPair.Clear();
			ConfigMoonPhaseRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoonPhaseRewardById.HandleId, 1, p0Id, ConfigMoonPhaseRewardById.LogPair) || ConfigCommon.Step(ConfigMoonPhaseRewardById.HandleId, true, ConfigMoonPhaseRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoonPhaseRewardById.HandleId, 0, ConfigMoonPhaseRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoonPhaseReward rootAsMoonPhaseReward = MoonPhaseReward.GetRootAsMoonPhaseReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair);
			return new MoonPhaseReward?(rootAsMoonPhaseReward);
		}

		// Token: 0x0400261E RID: 9758
		private const string DB = "db_moonsignin.db";

		// Token: 0x0400261F RID: 9759
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002620 RID: 9760
		private const string TABLE = "MoonPhaseReward";

		// Token: 0x04002621 RID: 9761
		private const string COMMAND = "select BinData from `MoonPhaseReward` where Id=?";

		// Token: 0x04002622 RID: 9762
		private const string KEY_PREFIX = "MoonPhaseRewardById";

		// Token: 0x04002623 RID: 9763
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002624 RID: 9764
		private static int HandleId;
	}
}
