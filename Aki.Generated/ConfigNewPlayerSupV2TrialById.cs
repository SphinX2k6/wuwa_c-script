using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F8 RID: 1528
	public class ConfigNewPlayerSupV2TrialById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023DF RID: 9183 RVA: 0x0012448B File Offset: 0x0012268B
		static ConfigNewPlayerSupV2TrialById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupV2TrialById.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupV2TrialById.ResetStaticDefaultValue));
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x001244AC File Offset: 0x001226AC
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

		// Token: 0x060023E1 RID: 9185 RVA: 0x0012452B File Offset: 0x0012272B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialById.LogPair = null;
			ConfigNewPlayerSupV2TrialById.HandleId = 0;
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00124539 File Offset: 0x00122739
		public static void Init()
		{
			ConfigNewPlayerSupV2TrialById.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupV2TrialById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupV2Trial` where Id=?");
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00124554 File Offset: 0x00122754
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

		// Token: 0x040029AE RID: 10670
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x040029AF RID: 10671
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x040029B0 RID: 10672
		private const string TABLE = "NewPlayerSupV2Trial";

		// Token: 0x040029B1 RID: 10673
		private const string COMMAND = "select BinData from `NewPlayerSupV2Trial` where Id=?";

		// Token: 0x040029B2 RID: 10674
		private const string KEY_PREFIX = "NewPlayerSupV2TrialById";

		// Token: 0x040029B3 RID: 10675
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029B4 RID: 10676
		private static int HandleId;
	}
}
