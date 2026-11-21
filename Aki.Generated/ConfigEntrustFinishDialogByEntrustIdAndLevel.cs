using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000297 RID: 663
	public class ConfigEntrustFinishDialogByEntrustIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F8F RID: 3983 RVA: 0x000B4EF5 File Offset: 0x000B30F5
		static ConfigEntrustFinishDialogByEntrustIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustFinishDialogByEntrustIdAndLevel.CreateStaticDefaultValue), new Action(ConfigEntrustFinishDialogByEntrustIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000B4F14 File Offset: 0x000B3114
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

		// Token: 0x06000F91 RID: 3985 RVA: 0x000B4F93 File Offset: 0x000B3193
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustFinishDialogByEntrustIdAndLevel.LogPair = null;
			ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId = 0;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000B4FA1 File Offset: 0x000B31A1
		public static void Init()
		{
			ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustFinishDialogByEntrustIdAndLevel.HandleId, "db_moonchasing.db", "select BinData from `EntrustFinishDialog` where EntrustId=? AND Level=?");
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000B4FBC File Offset: 0x000B31BC
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

		// Token: 0x04001205 RID: 4613
		private const string DB = "db_moonchasing.db";

		// Token: 0x04001206 RID: 4614
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04001207 RID: 4615
		private const string TABLE = "EntrustFinishDialog";

		// Token: 0x04001208 RID: 4616
		private const string COMMAND = "select BinData from `EntrustFinishDialog` where EntrustId=? AND Level=?";

		// Token: 0x04001209 RID: 4617
		private const string KEY_PREFIX = "EntrustFinishDialogByEntrustIdAndLevel";

		// Token: 0x0400120A RID: 4618
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400120B RID: 4619
		private static int HandleId;
	}
}
