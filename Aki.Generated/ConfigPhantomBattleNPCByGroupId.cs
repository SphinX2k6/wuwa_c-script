using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069A RID: 1690
	public class ConfigPhantomBattleNPCByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x0013D784 File Offset: 0x0013B984
		static ConfigPhantomBattleNPCByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleNPCByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleNPCByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x0013D7A4 File Offset: 0x0013B9A4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleNPCByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleNPCByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleNPC"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleNPC` where GroupId=?")
			});
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x0013D823 File Offset: 0x0013BA23
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleNPCByGroupId.LogPair = null;
			ConfigPhantomBattleNPCByGroupId.HandleId = 0;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0013D831 File Offset: 0x0013BA31
		public static void Init()
		{
			ConfigPhantomBattleNPCByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleNPCByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleNPC` where GroupId=?");
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x0013D84C File Offset: 0x0013BA4C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleNPC> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleNPCByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<PhantomBattleNPC> readOnlyList = (IReadOnlyList<PhantomBattleNPC>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleNPCByGroupId.LogPair.Clear();
			ConfigPhantomBattleNPCByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleNPCByGroupId.HandleId, 1, p0GroupId, ConfigPhantomBattleNPCByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair);
				return null;
			}
			List<PhantomBattleNPC> list = new List<PhantomBattleNPC>();
			while (ConfigCommon.Step(ConfigPhantomBattleNPCByGroupId.HandleId, false, ConfigPhantomBattleNPCByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleNPCByGroupId.HandleId, 0, ConfigPhantomBattleNPCByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair);
					return null;
				}
				PhantomBattleNPC rootAsPhantomBattleNPC = PhantomBattleNPC.GetRootAsPhantomBattleNPC(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleNPC);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleNPCByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleNPCByGroupId.HandleId, ConfigPhantomBattleNPCByGroupId.LogPair);
			return list;
		}

		// Token: 0x04002E1C RID: 11804
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E1D RID: 11805
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E1E RID: 11806
		private const string TABLE = "PhantomBattleNPC";

		// Token: 0x04002E1F RID: 11807
		private const string COMMAND = "select BinData from `PhantomBattleNPC` where GroupId=?";

		// Token: 0x04002E20 RID: 11808
		private const string KEY_PREFIX = "PhantomBattleNPCByGroupId";

		// Token: 0x04002E21 RID: 11809
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E22 RID: 11810
		private static int HandleId;
	}
}
