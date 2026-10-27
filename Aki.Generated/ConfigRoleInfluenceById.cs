using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AD RID: 2221
	public class ConfigRoleInfluenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003421 RID: 13345 RVA: 0x0017FE8B File Offset: 0x0017E08B
		static ConfigRoleInfluenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfluenceById.CreateStaticDefaultValue), new Action(ConfigRoleInfluenceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x0017FEAC File Offset: 0x0017E0AC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfluenceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfluenceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleinfluence.db"),
				new ValueTuple<string, object>("文件", "j.角色势力.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfluence"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfluence` where Id=?")
			});
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x0017FF2B File Offset: 0x0017E12B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfluenceById.LogPair = null;
			ConfigRoleInfluenceById.HandleId = 0;
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x0017FF39 File Offset: 0x0017E139
		public static void Init()
		{
			ConfigRoleInfluenceById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfluenceById.HandleId, "db_roleinfluence.db", "select BinData from `RoleInfluence` where Id=?");
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x0017FF54 File Offset: 0x0017E154
		public static RoleInfluence? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfluenceById.HandleId, ConfigRoleInfluenceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfluenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleInfluence?(RoleInfluence.GetRootAsRoleInfluence(configBuffer));
				}
			}
			ConfigRoleInfluenceById.LogPair.Clear();
			ConfigRoleInfluenceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleInfluenceById.HandleId, 1, p0Id, ConfigRoleInfluenceById.LogPair) || ConfigCommon.Step(ConfigRoleInfluenceById.HandleId, true, ConfigRoleInfluenceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleInfluenceById.HandleId, ConfigRoleInfluenceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfluenceById.HandleId, 0, ConfigRoleInfluenceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleInfluenceById.HandleId, ConfigRoleInfluenceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleInfluence rootAsRoleInfluence = RoleInfluence.GetRootAsRoleInfluence(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfluenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleInfluenceById.HandleId, ConfigRoleInfluenceById.LogPair);
			return new RoleInfluence?(rootAsRoleInfluence);
		}

		// Token: 0x04003CA1 RID: 15521
		private const string DB = "db_roleinfluence.db";

		// Token: 0x04003CA2 RID: 15522
		private const string FILE = "j.角色势力.xlsx";

		// Token: 0x04003CA3 RID: 15523
		private const string TABLE = "RoleInfluence";

		// Token: 0x04003CA4 RID: 15524
		private const string COMMAND = "select BinData from `RoleInfluence` where Id=?";

		// Token: 0x04003CA5 RID: 15525
		private const string KEY_PREFIX = "RoleInfluenceById";

		// Token: 0x04003CA6 RID: 15526
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CA7 RID: 15527
		private static int HandleId;
	}
}
