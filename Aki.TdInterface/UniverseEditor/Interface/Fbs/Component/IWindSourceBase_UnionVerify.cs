using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200619B RID: 24987
	public static class IWindSourceBase_UnionVerify
	{
		// Token: 0x0602A778 RID: 173944 RVA: 0x005CAEC0 File Offset: 0x005C90C0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWindDirectionalVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWindSourceBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
