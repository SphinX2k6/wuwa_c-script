using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776D RID: 30573
	public static class ISetAreaTimeBase_UnionVerify
	{
		// Token: 0x06035A88 RID: 219784 RVA: 0x00730D44 File Offset: 0x0072EF44
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetAreaTimeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISetAreaTimeLockVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetAreaTimeUnLockVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
