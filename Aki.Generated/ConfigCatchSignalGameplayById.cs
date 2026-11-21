using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014D RID: 333
	public class ConfigCatchSignalGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x00089694 File Offset: 0x00087894
		static ConfigCatchSignalGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCatchSignalGameplayById.CreateStaticDefaultValue), new Action(ConfigCatchSignalGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000896B4 File Offset: 0x000878B4
		public static void CreateStaticDefaultValue()
		{
			ConfigCatchSignalGameplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCatchSignalGameplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_catchsignalgameplay.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/m.捕获信号玩法配置/*.csv*"),
				new ValueTuple<string, object>("表名", "CatchSignalGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `CatchSignalGameplay` where Id=?")
			});
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00089733 File Offset: 0x00087933
		public static void ResetStaticDefaultValue()
		{
			ConfigCatchSignalGameplayById.LogPair = null;
			ConfigCatchSignalGameplayById.HandleId = 0;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00089741 File Offset: 0x00087941
		public static void Init()
		{
			ConfigCatchSignalGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCatchSignalGameplayById.HandleId, "db_catchsignalgameplay.db", "select BinData from `CatchSignalGameplay` where Id=?");
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0008975C File Offset: 0x0008795C
		public static CatchSignalGameplay? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCatchSignalGameplayById.HandleId, ConfigCatchSignalGameplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("CatchSignalGameplayById#" + p0Id);
				if (configBuffer != null)
				{
					return new CatchSignalGameplay?(CatchSignalGameplay.GetRootAsCatchSignalGameplay(configBuffer));
				}
			}
			ConfigCatchSignalGameplayById.LogPair.Clear();
			ConfigCatchSignalGameplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigCatchSignalGameplayById.HandleId, 1, p0Id, ConfigCatchSignalGameplayById.LogPair) || ConfigCommon.Step(ConfigCatchSignalGameplayById.HandleId, true, ConfigCatchSignalGameplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCatchSignalGameplayById.HandleId, ConfigCatchSignalGameplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCatchSignalGameplayById.HandleId, 0, ConfigCatchSignalGameplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCatchSignalGameplayById.HandleId, ConfigCatchSignalGameplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CatchSignalGameplay rootAsCatchSignalGameplay = CatchSignalGameplay.GetRootAsCatchSignalGameplay(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("CatchSignalGameplayById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCatchSignalGameplayById.HandleId, ConfigCatchSignalGameplayById.LogPair);
			return new CatchSignalGameplay?(rootAsCatchSignalGameplay);
		}

		// Token: 0x040008FF RID: 2303
		private const string DB = "db_catchsignalgameplay.db";

		// Token: 0x04000900 RID: 2304
		private const string FILE = "k.可视化编辑/c.Csv/m.捕获信号玩法配置/*.csv*";

		// Token: 0x04000901 RID: 2305
		private const string TABLE = "CatchSignalGameplay";

		// Token: 0x04000902 RID: 2306
		private const string COMMAND = "select BinData from `CatchSignalGameplay` where Id=?";

		// Token: 0x04000903 RID: 2307
		private const string KEY_PREFIX = "CatchSignalGameplayById";

		// Token: 0x04000904 RID: 2308
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000905 RID: 2309
		private static int HandleId;
	}
}
