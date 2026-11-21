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
	// Token: 0x02003AFD RID: 15101
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefencePhantomIconItem : SmallItemGrid, IGridProxy<PhantomSmallItemGrid>
	{
		// Token: 0x17004F86 RID: 20358
		// (get) Token: 0x06026C90 RID: 158864 RVA: 0x00ADAB0D File Offset: 0x00AD8D0D
		// (set) Token: 0x06026C91 RID: 158865 RVA: 0x00ADAB15 File Offset: 0x00AD8D15
		public IScrollViewDelegate<IGridProxy<PhantomSmallItemGrid>, PhantomSmallItemGrid> ScrollViewDelegate { get; set; }

		// Token: 0x17004F87 RID: 20359
		// (get) Token: 0x06026C92 RID: 158866 RVA: 0x00ADAB1E File Offset: 0x00AD8D1E
		// (set) Token: 0x06026C93 RID: 158867 RVA: 0x00ADAB26 File Offset: 0x00AD8D26
		public int GridIndex { get; set; }

		// Token: 0x17004F88 RID: 20360
		// (get) Token: 0x06026C94 RID: 158868 RVA: 0x00ADAB2F File Offset: 0x00AD8D2F
		// (set) Token: 0x06026C95 RID: 158869 RVA: 0x00ADAB37 File Offset: 0x00AD8D37
		public int DisplayIndex { get; set; }

		// Token: 0x06026C96 RID: 158870 RVA: 0x00ADAB40 File Offset: 0x00AD8D40
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

		// Token: 0x06026C97 RID: 158871 RVA: 0x00ADAB74 File Offset: 0x00AD8D74
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06026C98 RID: 158872 RVA: 0x00ADAB76 File Offset: 0x00AD8D76
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06026C99 RID: 158873 RVA: 0x00ADAB78 File Offset: 0x00AD8D78
		public object GetKey(PhantomSmallItemGrid data, int displayIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x06026C9A RID: 158874 RVA: 0x00ADAB88 File Offset: 0x00AD8D88
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

		// Token: 0x06026C9B RID: 158875 RVA: 0x00ADACF4 File Offset: 0x00AD8EF4
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefencePhantomIconItem.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefencePhantomIconItem.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026C9C RID: 158876 RVA: 0x00ADAD37 File Offset: 0x00AD8F37
		public void Refresh(PhantomSmallItemGrid data, bool isSelected, int gridIndex)
		{
			this.RefreshInternalAsync(data, isSelected, gridIndex);
		}

		// Token: 0x06026C9D RID: 158877 RVA: 0x00ADAD44 File Offset: 0x00AD8F44
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

		// Token: 0x06026C9E RID: 158878 RVA: 0x00ADAD90 File Offset: 0x00AD8F90
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

		// Token: 0x06026C9F RID: 158879 RVA: 0x00ADADDB File Offset: 0x00AD8FDB
		private void OnClick(EToggleState toggleState)
		{
			EventSystem.Instance.Emit<int>(EEventName.TowerDefenseOnClickOnePhantom, this.CachedTowerDefencePhantomId);
		}

		// Token: 0x04015370 RID: 86896
		private int CachedTowerDefencePhantomId;

		// Token: 0x04015371 RID: 86897
		private TowerDefensePhantomIconCornerMark CornerMark;

		// Token: 0x04015372 RID: 86898
		private TowerDefensePhantomUnavailableMask OccupiedMask;

		// Token: 0x020096F8 RID: 38648
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402F1F9 RID: 193017
			public const int QualitySprite = 0;

			// Token: 0x0402F1FA RID: 193018
			public const int IconTexture = 1;

			// Token: 0x0402F1FB RID: 193019
			public const int NameItem = 2;

			// Token: 0x0402F1FC RID: 193020
			public const int NameText = 3;

			// Token: 0x0402F1FD RID: 193021
			public const int BackgroundSprite = 4;

			// Token: 0x0402F1FE RID: 193022
			public const int BottomItem = 5;

			// Token: 0x0402F1FF RID: 193023
			public const int LockItem = 6;

			// Token: 0x0402F200 RID: 193024
			public const int Root = 7;
		}
	}
}
