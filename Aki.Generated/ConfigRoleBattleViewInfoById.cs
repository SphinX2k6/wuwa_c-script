using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000887 RID: 2183
	public class ConfigRoleBattleViewInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600333C RID: 13116 RVA: 0x0017B0B7 File Offset: 0x001792B7
		static ConfigRoleBattleViewInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBattleViewInfoById.CreateStaticDefaultValue), new Action(ConfigRoleBattleViewInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0017B0D8 File Offset: 0x001792D8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBattleViewInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBattleViewInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role_battle_view.db"),
				new ValueTuple<string, object>("文件", "j.角色战斗界面布局.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBattleViewInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBattleViewInfo` where Id=?")
			});
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x0017B157 File Offset: 0x00179357
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBattleViewInfoById.LogPair = null;
			ConfigRoleBattleViewInfoById.HandleId = 0;
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x0017B165 File Offset: 0x00179365
		public static void Init()
		{
			ConfigRoleBattleViewInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBattleViewInfoById.HandleId, "db_role_battle_view.db", "select BinData from `RoleBattleViewInfo` where Id=?");
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0017B180 File Offset: 0x00179380
		public static RoleBattleViewInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBattleViewInfoById.HandleId, ConfigRoleBattleViewInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBattleViewInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleBattleViewInfo?(RoleBattleViewInfo.GetRootAsRoleBattleViewInfo(configBuffer));
				}
			}
			ConfigRoleBattleViewInfoById.LogPair.Clear();
			ConfigRoleBattleViewInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleBattleViewInfoById.HandleId, 1, p0Id, ConfigRoleBattleViewInfoById.LogPair) || ConfigCommon.Step(ConfigRoleBattleViewInfoById.HandleId, true, ConfigRoleBattleViewInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleBattleViewInfoById.HandleId, ConfigRoleBattleViewInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBattleViewInfoById.HandleId, 0, ConfigRoleBattleViewInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleBattleViewInfoById.HandleId, ConfigRoleBattleViewInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleBattleViewInfo rootAsRoleBattleViewInfo = RoleBattleViewInfo.GetRootAsRoleBattleViewInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleBattleViewInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleBattleViewInfoById.HandleId, ConfigRoleBattleViewInfoById.LogPair);
			return new RoleBattleViewInfo?(rootAsRoleBattleViewInfo);
		}

		// Token: 0x04003B97 RID: 15255
		private const string DB = "db_role_battle_view.db";

		// Token: 0x04003B98 RID: 15256
		private const string FILE = "j.角色战斗界面布局.xlsx";

		// Token: 0x04003B99 RID: 15257
		private const string TABLE = "RoleBattleViewInfo";

		// Token: 0x04003B9A RID: 15258
		private const string COMMAND = "select BinData from `RoleBattleViewInfo` where Id=?";

		// Token: 0x04003B9B RID: 15259
		private const string KEY_PREFIX = "RoleBattleViewInfoById";

		// Token: 0x04003B9C RID: 15260
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B9D RID: 15261
		private static int HandleId;
	}
}
