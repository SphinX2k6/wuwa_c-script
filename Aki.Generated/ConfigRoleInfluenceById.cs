using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C9 RID: 2249
	public class ConfigRoleInfluenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034C9 RID: 13513 RVA: 0x00187173 File Offset: 0x00185373
		static ConfigRoleInfluenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfluenceById.CreateStaticDefaultValue), new Action(ConfigRoleInfluenceById.ResetStaticDefaultValue));
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00187194 File Offset: 0x00185394
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

		// Token: 0x060034CB RID: 13515 RVA: 0x00187213 File Offset: 0x00185413
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfluenceById.LogPair = null;
			ConfigRoleInfluenceById.HandleId = 0;
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00187221 File Offset: 0x00185421
		public static void Init()
		{
			ConfigRoleInfluenceById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfluenceById.HandleId, "db_roleinfluence.db", "select BinData from `RoleInfluence` where Id=?");
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x0018723C File Offset: 0x0018543C
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

		// Token: 0x04003D65 RID: 15717
		private const string DB = "db_roleinfluence.db";

		// Token: 0x04003D66 RID: 15718
		private const string FILE = "j.角色势力.xlsx";

		// Token: 0x04003D67 RID: 15719
		private const string TABLE = "RoleInfluence";

		// Token: 0x04003D68 RID: 15720
		private const string COMMAND = "select BinData from `RoleInfluence` where Id=?";

		// Token: 0x04003D69 RID: 15721
		private const string KEY_PREFIX = "RoleInfluenceById";

		// Token: 0x04003D6A RID: 15722
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D6B RID: 15723
		private static int HandleId;
	}
}
