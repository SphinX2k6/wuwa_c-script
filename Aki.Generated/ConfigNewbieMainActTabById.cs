using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000605 RID: 1541
	public class ConfigNewbieMainActTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x0012992F File Offset: 0x00127B2F
		static ConfigNewbieMainActTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTabById.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTabById.ResetStaticDefaultValue));
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00129950 File Offset: 0x00127B50
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

		// Token: 0x0600242F RID: 9263 RVA: 0x001299CF File Offset: 0x00127BCF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTabById.LogPair = null;
			ConfigNewbieMainActTabById.HandleId = 0;
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x001299DD File Offset: 0x00127BDD
		public static void Init()
		{
			ConfigNewbieMainActTabById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTabById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTab` where Id=?");
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x001299F8 File Offset: 0x00127BF8
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

		// Token: 0x04002A09 RID: 10761
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A0A RID: 10762
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002A0B RID: 10763
		private const string TABLE = "NewbieMainActTab";

		// Token: 0x04002A0C RID: 10764
		private const string COMMAND = "select BinData from `NewbieMainActTab` where Id=?";

		// Token: 0x04002A0D RID: 10765
		private const string KEY_PREFIX = "NewbieMainActTabById";

		// Token: 0x04002A0E RID: 10766
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A0F RID: 10767
		private static int HandleId;
	}
}
