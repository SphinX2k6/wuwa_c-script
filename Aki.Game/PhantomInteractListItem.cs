using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200247F RID: 9343
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractListItem : UiPanelBase
{
	// Token: 0x1700188F RID: 6287
	// (get) Token: 0x06012BF7 RID: 76791 RVA: 0x0049FF2A File Offset: 0x0049E12A
	public int ItemIndex
	{
		get
		{
			IPhantomInteractItemData itemData = this.ItemData;
			if (itemData == null)
			{
				return -1;
			}
			return itemData.ItemIndex;
		}
	}

	// Token: 0x06012BF8 RID: 76792 RVA: 0x0049FF40 File Offset: 0x0049E140
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange))
		};
	}

	// Token: 0x06012BF9 RID: 76793 RVA: 0x004A0000 File Offset: 0x0049E200
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractListItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractListItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012BFA RID: 76794 RVA: 0x004A0043 File Offset: 0x0049E243
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x06012BFB RID: 76795 RVA: 0x004A004B File Offset: 0x0049E24B
	public void DisableToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
	}

	// Token: 0x06012BFC RID: 76796 RVA: 0x004A0064 File Offset: 0x0049E264
	[NullableContext(1)]
	public UniTask Refresh(IPhantomInteractItemData itemData, bool showIndex, bool needAnim = true)
	{
		PhantomInteractListItem.<Refresh>d__17 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.itemData = itemData;
		<Refresh>d__.showIndex = showIndex;
		<Refresh>d__.needAnim = needAnim;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<PhantomInteractListItem.<Refresh>d__17>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06012BFD RID: 76797 RVA: 0x004A00BF File Offset: 0x0049E2BF
	public void SetSelected(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012BFE RID: 76798 RVA: 0x004A00DC File Offset: 0x0049E2DC
	private void OnToggleStateChange(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		if (this.OnToggleStateChangeCb != null && this.ItemData != null)
		{
			this.OnToggleStateChangeCb(this, this.ItemData, flag);
		}
		if (!flag)
		{
			return;
		}
		if (this.OnClickCb != null && this.ItemData != null)
		{
			this.OnClickCb(this.ItemData);
		}
	}

	// Token: 0x06012BFF RID: 76799 RVA: 0x004A0136 File Offset: 0x0049E336
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
	}

	// Token: 0x04008D36 RID: 36150
	private PhantomInteractListItemSlotIndexPanel SlotIndexPanel;

	// Token: 0x04008D37 RID: 36151
	private IPhantomInteractItemData ItemData;

	// Token: 0x04008D38 RID: 36152
	private PhantomInteractListItemSkillTagPanel SkillTagPanel;

	// Token: 0x04008D39 RID: 36153
	private int? CurrentMonsterId;

	// Token: 0x04008D3A RID: 36154
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008D3B RID: 36155
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnClickCb;

	// Token: 0x04008D3C RID: 36156
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData, bool> OnHoverCb;

	// Token: 0x04008D3D RID: 36157
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnPointerDownCb;

	// Token: 0x04008D3E RID: 36158
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnPointerUpCb;

	// Token: 0x04008D3F RID: 36159
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<PhantomInteractListItem, IPhantomInteractItemData, bool> OnToggleStateChangeCb;

	// Token: 0x020089F3 RID: 35315
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CCCD RID: 183501
		TogItem,
		// Token: 0x0402CCCE RID: 183502
		TexIcon,
		// Token: 0x0402CCCF RID: 183503
		ItemTagRight,
		// Token: 0x0402CCD0 RID: 183504
		ItemTagLeft,
		// Token: 0x0402CCD1 RID: 183505
		ItemSpriteEmptyAdd,
		// Token: 0x0402CCD2 RID: 183506
		ItemFXSelected
	}
}
