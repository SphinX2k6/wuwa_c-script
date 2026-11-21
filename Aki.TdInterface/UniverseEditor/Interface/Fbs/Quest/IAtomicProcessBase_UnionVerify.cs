using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004135 RID: 16693
	public static class IAtomicProcessBase_UnionVerify
	{
		// Token: 0x06016EAA RID: 93866 RVA: 0x00345428 File Offset: 0x00343628
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAtomicProcessStoveCoreFallVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAtomicProcessBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
