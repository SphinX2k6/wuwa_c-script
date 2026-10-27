using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x0200193D RID: 6461
public class MediumItemGridTrialRoleRightBottomTag : MediumItemGridComponent
{
	// Token: 0x0600BCE4 RID: 48356 RVA: 0x002ABCA4 File Offset: 0x002A9EA4
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

	// Token: 0x0600BCE5 RID: 48357 RVA: 0x002ABCEC File Offset: 0x002A9EEC
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_TagRoleTrial";
	}

	// Token: 0x0600BCE6 RID: 48358 RVA: 0x002ABCF4 File Offset: 0x002A9EF4
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

	// Token: 0x02007EA0 RID: 32416
	private class EChildType
	{
		// Token: 0x04029680 RID: 169600
		public const int IconImg = 0;
	}
}
