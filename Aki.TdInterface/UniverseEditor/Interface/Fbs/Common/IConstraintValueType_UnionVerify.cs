using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D84 RID: 23940
	public static class IConstraintValueType_UnionVerify
	{
		// Token: 0x06028F47 RID: 167751 RVA: 0x0059FD10 File Offset: 0x0059DF10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IConstraintValueTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IConstraintValueMaxVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IConstraintValueMinVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IConstraintValueClampVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
