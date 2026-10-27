using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004971 RID: 18801
	[NullableContext(2)]
	[Nullable(0)]
	public class HonamiStoryComponentBase : HotKeyComponent
	{
		// Token: 0x06031063 RID: 200803 RVA: 0x00B61978 File Offset: 0x00B5FB78
		public HonamiStoryComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x170079D9 RID: 31193
		// (get) Token: 0x06031064 RID: 200804 RVA: 0x00B61981 File Offset: 0x00B5FB81
		protected HonamiStoryGamepadLogicController Logic
		{
			get
			{
				return HonamiStoryModel.Instance.GetGamepadLogic();
			}
		}
	}
}
