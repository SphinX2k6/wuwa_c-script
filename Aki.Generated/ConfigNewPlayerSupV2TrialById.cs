using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000610 RID: 1552
	public class ConfigNewPlayerSupV2TrialById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600246F RID: 9327 RVA: 0x0012AF07 File Offset: 0x00129107
		static ConfigNewPlayerSupV2TrialById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupV2TrialById.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupV2TrialById.ResetStaticDefaultValue));
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x0012AF28 File Offset: 0x00129128
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupV2TrialById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动V2.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupV2Trial"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupV2Trial` where Id=?")
			});
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x0012AFA7 File Offset: 0x001291A7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialById.LogPair = null;
			ConfigNewPlayerSupV2TrialById.HandleId = 0;
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x0012AFB5 File Offset: 0x001291B5
		public static void Init()
		{
			ConfigNewPlayerSupV2TrialById.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupV2TrialById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupV2Trial` where Id=?");
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x0012AFD0 File Offset: 0x001291D0
		public static NewPlayerSupV2Trial? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupV2TrialById.HandleId, ConfigNewPlayerSupV2TrialById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewPlayerSupV2Trial?(NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(configBuffer));
				}
			}
			ConfigNewPlayerSupV2TrialById.LogPair.Clear();
			ConfigNewPlayerSupV2TrialById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewPlayerSupV2TrialById.HandleId, 1, p0Id, ConfigNewPlayerSupV2TrialById.LogPair) || ConfigCommon.Step(ConfigNewPlayerSupV2TrialById.HandleId, true, ConfigNewPlayerSupV2TrialById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupV2TrialById.HandleId, ConfigNewPlayerSupV2TrialById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupV2TrialById.HandleId, 0, ConfigNewPlayerSupV2TrialById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupV2TrialById.HandleId, ConfigNewPlayerSupV2TrialById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewPlayerSupV2Trial rootAsNewPlayerSupV2Trial = NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupV2TrialById.HandleId, ConfigNewPlayerSupV2TrialById.LogPair);
			return new NewPlayerSupV2Trial?(rootAsNewPlayerSupV2Trial);
		}

		// Token: 0x04002A56 RID: 10838
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A57 RID: 10839
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x04002A58 RID: 10840
		private const string TABLE = "NewPlayerSupV2Trial";

		// Token: 0x04002A59 RID: 10841
		private const string COMMAND = "select BinData from `NewPlayerSupV2Trial` where Id=?";

		// Token: 0x04002A5A RID: 10842
		private const string KEY_PREFIX = "NewPlayerSupV2TrialById";

		// Token: 0x04002A5B RID: 10843
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A5C RID: 10844
		private static int HandleId;
	}
}
