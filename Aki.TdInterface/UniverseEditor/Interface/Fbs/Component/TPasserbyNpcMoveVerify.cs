using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062A8 RID: 25256
	public static class TPasserbyNpcMoveVerify
	{
		// Token: 0x0602AF3E RID: 175934 RVA: 0x005DC2B8 File Offset: 0x005DA4B8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcSplineMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcLiftMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
