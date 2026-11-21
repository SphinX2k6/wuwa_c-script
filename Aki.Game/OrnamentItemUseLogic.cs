using System;

// Token: 0x0200148C RID: 5260
public class OrnamentItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D292 RID: 53906 RVA: 0x003E78EA File Offset: 0x003E5AEA
	public override bool CheckUseCondition(int itemId, int num)
	{
		return RoleOrnamentModel.Instance.IsOwnOrnament(itemId);
	}

	// Token: 0x0600D293 RID: 53907 RVA: 0x003E78F7 File Offset: 0x003E5AF7
	public override void OnUse(int itemId, int num)
	{
		RoleController.Instance.SkipToRoleOrnamentViewByItemId(itemId, true);
	}
}
