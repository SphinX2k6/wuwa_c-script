using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B1A RID: 23322
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class TuningStandConfig : ConfigBase
	{
		// Token: 0x06039619 RID: 235033 RVA: 0x0101A4F8 File Offset: 0x010186F8
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

		// Token: 0x17006D44 RID: 27972
		// (get) Token: 0x0603961A RID: 235034 RVA: 0x0101A5AC File Offset: 0x010187AC
		public static TuningStandConfig Instance
		{
			get
			{
				return TuningStandConfig._Instance;
			}
		}

		// Token: 0x0603961B RID: 235035 RVA: 0x0101A5B3 File Offset: 0x010187B3
		public static TuningStandConfig GetOrCreateInstance()
		{
			if (TuningStandConfig._Instance == null)
			{
				TuningStandConfig.CreateInstance();
			}
			return TuningStandConfig._Instance;
		}

		// Token: 0x0603961C RID: 235036 RVA: 0x0101A5C7 File Offset: 0x010187C7
		public static bool CreateInstance()
		{
			if (TuningStandConfig._Instance != null)
			{
				return true;
			}
			TuningStandConfig._Instance = new TuningStandConfig();
			return true;
		}

		// Token: 0x0603961D RID: 235037 RVA: 0x0101A5DD File Offset: 0x010187DD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603961E RID: 235038 RVA: 0x0101A5DF File Offset: 0x010187DF
		public static void ResetStaticDefaultValue()
		{
			TuningStandConfig._Instance = null;
		}

		// Token: 0x0603961F RID: 235039 RVA: 0x0101A5E7 File Offset: 0x010187E7
		static TuningStandConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TuningStandConfig.CreateStaticDefaultValue), new Action(TuningStandConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401E420 RID: 123936
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected Dictionary<string, string> CacheMap;

		// Token: 0x0401E421 RID: 123937
		[Nullable(2)]
		private static TuningStandConfig _Instance;
	}
}
