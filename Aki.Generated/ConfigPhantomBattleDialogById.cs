using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000674 RID: 1652
	public class ConfigPhantomBattleDialogById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026C8 RID: 9928 RVA: 0x00135008 File Offset: 0x00133208
		static ConfigPhantomBattleDialogById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleDialogById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleDialogById.ResetStaticDefaultValue));
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00135028 File Offset: 0x00133228
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleDialogById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleDialogById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleDialog` where Id=?")
			});
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x001350A7 File Offset: 0x001332A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleDialogById.LogPair = null;
			ConfigPhantomBattleDialogById.HandleId = 0;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x001350B5 File Offset: 0x001332B5
		public static void Init()
		{
			ConfigPhantomBattleDialogById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleDialogById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleDialog` where Id=?");
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x001350D0 File Offset: 0x001332D0
		public static PhantomBattleDialog? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleDialogById.HandleId, ConfigPhantomBattleDialogById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleDialogById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleDialog?(PhantomBattleDialog.GetRootAsPhantomBattleDialog(configBuffer));
				}
			}
			ConfigPhantomBattleDialogById.LogPair.Clear();
			ConfigPhantomBattleDialogById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleDialogById.HandleId, 1, p0Id, ConfigPhantomBattleDialogById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleDialogById.HandleId, true, ConfigPhantomBattleDialogById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleDialogById.HandleId, ConfigPhantomBattleDialogById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleDialogById.HandleId, 0, ConfigPhantomBattleDialogById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleDialogById.HandleId, ConfigPhantomBattleDialogById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleDialog rootAsPhantomBattleDialog = PhantomBattleDialog.GetRootAsPhantomBattleDialog(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleDialogById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleDialogById.HandleId, ConfigPhantomBattleDialogById.LogPair);
			return new PhantomBattleDialog?(rootAsPhantomBattleDialog);
		}

		// Token: 0x04002D12 RID: 11538
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D13 RID: 11539
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D14 RID: 11540
		private const string TABLE = "PhantomBattleDialog";

		// Token: 0x04002D15 RID: 11541
		private const string COMMAND = "select BinData from `PhantomBattleDialog` where Id=?";

		// Token: 0x04002D16 RID: 11542
		private const string KEY_PREFIX = "PhantomBattleDialogById";

		// Token: 0x04002D17 RID: 11543
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D18 RID: 11544
		private static int HandleId;
	}
}
