using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C1C RID: 3100
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineAttributeItem : UiPanelBase, IGridProxy<VisionRefineAttributeItemData>
{
	// Token: 0x17000E8B RID: 3723
	// (get) Token: 0x0600815E RID: 33118 RVA: 0x0027B0DD File Offset: 0x002792DD
	// (set) Token: 0x0600815F RID: 33119 RVA: 0x0027B0E5 File Offset: 0x002792E5
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

	// Token: 0x17000E8C RID: 3724
	// (get) Token: 0x06008160 RID: 33120 RVA: 0x0027B0EE File Offset: 0x002792EE
	// (set) Token: 0x06008161 RID: 33121 RVA: 0x0027B0F6 File Offset: 0x002792F6
	public int GridIndex { get; set; }

	// Token: 0x17000E8D RID: 3725
	// (get) Token: 0x06008162 RID: 33122 RVA: 0x0027B0FF File Offset: 0x002792FF
	// (set) Token: 0x06008163 RID: 33123 RVA: 0x0027B107 File Offset: 0x00279307
	public int DisplayIndex { get; set; }

	// Token: 0x06008164 RID: 33124 RVA: 0x0027B110 File Offset: 0x00279310
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

	// Token: 0x06008165 RID: 33125 RVA: 0x0027B24D File Offset: 0x0027944D
	public UniTask RefreshAsync(VisionRefineAttributeItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x06008166 RID: 33126 RVA: 0x0027B25D File Offset: 0x0027945D
	public void Clear()
	{
	}

	// Token: 0x06008167 RID: 33127 RVA: 0x0027B25F File Offset: 0x0027945F
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

	// Token: 0x06008168 RID: 33128 RVA: 0x0027B292 File Offset: 0x00279492
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

	// Token: 0x06008169 RID: 33129 RVA: 0x0027B2C5 File Offset: 0x002794C5
	[return: Nullable(2)]
	public object GetKey(VisionRefineAttributeItemData data, int gridIndex)
	{
		return data;
	}

	// Token: 0x0600816A RID: 33130 RVA: 0x0027B2C8 File Offset: 0x002794C8
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

	// Token: 0x0600816B RID: 33131 RVA: 0x0027B3A0 File Offset: 0x002795A0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributeItem.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributeItem.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600816C RID: 33132 RVA: 0x0027B3E3 File Offset: 0x002795E3
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

	// Token: 0x04004F7E RID: 20350
	[Nullable(2)]
	public Func<int, bool> OnSelectedCallback;

	// Token: 0x04004F7F RID: 20351
	[Nullable(2)]
	public Func<int, bool> OnDeselectedCallback;

	// Token: 0x02006EDA RID: 28378
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040243CE RID: 148430
		Toggle,
		// Token: 0x040243CF RID: 148431
		LightTexture,
		// Token: 0x040243D0 RID: 148432
		NameText,
		// Token: 0x040243D1 RID: 148433
		NumberText,
		// Token: 0x040243D2 RID: 148434
		ChosenSprite,
		// Token: 0x040243D3 RID: 148435
		NewItem,
		// Token: 0x040243D4 RID: 148436
		EffectItem
	}
}
