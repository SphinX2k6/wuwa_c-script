using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007670 RID: 30320
	public static class TClientEventVerify
	{
		// Token: 0x060372F5 RID: 226037 RVA: 0x0077B080 File Offset: 0x00779280
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISelfClientEventVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientUiEventVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
