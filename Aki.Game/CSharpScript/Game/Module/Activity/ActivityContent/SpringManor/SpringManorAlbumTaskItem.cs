using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200605D RID: 24669
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorAlbumTaskItem : GridProxyAbstract<AlbumTaskData>
	{
		// Token: 0x0603E691 RID: 255633 RVA: 0x00F133E0 File Offset: 0x00F115E0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick))
			};
		}

		// Token: 0x0603E692 RID: 255634 RVA: 0x00F1349F File Offset: 0x00F1169F
		private void OnClick(EToggleState state)
		{
			if (this.OnToggleCallBack != null && this.Data != null)
			{
				this.OnToggleCallBack(this.Data, this.Index);
			}
		}

		// Token: 0x0603E693 RID: 255635 RVA: 0x00F134C8 File Offset: 0x00F116C8
		public void SetToggleCallBack(Action<AlbumTaskData, int> callBack)
		{
			this.OnToggleCallBack = callBack;
		}

		// Token: 0x0603E694 RID: 255636 RVA: 0x00F134D1 File Offset: 0x00F116D1
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x0603E695 RID: 255637 RVA: 0x00F134DA File Offset: 0x00F116DA
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x0603E696 RID: 255638 RVA: 0x00F134E4 File Offset: 0x00F116E4
		public override void Refresh(AlbumTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.Index = gridIndex;
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(data.ConfigId) : null;
			if (bookItem == null)
			{
				return;
			}
			this.CurTaskType = data.Type;
			this.SetSelectedState(isSelected);
			bool flag = data.State == EBrochureState.Unlock;
			bool flag2 = data.State == EBrochureState.Rewarded;
			if (flag || flag2)
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.ShowTextNew(bookItem.Value.DescriptionTitle);
				}
			}
			else
			{
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.ShowTextNew((!string.IsNullOrEmpty(bookItem.Value.GuideTitle)) ? bookItem.Value.GuideTitle : bookItem.Value.DescriptionTitle);
				}
			}
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(data.IsFollowing);
			}
			if (data.IsFollowing)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(data.IsMainQuest ? "SP_IconTaskZhuXian" : "SP_IconTaskYaoYue");
				this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
			}
			UUISprite sprite2 = base.GetSprite(5);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(flag || flag2);
			}
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag);
		}

		// Token: 0x0603E697 RID: 255639 RVA: 0x00F13646 File Offset: 0x00F11846
		public void SetSelectedState(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			this.SetSelectedIcon(isSelected);
		}

		// Token: 0x0603E698 RID: 255640 RVA: 0x00F1366C File Offset: 0x00F1186C
		private void SetSelectedIcon(bool isSelected)
		{
			string text = null;
			if (this.CurTaskType == EBrochureType.Character)
			{
				UiResourceConfig instance = UiResourceConfig.Instance;
				text = ((instance != null) ? instance.GetResourcePath(isSelected ? "SP_AlbumTabBIconASel" : "SP_AlbumTabBIconANml") : null);
			}
			else if (this.CurTaskType == EBrochureType.EasterEggBook)
			{
				UiResourceConfig instance2 = UiResourceConfig.Instance;
				text = ((instance2 != null) ? instance2.GetResourcePath(isSelected ? "SP_AlbumTabBIconBNml" : "SP_AlbumTabBIconBSel") : null);
			}
			if (!string.IsNullOrEmpty(text))
			{
				this.SetSpriteByPath(text, base.GetSprite(2), false, null, delegate(bool _)
				{
					(base.GetSprite(2).GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition).SetAllStateSprite(base.GetSprite(2).GetSprite());
				});
			}
		}

		// Token: 0x040209D2 RID: 133586
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AlbumTaskData, int> OnToggleCallBack;

		// Token: 0x040209D3 RID: 133587
		[Nullable(2)]
		private AlbumTaskData Data;

		// Token: 0x040209D4 RID: 133588
		private EBrochureType CurTaskType = EBrochureType.Brochure;

		// Token: 0x040209D5 RID: 133589
		private int Index;
	}
}
