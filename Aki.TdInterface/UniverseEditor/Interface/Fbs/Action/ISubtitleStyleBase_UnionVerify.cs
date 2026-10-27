using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007228 RID: 29224
	public static class ISubtitleStyleBase_UnionVerify
	{
		// Token: 0x06033D6F RID: 212335 RVA: 0x006F9C9C File Offset: 0x006F7E9C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISubtitleStyleBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISubtitleStyleLevelAVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISubtitleStyleNewLevelBVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
