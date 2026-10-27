using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007779 RID: 30585
	public static class TScreenVerify
	{
		// Token: 0x060378A1 RID: 227489 RVA: 0x0078400C File Offset: 0x0078220C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISubScreenVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMainScreenVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
