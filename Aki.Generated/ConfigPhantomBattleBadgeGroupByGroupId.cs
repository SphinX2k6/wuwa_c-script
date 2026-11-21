using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000672 RID: 1650
	public class ConfigPhantomBattleBadgeGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x0013823B File Offset: 0x0013643B
		static ConfigPhantomBattleBadgeGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0013825C File Offset: 0x0013645C
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

		// Token: 0x060026BE RID: 9918 RVA: 0x001382DB File Offset: 0x001364DB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeGroupByGroupId.LogPair = null;
			ConfigPhantomBattleBadgeGroupByGroupId.HandleId = 0;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x001382E9 File Offset: 0x001364E9
		public static void Init()
		{
			ConfigPhantomBattleBadgeGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeGroupByGroupId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeGroup` where GroupId=?");
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00138304 File Offset: 0x00136504
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

		// Token: 0x04002D04 RID: 11524
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D05 RID: 11525
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D06 RID: 11526
		private const string TABLE = "PhantomBattleBadgeGroup";

		// Token: 0x04002D07 RID: 11527
		private const string COMMAND = "select BinData from `PhantomBattleBadgeGroup` where GroupId=?";

		// Token: 0x04002D08 RID: 11528
		private const string KEY_PREFIX = "PhantomBattleBadgeGroupByGroupId";

		// Token: 0x04002D09 RID: 11529
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D0A RID: 11530
		private static int HandleId;
	}
}
