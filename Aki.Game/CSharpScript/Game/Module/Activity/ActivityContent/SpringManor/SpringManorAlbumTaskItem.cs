using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FDB RID: 20443
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorAlbumTaskItem : GridProxyAbstract<AlbumTaskData>
	{
		// Token: 0x06033355 RID: 209749 RVA: 0x00E5A1A4 File Offset: 0x00E583A4
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

		// Token: 0x06033356 RID: 209750 RVA: 0x00E5A263 File Offset: 0x00E58463
		private void OnClick(EToggleState state)
		{
			if (this.OnToggleCallBack != null && this.Data != null)
			{
				this.OnToggleCallBack(this.Data, this.Index);
			}
		}

		// Token: 0x06033357 RID: 209751 RVA: 0x00E5A28C File Offset: 0x00E5848C
		public void SetToggleCallBack(Action<AlbumTaskData, int> callBack)
		{
			this.OnToggleCallBack = callBack;
		}

		// Token: 0x06033358 RID: 209752 RVA: 0x00E5A295 File Offset: 0x00E58495
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x06033359 RID: 209753 RVA: 0x00E5A29E File Offset: 0x00E5849E
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x0603335A RID: 209754 RVA: 0x00E5A2A8 File Offset: 0x00E584A8
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

		// Token: 0x0603335B RID: 209755 RVA: 0x00E5A40A File Offset: 0x00E5860A
		public void SetSelectedState(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			this.SetSelectedIcon(isSelected);
		}

		// Token: 0x0603335C RID: 209756 RVA: 0x00E5A430 File Offset: 0x00E58630
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

		// Token: 0x0401B2FF RID: 111359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<AlbumTaskData, int> OnToggleCallBack;

		// Token: 0x0401B300 RID: 111360
		[Nullable(2)]
		private AlbumTaskData Data;

		// Token: 0x0401B301 RID: 111361
		private EBrochureType CurTaskType = EBrochureType.Brochure;

		// Token: 0x0401B302 RID: 111362
		private int Index;
	}
}
