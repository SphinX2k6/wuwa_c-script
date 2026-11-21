using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003859 RID: 14425
	[NullableContext(1)]
	[Nullable(0)]
	public class UiComponentUtil
	{
		// Token: 0x060257A2 RID: 153506 RVA: 0x00A8E878 File Offset: 0x00A8CA78
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

		// Token: 0x060257A3 RID: 153507 RVA: 0x00A8E908 File Offset: 0x00A8CB08
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

		// Token: 0x060257A4 RID: 153508 RVA: 0x00A8E95C File Offset: 0x00A8CB5C
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

		// Token: 0x060257A5 RID: 153509 RVA: 0x00A8E9C3 File Offset: 0x00A8CBC3
		public static void UnBindAudioEventByName(string name)
		{
			AudioController.Instance.StopSelectableAudioEventByName(name);
		}

		// Token: 0x060257A6 RID: 153510 RVA: 0x00A8E9D0 File Offset: 0x00A8CBD0
		public static void UnBindAudioEvent(UUISelectableComponent selectable)
		{
			AudioController.Instance.StopSelectableAudioEvent(selectable.GetOwner());
		}
	}
}
