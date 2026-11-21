using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A3 RID: 2211
	public class ConfigRoleBattleViewInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033E4 RID: 13284 RVA: 0x0018239F File Offset: 0x0018059F
		static ConfigRoleBattleViewInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBattleViewInfoById.CreateStaticDefaultValue), new Action(ConfigRoleBattleViewInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x001823C0 File Offset: 0x001805C0
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

		// Token: 0x060033E6 RID: 13286 RVA: 0x0018243F File Offset: 0x0018063F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBattleViewInfoById.LogPair = null;
			ConfigRoleBattleViewInfoById.HandleId = 0;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x0018244D File Offset: 0x0018064D
		public static void Init()
		{
			ConfigRoleBattleViewInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBattleViewInfoById.HandleId, "db_role_battle_view.db", "select BinData from `RoleBattleViewInfo` where Id=?");
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00182468 File Offset: 0x00180668
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

		// Token: 0x04003C5B RID: 15451
		private const string DB = "db_role_battle_view.db";

		// Token: 0x04003C5C RID: 15452
		private const string FILE = "j.角色战斗界面布局.xlsx";

		// Token: 0x04003C5D RID: 15453
		private const string TABLE = "RoleBattleViewInfo";

		// Token: 0x04003C5E RID: 15454
		private const string COMMAND = "select BinData from `RoleBattleViewInfo` where Id=?";

		// Token: 0x04003C5F RID: 15455
		private const string KEY_PREFIX = "RoleBattleViewInfoById";

		// Token: 0x04003C60 RID: 15456
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C61 RID: 15457
		private static int HandleId;
	}
}
