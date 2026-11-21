using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062F9 RID: 25337
	public static class TTimelineTrackControlConfigVerify
	{
		// Token: 0x0602B0C2 RID: 176322 RVA: 0x005DE60C File Offset: 0x005DC80C
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
