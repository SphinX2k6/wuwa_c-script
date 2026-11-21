using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005085 RID: 20613
	public class RoverlikeActionSubViewFactory
	{
		// Token: 0x0603397A RID: 211322 RVA: 0x00E70E16 File Offset: 0x00E6F016
		public static ERoverActionSubViewType ServerTypeToSubViewType(RoverRogueGainOperateType serverType)
		{
			switch (serverType)
			{
			case RoverRogueGainOperateType.RoverRogueBlessSelect:
				return ERoverActionSubViewType.SelectBlessing;
			case RoverRogueGainOperateType.RoverRogueRoleEnhanceSelect:
				return ERoverActionSubViewType.SelectReinforcement;
			case RoverRogueGainOperateType.RoverRogueBlessEnhanceSelect:
				return ERoverActionSubViewType.BlessingReinforcement;
			default:
				return ERoverActionSubViewType.None;
			}
		}

		// Token: 0x0603397B RID: 211323 RVA: 0x00E70E34 File Offset: 0x00E6F034
		[NullableContext(2)]
		public static RoverlikeActionSubViewBase CreateSubView(ERoverActionSubViewType type)
		{
			switch (type)
			{
			case ERoverActionSubViewType.BlessingSuitPreview:
				return new RoverlikeSubViewBlessingSuitPreview();
			case ERoverActionSubViewType.BlessingSuitSelect:
				return new RoverlikeSubViewBlessingSuitSelect();
			case ERoverActionSubViewType.SelectBlessing:
				return new RoverlikeSubViewSelectBlessing();
			case ERoverActionSubViewType.SelectReinforcement:
				return new RoverlikeSubViewSelectReinforcement();
			case ERoverActionSubViewType.SelectEvent:
				return new RoverlikeSubViewEvent();
			case ERoverActionSubViewType.BlessingReinforcement:
				return new RoverlikeSubViewBlessingReinforcement();
			default:
				return null;
			}
		}
	}
}
