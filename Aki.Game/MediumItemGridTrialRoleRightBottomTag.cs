using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02000DF9 RID: 3577
public class MediumItemGridTrialRoleRightBottomTag : MediumItemGridComponent
{
	// Token: 0x060090DF RID: 37087 RVA: 0x002B6770 File Offset: 0x002B4970
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060090E0 RID: 37088 RVA: 0x002B67B8 File Offset: 0x002B49B8
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_TagRoleTrial";
	}

	// Token: 0x060090E1 RID: 37089 RVA: 0x002B67C0 File Offset: 0x002B49C0
	[NullableContext(2)]
	protected override void OnRefresh(object obj)
	{
		MediumTrialRoleRightBottomTag mediumTrialRoleRightBottomTag = obj as MediumTrialRoleRightBottomTag;
		if (mediumTrialRoleRightBottomTag == null)
		{
			return;
		}
		if (mediumTrialRoleRightBottomTag.IsTrialRole)
		{
			int trialRoleId = mediumTrialRoleRightBottomTag.TrialRoleId;
			string trailRoleLabelIconById = RoleUtils.GetTrailRoleLabelIconById(mediumTrialRoleRightBottomTag.TrialRoleId);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(trailRoleLabelIconById);
			UUISprite icon = base.GetSprite(0);
			icon.SetUIActive(false);
			this.SetSpriteByPath(resourcePath, icon, false, null, delegate(bool isSuccess)
			{
				icon.SetUIActive(true);
			});
			this.SetActive(true);
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x0200702D RID: 28717
	private class EChildType
	{
		// Token: 0x040249B8 RID: 149944
		public const int IconImg = 0;
	}
}
