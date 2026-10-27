using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C8F RID: 7311
[NullableContext(1)]
[Nullable(0)]
public class UpWeaponGachaPoolItem : GachaPoolItem
{
	// Token: 0x170011ED RID: 4589
	// (get) Token: 0x0600DC9E RID: 56478 RVA: 0x00337AB9 File Offset: 0x00335CB9
	private bool IsLock
	{
		get
		{
			return this.Operating;
		}
	}

	// Token: 0x0600DC9F RID: 56479 RVA: 0x00337AC1 File Offset: 0x00335CC1
	public UpWeaponGachaPoolItem(GachaDefine.EGachaViewType gachaType) : base(gachaType)
	{
	}

	// Token: 0x0600DCA0 RID: 56480 RVA: 0x00337AEC File Offset: 0x00335CEC
	private void Lock()
	{
		this.Operating = true;
	}

	// Token: 0x0600DCA1 RID: 56481 RVA: 0x00337AF8 File Offset: 0x00335CF8
	private void Unlock()
	{
		this.Operating = false;
		if (this.OperationQueue.Size == 0)
		{
			return;
		}
		int weaponId = this.OperationQueue.Pop();
		this.UpdateByWeaponId(weaponId);
	}

	// Token: 0x0600DCA2 RID: 56482 RVA: 0x00337B30 File Offset: 0x00335D30
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600DCA3 RID: 56483 RVA: 0x00337BBC File Offset: 0x00335DBC
	protected override UniTask OnBeforeStartAsync()
	{
		UpWeaponGachaPoolItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<UpWeaponGachaPoolItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DCA4 RID: 56484 RVA: 0x00337BFF File Offset: 0x00335DFF
	protected override void OnPlayStartSeq()
	{
		if (this.CurWeaponItem != null)
		{
			this.PlayWeaponStartSeq(this.CurWeaponItem);
		}
	}

	// Token: 0x0600DCA5 RID: 56485 RVA: 0x00337C15 File Offset: 0x00335E15
	protected override void OnAfterHide()
	{
		this.ResetCurrentShowWeaponItem();
	}

	// Token: 0x0600DCA6 RID: 56486 RVA: 0x00337C20 File Offset: 0x00335E20
	public override void Refresh()
	{
		if (this.GachaViewInfo == null)
		{
			return;
		}
		int weaponId = this.GachaViewInfo.Value.GetShowIdListArray()[0];
		this.UpdateByWeaponId(weaponId);
	}

	// Token: 0x0600DCA7 RID: 56487 RVA: 0x00337C58 File Offset: 0x00335E58
	private void UpdateByWeaponId(int weaponId)
	{
		if (this.IsLock)
		{
			this.OperationQueue.Push(weaponId);
			return;
		}
		this.Lock();
		this.UpdateByWeaponIdAsync(weaponId).ContinueWith(new Action(this.Unlock)).Forget();
	}

	// Token: 0x0600DCA8 RID: 56488 RVA: 0x00337C94 File Offset: 0x00335E94
	private UniTask UpdateByWeaponIdAsync(int weaponId)
	{
		UpWeaponGachaPoolItem.<UpdateByWeaponIdAsync>d__18 <UpdateByWeaponIdAsync>d__;
		<UpdateByWeaponIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateByWeaponIdAsync>d__.<>4__this = this;
		<UpdateByWeaponIdAsync>d__.weaponId = weaponId;
		<UpdateByWeaponIdAsync>d__.<>1__state = -1;
		<UpdateByWeaponIdAsync>d__.<>t__builder.Start<UpWeaponGachaPoolItem.<UpdateByWeaponIdAsync>d__18>(ref <UpdateByWeaponIdAsync>d__);
		return <UpdateByWeaponIdAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DCA9 RID: 56489 RVA: 0x00337CE0 File Offset: 0x00335EE0
	private void PlayWeaponStartSeq(UUIItem weaponItem)
	{
		LevelSequencePlayer levelSequencePlayer;
		if (!this.LevelSequencePlayerMap.TryGetValue(weaponItem, out levelSequencePlayer))
		{
			return;
		}
		levelSequencePlayer.StopSequenceByKey("Loop", false, false);
		levelSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600DCAA RID: 56490 RVA: 0x00337D20 File Offset: 0x00335F20
	[NullableContext(2)]
	private void StopPlayWeaponItemSequence(UUIItem weaponItem)
	{
		if (weaponItem == null)
		{
			return;
		}
		LevelSequencePlayer levelSequencePlayer;
		if (this.LevelSequencePlayerMap.TryGetValue(weaponItem, out levelSequencePlayer))
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
	}

	// Token: 0x0600DCAB RID: 56491 RVA: 0x00337D49 File Offset: 0x00335F49
	private void ResetCurrentShowWeaponItem()
	{
		if (this.CurWeaponItem == null)
		{
			return;
		}
		this.CurWeaponItem.SetUIActive(false);
		this.StopPlayWeaponItemSequence(this.CurWeaponItem);
		this.CurWeaponItem = null;
	}

	// Token: 0x0400652D RID: 25901
	[Nullable(2)]
	private WeaponDescribeComponent DescComponent;

	// Token: 0x0400652E RID: 25902
	private readonly Dictionary<string, UUIItem> WeaponItemMap = new Dictionary<string, UUIItem>();

	// Token: 0x0400652F RID: 25903
	private readonly Dictionary<UUIItem, LevelSequencePlayer> LevelSequencePlayerMap = new Dictionary<UUIItem, LevelSequencePlayer>();

	// Token: 0x04006530 RID: 25904
	[Nullable(2)]
	private UUIItem CurWeaponItem;

	// Token: 0x04006531 RID: 25905
	private readonly Queue<int> OperationQueue = new Queue<int>(4);

	// Token: 0x04006532 RID: 25906
	private bool Operating;

	// Token: 0x0200826B RID: 33387
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A8D4 RID: 174292
		ContentRootItem,
		// Token: 0x0402A8D5 RID: 174293
		DescItem,
		// Token: 0x0402A8D6 RID: 174294
		ThemeTextTexture
	}
}
