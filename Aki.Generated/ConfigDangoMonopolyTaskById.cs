using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F0 RID: 496
	public class ConfigDangoMonopolyTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x0009B7C3 File Offset: 0x000999C3
		static ConfigDangoMonopolyTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyTaskById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0009B7E4 File Offset: 0x000999E4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoMonopolyTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoMonopolyTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangomonopoly.db"),
				new ValueTuple<string, object>("文件", "t.团子大富翁.xlsx"),
				new ValueTuple<string, object>("表名", "DangoMonopolyTask"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoMonopolyTask` where TaskId=?")
			});
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0009B863 File Offset: 0x00099A63
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyTaskById.LogPair = null;
			ConfigDangoMonopolyTaskById.HandleId = 0;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0009B871 File Offset: 0x00099A71
		public static void Init()
		{
			ConfigDangoMonopolyTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyTaskById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyTask` where TaskId=?");
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0009B88C File Offset: 0x00099A8C
		public static DangoMonopolyTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoMonopolyTaskById.HandleId, ConfigDangoMonopolyTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoMonopolyTask?(DangoMonopolyTask.GetRootAsDangoMonopolyTask(configBuffer));
				}
			}
			ConfigDangoMonopolyTaskById.LogPair.Clear();
			ConfigDangoMonopolyTaskById.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigDangoMonopolyTaskById.HandleId, 1, p0TaskId, ConfigDangoMonopolyTaskById.LogPair) || ConfigCommon.Step(ConfigDangoMonopolyTaskById.HandleId, true, ConfigDangoMonopolyTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyTaskById.HandleId, ConfigDangoMonopolyTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoMonopolyTaskById.HandleId, 0, ConfigDangoMonopolyTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoMonopolyTaskById.HandleId, ConfigDangoMonopolyTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoMonopolyTask rootAsDangoMonopolyTask = DangoMonopolyTask.GetRootAsDangoMonopolyTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoMonopolyTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoMonopolyTaskById.HandleId, ConfigDangoMonopolyTaskById.LogPair);
			return new DangoMonopolyTask?(rootAsDangoMonopolyTask);
		}

		// Token: 0x04000D74 RID: 3444
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000D75 RID: 3445
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000D76 RID: 3446
		private const string TABLE = "DangoMonopolyTask";

		// Token: 0x04000D77 RID: 3447
		private const string COMMAND = "select BinData from `DangoMonopolyTask` where TaskId=?";

		// Token: 0x04000D78 RID: 3448
		private const string KEY_PREFIX = "DangoMonopolyTaskById";

		// Token: 0x04000D79 RID: 3449
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D7A RID: 3450
		private static int HandleId;
	}
}
