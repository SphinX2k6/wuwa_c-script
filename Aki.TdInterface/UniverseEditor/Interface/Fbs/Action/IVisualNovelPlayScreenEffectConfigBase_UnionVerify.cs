using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC9 RID: 32201
	public static class IVisualNovelPlayScreenEffectConfigBase_UnionVerify
	{
		// Token: 0x0603A30A RID: 238346 RVA: 0x007D7FF4 File Offset: 0x007D61F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelPlayScreenEffectConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelPlayScreenEffectOneShotVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelPlayScreenEffectPersistentVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVisualNovelPlayScreenEffectCustomVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
