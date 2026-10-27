using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000600 RID: 1536
	public class ConfigNewTowerMedalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002410 RID: 9232 RVA: 0x0012575F File Offset: 0x0012395F
		static ConfigNewTowerMedalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerMedalById.CreateStaticDefaultValue), new Action(ConfigNewTowerMedalById.ResetStaticDefaultValue));
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00125780 File Offset: 0x00123980
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

		// Token: 0x06002412 RID: 9234 RVA: 0x001257FF File Offset: 0x001239FF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerMedalById.LogPair = null;
			ConfigNewTowerMedalById.HandleId = 0;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0012580D File Offset: 0x00123A0D
		public static void Init()
		{
			ConfigNewTowerMedalById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerMedalById.HandleId, "db_newtower.db", "select BinData from `NewTowerMedal` where Id=?");
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00125828 File Offset: 0x00123A28
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

		// Token: 0x040029E6 RID: 10726
		private const string DB = "db_newtower.db";

		// Token: 0x040029E7 RID: 10727
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029E8 RID: 10728
		private const string TABLE = "NewTowerMedal";

		// Token: 0x040029E9 RID: 10729
		private const string COMMAND = "select BinData from `NewTowerMedal` where Id=?";

		// Token: 0x040029EA RID: 10730
		private const string KEY_PREFIX = "NewTowerMedalById";

		// Token: 0x040029EB RID: 10731
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029EC RID: 10732
		private static int HandleId;
	}
}
