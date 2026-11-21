using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E9 RID: 14569
	[NullableContext(2)]
	[Nullable(0)]
	public class HonamiStoryComponentBase : HotKeyComponent
	{
		// Token: 0x06025B93 RID: 154515 RVA: 0x00A9C858 File Offset: 0x00A9AA58
		public HonamiStoryComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x17004D41 RID: 19777
		// (get) Token: 0x06025B94 RID: 154516 RVA: 0x00A9C861 File Offset: 0x00A9AA61
		protected HonamiStoryGamepadLogicController Logic
		{
			get
			{
				return HonamiStoryModel.Instance.GetGamepadLogic();
			}
		}
	}
}
