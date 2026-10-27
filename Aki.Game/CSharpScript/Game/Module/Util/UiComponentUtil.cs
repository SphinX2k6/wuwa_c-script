using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048E2 RID: 18658
	[NullableContext(1)]
	[Nullable(0)]
	public class UiComponentUtil
	{
		// Token: 0x06030C75 RID: 199797 RVA: 0x00B53A08 File Offset: 0x00B51C08
		[return: Nullable(2)]
		public static CSharpScript.Game.Module.RoleUi.StarItem SetStarActiveNew(CSharpScript.Game.Module.RoleUi.StarItem[] starList, int currentCount, int? maxCount = null, bool showNextStar = true)
		{
			int num = starList.Length;
			int valueOrDefault = maxCount.GetValueOrDefault(num);
			CSharpScript.Game.Module.RoleUi.StarItem result = null;
			for (int i = 0; i < num; i++)
			{
				CSharpScript.Game.Module.RoleUi.StarItem starItem = starList[i];
				starItem.SetActive(i + 1 <= valueOrDefault);
				if (i + 1 <= valueOrDefault)
				{
					starItem.SetImgStarOnActive(i < currentCount);
					if (showNextStar)
					{
						starItem.SetImgStarNextActive(i == currentCount);
						if (i == currentCount)
						{
							result = starItem;
						}
						starItem.SetImgStarOffActive(i > currentCount);
					}
					else
					{
						starItem.SetImgStarNextActive(false);
						starItem.SetImgStarOffActive(i >= currentCount);
						if (i == currentCount - 1)
						{
							result = starItem;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06030C76 RID: 199798 RVA: 0x00B53A98 File Offset: 0x00B51C98
		public static bool SetMoneyState(UUIText costText, UUIText ownText, int costNumber, int ownNumber)
		{
			costText.SetText(costNumber.ToString(), true);
			bool flag = ownNumber >= costNumber;
			ownText.SetText(ownNumber.ToString(), true);
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(ownText.changeColor);
			ownText.SetChangeColor(bUseChangeColor, fcolor);
			costText.useChangeColor = !flag;
			return flag;
		}

		// Token: 0x06030C77 RID: 199799 RVA: 0x00B53AEC File Offset: 0x00B51CEC
		public static void BindAudioEvent(UUISelectableComponent selectable)
		{
			UUIButtonComponent uuibuttonComponent = selectable as UUIButtonComponent;
			if (uuibuttonComponent != null)
			{
				uuibuttonComponent.OnPostAudioStateEvent.Bind(delegate(EButtonAudioStateTransferType state, string eventPath)
				{
					AudioController.Instance.PostSelectableAudioEvent(eventPath, selectable.GetOwner());
				});
				return;
			}
			UUIExtendToggle uuiextendToggle = selectable as UUIExtendToggle;
			if (uuiextendToggle != null)
			{
				uuiextendToggle.OnPostAudioStateEvent.Bind(delegate(EToggleAudioTransitionState state, string eventPath)
				{
					AudioController.Instance.PostSelectableAudioEvent(eventPath, selectable.GetOwner());
				});
			}
		}

		// Token: 0x06030C78 RID: 199800 RVA: 0x00B53B53 File Offset: 0x00B51D53
		public static void UnBindAudioEventByName(string name)
		{
			AudioController.Instance.StopSelectableAudioEventByName(name);
		}

		// Token: 0x06030C79 RID: 199801 RVA: 0x00B53B60 File Offset: 0x00B51D60
		public static void UnBindAudioEvent(UUISelectableComponent selectable)
		{
			AudioController.Instance.StopSelectableAudioEvent(selectable.GetOwner());
		}
	}
}
