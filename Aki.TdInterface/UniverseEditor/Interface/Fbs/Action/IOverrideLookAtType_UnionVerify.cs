using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C3 RID: 29635
	public static class IOverrideLookAtType_UnionVerify
	{
		// Token: 0x06033D5F RID: 212319 RVA: 0x006FDCC8 File Offset: 0x006FBEC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckFlowLookAtVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOverrideLookAtTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
