using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B97 RID: 15255
	public static class ICheckpointDisplay_UnionVerify
	{
		// Token: 0x06014E55 RID: 85589 RVA: 0x003082B0 File Offset: 0x003064B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckpointDisplayRoleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckpointDisplayVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
