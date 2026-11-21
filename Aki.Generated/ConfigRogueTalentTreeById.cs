using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000885 RID: 2181
	public class ConfigRogueTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003330 RID: 13104 RVA: 0x0017E50F File Offset: 0x0017C70F
		static ConfigRogueTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTalentTreeById.CreateStaticDefaultValue), new Action(ConfigRogueTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0017E530 File Offset: 0x0017C730
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTalentTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTalentTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueTalentTree` where Id=?")
			});
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0017E5AF File Offset: 0x0017C7AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTalentTreeById.LogPair = null;
			ConfigRogueTalentTreeById.HandleId = 0;
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x0017E5BD File Offset: 0x0017C7BD
		public static void Init()
		{
			ConfigRogueTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTalentTreeById.HandleId, "db_rogue.db", "select BinData from `RogueTalentTree` where Id=?");
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x0017E5D8 File Offset: 0x0017C7D8
		public static RogueTalentTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTalentTreeById.HandleId, ConfigRogueTalentTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueTalentTree?(RogueTalentTree.GetRootAsRogueTalentTree(configBuffer));
				}
			}
			ConfigRogueTalentTreeById.LogPair.Clear();
			ConfigRogueTalentTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueTalentTreeById.HandleId, 1, p0Id, ConfigRogueTalentTreeById.LogPair) || ConfigCommon.Step(ConfigRogueTalentTreeById.HandleId, true, ConfigRogueTalentTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueTalentTreeById.HandleId, ConfigRogueTalentTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTalentTreeById.HandleId, 0, ConfigRogueTalentTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueTalentTreeById.HandleId, ConfigRogueTalentTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueTalentTree rootAsRogueTalentTree = RogueTalentTree.GetRootAsRogueTalentTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueTalentTreeById.HandleId, ConfigRogueTalentTreeById.LogPair);
			return new RogueTalentTree?(rootAsRogueTalentTree);
		}

		// Token: 0x04003B89 RID: 15241
		private const string DB = "db_rogue.db";

		// Token: 0x04003B8A RID: 15242
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B8B RID: 15243
		private const string TABLE = "RogueTalentTree";

		// Token: 0x04003B8C RID: 15244
		private const string COMMAND = "select BinData from `RogueTalentTree` where Id=?";

		// Token: 0x04003B8D RID: 15245
		private const string KEY_PREFIX = "RogueTalentTreeById";

		// Token: 0x04003B8E RID: 15246
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B8F RID: 15247
		private static int HandleId;
	}
}
