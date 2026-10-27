using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A84 RID: 23172
	public static class ITimelineTrackControlData_UnionVerify
	{
		// Token: 0x0602777A RID: 161658 RVA: 0x0056E35C File Offset: 0x0056C55C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITimelineTrackControlDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISequenceTrackControlVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityTrackControlVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
