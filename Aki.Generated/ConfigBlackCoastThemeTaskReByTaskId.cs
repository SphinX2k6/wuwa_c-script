using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000109 RID: 265
	public class ConfigBlackCoastThemeTaskReByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x0008079B File Offset: 0x0007E99B
		static ConfigBlackCoastThemeTaskReByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeTaskReByTaskId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeTaskReByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000807BC File Offset: 0x0007E9BC
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackCoastThemeTaskReByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackCoastThemeTaskReByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackcoasttheme.db"),
				new ValueTuple<string, object>("文件", "h.黑海岸主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "BlackCoastThemeTaskRe"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackCoastThemeTaskRe` where TaskId=?")
			});
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0008083B File Offset: 0x0007EA3B
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeTaskReByTaskId.LogPair = null;
			ConfigBlackCoastThemeTaskReByTaskId.HandleId = 0;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00080849 File Offset: 0x0007EA49
		public static void Init()
		{
			ConfigBlackCoastThemeTaskReByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeTaskReByTaskId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeTaskRe` where TaskId=?");
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00080864 File Offset: 0x0007EA64
		public static BlackCoastThemeTaskRe? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackCoastThemeTaskReByTaskId.HandleId, ConfigBlackCoastThemeTaskReByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeTaskReByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlackCoastThemeTaskRe?(BlackCoastThemeTaskRe.GetRootAsBlackCoastThemeTaskRe(configBuffer));
				}
			}
			ConfigBlackCoastThemeTaskReByTaskId.LogPair.Clear();
			ConfigBlackCoastThemeTaskReByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigBlackCoastThemeTaskReByTaskId.HandleId, 1, p0TaskId, ConfigBlackCoastThemeTaskReByTaskId.LogPair) || ConfigCommon.Step(ConfigBlackCoastThemeTaskReByTaskId.HandleId, true, ConfigBlackCoastThemeTaskReByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeTaskReByTaskId.HandleId, ConfigBlackCoastThemeTaskReByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackCoastThemeTaskReByTaskId.HandleId, 0, ConfigBlackCoastThemeTaskReByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeTaskReByTaskId.HandleId, ConfigBlackCoastThemeTaskReByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlackCoastThemeTaskRe rootAsBlackCoastThemeTaskRe = BlackCoastThemeTaskRe.GetRootAsBlackCoastThemeTaskRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeTaskReByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlackCoastThemeTaskReByTaskId.HandleId, ConfigBlackCoastThemeTaskReByTaskId.LogPair);
			return new BlackCoastThemeTaskRe?(rootAsBlackCoastThemeTaskRe);
		}

		// Token: 0x04000723 RID: 1827
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x04000724 RID: 1828
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x04000725 RID: 1829
		private const string TABLE = "BlackCoastThemeTaskRe";

		// Token: 0x04000726 RID: 1830
		private const string COMMAND = "select BinData from `BlackCoastThemeTaskRe` where TaskId=?";

		// Token: 0x04000727 RID: 1831
		private const string KEY_PREFIX = "BlackCoastThemeTaskReByTaskId";

		// Token: 0x04000728 RID: 1832
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000729 RID: 1833
		private static int HandleId;
	}
}
