using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090F RID: 2319
	public class ConfigRoleTowerStarGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600366D RID: 13933 RVA: 0x001903D3 File Offset: 0x0018E5D3
		static ConfigRoleTowerStarGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerStarGroupById.CreateStaticDefaultValue), new Action(ConfigRoleTowerStarGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x001903F4 File Offset: 0x0018E5F4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerStarGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerStarGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerStarGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerStarGroup` where Id=?")
			});
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00190473 File Offset: 0x0018E673
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerStarGroupById.LogPair = null;
			ConfigRoleTowerStarGroupById.HandleId = 0;
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00190481 File Offset: 0x0018E681
		public static void Init()
		{
			ConfigRoleTowerStarGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerStarGroupById.HandleId, "db_roletower.db", "select BinData from `RoleTowerStarGroup` where Id=?");
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0019049C File Offset: 0x0018E69C
		public static RoleTowerStarGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerStarGroupById.HandleId, ConfigRoleTowerStarGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStarGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerStarGroup?(RoleTowerStarGroup.GetRootAsRoleTowerStarGroup(configBuffer));
				}
			}
			ConfigRoleTowerStarGroupById.LogPair.Clear();
			ConfigRoleTowerStarGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerStarGroupById.HandleId, 1, p0Id, ConfigRoleTowerStarGroupById.LogPair) || ConfigCommon.Step(ConfigRoleTowerStarGroupById.HandleId, true, ConfigRoleTowerStarGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerStarGroupById.HandleId, ConfigRoleTowerStarGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerStarGroupById.HandleId, 0, ConfigRoleTowerStarGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerStarGroupById.HandleId, ConfigRoleTowerStarGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerStarGroup rootAsRoleTowerStarGroup = RoleTowerStarGroup.GetRootAsRoleTowerStarGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStarGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerStarGroupById.HandleId, ConfigRoleTowerStarGroupById.LogPair);
			return new RoleTowerStarGroup?(rootAsRoleTowerStarGroup);
		}

		// Token: 0x04003F4F RID: 16207
		private const string DB = "db_roletower.db";

		// Token: 0x04003F50 RID: 16208
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003F51 RID: 16209
		private const string TABLE = "RoleTowerStarGroup";

		// Token: 0x04003F52 RID: 16210
		private const string COMMAND = "select BinData from `RoleTowerStarGroup` where Id=?";

		// Token: 0x04003F53 RID: 16211
		private const string KEY_PREFIX = "RoleTowerStarGroupById";

		// Token: 0x04003F54 RID: 16212
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F55 RID: 16213
		private static int HandleId;
	}
}
