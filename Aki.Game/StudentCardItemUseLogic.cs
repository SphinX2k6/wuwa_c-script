using System;
using CSharpScript.Game.Ui;

// Token: 0x02001490 RID: 5264
public class StudentCardItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D29E RID: 53918 RVA: 0x003E7999 File Offset: 0x003E5B99
	public override bool IsMatch(int itemId)
	{
		return itemId == 70290000;
	}

	// Token: 0x0600D29F RID: 53919 RVA: 0x003E79A3 File Offset: 0x003E5BA3
	public override void OnUse(int itemId, int num)
	{
		UiManager.Instance.OpenView(EUiViewName.AdmissionStudentCardView, null, null);
	}

	// Token: 0x04007690 RID: 30352
	private const int STUDENT_CARD_ITEM_ID = 70290000;
}
