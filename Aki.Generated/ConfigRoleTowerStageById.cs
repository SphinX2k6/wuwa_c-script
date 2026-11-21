using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090A RID: 2314
	public class ConfigRoleTowerStageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600364F RID: 13903 RVA: 0x0018F9E3 File Offset: 0x0018DBE3
		static ConfigRoleTowerStageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerStageById.CreateStaticDefaultValue), new Action(ConfigRoleTowerStageById.ResetStaticDefaultValue));
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0018FA04 File Offset: 0x0018DC04
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerStageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerStageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerStage"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerStage` where Id=?")
			});
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x0018FA83 File Offset: 0x0018DC83
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerStageById.LogPair = null;
			ConfigRoleTowerStageById.HandleId = 0;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0018FA91 File Offset: 0x0018DC91
		public static void Init()
		{
			ConfigRoleTowerStageById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerStageById.HandleId, "db_roletower.db", "select BinData from `RoleTowerStage` where Id=?");
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0018FAAC File Offset: 0x0018DCAC
		public static RoleTowerStage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerStageById.HandleId, ConfigRoleTowerStageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerStage?(RoleTowerStage.GetRootAsRoleTowerStage(configBuffer));
				}
			}
			ConfigRoleTowerStageById.LogPair.Clear();
			ConfigRoleTowerStageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerStageById.HandleId, 1, p0Id, ConfigRoleTowerStageById.LogPair) || ConfigCommon.Step(ConfigRoleTowerStageById.HandleId, true, ConfigRoleTowerStageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerStageById.HandleId, ConfigRoleTowerStageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerStageById.HandleId, 0, ConfigRoleTowerStageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerStageById.HandleId, ConfigRoleTowerStageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerStage rootAsRoleTowerStage = RoleTowerStage.GetRootAsRoleTowerStage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerStageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerStageById.HandleId, ConfigRoleTowerStageById.LogPair);
			return new RoleTowerStage?(rootAsRoleTowerStage);
		}

		// Token: 0x04003F2C RID: 16172
		private const string DB = "db_roletower.db";

		// Token: 0x04003F2D RID: 16173
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003F2E RID: 16174
		private const string TABLE = "RoleTowerStage";

		// Token: 0x04003F2F RID: 16175
		private const string COMMAND = "select BinData from `RoleTowerStage` where Id=?";

		// Token: 0x04003F30 RID: 16176
		private const string KEY_PREFIX = "RoleTowerStageById";

		// Token: 0x04003F31 RID: 16177
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F32 RID: 16178
		private static int HandleId;
	}
}
