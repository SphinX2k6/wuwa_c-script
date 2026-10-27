using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001449 RID: 5193
public class ActivityRegressRoleItem : UiPanelBase
{
	// Token: 0x060092B1 RID: 37553 RVA: 0x001F7938 File Offset: 0x001F5B38
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

	// Token: 0x060092B2 RID: 37554 RVA: 0x001F79E4 File Offset: 0x001F5BE4
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

	// Token: 0x02007A81 RID: 31361
	private class EActivityRegressRoleItemComponents
	{
		// Token: 0x04028501 RID: 165121
		public const int Button = 0;

		// Token: 0x04028502 RID: 165122
		public const int LockItem = 1;

		// Token: 0x04028503 RID: 165123
		public const int LocKTexture = 2;

		// Token: 0x04028504 RID: 165124
		public const int UnLockItem = 3;

		// Token: 0x04028505 RID: 165125
		public const int UnLockTexture = 4;

		// Token: 0x04028506 RID: 165126
		public const int TitleText = 5;
	}
}
