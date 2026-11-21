using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FAE RID: 16302
	public static class IShowTimelineActionOptionBase_UnionVerify
	{
		// Token: 0x060163B2 RID: 91058 RVA: 0x0032F968 File Offset: 0x0032DB68
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
