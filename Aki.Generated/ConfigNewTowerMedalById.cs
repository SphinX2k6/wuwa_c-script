using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000618 RID: 1560
	public class ConfigNewTowerMedalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024A0 RID: 9376 RVA: 0x0012C1DB File Offset: 0x0012A3DB
		static ConfigNewTowerMedalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerMedalById.CreateStaticDefaultValue), new Action(ConfigNewTowerMedalById.ResetStaticDefaultValue));
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0012C1FC File Offset: 0x0012A3FC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerMedalById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerMedalById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerMedal"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerMedal` where Id=?")
			});
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0012C27B File Offset: 0x0012A47B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerMedalById.LogPair = null;
			ConfigNewTowerMedalById.HandleId = 0;
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0012C289 File Offset: 0x0012A489
		public static void Init()
		{
			ConfigNewTowerMedalById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerMedalById.HandleId, "db_newtower.db", "select BinData from `NewTowerMedal` where Id=?");
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0012C2A4 File Offset: 0x0012A4A4
		public static NewTowerMedal? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerMedalById.HandleId, ConfigNewTowerMedalById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerMedalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerMedal?(NewTowerMedal.GetRootAsNewTowerMedal(configBuffer));
				}
			}
			ConfigNewTowerMedalById.LogPair.Clear();
			ConfigNewTowerMedalById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerMedalById.HandleId, 1, p0Id, ConfigNewTowerMedalById.LogPair) || ConfigCommon.Step(ConfigNewTowerMedalById.HandleId, true, ConfigNewTowerMedalById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerMedalById.HandleId, ConfigNewTowerMedalById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerMedalById.HandleId, 0, ConfigNewTowerMedalById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerMedalById.HandleId, ConfigNewTowerMedalById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerMedal rootAsNewTowerMedal = NewTowerMedal.GetRootAsNewTowerMedal(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerMedalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerMedalById.HandleId, ConfigNewTowerMedalById.LogPair);
			return new NewTowerMedal?(rootAsNewTowerMedal);
		}

		// Token: 0x04002A8E RID: 10894
		private const string DB = "db_newtower.db";

		// Token: 0x04002A8F RID: 10895
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A90 RID: 10896
		private const string TABLE = "NewTowerMedal";

		// Token: 0x04002A91 RID: 10897
		private const string COMMAND = "select BinData from `NewTowerMedal` where Id=?";

		// Token: 0x04002A92 RID: 10898
		private const string KEY_PREFIX = "NewTowerMedalById";

		// Token: 0x04002A93 RID: 10899
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A94 RID: 10900
		private static int HandleId;
	}
}
