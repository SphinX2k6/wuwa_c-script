using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E2 RID: 2274
	public class ConfigRoleSkinByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600355F RID: 13663 RVA: 0x0018A6AC File Offset: 0x001888AC
		static ConfigRoleSkinByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinByGroupId.CreateStaticDefaultValue), new Action(ConfigRoleSkinByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0018A6CC File Offset: 0x001888CC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin` where GroupId=?")
			});
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0018A74B File Offset: 0x0018894B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinByGroupId.LogPair = null;
			ConfigRoleSkinByGroupId.HandleId = 0;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x0018A759 File Offset: 0x00188959
		public static void Init()
		{
			ConfigRoleSkinByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinByGroupId.HandleId, "db_role.db", "select BinData from `RoleSkin` where GroupId=?");
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x0018A774 File Offset: 0x00188974
		[NullableContext(2)]
		public static IReadOnlyList<RoleSkin> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<RoleSkin> readOnlyList = (IReadOnlyList<RoleSkin>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleSkinByGroupId.LogPair.Clear();
			ConfigRoleSkinByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigRoleSkinByGroupId.HandleId, 1, p0GroupId, ConfigRoleSkinByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair);
				return null;
			}
			List<RoleSkin> list = new List<RoleSkin>();
			while (ConfigCommon.Step(ConfigRoleSkinByGroupId.HandleId, false, ConfigRoleSkinByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinByGroupId.HandleId, 0, ConfigRoleSkinByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair);
					return null;
				}
				RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(new ByteBuffer(item2));
				list.Add(rootAsRoleSkin);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleSkinByGroupId.HandleId, ConfigRoleSkinByGroupId.LogPair);
			return list;
		}

		// Token: 0x04003E14 RID: 15892
		private const string DB = "db_role.db";

		// Token: 0x04003E15 RID: 15893
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003E16 RID: 15894
		private const string TABLE = "RoleSkin";

		// Token: 0x04003E17 RID: 15895
		private const string COMMAND = "select BinData from `RoleSkin` where GroupId=?";

		// Token: 0x04003E18 RID: 15896
		private const string KEY_PREFIX = "RoleSkinByGroupId";

		// Token: 0x04003E19 RID: 15897
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E1A RID: 15898
		private static int HandleId;
	}
}
