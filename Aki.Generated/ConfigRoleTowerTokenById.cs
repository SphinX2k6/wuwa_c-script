using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000912 RID: 2322
	public class ConfigRoleTowerTokenById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600367F RID: 13951 RVA: 0x001909E7 File Offset: 0x0018EBE7
		static ConfigRoleTowerTokenById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenById.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenById.ResetStaticDefaultValue));
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00190A08 File Offset: 0x0018EC08
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerToken"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerToken` where Id=?")
			});
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x00190A87 File Offset: 0x0018EC87
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenById.LogPair = null;
			ConfigRoleTowerTokenById.HandleId = 0;
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x00190A95 File Offset: 0x0018EC95
		public static void Init()
		{
			ConfigRoleTowerTokenById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenById.HandleId, "db_roletower.db", "select BinData from `RoleTowerToken` where Id=?");
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00190AB0 File Offset: 0x0018ECB0
		public static RoleTowerToken? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenById.HandleId, ConfigRoleTowerTokenById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerToken?(RoleTowerToken.GetRootAsRoleTowerToken(configBuffer));
				}
			}
			ConfigRoleTowerTokenById.LogPair.Clear();
			ConfigRoleTowerTokenById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerTokenById.HandleId, 1, p0Id, ConfigRoleTowerTokenById.LogPair) || ConfigCommon.Step(ConfigRoleTowerTokenById.HandleId, true, ConfigRoleTowerTokenById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenById.HandleId, ConfigRoleTowerTokenById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenById.HandleId, 0, ConfigRoleTowerTokenById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenById.HandleId, ConfigRoleTowerTokenById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerToken rootAsRoleTowerToken = RoleTowerToken.GetRootAsRoleTowerToken(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenById.HandleId, ConfigRoleTowerTokenById.LogPair);
			return new RoleTowerToken?(rootAsRoleTowerToken);
		}

		// Token: 0x04003F64 RID: 16228
		private const string DB = "db_roletower.db";

		// Token: 0x04003F65 RID: 16229
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F66 RID: 16230
		private const string TABLE = "RoleTowerToken";

		// Token: 0x04003F67 RID: 16231
		private const string COMMAND = "select BinData from `RoleTowerToken` where Id=?";

		// Token: 0x04003F68 RID: 16232
		private const string KEY_PREFIX = "RoleTowerTokenById";

		// Token: 0x04003F69 RID: 16233
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F6A RID: 16234
		private static int HandleId;
	}
}
