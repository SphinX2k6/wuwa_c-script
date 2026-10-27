using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C71 RID: 23665
	public static class TNpcModelTypeVerify
	{
		// Token: 0x060288C8 RID: 166088 RVA: 0x00593654 File Offset: 0x00591854
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMeshNpcModelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDaNpcModelVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
