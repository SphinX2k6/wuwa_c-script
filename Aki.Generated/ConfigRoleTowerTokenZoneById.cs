using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000917 RID: 2327
	public class ConfigRoleTowerTokenZoneById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600369D RID: 13981 RVA: 0x001913D7 File Offset: 0x0018F5D7
		static ConfigRoleTowerTokenZoneById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenZoneById.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenZoneById.ResetStaticDefaultValue));
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x001913F8 File Offset: 0x0018F5F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenZoneById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenZoneById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerTokenZone"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerTokenZone` where Id=?")
			});
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00191477 File Offset: 0x0018F677
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenZoneById.LogPair = null;
			ConfigRoleTowerTokenZoneById.HandleId = 0;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x00191485 File Offset: 0x0018F685
		public static void Init()
		{
			ConfigRoleTowerTokenZoneById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenZoneById.HandleId, "db_roletower.db", "select BinData from `RoleTowerTokenZone` where Id=?");
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x001914A0 File Offset: 0x0018F6A0
		public static RoleTowerTokenZone? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenZoneById.HandleId, ConfigRoleTowerTokenZoneById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenZoneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerTokenZone?(RoleTowerTokenZone.GetRootAsRoleTowerTokenZone(configBuffer));
				}
			}
			ConfigRoleTowerTokenZoneById.LogPair.Clear();
			ConfigRoleTowerTokenZoneById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerTokenZoneById.HandleId, 1, p0Id, ConfigRoleTowerTokenZoneById.LogPair) || ConfigCommon.Step(ConfigRoleTowerTokenZoneById.HandleId, true, ConfigRoleTowerTokenZoneById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenZoneById.HandleId, ConfigRoleTowerTokenZoneById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenZoneById.HandleId, 0, ConfigRoleTowerTokenZoneById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenZoneById.HandleId, ConfigRoleTowerTokenZoneById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerTokenZone rootAsRoleTowerTokenZone = RoleTowerTokenZone.GetRootAsRoleTowerTokenZone(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenZoneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenZoneById.HandleId, ConfigRoleTowerTokenZoneById.LogPair);
			return new RoleTowerTokenZone?(rootAsRoleTowerTokenZone);
		}

		// Token: 0x04003F87 RID: 16263
		private const string DB = "db_roletower.db";

		// Token: 0x04003F88 RID: 16264
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F89 RID: 16265
		private const string TABLE = "RoleTowerTokenZone";

		// Token: 0x04003F8A RID: 16266
		private const string COMMAND = "select BinData from `RoleTowerTokenZone` where Id=?";

		// Token: 0x04003F8B RID: 16267
		private const string KEY_PREFIX = "RoleTowerTokenZoneById";

		// Token: 0x04003F8C RID: 16268
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F8D RID: 16269
		private static int HandleId;
	}
}
