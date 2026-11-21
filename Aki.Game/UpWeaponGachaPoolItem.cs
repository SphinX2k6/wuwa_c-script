using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200114E RID: 4430
[NullableContext(1)]
[Nullable(0)]
public class UpWeaponGachaPoolItem : GachaPoolItem
{
	// Token: 0x17001213 RID: 4627
	// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x00342FDD File Offset: 0x003411DD
	private bool IsLock
	{
		get
		{
			return this.Operating;
		}
	}

	// Token: 0x0600B0B5 RID: 45237 RVA: 0x00342FE5 File Offset: 0x003411E5
	public UpWeaponGachaPoolItem(GachaDefine.EGachaViewType gachaType) : base(gachaType)
	{
	}

	// Token: 0x0600B0B6 RID: 45238 RVA: 0x00343010 File Offset: 0x00341210
	private void Lock()
	{
		this.Operating = true;
	}

	// Token: 0x0600B0B7 RID: 45239 RVA: 0x0034301C File Offset: 0x0034121C
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

	// Token: 0x0600B0B8 RID: 45240 RVA: 0x00343054 File Offset: 0x00341254
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

	// Token: 0x0600B0B9 RID: 45241 RVA: 0x003430E0 File Offset: 0x003412E0
	protected override UniTask OnBeforeStartAsync()
	{
		UpWeaponGachaPoolItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<UpWeaponGachaPoolItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B0BA RID: 45242 RVA: 0x00343123 File Offset: 0x00341323
	protected override void OnPlayStartSeq()
	{
		if (this.CurWeaponItem != null)
		{
			this.PlayWeaponStartSeq(this.CurWeaponItem);
		}
	}

	// Token: 0x0600B0BB RID: 45243 RVA: 0x00343139 File Offset: 0x00341339
	protected override void OnAfterHide()
	{
		this.ResetCurrentShowWeaponItem();
	}

	// Token: 0x0600B0BC RID: 45244 RVA: 0x00343144 File Offset: 0x00341344
	public override void Refresh()
	{
		if (this.GachaViewInfo == null)
		{
			return;
		}
		int weaponId = this.GachaViewInfo.Value.GetShowIdListArray()[0];
		this.UpdateByWeaponId(weaponId);
	}

	// Token: 0x0600B0BD RID: 45245 RVA: 0x0034317C File Offset: 0x0034137C
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

	// Token: 0x0600B0BE RID: 45246 RVA: 0x003431B8 File Offset: 0x003413B8
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

	// Token: 0x0600B0BF RID: 45247 RVA: 0x00343204 File Offset: 0x00341404
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

	// Token: 0x0600B0C0 RID: 45248 RVA: 0x00343244 File Offset: 0x00341444
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

	// Token: 0x0600B0C1 RID: 45249 RVA: 0x0034326D File Offset: 0x0034146D
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

	// Token: 0x040065FF RID: 26111
	[Nullable(2)]
	private WeaponDescribeComponent DescComponent;

	// Token: 0x04006600 RID: 26112
	private readonly Dictionary<string, UUIItem> WeaponItemMap = new Dictionary<string, UUIItem>();

	// Token: 0x04006601 RID: 26113
	private readonly Dictionary<UUIItem, LevelSequencePlayer> LevelSequencePlayerMap = new Dictionary<UUIItem, LevelSequencePlayer>();

	// Token: 0x04006602 RID: 26114
	[Nullable(2)]
	private UUIItem CurWeaponItem;

	// Token: 0x04006603 RID: 26115
	private readonly Queue<int> OperationQueue = new Queue<int>(4);

	// Token: 0x04006604 RID: 26116
	private bool Operating;

	// Token: 0x020073F3 RID: 29683
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04025BF5 RID: 154613
		ContentRootItem,
		// Token: 0x04025BF6 RID: 154614
		DescItem,
		// Token: 0x04025BF7 RID: 154615
		ThemeTextTexture
	}
}
