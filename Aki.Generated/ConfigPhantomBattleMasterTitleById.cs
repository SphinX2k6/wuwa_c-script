using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000699 RID: 1689
	public class ConfigPhantomBattleMasterTitleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x0013D53B File Offset: 0x0013B73B
		static ConfigPhantomBattleMasterTitleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterTitleById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterTitleById.ResetStaticDefaultValue));
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0013D55C File Offset: 0x0013B75C
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

		// Token: 0x060027A8 RID: 10152 RVA: 0x0013D5DB File Offset: 0x0013B7DB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterTitleById.LogPair = null;
			ConfigPhantomBattleMasterTitleById.HandleId = 0;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x0013D5E9 File Offset: 0x0013B7E9
		public static void Init()
		{
			ConfigPhantomBattleMasterTitleById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterTitleById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterTitle` where Id=?");
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x0013D604 File Offset: 0x0013B804
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

		// Token: 0x04002E15 RID: 11797
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E16 RID: 11798
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E17 RID: 11799
		private const string TABLE = "PhantomBattleMasterTitle";

		// Token: 0x04002E18 RID: 11800
		private const string COMMAND = "select BinData from `PhantomBattleMasterTitle` where Id=?";

		// Token: 0x04002E19 RID: 11801
		private const string KEY_PREFIX = "PhantomBattleMasterTitleById";

		// Token: 0x04002E1A RID: 11802
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E1B RID: 11803
		private static int HandleId;
	}
}
