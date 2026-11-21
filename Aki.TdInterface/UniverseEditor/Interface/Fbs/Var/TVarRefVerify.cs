using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F69 RID: 16233
	public static class TVarRefVerify
	{
		// Token: 0x0601617A RID: 90490 RVA: 0x0032B9A8 File Offset: 0x00329BA8
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
