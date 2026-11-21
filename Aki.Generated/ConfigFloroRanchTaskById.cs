using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033F RID: 831
	public class ConfigFloroRanchTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600137F RID: 4991 RVA: 0x000CB217 File Offset: 0x000C9417
		static ConfigFloroRanchTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x000CB238 File Offset: 0x000C9438
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTask"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTask` where Id=?")
			});
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000CB2B7 File Offset: 0x000C94B7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskById.LogPair = null;
			ConfigFloroRanchTaskById.HandleId = 0;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x000CB2C5 File Offset: 0x000C94C5
		public static void Init()
		{
			ConfigFloroRanchTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTask` where Id=?");
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x000CB2E0 File Offset: 0x000C94E0
		public static FloroRanchTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTaskById.HandleId, ConfigFloroRanchTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchTask?(FloroRanchTask.GetRootAsFloroRanchTask(configBuffer));
				}
			}
			ConfigFloroRanchTaskById.LogPair.Clear();
			ConfigFloroRanchTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTaskById.HandleId, 1, p0Id, ConfigFloroRanchTaskById.LogPair) || ConfigCommon.Step(ConfigFloroRanchTaskById.HandleId, true, ConfigFloroRanchTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchTaskById.HandleId, ConfigFloroRanchTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTaskById.HandleId, 0, ConfigFloroRanchTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchTaskById.HandleId, ConfigFloroRanchTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchTask rootAsFloroRanchTask = FloroRanchTask.GetRootAsFloroRanchTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchTaskById.HandleId, ConfigFloroRanchTaskById.LogPair);
			return new FloroRanchTask?(rootAsFloroRanchTask);
		}

		// Token: 0x0400169D RID: 5789
		private const string DB = "db_flororanch.db";

		// Token: 0x0400169E RID: 5790
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400169F RID: 5791
		private const string TABLE = "FloroRanchTask";

		// Token: 0x040016A0 RID: 5792
		private const string COMMAND = "select BinData from `FloroRanchTask` where Id=?";

		// Token: 0x040016A1 RID: 5793
		private const string KEY_PREFIX = "FloroRanchTaskById";

		// Token: 0x040016A2 RID: 5794
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016A3 RID: 5795
		private static int HandleId;
	}
}
