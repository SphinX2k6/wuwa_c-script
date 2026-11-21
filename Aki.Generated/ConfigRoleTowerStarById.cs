using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090D RID: 2317
	public class ConfigRoleTowerStarById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003661 RID: 13921 RVA: 0x0018FFF7 File Offset: 0x0018E1F7
		static ConfigRoleTowerStarById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerStarById.CreateStaticDefaultValue), new Action(ConfigRoleTowerStarById.ResetStaticDefaultValue));
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x00190018 File Offset: 0x0018E218
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerStarById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerStarById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerStar"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerStar` where Id=?")
			});
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00190097 File Offset: 0x0018E297
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerStarById.LogPair = null;
			ConfigRoleTowerStarById.HandleId = 0;
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x001900A5 File Offset: 0x0018E2A5
		public static void Init()
		{
			ConfigRoleTowerStarById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerStarById.HandleId, "db_roletower.db", "select BinData from `RoleTowerStar` where Id=?");
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x001900C0 File Offset: 0x0018E2C0
		public static RoleTowerStar? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerStarById.HandleId, ConfigRoleTowerStarById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStarById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerStar?(RoleTowerStar.GetRootAsRoleTowerStar(configBuffer));
				}
			}
			ConfigRoleTowerStarById.LogPair.Clear();
			ConfigRoleTowerStarById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerStarById.HandleId, 1, p0Id, ConfigRoleTowerStarById.LogPair) || ConfigCommon.Step(ConfigRoleTowerStarById.HandleId, true, ConfigRoleTowerStarById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerStarById.HandleId, ConfigRoleTowerStarById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerStarById.HandleId, 0, ConfigRoleTowerStarById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerStarById.HandleId, ConfigRoleTowerStarById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerStar rootAsRoleTowerStar = RoleTowerStar.GetRootAsRoleTowerStar(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStarById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerStarById.HandleId, ConfigRoleTowerStarById.LogPair);
			return new RoleTowerStar?(rootAsRoleTowerStar);
		}

		// Token: 0x04003F41 RID: 16193
		private const string DB = "db_roletower.db";

		// Token: 0x04003F42 RID: 16194
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003F43 RID: 16195
		private const string TABLE = "RoleTowerStar";

		// Token: 0x04003F44 RID: 16196
		private const string COMMAND = "select BinData from `RoleTowerStar` where Id=?";

		// Token: 0x04003F45 RID: 16197
		private const string KEY_PREFIX = "RoleTowerStarById";

		// Token: 0x04003F46 RID: 16198
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F47 RID: 16199
		private static int HandleId;
	}
}
