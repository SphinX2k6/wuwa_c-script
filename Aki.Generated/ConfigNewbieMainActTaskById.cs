using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000607 RID: 1543
	public class ConfigNewbieMainActTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002439 RID: 9273 RVA: 0x00129D0B File Offset: 0x00127F0B
		static ConfigNewbieMainActTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTaskById.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00129D2C File Offset: 0x00127F2C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActTask` where Id=?")
			});
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00129DAB File Offset: 0x00127FAB
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTaskById.LogPair = null;
			ConfigNewbieMainActTaskById.HandleId = 0;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00129DB9 File Offset: 0x00127FB9
		public static void Init()
		{
			ConfigNewbieMainActTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTaskById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTask` where Id=?");
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00129DD4 File Offset: 0x00127FD4
		public static NewbieMainActTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieMainActTask?(NewbieMainActTask.GetRootAsNewbieMainActTask(configBuffer));
				}
			}
			ConfigNewbieMainActTaskById.LogPair.Clear();
			ConfigNewbieMainActTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActTaskById.HandleId, 1, p0Id, ConfigNewbieMainActTaskById.LogPair) || ConfigCommon.Step(ConfigNewbieMainActTaskById.HandleId, true, ConfigNewbieMainActTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActTaskById.HandleId, 0, ConfigNewbieMainActTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieMainActTask rootAsNewbieMainActTask = NewbieMainActTask.GetRootAsNewbieMainActTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieMainActTaskById.HandleId, ConfigNewbieMainActTaskById.LogPair);
			return new NewbieMainActTask?(rootAsNewbieMainActTask);
		}

		// Token: 0x04002A17 RID: 10775
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A18 RID: 10776
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002A19 RID: 10777
		private const string TABLE = "NewbieMainActTask";

		// Token: 0x04002A1A RID: 10778
		private const string COMMAND = "select BinData from `NewbieMainActTask` where Id=?";

		// Token: 0x04002A1B RID: 10779
		private const string KEY_PREFIX = "NewbieMainActTaskById";

		// Token: 0x04002A1C RID: 10780
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A1D RID: 10781
		private static int HandleId;
	}
}
