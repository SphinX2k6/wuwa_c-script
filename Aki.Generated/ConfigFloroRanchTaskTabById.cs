using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000341 RID: 833
	public class ConfigFloroRanchTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x000CB5F3 File Offset: 0x000C97F3
		static ConfigFloroRanchTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskTabById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000CB614 File Offset: 0x000C9814
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

		// Token: 0x0600138D RID: 5005 RVA: 0x000CB693 File Offset: 0x000C9893
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskTabById.LogPair = null;
			ConfigFloroRanchTaskTabById.HandleId = 0;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000CB6A1 File Offset: 0x000C98A1
		public static void Init()
		{
			ConfigFloroRanchTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskTabById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTaskTab` where Id=?");
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x000CB6BC File Offset: 0x000C98BC
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

		// Token: 0x040016AB RID: 5803
		private const string DB = "db_flororanch.db";

		// Token: 0x040016AC RID: 5804
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016AD RID: 5805
		private const string TABLE = "FloroRanchTaskTab";

		// Token: 0x040016AE RID: 5806
		private const string COMMAND = "select BinData from `FloroRanchTaskTab` where Id=?";

		// Token: 0x040016AF RID: 5807
		private const string KEY_PREFIX = "FloroRanchTaskTabById";

		// Token: 0x040016B0 RID: 5808
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016B1 RID: 5809
		private static int HandleId;
	}
}
