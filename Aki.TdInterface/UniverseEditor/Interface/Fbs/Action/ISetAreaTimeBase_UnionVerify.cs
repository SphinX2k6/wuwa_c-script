using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA7 RID: 28583
	public static class ISetAreaTimeBase_UnionVerify
	{
		// Token: 0x06032838 RID: 206904 RVA: 0x006D138C File Offset: 0x006CF58C
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
