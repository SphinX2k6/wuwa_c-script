using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000911 RID: 2321
	public class ConfigRoleTowerTokenByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003679 RID: 13945 RVA: 0x001907AF File Offset: 0x0018E9AF
		static ConfigRoleTowerTokenByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x001907D0 File Offset: 0x0018E9D0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerToken"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerToken` where ActivityId=?")
			});
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x0019084F File Offset: 0x0018EA4F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenByActivityId.LogPair = null;
			ConfigRoleTowerTokenByActivityId.HandleId = 0;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0019085D File Offset: 0x0018EA5D
		public static void Init()
		{
			ConfigRoleTowerTokenByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerToken` where ActivityId=?");
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00190878 File Offset: 0x0018EA78
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerToken> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenByActivityId.HandleId, ConfigRoleTowerTokenByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoleTowerToken> readOnlyList = (IReadOnlyList<RoleTowerToken>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerTokenByActivityId.LogPair.Clear();
			ConfigRoleTowerTokenByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerTokenByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerTokenByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerTokenByActivityId.HandleId, ConfigRoleTowerTokenByActivityId.LogPair);
				return null;
			}
			List<RoleTowerToken> list = new List<RoleTowerToken>();
			while (ConfigCommon.Step(ConfigRoleTowerTokenByActivityId.HandleId, false, ConfigRoleTowerTokenByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenByActivityId.HandleId, 0, ConfigRoleTowerTokenByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerTokenByActivityId.HandleId, ConfigRoleTowerTokenByActivityId.LogPair);
					return null;
				}
				RoleTowerToken rootAsRoleTowerToken = RoleTowerToken.GetRootAsRoleTowerToken(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerToken);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerTokenByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenByActivityId.HandleId, ConfigRoleTowerTokenByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003F5D RID: 16221
		private const string DB = "db_roletower.db";

		// Token: 0x04003F5E RID: 16222
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F5F RID: 16223
		private const string TABLE = "RoleTowerToken";

		// Token: 0x04003F60 RID: 16224
		private const string COMMAND = "select BinData from `RoleTowerToken` where ActivityId=?";

		// Token: 0x04003F61 RID: 16225
		private const string KEY_PREFIX = "RoleTowerTokenByActivityId";

		// Token: 0x04003F62 RID: 16226
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F63 RID: 16227
		private static int HandleId;
	}
}
