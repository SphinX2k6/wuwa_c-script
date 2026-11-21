using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000886 RID: 2182
	public class ConfigRogueTalentTreeDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003336 RID: 13110 RVA: 0x0017E758 File Offset: 0x0017C958
		static ConfigRogueTalentTreeDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTalentTreeDescById.CreateStaticDefaultValue), new Action(ConfigRogueTalentTreeDescById.ResetStaticDefaultValue));
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x0017E778 File Offset: 0x0017C978
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTalentTreeDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTalentTreeDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueTalentTreeDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueTalentTreeDesc` where Id=?")
			});
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0017E7F7 File Offset: 0x0017C9F7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTalentTreeDescById.LogPair = null;
			ConfigRogueTalentTreeDescById.HandleId = 0;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x0017E805 File Offset: 0x0017CA05
		public static void Init()
		{
			ConfigRogueTalentTreeDescById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTalentTreeDescById.HandleId, "db_rogue.db", "select BinData from `RogueTalentTreeDesc` where Id=?");
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0017E820 File Offset: 0x0017CA20
		public static RogueTalentTreeDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueTalentTreeDesc?(RogueTalentTreeDesc.GetRootAsRogueTalentTreeDesc(configBuffer));
				}
			}
			ConfigRogueTalentTreeDescById.LogPair.Clear();
			ConfigRogueTalentTreeDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueTalentTreeDescById.HandleId, 1, p0Id, ConfigRogueTalentTreeDescById.LogPair) || ConfigCommon.Step(ConfigRogueTalentTreeDescById.HandleId, true, ConfigRogueTalentTreeDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTalentTreeDescById.HandleId, 0, ConfigRogueTalentTreeDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueTalentTreeDesc rootAsRogueTalentTreeDesc = RogueTalentTreeDesc.GetRootAsRogueTalentTreeDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair);
			return new RogueTalentTreeDesc?(rootAsRogueTalentTreeDesc);
		}

		// Token: 0x04003B90 RID: 15248
		private const string DB = "db_rogue.db";

		// Token: 0x04003B91 RID: 15249
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B92 RID: 15250
		private const string TABLE = "RogueTalentTreeDesc";

		// Token: 0x04003B93 RID: 15251
		private const string COMMAND = "select BinData from `RogueTalentTreeDesc` where Id=?";

		// Token: 0x04003B94 RID: 15252
		private const string KEY_PREFIX = "RogueTalentTreeDescById";

		// Token: 0x04003B95 RID: 15253
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B96 RID: 15254
		private static int HandleId;
	}
}
