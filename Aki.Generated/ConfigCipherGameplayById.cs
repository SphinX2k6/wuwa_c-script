using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017D RID: 381
	public class ConfigCipherGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x0008F8C8 File Offset: 0x0008DAC8
		static ConfigCipherGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCipherGameplayById.CreateStaticDefaultValue), new Action(ConfigCipherGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0008F8E8 File Offset: 0x0008DAE8
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

		// Token: 0x060008F1 RID: 2289 RVA: 0x0008F967 File Offset: 0x0008DB67
		public static void ResetStaticDefaultValue()
		{
			ConfigCipherGameplayById.LogPair = null;
			ConfigCipherGameplayById.HandleId = 0;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0008F975 File Offset: 0x0008DB75
		public static void Init()
		{
			ConfigCipherGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCipherGameplayById.HandleId, "db_ciphergameplay.db", "select BinData from `CipherGameplay` where Id=?");
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0008F990 File Offset: 0x0008DB90
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

		// Token: 0x04000A4F RID: 2639
		private const string DB = "db_ciphergameplay.db";

		// Token: 0x04000A50 RID: 2640
		private const string FILE = "k.可视化编辑/c.Csv/u.UI玩法/m.密码锁/*.csv*";

		// Token: 0x04000A51 RID: 2641
		private const string TABLE = "CipherGameplay";

		// Token: 0x04000A52 RID: 2642
		private const string COMMAND = "select BinData from `CipherGameplay` where Id=?";

		// Token: 0x04000A53 RID: 2643
		private const string KEY_PREFIX = "CipherGameplayById";

		// Token: 0x04000A54 RID: 2644
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A55 RID: 2645
		private static int HandleId;
	}
}
