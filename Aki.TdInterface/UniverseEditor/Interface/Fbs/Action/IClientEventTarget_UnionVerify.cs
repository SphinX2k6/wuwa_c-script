using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A22 RID: 27170
	public static class IClientEventTarget_UnionVerify
	{
		// Token: 0x0602E9C0 RID: 190912 RVA: 0x0065AFE8 File Offset: 0x006591E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientEventTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISelfClientEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientUiEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
