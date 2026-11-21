using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BD9 RID: 19417
	[Config(0)]
	public class BossPilingConfig : ConfigBase
	{
		// Token: 0x06030764 RID: 198500 RVA: 0x00D81B4C File Offset: 0x00D7FD4C
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

		// Token: 0x06030765 RID: 198501 RVA: 0x00D81B9C File Offset: 0x00D7FD9C
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

		// Token: 0x06030766 RID: 198502 RVA: 0x00D81BEC File Offset: 0x00D7FDEC
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

		// Token: 0x06030767 RID: 198503 RVA: 0x00D81C3C File Offset: 0x00D7FE3C
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

		// Token: 0x17006141 RID: 24897
		// (get) Token: 0x06030768 RID: 198504 RVA: 0x00D81CAF File Offset: 0x00D7FEAF
		[Nullable(1)]
		public static BossPilingConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return BossPilingConfig._Instance;
			}
		}

		// Token: 0x06030769 RID: 198505 RVA: 0x00D81CB6 File Offset: 0x00D7FEB6
		[NullableContext(1)]
		public static BossPilingConfig GetOrCreateInstance()
		{
			if (BossPilingConfig._Instance == null)
			{
				BossPilingConfig.CreateInstance();
			}
			return BossPilingConfig._Instance;
		}

		// Token: 0x0603076A RID: 198506 RVA: 0x00D81CCA File Offset: 0x00D7FECA
		public static bool CreateInstance()
		{
			if (BossPilingConfig._Instance != null)
			{
				return true;
			}
			BossPilingConfig._Instance = new BossPilingConfig();
			return true;
		}

		// Token: 0x0603076B RID: 198507 RVA: 0x00D81CE0 File Offset: 0x00D7FEE0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603076C RID: 198508 RVA: 0x00D81CE2 File Offset: 0x00D7FEE2
		public static void ResetStaticDefaultValue()
		{
			BossPilingConfig._Instance = null;
		}

		// Token: 0x0603076D RID: 198509 RVA: 0x00D81CEA File Offset: 0x00D7FEEA
		static BossPilingConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BossPilingConfig.CreateStaticDefaultValue), new Action(BossPilingConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04019AA1 RID: 105121
		protected ValueTuple<int, int>? RateConfig;

		// Token: 0x04019AA2 RID: 105122
		[Nullable(2)]
		private static BossPilingConfig _Instance;
	}
}
