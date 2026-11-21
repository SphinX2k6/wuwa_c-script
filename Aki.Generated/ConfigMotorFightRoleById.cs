using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B0 RID: 1456
	public class ConfigMotorFightRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x0011E433 File Offset: 0x0011C633
		static ConfigMotorFightRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRoleById.CreateStaticDefaultValue), new Action(ConfigMotorFightRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0011E454 File Offset: 0x0011C654
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

		// Token: 0x0600222F RID: 8751 RVA: 0x0011E4D3 File Offset: 0x0011C6D3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRoleById.LogPair = null;
			ConfigMotorFightRoleById.HandleId = 0;
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0011E4E1 File Offset: 0x0011C6E1
		public static void Init()
		{
			ConfigMotorFightRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRoleById.HandleId, "db_motorfight.db", "select BinData from `MotorFightRole` where Id=?");
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0011E4FC File Offset: 0x0011C6FC
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

		// Token: 0x040027B4 RID: 10164
		private const string DB = "db_motorfight.db";

		// Token: 0x040027B5 RID: 10165
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027B6 RID: 10166
		private const string TABLE = "MotorFightRole";

		// Token: 0x040027B7 RID: 10167
		private const string COMMAND = "select BinData from `MotorFightRole` where Id=?";

		// Token: 0x040027B8 RID: 10168
		private const string KEY_PREFIX = "MotorFightRoleById";

		// Token: 0x040027B9 RID: 10169
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027BA RID: 10170
		private static int HandleId;
	}
}
