using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BD6 RID: 15318
	public static class TShowTimelineActionOptionVerify
	{
		// Token: 0x060150F8 RID: 86264 RVA: 0x0030D77C File Offset: 0x0030B97C
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
