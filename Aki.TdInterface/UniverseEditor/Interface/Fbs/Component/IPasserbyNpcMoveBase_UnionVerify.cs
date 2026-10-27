using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056CA RID: 22218
	public static class IPasserbyNpcMoveBase_UnionVerify
	{
		// Token: 0x060251CF RID: 152015 RVA: 0x0051FB14 File Offset: 0x0051DD14
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcSplineMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcMoveBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
