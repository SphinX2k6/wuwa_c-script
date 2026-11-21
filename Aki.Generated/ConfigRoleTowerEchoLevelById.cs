using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F0 RID: 2288
	public class ConfigRoleTowerEchoLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035B3 RID: 13747 RVA: 0x0018C4A3 File Offset: 0x0018A6A3
		static ConfigRoleTowerEchoLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerEchoLevelById.CreateStaticDefaultValue), new Action(ConfigRoleTowerEchoLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x0018C4C4 File Offset: 0x0018A6C4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerEchoLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerEchoLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerEchoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerEchoLevel` where Id=?")
			});
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x0018C543 File Offset: 0x0018A743
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerEchoLevelById.LogPair = null;
			ConfigRoleTowerEchoLevelById.HandleId = 0;
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x0018C551 File Offset: 0x0018A751
		public static void Init()
		{
			ConfigRoleTowerEchoLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerEchoLevelById.HandleId, "db_roletower.db", "select BinData from `RoleTowerEchoLevel` where Id=?");
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x0018C56C File Offset: 0x0018A76C
		public static RoleTowerEchoLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerEchoLevelById.HandleId, ConfigRoleTowerEchoLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerEchoLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerEchoLevel?(RoleTowerEchoLevel.GetRootAsRoleTowerEchoLevel(configBuffer));
				}
			}
			ConfigRoleTowerEchoLevelById.LogPair.Clear();
			ConfigRoleTowerEchoLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerEchoLevelById.HandleId, 1, p0Id, ConfigRoleTowerEchoLevelById.LogPair) || ConfigCommon.Step(ConfigRoleTowerEchoLevelById.HandleId, true, ConfigRoleTowerEchoLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerEchoLevelById.HandleId, ConfigRoleTowerEchoLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerEchoLevelById.HandleId, 0, ConfigRoleTowerEchoLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerEchoLevelById.HandleId, ConfigRoleTowerEchoLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerEchoLevel rootAsRoleTowerEchoLevel = RoleTowerEchoLevel.GetRootAsRoleTowerEchoLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerEchoLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerEchoLevelById.HandleId, ConfigRoleTowerEchoLevelById.LogPair);
			return new RoleTowerEchoLevel?(rootAsRoleTowerEchoLevel);
		}

		// Token: 0x04003E76 RID: 15990
		private const string DB = "db_roletower.db";

		// Token: 0x04003E77 RID: 15991
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003E78 RID: 15992
		private const string TABLE = "RoleTowerEchoLevel";

		// Token: 0x04003E79 RID: 15993
		private const string COMMAND = "select BinData from `RoleTowerEchoLevel` where Id=?";

		// Token: 0x04003E7A RID: 15994
		private const string KEY_PREFIX = "RoleTowerEchoLevelById";

		// Token: 0x04003E7B RID: 15995
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E7C RID: 15996
		private static int HandleId;
	}
}
