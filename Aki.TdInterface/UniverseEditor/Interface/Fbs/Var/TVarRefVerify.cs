using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B61 RID: 15201
	public static class TVarRefVerify
	{
		// Token: 0x06014CB0 RID: 85168 RVA: 0x00305410 File Offset: 0x00303610
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IConstVarRefVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGlobalVarRefVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOtherVarRefVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISelfVarRefVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ISystemVarRefVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
