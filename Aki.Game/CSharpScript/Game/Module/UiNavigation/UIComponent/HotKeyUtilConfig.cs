using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02004A03 RID: 18947
	public class HotKeyUtilConfig : IStaticVariableResetter
	{
		// Token: 0x170079EB RID: 31211
		// (get) Token: 0x060312D4 RID: 201428 RVA: 0x00B67F0A File Offset: 0x00B6610A
		[Nullable(1)]
		public static Dictionary<EHotKeyCacheKey, Type> CacheKey2CompMap
		{
			[NullableContext(1)]
			get
			{
				return HotKeyUtilConfig._cacheKey2CompMap;
			}
		}

		// Token: 0x060312D5 RID: 201429 RVA: 0x00B67F11 File Offset: 0x00B66111
		static HotKeyUtilConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotKeyUtilConfig.CreateStaticDefaultValue), new Action(HotKeyUtilConfig.ResetStaticDefaultValue));
		}

		// Token: 0x060312D6 RID: 201430 RVA: 0x00B67F30 File Offset: 0x00B66130
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
				}
			};
		}

		// Token: 0x060312D7 RID: 201431 RVA: 0x00B67F5E File Offset: 0x00B6615E
		public static void ResetStaticDefaultValue()
		{
			HotKeyUtilConfig._cacheKey2CompMap = null;
		}

		// Token: 0x0401A4ED RID: 107757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Dictionary<EHotKeyCacheKey, Type> _cacheKey2CompMap;
	}
}
