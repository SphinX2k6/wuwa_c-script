using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000914 RID: 2324
	public class ConfigRoleTowerTokenTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600368B RID: 13963 RVA: 0x00190DC3 File Offset: 0x0018EFC3
		static ConfigRoleTowerTokenTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenTypeById.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00190DE4 File Offset: 0x0018EFE4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerTokenType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerTokenType` where Id=?")
			});
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00190E63 File Offset: 0x0018F063
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenTypeById.LogPair = null;
			ConfigRoleTowerTokenTypeById.HandleId = 0;
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00190E71 File Offset: 0x0018F071
		public static void Init()
		{
			ConfigRoleTowerTokenTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenTypeById.HandleId, "db_roletower.db", "select BinData from `RoleTowerTokenType` where Id=?");
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00190E8C File Offset: 0x0018F08C
		public static RoleTowerTokenType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenTypeById.HandleId, ConfigRoleTowerTokenTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerTokenType?(RoleTowerTokenType.GetRootAsRoleTowerTokenType(configBuffer));
				}
			}
			ConfigRoleTowerTokenTypeById.LogPair.Clear();
			ConfigRoleTowerTokenTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerTokenTypeById.HandleId, 1, p0Id, ConfigRoleTowerTokenTypeById.LogPair) || ConfigCommon.Step(ConfigRoleTowerTokenTypeById.HandleId, true, ConfigRoleTowerTokenTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenTypeById.HandleId, ConfigRoleTowerTokenTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenTypeById.HandleId, 0, ConfigRoleTowerTokenTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenTypeById.HandleId, ConfigRoleTowerTokenTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerTokenType rootAsRoleTowerTokenType = RoleTowerTokenType.GetRootAsRoleTowerTokenType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenTypeById.HandleId, ConfigRoleTowerTokenTypeById.LogPair);
			return new RoleTowerTokenType?(rootAsRoleTowerTokenType);
		}

		// Token: 0x04003F72 RID: 16242
		private const string DB = "db_roletower.db";

		// Token: 0x04003F73 RID: 16243
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F74 RID: 16244
		private const string TABLE = "RoleTowerTokenType";

		// Token: 0x04003F75 RID: 16245
		private const string COMMAND = "select BinData from `RoleTowerTokenType` where Id=?";

		// Token: 0x04003F76 RID: 16246
		private const string KEY_PREFIX = "RoleTowerTokenTypeById";

		// Token: 0x04003F77 RID: 16247
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F78 RID: 16248
		private static int HandleId;
	}
}
