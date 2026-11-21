using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020008FD RID: 2301
public class ActivityRegressRoleItem : UiPanelBase
{
	// Token: 0x06006646 RID: 26182 RVA: 0x00200474 File Offset: 0x001FE674
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006647 RID: 26183 RVA: 0x00200520 File Offset: 0x001FE720
	public void RefreshItem(int roleId)
	{
		if (roleId == 0)
		{
			base.GetItem(1).SetUIActive(true);
			base.GetItem(3).SetUIActive(false);
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			string resourcePath = UiResourceConfig.Instance.GetResourcePath((playerGender == EPlayerGender.Male) ? "T_RoleTrialBoy" : "T_RoleTrialGirl");
			base.SetTextureByPath(resourcePath, base.GetTexture(2), null, null);
			return;
		}
		base.GetItem(1).SetUIActive(false);
		base.GetItem(3).SetUIActive(true);
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(roleId).Value.FormationRoleCard, base.GetTexture(4), roleId, null, null);
	}

	// Token: 0x02006C05 RID: 27653
	private class EActivityRegressRoleItemComponents
	{
		// Token: 0x0402381B RID: 145435
		public const int Button = 0;

		// Token: 0x0402381C RID: 145436
		public const int LockItem = 1;

		// Token: 0x0402381D RID: 145437
		public const int LocKTexture = 2;

		// Token: 0x0402381E RID: 145438
		public const int UnLockItem = 3;

		// Token: 0x0402381F RID: 145439
		public const int UnLockTexture = 4;

		// Token: 0x04023820 RID: 145440
		public const int TitleText = 5;
	}
}
