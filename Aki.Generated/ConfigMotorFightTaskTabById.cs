using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A0 RID: 1440
	public class ConfigMotorFightTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x00118B13 File Offset: 0x00116D13
		static ConfigMotorFightTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskTabById.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00118B34 File Offset: 0x00116D34
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTaskTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTaskTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTaskTab` where Id=?")
			});
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00118BB3 File Offset: 0x00116DB3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskTabById.LogPair = null;
			ConfigMotorFightTaskTabById.HandleId = 0;
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00118BC1 File Offset: 0x00116DC1
		public static void Init()
		{
			ConfigMotorFightTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskTabById.HandleId, "db_motorfight.db", "select BinData from `MotorFightTaskTab` where Id=?");
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00118BDC File Offset: 0x00116DDC
		public static MotorFightTaskTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightTaskTab?(MotorFightTaskTab.GetRootAsMotorFightTaskTab(configBuffer));
				}
			}
			ConfigMotorFightTaskTabById.LogPair.Clear();
			ConfigMotorFightTaskTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightTaskTabById.HandleId, 1, p0Id, ConfigMotorFightTaskTabById.LogPair) || ConfigCommon.Step(ConfigMotorFightTaskTabById.HandleId, true, ConfigMotorFightTaskTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTaskTabById.HandleId, 0, ConfigMotorFightTaskTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightTaskTab rootAsMotorFightTaskTab = MotorFightTaskTab.GetRootAsMotorFightTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair);
			return new MotorFightTaskTab?(rootAsMotorFightTaskTab);
		}

		// Token: 0x04002744 RID: 10052
		private const string DB = "db_motorfight.db";

		// Token: 0x04002745 RID: 10053
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002746 RID: 10054
		private const string TABLE = "MotorFightTaskTab";

		// Token: 0x04002747 RID: 10055
		private const string COMMAND = "select BinData from `MotorFightTaskTab` where Id=?";

		// Token: 0x04002748 RID: 10056
		private const string KEY_PREFIX = "MotorFightTaskTabById";

		// Token: 0x04002749 RID: 10057
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400274A RID: 10058
		private static int HandleId;
	}
}
