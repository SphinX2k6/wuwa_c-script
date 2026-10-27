using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016D RID: 365
	public class ConfigCipherGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x00089D6C File Offset: 0x00087F6C
		static ConfigCipherGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCipherGameplayById.CreateStaticDefaultValue), new Action(ConfigCipherGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00089D8C File Offset: 0x00087F8C
		public static void CreateStaticDefaultValue()
		{
			ConfigCipherGameplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCipherGameplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciphergameplay.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/u.UI玩法/m.密码锁/*.csv*"),
				new ValueTuple<string, object>("表名", "CipherGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `CipherGameplay` where Id=?")
			});
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00089E0B File Offset: 0x0008800B
		public static void ResetStaticDefaultValue()
		{
			ConfigCipherGameplayById.LogPair = null;
			ConfigCipherGameplayById.HandleId = 0;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00089E19 File Offset: 0x00088019
		public static void Init()
		{
			ConfigCipherGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCipherGameplayById.HandleId, "db_ciphergameplay.db", "select BinData from `CipherGameplay` where Id=?");
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00089E34 File Offset: 0x00088034
		public static CipherGameplay? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCipherGameplayById.HandleId, ConfigCipherGameplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("CipherGameplayById#" + p0Id);
				if (configBuffer != null)
				{
					return new CipherGameplay?(CipherGameplay.GetRootAsCipherGameplay(configBuffer));
				}
			}
			ConfigCipherGameplayById.LogPair.Clear();
			ConfigCipherGameplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigCipherGameplayById.HandleId, 1, p0Id, ConfigCipherGameplayById.LogPair) || ConfigCommon.Step(ConfigCipherGameplayById.HandleId, true, ConfigCipherGameplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCipherGameplayById.HandleId, ConfigCipherGameplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCipherGameplayById.HandleId, 0, ConfigCipherGameplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCipherGameplayById.HandleId, ConfigCipherGameplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CipherGameplay rootAsCipherGameplay = CipherGameplay.GetRootAsCipherGameplay(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("CipherGameplayById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCipherGameplayById.HandleId, ConfigCipherGameplayById.LogPair);
			return new CipherGameplay?(rootAsCipherGameplay);
		}

		// Token: 0x040009DF RID: 2527
		private const string DB = "db_ciphergameplay.db";

		// Token: 0x040009E0 RID: 2528
		private const string FILE = "k.可视化编辑/c.Csv/u.UI玩法/m.密码锁/*.csv*";

		// Token: 0x040009E1 RID: 2529
		private const string TABLE = "CipherGameplay";

		// Token: 0x040009E2 RID: 2530
		private const string COMMAND = "select BinData from `CipherGameplay` where Id=?";

		// Token: 0x040009E3 RID: 2531
		private const string KEY_PREFIX = "CipherGameplayById";

		// Token: 0x040009E4 RID: 2532
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009E5 RID: 2533
		private static int HandleId;
	}
}
