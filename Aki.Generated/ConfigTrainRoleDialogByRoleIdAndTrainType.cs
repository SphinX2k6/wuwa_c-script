using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A15 RID: 2581
	public class ConfigTrainRoleDialogByRoleIdAndTrainType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C92 RID: 15506 RVA: 0x001B03FC File Offset: 0x001AE5FC
		static ConfigTrainRoleDialogByRoleIdAndTrainType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrainRoleDialogByRoleIdAndTrainType.CreateStaticDefaultValue), new Action(ConfigTrainRoleDialogByRoleIdAndTrainType.ResetStaticDefaultValue));
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x001B041C File Offset: 0x001AE61C
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

		// Token: 0x06003C94 RID: 15508 RVA: 0x001B049B File Offset: 0x001AE69B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrainRoleDialogByRoleIdAndTrainType.LogPair = null;
			ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId = 0;
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x001B04A9 File Offset: 0x001AE6A9
		public static void Init()
		{
			ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId = ConfigCommon.InitDataStatement(ConfigTrainRoleDialogByRoleIdAndTrainType.HandleId, "db_moonchasing.db", "select BinData from `TrainRoleDialog` where RoleId=? AND TrainType=?");
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x001B04C4 File Offset: 0x001AE6C4
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

		// Token: 0x04004679 RID: 18041
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400467A RID: 18042
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400467B RID: 18043
		private const string TABLE = "TrainRoleDialog";

		// Token: 0x0400467C RID: 18044
		private const string COMMAND = "select BinData from `TrainRoleDialog` where RoleId=? AND TrainType=?";

		// Token: 0x0400467D RID: 18045
		private const string KEY_PREFIX = "TrainRoleDialogByRoleIdAndTrainType";

		// Token: 0x0400467E RID: 18046
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400467F RID: 18047
		private static int HandleId;
	}
}
