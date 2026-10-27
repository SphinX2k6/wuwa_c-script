using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013E RID: 318
	public class ConfigCatchSignalGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x00083D30 File Offset: 0x00081F30
		static ConfigCatchSignalGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCatchSignalGameplayById.CreateStaticDefaultValue), new Action(ConfigCatchSignalGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00083D50 File Offset: 0x00081F50
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

		// Token: 0x06000777 RID: 1911 RVA: 0x00083DCF File Offset: 0x00081FCF
		public static void ResetStaticDefaultValue()
		{
			ConfigCatchSignalGameplayById.LogPair = null;
			ConfigCatchSignalGameplayById.HandleId = 0;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00083DDD File Offset: 0x00081FDD
		public static void Init()
		{
			ConfigCatchSignalGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCatchSignalGameplayById.HandleId, "db_catchsignalgameplay.db", "select BinData from `CatchSignalGameplay` where Id=?");
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00083DF8 File Offset: 0x00081FF8
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

		// Token: 0x04000896 RID: 2198
		private const string DB = "db_catchsignalgameplay.db";

		// Token: 0x04000897 RID: 2199
		private const string FILE = "k.可视化编辑/c.Csv/m.捕获信号玩法配置/*.csv*";

		// Token: 0x04000898 RID: 2200
		private const string TABLE = "CatchSignalGameplay";

		// Token: 0x04000899 RID: 2201
		private const string COMMAND = "select BinData from `CatchSignalGameplay` where Id=?";

		// Token: 0x0400089A RID: 2202
		private const string KEY_PREFIX = "CatchSignalGameplayById";

		// Token: 0x0400089B RID: 2203
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400089C RID: 2204
		private static int HandleId;
	}
}
