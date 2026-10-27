using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032A RID: 810
	public class ConfigFloroRanchTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x000C4D0B File Offset: 0x000C2F0B
		static ConfigFloroRanchTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000C4D2C File Offset: 0x000C2F2C
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

		// Token: 0x06001303 RID: 4867 RVA: 0x000C4DAB File Offset: 0x000C2FAB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskById.LogPair = null;
			ConfigFloroRanchTaskById.HandleId = 0;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000C4DB9 File Offset: 0x000C2FB9
		public static void Init()
		{
			ConfigFloroRanchTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTask` where Id=?");
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000C4DD4 File Offset: 0x000C2FD4
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

		// Token: 0x0400160A RID: 5642
		private const string DB = "db_flororanch.db";

		// Token: 0x0400160B RID: 5643
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400160C RID: 5644
		private const string TABLE = "FloroRanchTask";

		// Token: 0x0400160D RID: 5645
		private const string COMMAND = "select BinData from `FloroRanchTask` where Id=?";

		// Token: 0x0400160E RID: 5646
		private const string KEY_PREFIX = "FloroRanchTaskById";

		// Token: 0x0400160F RID: 5647
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001610 RID: 5648
		private static int HandleId;
	}
}
