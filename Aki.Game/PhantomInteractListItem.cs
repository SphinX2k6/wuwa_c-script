using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001964 RID: 6500
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractListItem : UiPanelBase
{
	// Token: 0x170018C9 RID: 6345
	// (get) Token: 0x060100AE RID: 65710 RVA: 0x004AD682 File Offset: 0x004AB882
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

	// Token: 0x060100AF RID: 65711 RVA: 0x004AD698 File Offset: 0x004AB898
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

	// Token: 0x060100B0 RID: 65712 RVA: 0x004AD758 File Offset: 0x004AB958
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractListItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractListItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060100B1 RID: 65713 RVA: 0x004AD79B File Offset: 0x004AB99B
	protected override void OnStart()
	{
		base.OnStart();
	}

	// Token: 0x060100B2 RID: 65714 RVA: 0x004AD7A3 File Offset: 0x004AB9A3
	public void DisableToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
	}

	// Token: 0x060100B3 RID: 65715 RVA: 0x004AD7BC File Offset: 0x004AB9BC
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

	// Token: 0x060100B4 RID: 65716 RVA: 0x004AD817 File Offset: 0x004ABA17
	public void SetSelected(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060100B5 RID: 65717 RVA: 0x004AD834 File Offset: 0x004ABA34
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

	// Token: 0x060100B6 RID: 65718 RVA: 0x004AD88E File Offset: 0x004ABA8E
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
	}

	// Token: 0x04008E7D RID: 36477
	private PhantomInteractListItemSlotIndexPanel SlotIndexPanel;

	// Token: 0x04008E7E RID: 36478
	private IPhantomInteractItemData ItemData;

	// Token: 0x04008E7F RID: 36479
	private PhantomInteractListItemSkillTagPanel SkillTagPanel;

	// Token: 0x04008E80 RID: 36480
	private int? CurrentMonsterId;

	// Token: 0x04008E81 RID: 36481
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008E82 RID: 36482
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnClickCb;

	// Token: 0x04008E83 RID: 36483
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData, bool> OnHoverCb;

	// Token: 0x04008E84 RID: 36484
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnPointerDownCb;

	// Token: 0x04008E85 RID: 36485
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IPhantomInteractItemData> OnPointerUpCb;

	// Token: 0x04008E86 RID: 36486
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<PhantomInteractListItem, IPhantomInteractItemData, bool> OnToggleStateChangeCb;

	// Token: 0x02007B7A RID: 31610
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04027FE3 RID: 163811
		TogItem,
		// Token: 0x04027FE4 RID: 163812
		TexIcon,
		// Token: 0x04027FE5 RID: 163813
		ItemTagRight,
		// Token: 0x04027FE6 RID: 163814
		ItemTagLeft,
		// Token: 0x04027FE7 RID: 163815
		ItemSpriteEmptyAdd,
		// Token: 0x04027FE8 RID: 163816
		ItemFXSelected
	}
}
