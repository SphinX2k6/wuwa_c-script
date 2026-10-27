using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B5 RID: 2229
	public class ConfigRoleLevelConsumeByConsumeGroupIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003451 RID: 13393 RVA: 0x00180EA0 File Offset: 0x0017F0A0
		static ConfigRoleLevelConsumeByConsumeGroupIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.CreateStaticDefaultValue), new Action(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00180EC0 File Offset: 0x0017F0C0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role_level.db"),
				new ValueTuple<string, object>("文件", "j.角色升级突破.xlsx"),
				new ValueTuple<string, object>("表名", "RoleLevelConsume"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleLevelConsume` where ConsumeGroupId=? AND Level=?")
			});
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00180F3F File Offset: 0x0017F13F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair = null;
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId = 0;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00180F4D File Offset: 0x0017F14D
		public static void Init()
		{
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, "db_role_level.db", "select BinData from `RoleLevelConsume` where ConsumeGroupId=? AND Level=?");
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00180F68 File Offset: 0x0017F168
		public static RoleLevelConsume? GetConfig(int p0ConsumeGroupId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleLevelConsumeByConsumeGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ConsumeGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleLevelConsume?(RoleLevelConsume.GetRootAsRoleLevelConsume(configBuffer));
				}
			}
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair.Clear();
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("ConsumeGroupId", p0ConsumeGroupId));
			ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, 1, p0ConsumeGroupId, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, 2, p1Level, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair) || ConfigCommon.Step(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, true, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, 0, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleLevelConsume rootAsRoleLevelConsume = RoleLevelConsume.GetRootAsRoleLevelConsume(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RoleLevelConsumeByConsumeGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ConsumeGroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.HandleId, ConfigRoleLevelConsumeByConsumeGroupIdAndLevel.LogPair);
			return new RoleLevelConsume?(rootAsRoleLevelConsume);
		}

		// Token: 0x04003CD9 RID: 15577
		private const string DB = "db_role_level.db";

		// Token: 0x04003CDA RID: 15578
		private const string FILE = "j.角色升级突破.xlsx";

		// Token: 0x04003CDB RID: 15579
		private const string TABLE = "RoleLevelConsume";

		// Token: 0x04003CDC RID: 15580
		private const string COMMAND = "select BinData from `RoleLevelConsume` where ConsumeGroupId=? AND Level=?";

		// Token: 0x04003CDD RID: 15581
		private const string KEY_PREFIX = "RoleLevelConsumeByConsumeGroupIdAndLevel";

		// Token: 0x04003CDE RID: 15582
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CDF RID: 15583
		private static int HandleId;
	}
}
