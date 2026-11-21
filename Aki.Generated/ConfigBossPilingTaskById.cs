using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000116 RID: 278
	public class ConfigBossPilingTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x00082224 File Offset: 0x00080424
		static ConfigBossPilingTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossPilingTaskById.CreateStaticDefaultValue), new Action(ConfigBossPilingTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00082244 File Offset: 0x00080444
		public static void CreateStaticDefaultValue()
		{
			ConfigBossPilingTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossPilingTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bosspiling.db"),
				new ValueTuple<string, object>("文件", "b.Boss打桩活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossPilingTask"),
				new ValueTuple<string, object>("语句", "select BinData from `BossPilingTask` where Id=?")
			});
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000822C3 File Offset: 0x000804C3
		public static void ResetStaticDefaultValue()
		{
			ConfigBossPilingTaskById.LogPair = null;
			ConfigBossPilingTaskById.HandleId = 0;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000822D1 File Offset: 0x000804D1
		public static void Init()
		{
			ConfigBossPilingTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigBossPilingTaskById.HandleId, "db_bosspiling.db", "select BinData from `BossPilingTask` where Id=?");
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000822EC File Offset: 0x000804EC
		public static BossPilingTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossPilingTask?(BossPilingTask.GetRootAsBossPilingTask(configBuffer));
				}
			}
			ConfigBossPilingTaskById.LogPair.Clear();
			ConfigBossPilingTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossPilingTaskById.HandleId, 1, p0Id, ConfigBossPilingTaskById.LogPair) || ConfigCommon.Step(ConfigBossPilingTaskById.HandleId, true, ConfigBossPilingTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossPilingTaskById.HandleId, 0, ConfigBossPilingTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossPilingTask rootAsBossPilingTask = BossPilingTask.GetRootAsBossPilingTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossPilingTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossPilingTaskById.HandleId, ConfigBossPilingTaskById.LogPair);
			return new BossPilingTask?(rootAsBossPilingTask);
		}

		// Token: 0x0400077E RID: 1918
		private const string DB = "db_bosspiling.db";

		// Token: 0x0400077F RID: 1919
		private const string FILE = "b.Boss打桩活动.xlsx";

		// Token: 0x04000780 RID: 1920
		private const string TABLE = "BossPilingTask";

		// Token: 0x04000781 RID: 1921
		private const string COMMAND = "select BinData from `BossPilingTask` where Id=?";

		// Token: 0x04000782 RID: 1922
		private const string KEY_PREFIX = "BossPilingTaskById";

		// Token: 0x04000783 RID: 1923
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000784 RID: 1924
		private static int HandleId;
	}
}
