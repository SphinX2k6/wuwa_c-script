using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069BE RID: 27070
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class TuningStandConfig : ConfigBase
	{
		// Token: 0x060435DD RID: 275933 RVA: 0x01076064 File Offset: 0x01074264
		[return: Nullable(2)]
		public string GetEvent(string node)
		{
			if (this.CacheMap == null)
			{
				this.CacheMap = new Dictionary<string, string>();
				IReadOnlyList<TuningNode> configList = ConfigTuningNodeByAll.GetConfigList(true);
				if (configList != null)
				{
					foreach (TuningNode tuningNode in configList)
					{
						this.CacheMap[tuningNode.Desc] = tuningNode.AkEvent;
					}
				}
			}
			string result;
			if (!this.CacheMap.TryGetValue(node, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "No TuningNode Config";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TuningNode", node);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return result;
		}

		// Token: 0x17009864 RID: 39012
		// (get) Token: 0x060435DE RID: 275934 RVA: 0x01076118 File Offset: 0x01074318
		public static TuningStandConfig Instance
		{
			get
			{
				return TuningStandConfig._Instance;
			}
		}

		// Token: 0x060435DF RID: 275935 RVA: 0x0107611F File Offset: 0x0107431F
		public static TuningStandConfig GetOrCreateInstance()
		{
			if (TuningStandConfig._Instance == null)
			{
				TuningStandConfig.CreateInstance();
			}
			return TuningStandConfig._Instance;
		}

		// Token: 0x060435E0 RID: 275936 RVA: 0x01076133 File Offset: 0x01074333
		public static bool CreateInstance()
		{
			if (TuningStandConfig._Instance != null)
			{
				return true;
			}
			TuningStandConfig._Instance = new TuningStandConfig();
			return true;
		}

		// Token: 0x060435E1 RID: 275937 RVA: 0x01076149 File Offset: 0x01074349
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060435E2 RID: 275938 RVA: 0x0107614B File Offset: 0x0107434B
		public static void ResetStaticDefaultValue()
		{
			TuningStandConfig._Instance = null;
		}

		// Token: 0x060435E3 RID: 275939 RVA: 0x01076153 File Offset: 0x01074353
		static TuningStandConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TuningStandConfig.CreateStaticDefaultValue), new Action(TuningStandConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04023230 RID: 143920
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected Dictionary<string, string> CacheMap;

		// Token: 0x04023231 RID: 143921
		[Nullable(2)]
		private static TuningStandConfig _Instance;
	}
}
