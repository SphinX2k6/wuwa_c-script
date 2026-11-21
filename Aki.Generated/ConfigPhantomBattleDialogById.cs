using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068C RID: 1676
	public class ConfigPhantomBattleDialogById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002758 RID: 10072 RVA: 0x0013BA84 File Offset: 0x00139C84
		static ConfigPhantomBattleDialogById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleDialogById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleDialogById.ResetStaticDefaultValue));
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0013BAA4 File Offset: 0x00139CA4
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

		// Token: 0x0600275A RID: 10074 RVA: 0x0013BB23 File Offset: 0x00139D23
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleDialogById.LogPair = null;
			ConfigPhantomBattleDialogById.HandleId = 0;
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x0013BB31 File Offset: 0x00139D31
		public static void Init()
		{
			ConfigPhantomBattleDialogById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleDialogById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleDialog` where Id=?");
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x0013BB4C File Offset: 0x00139D4C
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

		// Token: 0x04002DBA RID: 11706
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DBB RID: 11707
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002DBC RID: 11708
		private const string TABLE = "PhantomBattleDialog";

		// Token: 0x04002DBD RID: 11709
		private const string COMMAND = "select BinData from `PhantomBattleDialog` where Id=?";

		// Token: 0x04002DBE RID: 11710
		private const string KEY_PREFIX = "PhantomBattleDialogById";

		// Token: 0x04002DBF RID: 11711
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DC0 RID: 11712
		private static int HandleId;
	}
}
