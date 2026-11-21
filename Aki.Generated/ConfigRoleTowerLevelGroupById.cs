using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FA RID: 2298
	public class ConfigRoleTowerLevelGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035EF RID: 13807 RVA: 0x0018D927 File Offset: 0x0018BB27
		static ConfigRoleTowerLevelGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerLevelGroupById.CreateStaticDefaultValue), new Action(ConfigRoleTowerLevelGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x0018D948 File Offset: 0x0018BB48
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerLevelGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerLevelGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerLevelGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerLevelGroup` where Id=?")
			});
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0018D9C7 File Offset: 0x0018BBC7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerLevelGroupById.LogPair = null;
			ConfigRoleTowerLevelGroupById.HandleId = 0;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0018D9D5 File Offset: 0x0018BBD5
		public static void Init()
		{
			ConfigRoleTowerLevelGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerLevelGroupById.HandleId, "db_roletower.db", "select BinData from `RoleTowerLevelGroup` where Id=?");
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0018D9F0 File Offset: 0x0018BBF0
		public static RoleTowerLevelGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerLevelGroupById.HandleId, ConfigRoleTowerLevelGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerLevelGroup?(RoleTowerLevelGroup.GetRootAsRoleTowerLevelGroup(configBuffer));
				}
			}
			ConfigRoleTowerLevelGroupById.LogPair.Clear();
			ConfigRoleTowerLevelGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerLevelGroupById.HandleId, 1, p0Id, ConfigRoleTowerLevelGroupById.LogPair) || ConfigCommon.Step(ConfigRoleTowerLevelGroupById.HandleId, true, ConfigRoleTowerLevelGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerLevelGroupById.HandleId, ConfigRoleTowerLevelGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerLevelGroupById.HandleId, 0, ConfigRoleTowerLevelGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerLevelGroupById.HandleId, ConfigRoleTowerLevelGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerLevelGroup rootAsRoleTowerLevelGroup = RoleTowerLevelGroup.GetRootAsRoleTowerLevelGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerLevelGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerLevelGroupById.HandleId, ConfigRoleTowerLevelGroupById.LogPair);
			return new RoleTowerLevelGroup?(rootAsRoleTowerLevelGroup);
		}

		// Token: 0x04003EBC RID: 16060
		private const string DB = "db_roletower.db";

		// Token: 0x04003EBD RID: 16061
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003EBE RID: 16062
		private const string TABLE = "RoleTowerLevelGroup";

		// Token: 0x04003EBF RID: 16063
		private const string COMMAND = "select BinData from `RoleTowerLevelGroup` where Id=?";

		// Token: 0x04003EC0 RID: 16064
		private const string KEY_PREFIX = "RoleTowerLevelGroupById";

		// Token: 0x04003EC1 RID: 16065
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EC2 RID: 16066
		private static int HandleId;
	}
}
