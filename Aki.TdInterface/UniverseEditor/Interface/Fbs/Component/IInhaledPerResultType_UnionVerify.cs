using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599E RID: 22942
	public static class IInhaledPerResultType_UnionVerify
	{
		// Token: 0x06025674 RID: 153204 RVA: 0x00521C18 File Offset: 0x0051FE18
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
