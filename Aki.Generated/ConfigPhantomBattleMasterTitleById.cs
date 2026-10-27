using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000681 RID: 1665
	public class ConfigPhantomBattleMasterTitleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002716 RID: 10006 RVA: 0x00136ABF File Offset: 0x00134CBF
		static ConfigPhantomBattleMasterTitleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterTitleById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterTitleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00136AE0 File Offset: 0x00134CE0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMasterTitleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMasterTitleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMasterTitle"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMasterTitle` where Id=?")
			});
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00136B5F File Offset: 0x00134D5F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterTitleById.LogPair = null;
			ConfigPhantomBattleMasterTitleById.HandleId = 0;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00136B6D File Offset: 0x00134D6D
		public static void Init()
		{
			ConfigPhantomBattleMasterTitleById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterTitleById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterTitle` where Id=?");
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00136B88 File Offset: 0x00134D88
		public static PhantomBattleMasterTitle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMasterTitleById.HandleId, ConfigPhantomBattleMasterTitleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMasterTitleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleMasterTitle?(PhantomBattleMasterTitle.GetRootAsPhantomBattleMasterTitle(configBuffer));
				}
			}
			ConfigPhantomBattleMasterTitleById.LogPair.Clear();
			ConfigPhantomBattleMasterTitleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleMasterTitleById.HandleId, 1, p0Id, ConfigPhantomBattleMasterTitleById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleMasterTitleById.HandleId, true, ConfigPhantomBattleMasterTitleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMasterTitleById.HandleId, ConfigPhantomBattleMasterTitleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMasterTitleById.HandleId, 0, ConfigPhantomBattleMasterTitleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMasterTitleById.HandleId, ConfigPhantomBattleMasterTitleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleMasterTitle rootAsPhantomBattleMasterTitle = PhantomBattleMasterTitle.GetRootAsPhantomBattleMasterTitle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMasterTitleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMasterTitleById.HandleId, ConfigPhantomBattleMasterTitleById.LogPair);
			return new PhantomBattleMasterTitle?(rootAsPhantomBattleMasterTitle);
		}

		// Token: 0x04002D6D RID: 11629
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D6E RID: 11630
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D6F RID: 11631
		private const string TABLE = "PhantomBattleMasterTitle";

		// Token: 0x04002D70 RID: 11632
		private const string COMMAND = "select BinData from `PhantomBattleMasterTitle` where Id=?";

		// Token: 0x04002D71 RID: 11633
		private const string KEY_PREFIX = "PhantomBattleMasterTitleById";

		// Token: 0x04002D72 RID: 11634
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D73 RID: 11635
		private static int HandleId;
	}
}
