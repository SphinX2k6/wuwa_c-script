using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F5 RID: 29941
	public static class IVarContext_UnionVerify
	{
		// Token: 0x0603671C RID: 223004 RVA: 0x00765864 File Offset: 0x00763A64
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVarContextVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityVarContextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestVarContextVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILevelPlayVarContextVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEntityTemplateContextVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBehaviorTreeFragmentContextVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ICommonBtContextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
