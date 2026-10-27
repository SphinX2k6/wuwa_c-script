using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200585A RID: 22618
	public static class InteractionLongPressButtonDefine
	{
		// Token: 0x06039816 RID: 235542 RVA: 0x00DA70C4 File Offset: 0x00DA52C4
		// Note: this type is marked as 'beforefieldinit'.
		static InteractionLongPressButtonDefine()
		{
			Dictionary<ELongPressInteractStyle, ILongPressButtonStyle> dictionary = new Dictionary<ELongPressInteractStyle, ILongPressButtonStyle>();
			dictionary[ELongPressInteractStyle.SwordRiderInteract] = new LongPressButtonStyle
			{
				ResourceId = "UiItem_InteractLongPressButton",
				Create = (() => new InteractionLongPressButtonSwordRider()),
				CreateRestriction = (() => new LongPressInteractRestrictSwordRider.SwordRiderLongPressRestriction())
			};
			dictionary[ELongPressInteractStyle.CoreFixInteract] = new LongPressButtonStyle
			{
				ResourceId = "UiItem_TxtBtnLongPress",
				Create = (() => new InteractionLongPressButtonCoreFix()),
				CreateRestriction = (() => new LongPressInteractRestrictCoreFix.CoreFixLongPressRestriction())
			};
			InteractionLongPressButtonDefine.longPressButtonStyles = dictionary;
		}

		// Token: 0x0401E109 RID: 123145
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ELongPressInteractStyle, ILongPressButtonStyle> longPressButtonStyles;
	}
}
