using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA6 RID: 15270
	public static class IShowTimelineActionOptionBase_UnionVerify
	{
		// Token: 0x06014EE8 RID: 85736 RVA: 0x003093D0 File Offset: 0x003075D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IShowTimelineActionOptionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowTimelineCastSkillVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IShowTimelineJumpVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
