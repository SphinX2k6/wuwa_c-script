using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032C RID: 812
	public class ConfigFloroRanchTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x000C50E7 File Offset: 0x000C32E7
		static ConfigFloroRanchTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskTabById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000C5108 File Offset: 0x000C3308
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTaskTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTaskTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTaskTab` where Id=?")
			});
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000C5187 File Offset: 0x000C3387
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskTabById.LogPair = null;
			ConfigFloroRanchTaskTabById.HandleId = 0;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000C5195 File Offset: 0x000C3395
		public static void Init()
		{
			ConfigFloroRanchTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskTabById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTaskTab` where Id=?");
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000C51B0 File Offset: 0x000C33B0
		public static FloroRanchTaskTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTaskTabById.HandleId, ConfigFloroRanchTaskTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchTaskTab?(FloroRanchTaskTab.GetRootAsFloroRanchTaskTab(configBuffer));
				}
			}
			ConfigFloroRanchTaskTabById.LogPair.Clear();
			ConfigFloroRanchTaskTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTaskTabById.HandleId, 1, p0Id, ConfigFloroRanchTaskTabById.LogPair) || ConfigCommon.Step(ConfigFloroRanchTaskTabById.HandleId, true, ConfigFloroRanchTaskTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchTaskTabById.HandleId, ConfigFloroRanchTaskTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTaskTabById.HandleId, 0, ConfigFloroRanchTaskTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchTaskTabById.HandleId, ConfigFloroRanchTaskTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchTaskTab rootAsFloroRanchTaskTab = FloroRanchTaskTab.GetRootAsFloroRanchTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchTaskTabById.HandleId, ConfigFloroRanchTaskTabById.LogPair);
			return new FloroRanchTaskTab?(rootAsFloroRanchTaskTab);
		}

		// Token: 0x04001618 RID: 5656
		private const string DB = "db_flororanch.db";

		// Token: 0x04001619 RID: 5657
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400161A RID: 5658
		private const string TABLE = "FloroRanchTaskTab";

		// Token: 0x0400161B RID: 5659
		private const string COMMAND = "select BinData from `FloroRanchTaskTab` where Id=?";

		// Token: 0x0400161C RID: 5660
		private const string KEY_PREFIX = "FloroRanchTaskTabById";

		// Token: 0x0400161D RID: 5661
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400161E RID: 5662
		private static int HandleId;
	}
}
