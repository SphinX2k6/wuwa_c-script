using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020010CA RID: 4298
public class FormationRoleDragItem : UiPanelBase
{
	// Token: 0x0600AADF RID: 43743 RVA: 0x00325BF0 File Offset: 0x00323DF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AAE0 RID: 43744 RVA: 0x00325C5C File Offset: 0x00323E5C
	public virtual void RefreshRoleIcon(int configId, int roleSkinId)
	{
		FormationRoleDragItem.<>c__DisplayClass2_0 CS$<>8__locals1 = new FormationRoleDragItem.<>c__DisplayClass2_0();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(configId);
		if (roleConfig == null)
		{
			return;
		}
		RoleSkin? roleSkin = (roleSkinId != 0) ? SkinConfig.Instance.GetRoleSkinConfig(roleSkinId) : null;
		string atlasPath = (roleSkin != null) ? roleSkin.Value.FormationSpineAtlas : roleConfig.Value.FormationSpineAtlas;
		string skeletonPath = (roleSkin != null) ? roleSkin.Value.FormationSpineSkeletonData : roleConfig.Value.FormationSpineSkeletonData;
		FormationRoleDragItem.<>c__DisplayClass2_0 CS$<>8__locals2 = CS$<>8__locals1;
		float[] param;
		if (roleSkin == null)
		{
			(param = new float[3])[2] = 1f;
		}
		else
		{
			param = roleSkin.Value.SpineParam();
		}
		CS$<>8__locals2.param = param;
		CS$<>8__locals1.roleItem = base.GetItem(3);
		CS$<>8__locals1.roleSpine = base.GetSpine(2);
		base.SetSpineAssetByPath(atlasPath, skeletonPath, CS$<>8__locals1.roleSpine).ContinueWith(delegate()
		{
			CS$<>8__locals1.roleItem.SetAlpha(1f);
			CS$<>8__locals1.roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
			CS$<>8__locals1.roleItem.SetAnchorOffsetX(CS$<>8__locals1.param[0]);
			CS$<>8__locals1.roleItem.SetAnchorOffsetY(CS$<>8__locals1.param[1]);
			CS$<>8__locals1.roleItem.SetUIItemScale(new FVector(CS$<>8__locals1.param[2], CS$<>8__locals1.param[2], CS$<>8__locals1.param[2]));
		});
	}

	// Token: 0x02007346 RID: 29510
	private enum EChildType
	{
		// Token: 0x04025885 RID: 153733
		RoleIconSpine = 2,
		// Token: 0x04025886 RID: 153734
		RoleItem
	}
}
