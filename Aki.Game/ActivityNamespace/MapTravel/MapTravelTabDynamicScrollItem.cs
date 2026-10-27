using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x020044D1 RID: 17617
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelTabDynamicScrollItem : UiPanelBase, IDynamicScrollItem<MapTravelAreaData>
	{
		// Token: 0x0602D64C RID: 185932 RVA: 0x00A3E69F File Offset: 0x00A3C89F
		public MapTravelTabDynamicScrollItem(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0602D64D RID: 185933 RVA: 0x00A3E6B0 File Offset: 0x00A3C8B0
		public UniTask Init(UUIItem actor)
		{
			MapTravelTabDynamicScrollItem.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MapTravelTabDynamicScrollItem.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602D64E RID: 185934 RVA: 0x00A3E6FC File Offset: 0x00A3C8FC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D64F RID: 185935 RVA: 0x00A3E768 File Offset: 0x00A3C968
		protected override UniTask OnBeforeStartAsync()
		{
			MapTravelTabDynamicScrollItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelTabDynamicScrollItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D650 RID: 185936 RVA: 0x00A3E7AB File Offset: 0x00A3C9AB
		public AUIBaseActor GetUsingItem(MapTravelAreaData data)
		{
			if (data.IsUnlock)
			{
				return this.GetItemActor(1);
			}
			return this.GetItemActor(0);
		}

		// Token: 0x0602D651 RID: 185937 RVA: 0x00A3E7C4 File Offset: 0x00A3C9C4
		private AUIBaseActor GetItemActor(int key)
		{
			return base.GetItem(key).GetOwner() as AUIBaseActor;
		}

		// Token: 0x0602D652 RID: 185938 RVA: 0x00A3E7D8 File Offset: 0x00A3C9D8
		public void Update(MapTravelAreaData data, int index)
		{
			this.Data = data;
			this.LockItem.SetUiActive(!data.IsUnlock);
			this.NormalItem.SetUiActive(data.IsUnlock);
			if (!data.IsUnlock)
			{
				this.LockItem.RefreshByData(data, index);
			}
			else
			{
				this.NormalItem.RefreshByData(data, index);
			}
			Func<MapTravelAreaData, int, bool> isSelectedOn = this.IsSelectedOn;
			if (isSelectedOn != null && isSelectedOn(data, index))
			{
				this.SetSelected(true, false);
				return;
			}
			this.SetSelected(false, false);
		}

		// Token: 0x0602D653 RID: 185939 RVA: 0x00A3E85C File Offset: 0x00A3CA5C
		public void SetSelected(bool bOn, bool bFireEvent)
		{
			this.LockItem.SetToggleState(bOn, bFireEvent && !this.Data.IsUnlock);
			this.NormalItem.SetToggleState(bOn, bFireEvent && this.Data.IsUnlock);
		}

		// Token: 0x0602D654 RID: 185940 RVA: 0x00A3E89B File Offset: 0x00A3CA9B
		public void BindSelectedCallBack(Action<MapTravelAreaData, int> selectCallback)
		{
			this.SelectedCallBack = selectCallback;
		}

		// Token: 0x0602D655 RID: 185941 RVA: 0x00A3E8A4 File Offset: 0x00A3CAA4
		public void BindIsSelectedOn(Func<MapTravelAreaData, int, bool> isSelectedOn)
		{
			this.IsSelectedOn = isSelectedOn;
		}

		// Token: 0x0602D656 RID: 185942 RVA: 0x00A3E8AD File Offset: 0x00A3CAAD
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x04018474 RID: 99444
		[Nullable(2)]
		private MapTravelTabItem NormalItem;

		// Token: 0x04018475 RID: 99445
		[Nullable(2)]
		private MapTravelTabItemLock LockItem;

		// Token: 0x04018476 RID: 99446
		[Nullable(2)]
		protected MapTravelAreaData Data;

		// Token: 0x04018477 RID: 99447
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<MapTravelAreaData, int> SelectedCallBack;

		// Token: 0x04018478 RID: 99448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Func<MapTravelAreaData, int, bool> IsSelectedOn;

		// Token: 0x04018479 RID: 99449
		protected ActivityMapTravelData ActivityBaseData;

		// Token: 0x0200A715 RID: 42773
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403275F RID: 206687
			public const int NormalItem = 0;

			// Token: 0x04032760 RID: 206688
			public const int LockItem = 1;
		}
	}
}
