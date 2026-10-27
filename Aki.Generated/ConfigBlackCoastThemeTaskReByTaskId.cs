using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FA RID: 250
	public class ConfigBlackCoastThemeTaskReByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x0007AE37 File Offset: 0x00079037
		static ConfigBlackCoastThemeTaskReByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeTaskReByTaskId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeTaskReByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0007AE58 File Offset: 0x00079058
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

		// Token: 0x060005DF RID: 1503 RVA: 0x0007AED7 File Offset: 0x000790D7
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeTaskReByTaskId.LogPair = null;
			ConfigBlackCoastThemeTaskReByTaskId.HandleId = 0;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0007AEE5 File Offset: 0x000790E5
		public static void Init()
		{
			ConfigBlackCoastThemeTaskReByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeTaskReByTaskId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeTaskRe` where TaskId=?");
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0007AF00 File Offset: 0x00079100
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

		// Token: 0x040006BA RID: 1722
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x040006BB RID: 1723
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x040006BC RID: 1724
		private const string TABLE = "BlackCoastThemeTaskRe";

		// Token: 0x040006BD RID: 1725
		private const string COMMAND = "select BinData from `BlackCoastThemeTaskRe` where TaskId=?";

		// Token: 0x040006BE RID: 1726
		private const string KEY_PREFIX = "BlackCoastThemeTaskReByTaskId";

		// Token: 0x040006BF RID: 1727
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006C0 RID: 1728
		private static int HandleId;
	}
}
