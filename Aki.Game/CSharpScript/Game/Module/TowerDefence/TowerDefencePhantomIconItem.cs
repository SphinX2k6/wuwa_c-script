using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B55 RID: 19285
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefencePhantomIconItem : SmallItemGrid, IGridProxy<PhantomSmallItemGrid>
	{
		// Token: 0x17007BD9 RID: 31705
		// (get) Token: 0x06031F01 RID: 204545 RVA: 0x00B968D1 File Offset: 0x00B94AD1
		// (set) Token: 0x06031F02 RID: 204546 RVA: 0x00B968D9 File Offset: 0x00B94AD9
		public IScrollViewDelegate<IGridProxy<PhantomSmallItemGrid>, PhantomSmallItemGrid> ScrollViewDelegate { get; set; }

		// Token: 0x17007BDA RID: 31706
		// (get) Token: 0x06031F03 RID: 204547 RVA: 0x00B968E2 File Offset: 0x00B94AE2
		// (set) Token: 0x06031F04 RID: 204548 RVA: 0x00B968EA File Offset: 0x00B94AEA
		public int GridIndex { get; set; }

		// Token: 0x17007BDB RID: 31707
		// (get) Token: 0x06031F05 RID: 204549 RVA: 0x00B968F3 File Offset: 0x00B94AF3
		// (set) Token: 0x06031F06 RID: 204550 RVA: 0x00B968FB File Offset: 0x00B94AFB
		public int DisplayIndex { get; set; }

		// Token: 0x06031F07 RID: 204551 RVA: 0x00B96904 File Offset: 0x00B94B04
		public void Clear()
		{
			TowerDefensePhantomIconCornerMark cornerMark = this.CornerMark;
			if (cornerMark != null)
			{
				cornerMark.Destroy(null);
			}
			this.CornerMark = null;
			TowerDefensePhantomUnavailableMask occupiedMask = this.OccupiedMask;
			if (occupiedMask != null)
			{
				occupiedMask.Destroy(null);
			}
			this.OccupiedMask = null;
		}

		// Token: 0x06031F08 RID: 204552 RVA: 0x00B96938 File Offset: 0x00B94B38
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06031F09 RID: 204553 RVA: 0x00B9693A File Offset: 0x00B94B3A
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06031F0A RID: 204554 RVA: 0x00B9693C File Offset: 0x00B94B3C
		public object GetKey(PhantomSmallItemGrid data, int displayIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x06031F0B RID: 204555 RVA: 0x00B9694C File Offset: 0x00B94B4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031F0C RID: 204556 RVA: 0x00B96AB8 File Offset: 0x00B94CB8
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefencePhantomIconItem.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefencePhantomIconItem.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F0D RID: 204557 RVA: 0x00B96AFB File Offset: 0x00B94CFB
		public void Refresh(PhantomSmallItemGrid data, bool isSelected, int gridIndex)
		{
			this.RefreshInternalAsync(data, isSelected, gridIndex);
		}

		// Token: 0x06031F0E RID: 204558 RVA: 0x00B96B08 File Offset: 0x00B94D08
		private UniTask RefreshInternalAsync(PhantomSmallItemGrid data, bool isSelected, int gridIndex)
		{
			TowerDefencePhantomIconItem.<RefreshInternalAsync>d__23 <RefreshInternalAsync>d__;
			<RefreshInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshInternalAsync>d__.<>4__this = this;
			<RefreshInternalAsync>d__.data = data;
			<RefreshInternalAsync>d__.<>1__state = -1;
			<RefreshInternalAsync>d__.<>t__builder.Start<TowerDefencePhantomIconItem.<RefreshInternalAsync>d__23>(ref <RefreshInternalAsync>d__);
			return <RefreshInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F0F RID: 204559 RVA: 0x00B96B54 File Offset: 0x00B94D54
		private UniTask TryPlayUnlockAsync(bool isLocked)
		{
			TowerDefencePhantomIconItem.<TryPlayUnlockAsync>d__24 <TryPlayUnlockAsync>d__;
			<TryPlayUnlockAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryPlayUnlockAsync>d__.<>4__this = this;
			<TryPlayUnlockAsync>d__.isLocked = isLocked;
			<TryPlayUnlockAsync>d__.<>1__state = -1;
			<TryPlayUnlockAsync>d__.<>t__builder.Start<TowerDefencePhantomIconItem.<TryPlayUnlockAsync>d__24>(ref <TryPlayUnlockAsync>d__);
			return <TryPlayUnlockAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F10 RID: 204560 RVA: 0x00B96B9F File Offset: 0x00B94D9F
		private void OnClick(EToggleState toggleState)
		{
			EventSystem.Instance.Emit<int>(EEventName.TowerDefenseOnClickOnePhantom, this.CachedTowerDefencePhantomId);
		}

		// Token: 0x0401AA1E RID: 109086
		private int CachedTowerDefencePhantomId;

		// Token: 0x0401AA1F RID: 109087
		private TowerDefensePhantomIconCornerMark CornerMark;

		// Token: 0x0401AA20 RID: 109088
		private TowerDefensePhantomUnavailableMask OccupiedMask;

		// Token: 0x0200ACD9 RID: 44249
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04034850 RID: 215120
			public const int QualitySprite = 0;

			// Token: 0x04034851 RID: 215121
			public const int IconTexture = 1;

			// Token: 0x04034852 RID: 215122
			public const int NameItem = 2;

			// Token: 0x04034853 RID: 215123
			public const int NameText = 3;

			// Token: 0x04034854 RID: 215124
			public const int BackgroundSprite = 4;

			// Token: 0x04034855 RID: 215125
			public const int BottomItem = 5;

			// Token: 0x04034856 RID: 215126
			public const int LockItem = 6;

			// Token: 0x04034857 RID: 215127
			public const int Root = 7;
		}
	}
}
