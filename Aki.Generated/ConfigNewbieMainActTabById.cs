using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005ED RID: 1517
	public class ConfigNewbieMainActTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600239D RID: 9117 RVA: 0x00122EB3 File Offset: 0x001210B3
		static ConfigNewbieMainActTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTabById.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTabById.ResetStaticDefaultValue));
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00122ED4 File Offset: 0x001210D4
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActTab"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActTab` where Id=?")
			});
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00122F53 File Offset: 0x00121153
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTabById.LogPair = null;
			ConfigNewbieMainActTabById.HandleId = 0;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00122F61 File Offset: 0x00121161
		public static void Init()
		{
			ConfigNewbieMainActTabById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTabById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTab` where Id=?");
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00122F7C File Offset: 0x0012117C
		public static NewbieMainActTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActTabById.HandleId, ConfigNewbieMainActTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieMainActTab?(NewbieMainActTab.GetRootAsNewbieMainActTab(configBuffer));
				}
			}
			ConfigNewbieMainActTabById.LogPair.Clear();
			ConfigNewbieMainActTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActTabById.HandleId, 1, p0Id, ConfigNewbieMainActTabById.LogPair) || ConfigCommon.Step(ConfigNewbieMainActTabById.HandleId, true, ConfigNewbieMainActTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieMainActTabById.HandleId, ConfigNewbieMainActTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActTabById.HandleId, 0, ConfigNewbieMainActTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieMainActTabById.HandleId, ConfigNewbieMainActTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieMainActTab rootAsNewbieMainActTab = NewbieMainActTab.GetRootAsNewbieMainActTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieMainActTabById.HandleId, ConfigNewbieMainActTabById.LogPair);
			return new NewbieMainActTab?(rootAsNewbieMainActTab);
		}

		// Token: 0x04002961 RID: 10593
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002962 RID: 10594
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002963 RID: 10595
		private const string TABLE = "NewbieMainActTab";

		// Token: 0x04002964 RID: 10596
		private const string COMMAND = "select BinData from `NewbieMainActTab` where Id=?";

		// Token: 0x04002965 RID: 10597
		private const string KEY_PREFIX = "NewbieMainActTabById";

		// Token: 0x04002966 RID: 10598
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002967 RID: 10599
		private static int HandleId;
	}
}
