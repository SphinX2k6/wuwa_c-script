using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000202 RID: 514
	public class ConfigDangoMonopolyTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C0F RID: 3087 RVA: 0x000A16FB File Offset: 0x0009F8FB
		static ConfigDangoMonopolyTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoMonopolyTaskById.CreateStaticDefaultValue), new Action(ConfigDangoMonopolyTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000A171C File Offset: 0x0009F91C
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

		// Token: 0x06000C11 RID: 3089 RVA: 0x000A179B File Offset: 0x0009F99B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoMonopolyTaskById.LogPair = null;
			ConfigDangoMonopolyTaskById.HandleId = 0;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000A17A9 File Offset: 0x0009F9A9
		public static void Init()
		{
			ConfigDangoMonopolyTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoMonopolyTaskById.HandleId, "db_dangomonopoly.db", "select BinData from `DangoMonopolyTask` where TaskId=?");
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000A17C4 File Offset: 0x0009F9C4
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

		// Token: 0x04000DF2 RID: 3570
		private const string DB = "db_dangomonopoly.db";

		// Token: 0x04000DF3 RID: 3571
		private const string FILE = "t.团子大富翁.xlsx";

		// Token: 0x04000DF4 RID: 3572
		private const string TABLE = "DangoMonopolyTask";

		// Token: 0x04000DF5 RID: 3573
		private const string COMMAND = "select BinData from `DangoMonopolyTask` where TaskId=?";

		// Token: 0x04000DF6 RID: 3574
		private const string KEY_PREFIX = "DangoMonopolyTaskById";

		// Token: 0x04000DF7 RID: 3575
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DF8 RID: 3576
		private static int HandleId;
	}
}
