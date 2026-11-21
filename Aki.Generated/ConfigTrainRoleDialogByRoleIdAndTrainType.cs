using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEA RID: 2794
	public class ConfigTrainRoleDialogByRoleIdAndTrainType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004190 RID: 16784 RVA: 0x001CF790 File Offset: 0x001CD990
		static ConfigTrainRoleDialogByRoleIdAndTrainType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrainRoleDialogByRoleIdAndTrainType.CreateStaticDefaultValue), new Action(ConfigTrainRoleDialogByRoleIdAndTrainType.ResetStaticDefaultValue));
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x001CF7B0 File Offset: 0x001CD9B0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrainRoleDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `TrainRoleDialog` where RoleId=? AND TrainType=?")
			});
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x001CF82F File Offset: 0x001CDA2F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair = null;
			ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId = 0;
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x001CF83D File Offset: 0x001CDA3D
		public static void Init()
		{
			ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId = ConfigCommon.InitDataStatement(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, "db_moonchasing.db", "select BinData from `TrainRoleDialog` where RoleId=? AND TrainType=?");
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x001CF858 File Offset: 0x001CDA58
		public static TrainRoleDialog? GetConfig(int p0RoleId, int p1TrainType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TrainRoleDialogByRoleIdAndTrainType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TrainType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrainRoleDialog?(TrainRoleDialog.GetRootAsTrainRoleDialog(configBuffer));
				}
			}
			ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair.Clear();
			ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair.Add(new ValueTuple<string, object>("TrainType", p1TrainType));
			if (!ConfigCommon.BindInt(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, 1, p0RoleId, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair) || !ConfigCommon.BindInt(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, 2, p1TrainType, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair) || ConfigCommon.Step(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, true, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, 0, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrainRoleDialog rootAsTrainRoleDialog = TrainRoleDialog.GetRootAsTrainRoleDialog(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("TrainRoleDialogByRoleIdAndTrainType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1TrainType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair);
			return new TrainRoleDialog?(rootAsTrainRoleDialog);
		}

		// Token: 0x04004C4C RID: 19532
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C4D RID: 19533
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C4E RID: 19534
		private const string TABLE = "TrainRoleDialog";

		// Token: 0x04004C4F RID: 19535
		private const string COMMAND = "select BinData from `TrainRoleDialog` where RoleId=? AND TrainType=?";

		// Token: 0x04004C50 RID: 19536
		private const string KEY_PREFIX = "TrainRoleDialogByRoleIdAndTrainType";

		// Token: 0x04004C51 RID: 19537
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C52 RID: 19538
		private static int HandleId;
	}
}
