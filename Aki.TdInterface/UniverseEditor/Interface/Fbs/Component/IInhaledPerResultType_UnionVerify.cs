using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005418 RID: 21528
	public static class IInhaledPerResultType_UnionVerify
	{
		// Token: 0x060235BC RID: 144828 RVA: 0x004E4BEC File Offset: 0x004E2DEC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInhaledPerResultTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInhaledDestroySelfVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInhaledChangeSelfStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
