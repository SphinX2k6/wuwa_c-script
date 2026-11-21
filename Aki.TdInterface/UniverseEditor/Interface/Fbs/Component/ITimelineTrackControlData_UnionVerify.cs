using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006091 RID: 24721
	public static class ITimelineTrackControlData_UnionVerify
	{
		// Token: 0x06029CF2 RID: 171250 RVA: 0x005B5368 File Offset: 0x005B3568
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
