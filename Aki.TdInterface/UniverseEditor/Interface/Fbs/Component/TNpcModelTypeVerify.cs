using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006299 RID: 25241
	public static class TNpcModelTypeVerify
	{
		// Token: 0x0602AEE8 RID: 175848 RVA: 0x005DBA30 File Offset: 0x005D9C30
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICombineDaNpcModelVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDaNpcModelVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMeshNpcModelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
