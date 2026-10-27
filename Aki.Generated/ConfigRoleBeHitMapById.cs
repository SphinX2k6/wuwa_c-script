using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000889 RID: 2185
	public class ConfigRoleBeHitMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003348 RID: 13128 RVA: 0x0017B493 File Offset: 0x00179693
		static ConfigRoleBeHitMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBeHitMapById.CreateStaticDefaultValue), new Action(ConfigRoleBeHitMapById.ResetStaticDefaultValue));
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x0017B4B4 File Offset: 0x001796B4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBeHitMapById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBeHitMapById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolebehitmap.db"),
				new ValueTuple<string, object>("文件", "j.角色受击状态机.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBeHitMap"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBeHitMap` where Id=?")
			});
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0017B533 File Offset: 0x00179733
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBeHitMapById.LogPair = null;
			ConfigRoleBeHitMapById.HandleId = 0;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x0017B541 File Offset: 0x00179741
		public static void Init()
		{
			ConfigRoleBeHitMapById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBeHitMapById.HandleId, "db_rolebehitmap.db", "select BinData from `RoleBeHitMap` where Id=?");
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x0017B55C File Offset: 0x0017975C
		public static RoleBeHitMap? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBeHitMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleBeHitMap?(RoleBeHitMap.GetRootAsRoleBeHitMap(configBuffer));
				}
			}
			ConfigRoleBeHitMapById.LogPair.Clear();
			ConfigRoleBeHitMapById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleBeHitMapById.HandleId, 1, p0Id, ConfigRoleBeHitMapById.LogPair) || ConfigCommon.Step(ConfigRoleBeHitMapById.HandleId, true, ConfigRoleBeHitMapById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBeHitMapById.HandleId, 0, ConfigRoleBeHitMapById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleBeHitMap rootAsRoleBeHitMap = RoleBeHitMap.GetRootAsRoleBeHitMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBeHitMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleBeHitMapById.HandleId, ConfigRoleBeHitMapById.LogPair);
			return new RoleBeHitMap?(rootAsRoleBeHitMap);
		}

		// Token: 0x04003BA5 RID: 15269
		private const string DB = "db_rolebehitmap.db";

		// Token: 0x04003BA6 RID: 15270
		private const string FILE = "j.角色受击状态机.xlsx";

		// Token: 0x04003BA7 RID: 15271
		private const string TABLE = "RoleBeHitMap";

		// Token: 0x04003BA8 RID: 15272
		private const string COMMAND = "select BinData from `RoleBeHitMap` where Id=?";

		// Token: 0x04003BA9 RID: 15273
		private const string KEY_PREFIX = "RoleBeHitMapById";

		// Token: 0x04003BAA RID: 15274
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BAB RID: 15275
		private static int HandleId;
	}
}
