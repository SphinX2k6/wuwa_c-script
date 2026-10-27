using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000283 RID: 643
	public class ConfigEntrustFinishDialogByEntrustIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F17 RID: 3863 RVA: 0x000AEC31 File Offset: 0x000ACE31
		static ConfigEntrustFinishDialogByEntrustIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustFinishDialogByEntrustIdAndLevel.CreateStaticDefaultValue), new Action(ConfigEntrustFinishDialogByEntrustIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000AEC50 File Offset: 0x000ACE50
		public static void CreateStaticDefaultValue()
		{
			ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "EntrustFinishDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `EntrustFinishDialog` where EntrustId=? AND Level=?")
			});
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000AECCF File Offset: 0x000ACECF
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair = null;
			ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId = 0;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000AECDD File Offset: 0x000ACEDD
		public static void Init()
		{
			ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, "db_moonchasing.db", "select BinData from `EntrustFinishDialog` where EntrustId=? AND Level=?");
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000AECF8 File Offset: 0x000ACEF8
		public static EntrustFinishDialog? GetConfig(int p0EntrustId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntrustFinishDialogByEntrustIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntrustId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntrustFinishDialog?(EntrustFinishDialog.GetRootAsEntrustFinishDialog(configBuffer));
				}
			}
			ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair.Clear();
			ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair.Add(new ValueTuple<string, object>("EntrustId", p0EntrustId));
			ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, 1, p0EntrustId, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, 2, p1Level, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair) || ConfigCommon.Step(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, true, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, 0, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntrustFinishDialog rootAsEntrustFinishDialog = EntrustFinishDialog.GetRootAsEntrustFinishDialog(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntrustFinishDialogByEntrustIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EntrustId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair);
			return new EntrustFinishDialog?(rootAsEntrustFinishDialog);
		}

		// Token: 0x04001179 RID: 4473
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400117A RID: 4474
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400117B RID: 4475
		private const string TABLE = "EntrustFinishDialog";

		// Token: 0x0400117C RID: 4476
		private const string COMMAND = "select BinData from `EntrustFinishDialog` where EntrustId=? AND Level=?";

		// Token: 0x0400117D RID: 4477
		private const string KEY_PREFIX = "EntrustFinishDialogByEntrustIdAndLevel";

		// Token: 0x0400117E RID: 4478
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400117F RID: 4479
		private static int HandleId;
	}
}
