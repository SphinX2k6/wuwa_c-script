using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02005BF9 RID: 23545
	[Config(0)]
	public class BossPilingConfig : ConfigBase
	{
		// Token: 0x0603B819 RID: 243737 RVA: 0x00E31804 File Offset: 0x00E2FA04
		public BossPilingLevels? GetLevelInfo(int id)
		{
			BossPilingLevels? config = ConfigBossPilingLevelsById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BossPiling;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "BossPilingLevels数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603B81A RID: 243738 RVA: 0x00E31854 File Offset: 0x00E2FA54
		public BossPilingBuff? GetBuffInfo(int id)
		{
			BossPilingBuff? config = ConfigBossPilingBuffById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BossPiling;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "BossPilingBuff数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603B81B RID: 243739 RVA: 0x00E318A4 File Offset: 0x00E2FAA4
		public BossPilingTask? GetTaskInfo(int id)
		{
			BossPilingTask? config = ConfigBossPilingTaskById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.BossPiling;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "BossPilingTask数据无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x0603B81C RID: 243740 RVA: 0x00E318F4 File Offset: 0x00E2FAF4
		public ValueTuple<int, int> GetTipsPlayRate()
		{
			if (this.RateConfig == null)
			{
				int item = ConfigCommonParamById.GetIntConfig("BossPilingBuffTipsNormalPlayRate").GetValueOrDefault(1000) / 1000;
				int item2 = ConfigCommonParamById.GetIntConfig("BossPilingBuffTipsFastPlayRate").GetValueOrDefault(2000) / 1000;
				this.RateConfig = new ValueTuple<int, int>?(new ValueTuple<int, int>(item, item2));
			}
			return this.RateConfig.Value;
		}

		// Token: 0x17008D6F RID: 36207
		// (get) Token: 0x0603B81D RID: 243741 RVA: 0x00E31967 File Offset: 0x00E2FB67
		[Nullable(1)]
		public static BossPilingConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return BossPilingConfig._Instance;
			}
		}

		// Token: 0x0603B81E RID: 243742 RVA: 0x00E3196E File Offset: 0x00E2FB6E
		[NullableContext(1)]
		public static BossPilingConfig GetOrCreateInstance()
		{
			if (BossPilingConfig._Instance == null)
			{
				BossPilingConfig.CreateInstance();
			}
			return BossPilingConfig._Instance;
		}

		// Token: 0x0603B81F RID: 243743 RVA: 0x00E31982 File Offset: 0x00E2FB82
		public static bool CreateInstance()
		{
			if (BossPilingConfig._Instance != null)
			{
				return true;
			}
			BossPilingConfig._Instance = new BossPilingConfig();
			return true;
		}

		// Token: 0x0603B820 RID: 243744 RVA: 0x00E31998 File Offset: 0x00E2FB98
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B821 RID: 243745 RVA: 0x00E3199A File Offset: 0x00E2FB9A
		public static void ResetStaticDefaultValue()
		{
			BossPilingConfig._Instance = null;
		}

		// Token: 0x0603B822 RID: 243746 RVA: 0x00E319A2 File Offset: 0x00E2FBA2
		static BossPilingConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingConfig.CreateStaticDefaultValue), new Action(BossPilingConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401EFF0 RID: 126960
		protected ValueTuple<int, int>? RateConfig;

		// Token: 0x0401EFF1 RID: 126961
		[Nullable(2)]
		private static BossPilingConfig _Instance;
	}
}
