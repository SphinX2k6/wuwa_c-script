using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC8 RID: 23752
	public static class TTimelineTrackControlConfigVerify
	{
		// Token: 0x06028A7A RID: 166522 RVA: 0x00595E98 File Offset: 0x00594098
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISequenceTrackControlVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEntityTrackControlVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
