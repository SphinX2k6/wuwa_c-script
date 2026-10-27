using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000599 RID: 1433
	public class ConfigMotorFightRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x00117B4B File Offset: 0x00115D4B
		static ConfigMotorFightRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRoleById.CreateStaticDefaultValue), new Action(ConfigMotorFightRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00117B6C File Offset: 0x00115D6C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightRole"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightRole` where Id=?")
			});
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00117BEB File Offset: 0x00115DEB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRoleById.LogPair = null;
			ConfigMotorFightRoleById.HandleId = 0;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00117BF9 File Offset: 0x00115DF9
		public static void Init()
		{
			ConfigMotorFightRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRoleById.HandleId, "db_motorfight.db", "select BinData from `MotorFightRole` where Id=?");
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00117C14 File Offset: 0x00115E14
		public static MotorFightRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightRoleById.HandleId, ConfigMotorFightRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightRole?(MotorFightRole.GetRootAsMotorFightRole(configBuffer));
				}
			}
			ConfigMotorFightRoleById.LogPair.Clear();
			ConfigMotorFightRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightRoleById.HandleId, 1, p0Id, ConfigMotorFightRoleById.LogPair) || ConfigCommon.Step(ConfigMotorFightRoleById.HandleId, true, ConfigMotorFightRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightRoleById.HandleId, ConfigMotorFightRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightRoleById.HandleId, 0, ConfigMotorFightRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightRoleById.HandleId, ConfigMotorFightRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightRole rootAsMotorFightRole = MotorFightRole.GetRootAsMotorFightRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightRoleById.HandleId, ConfigMotorFightRoleById.LogPair);
			return new MotorFightRole?(rootAsMotorFightRole);
		}

		// Token: 0x04002713 RID: 10003
		private const string DB = "db_motorfight.db";

		// Token: 0x04002714 RID: 10004
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002715 RID: 10005
		private const string TABLE = "MotorFightRole";

		// Token: 0x04002716 RID: 10006
		private const string COMMAND = "select BinData from `MotorFightRole` where Id=?";

		// Token: 0x04002717 RID: 10007
		private const string KEY_PREFIX = "MotorFightRoleById";

		// Token: 0x04002718 RID: 10008
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002719 RID: 10009
		private static int HandleId;
	}
}
