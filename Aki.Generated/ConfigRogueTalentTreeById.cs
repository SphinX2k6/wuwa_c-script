using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000869 RID: 2153
	public class ConfigRogueTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003288 RID: 12936 RVA: 0x00177227 File Offset: 0x00175427
		static ConfigRogueTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTalentTreeById.CreateStaticDefaultValue), new Action(ConfigRogueTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00177248 File Offset: 0x00175448
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

		// Token: 0x0600328A RID: 12938 RVA: 0x001772C7 File Offset: 0x001754C7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTalentTreeById.LogPair = null;
			ConfigRogueTalentTreeById.HandleId = 0;
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x001772D5 File Offset: 0x001754D5
		public static void Init()
		{
			ConfigRogueTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTalentTreeById.HandleId, "db_rogue.db", "select BinData from `RogueTalentTree` where Id=?");
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x001772F0 File Offset: 0x001754F0
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

		// Token: 0x04003AC5 RID: 15045
		private const string DB = "db_rogue.db";

		// Token: 0x04003AC6 RID: 15046
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003AC7 RID: 15047
		private const string TABLE = "RogueTalentTree";

		// Token: 0x04003AC8 RID: 15048
		private const string COMMAND = "select BinData from `RogueTalentTree` where Id=?";

		// Token: 0x04003AC9 RID: 15049
		private const string KEY_PREFIX = "RogueTalentTreeById";

		// Token: 0x04003ACA RID: 15050
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003ACB RID: 15051
		private static int HandleId;
	}
}
