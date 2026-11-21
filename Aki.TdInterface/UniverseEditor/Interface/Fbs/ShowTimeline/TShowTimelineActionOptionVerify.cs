using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FE1 RID: 16353
	public static class TShowTimelineActionOptionVerify
	{
		// Token: 0x060165EE RID: 91630 RVA: 0x00334304 File Offset: 0x00332504
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IShowTimelineCastSkillVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowTimelineJumpVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IShowTimelineSwitchRoleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
