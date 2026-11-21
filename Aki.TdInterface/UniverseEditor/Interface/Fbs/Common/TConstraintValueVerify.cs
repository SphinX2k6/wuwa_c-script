using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B4 RID: 25780
	public static class TConstraintValueVerify
	{
		// Token: 0x0602BD44 RID: 179524 RVA: 0x005F5EA8 File Offset: 0x005F40A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IConstraintValueClampVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IConstraintValueMaxVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IConstraintValueMinVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
