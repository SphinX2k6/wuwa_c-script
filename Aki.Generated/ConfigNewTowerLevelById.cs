using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FE RID: 1534
	public class ConfigNewTowerLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002404 RID: 9220 RVA: 0x001252DF File Offset: 0x001234DF
		static ConfigNewTowerLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerLevelById.CreateStaticDefaultValue), new Action(ConfigNewTowerLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00125300 File Offset: 0x00123500
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

		// Token: 0x06002406 RID: 9222 RVA: 0x0012537F File Offset: 0x0012357F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerLevelById.LogPair = null;
			ConfigNewTowerLevelById.HandleId = 0;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0012538D File Offset: 0x0012358D
		public static void Init()
		{
			ConfigNewTowerLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerLevelById.HandleId, "db_newtower.db", "select BinData from `NewTowerLevel` where Id=?");
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x001253A8 File Offset: 0x001235A8
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

		// Token: 0x040029D8 RID: 10712
		private const string DB = "db_newtower.db";

		// Token: 0x040029D9 RID: 10713
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029DA RID: 10714
		private const string TABLE = "NewTowerLevel";

		// Token: 0x040029DB RID: 10715
		private const string COMMAND = "select BinData from `NewTowerLevel` where Id=?";

		// Token: 0x040029DC RID: 10716
		private const string KEY_PREFIX = "NewTowerLevelById";

		// Token: 0x040029DD RID: 10717
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029DE RID: 10718
		private static int HandleId;
	}
}
