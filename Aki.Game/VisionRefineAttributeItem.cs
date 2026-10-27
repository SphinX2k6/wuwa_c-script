using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001763 RID: 5987
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineAttributeItem : UiPanelBase, IGridProxy<VisionRefineAttributeItemData>
{
	// Token: 0x17000E68 RID: 3688
	// (get) Token: 0x0600AD77 RID: 44407 RVA: 0x00270C1D File Offset: 0x0026EE1D
	// (set) Token: 0x0600AD78 RID: 44408 RVA: 0x00270C25 File Offset: 0x0026EE25
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<VisionRefineAttributeItemData>, VisionRefineAttributeItemData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17000E69 RID: 3689
	// (get) Token: 0x0600AD79 RID: 44409 RVA: 0x00270C2E File Offset: 0x0026EE2E
	// (set) Token: 0x0600AD7A RID: 44410 RVA: 0x00270C36 File Offset: 0x0026EE36
	public int GridIndex { get; set; }

	// Token: 0x17000E6A RID: 3690
	// (get) Token: 0x0600AD7B RID: 44411 RVA: 0x00270C3F File Offset: 0x0026EE3F
	// (set) Token: 0x0600AD7C RID: 44412 RVA: 0x00270C47 File Offset: 0x0026EE47
	public int DisplayIndex { get; set; }

	// Token: 0x0600AD7D RID: 44413 RVA: 0x00270C50 File Offset: 0x0026EE50
	public void Refresh(VisionRefineAttributeItemData data, bool isSelected, int gridIndex)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.IsSelfInteractive = data.CanInteractive;
		extendToggle.SetToggleState(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.NameTextId, Array.Empty<object>());
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(data.NumberText ?? "", true);
		}
		if (data.ForceCheckboxActive != null)
		{
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(data.ForceCheckboxActive.Value);
			}
		}
		if (data.HasNewIcon == null)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		else
		{
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 != null)
			{
				item3.SetAlpha(data.HasNewIcon.Value > false);
			}
		}
		UUIItem item4 = base.GetItem(6);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(data.IsRecommend);
		}
		if (data.HasNewIcon.GetValueOrDefault())
		{
			UUIItem item5 = base.GetItem(6);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(true);
		}
	}

	// Token: 0x0600AD7E RID: 44414 RVA: 0x00270D8D File Offset: 0x0026EF8D
	public UniTask RefreshAsync(VisionRefineAttributeItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x0600AD7F RID: 44415 RVA: 0x00270D9D File Offset: 0x0026EF9D
	public void Clear()
	{
	}

	// Token: 0x0600AD80 RID: 44416 RVA: 0x00270D9F File Offset: 0x0026EF9F
	public void OnSelected(bool fireEvent)
	{
		if (this.OnSelectedCallback != null && !this.OnSelectedCallback(this.GridIndex))
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600AD81 RID: 44417 RVA: 0x00270DD2 File Offset: 0x0026EFD2
	public void OnDeselected(bool fireEvent)
	{
		if (this.OnDeselectedCallback != null && !this.OnDeselectedCallback(this.GridIndex))
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
	}

	// Token: 0x0600AD82 RID: 44418 RVA: 0x00270E05 File Offset: 0x0026F005
	[return: Nullable(2)]
	public object GetKey(VisionRefineAttributeItemData data, int gridIndex)
	{
		return data;
	}

	// Token: 0x0600AD83 RID: 44419 RVA: 0x00270E08 File Offset: 0x0026F008
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x0600AD84 RID: 44420 RVA: 0x00270EE0 File Offset: 0x0026F0E0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributeItem.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributeItem.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD85 RID: 44421 RVA: 0x00270F23 File Offset: 0x0026F123
	private void OnClick(EToggleState toggleState)
	{
		if (toggleState != EToggleState.ETT_UnChecked)
		{
			if (toggleState == EToggleState.ETT_Checked)
			{
				this.OnSelected(false);
				return;
			}
		}
		else
		{
			this.OnDeselected(false);
		}
	}

	// Token: 0x04004ED4 RID: 20180
	[Nullable(2)]
	public Func<int, bool> OnSelectedCallback;

	// Token: 0x04004ED5 RID: 20181
	[Nullable(2)]
	public Func<int, bool> OnDeselectedCallback;

	// Token: 0x02007D54 RID: 32084
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290A3 RID: 168099
		Toggle,
		// Token: 0x040290A4 RID: 168100
		LightTexture,
		// Token: 0x040290A5 RID: 168101
		NameText,
		// Token: 0x040290A6 RID: 168102
		NumberText,
		// Token: 0x040290A7 RID: 168103
		ChosenSprite,
		// Token: 0x040290A8 RID: 168104
		NewItem,
		// Token: 0x040290A9 RID: 168105
		EffectItem
	}
}
