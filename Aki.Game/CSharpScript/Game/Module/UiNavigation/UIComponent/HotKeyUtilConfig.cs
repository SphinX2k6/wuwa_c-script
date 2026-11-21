using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x0200397F RID: 14719
	public class HotKeyUtilConfig : IStaticVariableResetter
	{
		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x06025E22 RID: 155170 RVA: 0x00AA3666 File Offset: 0x00AA1866
		[Nullable(1)]
		public static Dictionary<EHotKeyCacheKey, Type> CacheKey2CompMap
		{
			[NullableContext(1)]
			get
			{
				return HotKeyUtilConfig._cacheKey2CompMap;
			}
		}

		// Token: 0x06025E23 RID: 155171 RVA: 0x00AA366D File Offset: 0x00AA186D
		static HotKeyUtilConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotKeyUtilConfig.CreateStaticDefaultValue), new Action(HotKeyUtilConfig.ResetStaticDefaultValue));
		}

		// Token: 0x06025E24 RID: 155172 RVA: 0x00AA368C File Offset: 0x00AA188C
		public static void CreateStaticDefaultValue()
		{
			HotKeyUtilConfig._cacheKey2CompMap = new Dictionary<EHotKeyCacheKey, Type>
			{
				{
					EHotKeyCacheKey.RewardTakeDataCallback,
					typeof(RewardTakeComponent)
				},
				{
					EHotKeyCacheKey.PhonePetInteractCallback,
					typeof(PhonePetInteractComponent)
				},
				{
					EHotKeyCacheKey.FreeDrag2D,
					typeof(FreeDrag2DComponent)
				}
			};
		}

		// Token: 0x06025E25 RID: 155173 RVA: 0x00AA36CB File Offset: 0x00AA18CB
		public static void ResetStaticDefaultValue()
		{
			HotKeyUtilConfig._cacheKey2CompMap = null;
		}

		// Token: 0x04014D71 RID: 85361
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<EHotKeyCacheKey, Type> _cacheKey2CompMap;
	}
}
