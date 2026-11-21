using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F6F RID: 16239
	public static class TVarValueVerify
	{
		// Token: 0x060161AE RID: 90542 RVA: 0x0032BF10 File Offset: 0x0032A110
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = BooleanValueVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IntValueVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = FloatValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = StringValueVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = QuestStateValueVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = EntityValueVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = QuestValueVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = PrefabValueVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = TransformValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
