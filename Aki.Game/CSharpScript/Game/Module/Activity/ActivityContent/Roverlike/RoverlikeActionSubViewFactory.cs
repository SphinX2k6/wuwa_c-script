using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006107 RID: 24839
	public class RoverlikeActionSubViewFactory
	{
		// Token: 0x0603ECB8 RID: 257208 RVA: 0x00F2A002 File Offset: 0x00F28202
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

		// Token: 0x0603ECB9 RID: 257209 RVA: 0x00F2A020 File Offset: 0x00F28220
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
