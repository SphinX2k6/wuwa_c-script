using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FA RID: 1018
	public class ConfigHonamiStoryOutDialogById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017E3 RID: 6115 RVA: 0x000E0BD1 File Offset: 0x000DEDD1
		static ConfigHonamiStoryOutDialogById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryOutDialogById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryOutDialogById.ResetStaticDefaultValue));
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x000E0BF0 File Offset: 0x000DEDF0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryOutDialogById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryOutDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryOutDialog` where Id=?")
			});
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x000E0C6F File Offset: 0x000DEE6F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryOutDialogById.LogPair = null;
			ConfigHonamiStoryOutDialogById.HandleId = 0;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x000E0C7D File Offset: 0x000DEE7D
		public static void Init()
		{
			ConfigHonamiStoryOutDialogById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryOutDialogById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryOutDialog` where Id=?");
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000E0C98 File Offset: 0x000DEE98
		public static HonamiStoryOutDialog? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryOutDialogById.HandleId, ConfigHonamiStoryOutDialogById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryOutDialogById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryOutDialog?(HonamiStoryOutDialog.GetRootAsHonamiStoryOutDialog(configBuffer));
				}
			}
			ConfigHonamiStoryOutDialogById.LogPair.Clear();
			ConfigHonamiStoryOutDialogById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryOutDialogById.HandleId, 1, p0Id, ConfigHonamiStoryOutDialogById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryOutDialogById.HandleId, true, ConfigHonamiStoryOutDialogById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryOutDialogById.HandleId, ConfigHonamiStoryOutDialogById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryOutDialogById.HandleId, 0, ConfigHonamiStoryOutDialogById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryOutDialogById.HandleId, ConfigHonamiStoryOutDialogById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryOutDialog rootAsHonamiStoryOutDialog = HonamiStoryOutDialog.GetRootAsHonamiStoryOutDialog(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryOutDialogById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryOutDialogById.HandleId, ConfigHonamiStoryOutDialogById.LogPair);
			return new HonamiStoryOutDialog?(rootAsHonamiStoryOutDialog);
		}

		// Token: 0x04001BBA RID: 7098
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BBB RID: 7099
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001BBC RID: 7100
		private const string TABLE = "HonamiStoryOutDialog";

		// Token: 0x04001BBD RID: 7101
		private const string COMMAND = "select BinData from `HonamiStoryOutDialog` where Id=?";

		// Token: 0x04001BBE RID: 7102
		private const string KEY_PREFIX = "HonamiStoryOutDialogById";

		// Token: 0x04001BBF RID: 7103
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BC0 RID: 7104
		private static int HandleId;
	}
}
