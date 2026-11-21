using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004832 RID: 18482
	public static class InteractionLongPressButtonDefine
	{
		// Token: 0x0602E733 RID: 190259 RVA: 0x00CF5DEC File Offset: 0x00CF3FEC
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

		// Token: 0x04018BA6 RID: 101286
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ELongPressInteractStyle, ILongPressButtonStyle> longPressButtonStyles;
	}
}
