using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E71 RID: 24177
	public static class TConstraintValueVerify
	{
		// Token: 0x0602969C RID: 169628 RVA: 0x005ACF04 File Offset: 0x005AB104
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
