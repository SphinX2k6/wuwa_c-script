using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065A RID: 1626
	public class ConfigPhantomBattleBadgeGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600262C RID: 9772 RVA: 0x001317BF File Offset: 0x0012F9BF
		static ConfigPhantomBattleBadgeGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x001317E0 File Offset: 0x0012F9E0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeGroupByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeGroupByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadgeGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadgeGroup` where GroupId=?")
			});
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0013185F File Offset: 0x0012FA5F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeGroupByGroupId.LogPair = null;
			ConfigPhantomBattleBadgeGroupByGroupId.HandleId = 0;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0013186D File Offset: 0x0012FA6D
		public static void Init()
		{
			ConfigPhantomBattleBadgeGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeGroup` where GroupId=?");
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00131888 File Offset: 0x0012FA88
		public static PhantomBattleBadgeGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, ConfigPhantomBattleBadgeGroupByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleBadgeGroup?(PhantomBattleBadgeGroup.GetRootAsPhantomBattleBadgeGroup(configBuffer));
				}
			}
			ConfigPhantomBattleBadgeGroupByGroupId.LogPair.Clear();
			ConfigPhantomBattleBadgeGroupByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, 1, p0GroupId, ConfigPhantomBattleBadgeGroupByGroupId.LogPair) || ConfigCommon.Step(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, true, ConfigPhantomBattleBadgeGroupByGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, ConfigPhantomBattleBadgeGroupByGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, 0, ConfigPhantomBattleBadgeGroupByGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, ConfigPhantomBattleBadgeGroupByGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleBadgeGroup rootAsPhantomBattleBadgeGroup = PhantomBattleBadgeGroup.GetRootAsPhantomBattleBadgeGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, ConfigPhantomBattleBadgeGroupByGroupId.LogPair);
			return new PhantomBattleBadgeGroup?(rootAsPhantomBattleBadgeGroup);
		}

		// Token: 0x04002C5C RID: 11356
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C5D RID: 11357
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C5E RID: 11358
		private const string TABLE = "PhantomBattleBadgeGroup";

		// Token: 0x04002C5F RID: 11359
		private const string COMMAND = "select BinData from `PhantomBattleBadgeGroup` where GroupId=?";

		// Token: 0x04002C60 RID: 11360
		private const string KEY_PREFIX = "PhantomBattleBadgeGroupByGroupId";

		// Token: 0x04002C61 RID: 11361
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C62 RID: 11362
		private static int HandleId;
	}
}
