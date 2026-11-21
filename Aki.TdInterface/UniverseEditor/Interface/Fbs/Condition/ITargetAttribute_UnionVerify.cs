using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E0 RID: 20960
	public static class ITargetAttribute_UnionVerify
	{
		// Token: 0x06021026 RID: 135206 RVA: 0x004903BC File Offset: 0x0048E5BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerAttributeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITargetAttributeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
