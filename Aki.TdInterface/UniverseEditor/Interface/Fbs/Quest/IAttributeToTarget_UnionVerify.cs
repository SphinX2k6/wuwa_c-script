using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413E RID: 16702
	public static class IAttributeToTarget_UnionVerify
	{
		// Token: 0x06016EE6 RID: 93926 RVA: 0x003459C8 File Offset: 0x00343BC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHealthAttributeToTargetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAttributeToTargetVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
