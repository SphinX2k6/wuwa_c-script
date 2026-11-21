using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000616 RID: 1558
	public class ConfigNewTowerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002494 RID: 9364 RVA: 0x0012BD5B File Offset: 0x00129F5B
		static ConfigNewTowerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerLevelById.CreateStaticDefaultValue), new Action(ConfigNewTowerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0012BD7C File Offset: 0x00129F7C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerLevel` where Id=?")
			});
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0012BDFB File Offset: 0x00129FFB
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerLevelById.LogPair = null;
			ConfigNewTowerLevelById.HandleId = 0;
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0012BE09 File Offset: 0x0012A009
		public static void Init()
		{
			ConfigNewTowerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerLevelById.HandleId, "db_newtower.db", "select BinData from `NewTowerLevel` where Id=?");
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0012BE24 File Offset: 0x0012A024
		public static NewTowerLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerLevelById.HandleId, ConfigNewTowerLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerLevel?(NewTowerLevel.GetRootAsNewTowerLevel(configBuffer));
				}
			}
			ConfigNewTowerLevelById.LogPair.Clear();
			ConfigNewTowerLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerLevelById.HandleId, 1, p0Id, ConfigNewTowerLevelById.LogPair) || ConfigCommon.Step(ConfigNewTowerLevelById.HandleId, true, ConfigNewTowerLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerLevelById.HandleId, ConfigNewTowerLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerLevelById.HandleId, 0, ConfigNewTowerLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerLevelById.HandleId, ConfigNewTowerLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerLevel rootAsNewTowerLevel = NewTowerLevel.GetRootAsNewTowerLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerLevelById.HandleId, ConfigNewTowerLevelById.LogPair);
			return new NewTowerLevel?(rootAsNewTowerLevel);
		}

		// Token: 0x04002A80 RID: 10880
		private const string DB = "db_newtower.db";

		// Token: 0x04002A81 RID: 10881
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A82 RID: 10882
		private const string TABLE = "NewTowerLevel";

		// Token: 0x04002A83 RID: 10883
		private const string COMMAND = "select BinData from `NewTowerLevel` where Id=?";

		// Token: 0x04002A84 RID: 10884
		private const string KEY_PREFIX = "NewTowerLevelById";

		// Token: 0x04002A85 RID: 10885
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A86 RID: 10886
		private static int HandleId;
	}
}
