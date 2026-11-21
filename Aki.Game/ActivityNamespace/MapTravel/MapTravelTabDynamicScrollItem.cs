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
	// Token: 0x02002F5E RID: 12126
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelTabDynamicScrollItem : UiPanelBase, IDynamicScrollItem<MapTravelAreaData>
	{
		// Token: 0x0601CB8A RID: 117642 RVA: 0x008C42FF File Offset: 0x008C24FF
		public MapTravelTabDynamicScrollItem(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0601CB8B RID: 117643 RVA: 0x008C4310 File Offset: 0x008C2510
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

		// Token: 0x0601CB8C RID: 117644 RVA: 0x008C435C File Offset: 0x008C255C
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

		// Token: 0x0601CB8D RID: 117645 RVA: 0x008C43C8 File Offset: 0x008C25C8
		protected override UniTask OnBeforeStartAsync()
		{
			MapTravelTabDynamicScrollItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelTabDynamicScrollItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601CB8E RID: 117646 RVA: 0x008C440B File Offset: 0x008C260B
		public AUIBaseActor GetUsingItem(MapTravelAreaData data)
		{
			if (data.IsUnlock)
			{
				return this.GetItemActor(1);
			}
			return this.GetItemActor(0);
		}

		// Token: 0x0601CB8F RID: 117647 RVA: 0x008C4424 File Offset: 0x008C2624
		private AUIBaseActor GetItemActor(int key)
		{
			return base.GetItem(key).GetOwner() as AUIBaseActor;
		}

		// Token: 0x0601CB90 RID: 117648 RVA: 0x008C4438 File Offset: 0x008C2638
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

		// Token: 0x0601CB91 RID: 117649 RVA: 0x008C44BC File Offset: 0x008C26BC
		public void SetSelected(bool bOn, bool bFireEvent)
		{
			this.LockItem.SetToggleState(bOn, bFireEvent && !this.Data.IsUnlock);
			this.NormalItem.SetToggleState(bOn, bFireEvent && this.Data.IsUnlock);
		}

		// Token: 0x0601CB92 RID: 117650 RVA: 0x008C44FB File Offset: 0x008C26FB
		public void BindSelectedCallBack(Action<MapTravelAreaData, int> selectCallback)
		{
			this.SelectedCallBack = selectCallback;
		}

		// Token: 0x0601CB93 RID: 117651 RVA: 0x008C4504 File Offset: 0x008C2704
		public void BindIsSelectedOn(Func<MapTravelAreaData, int, bool> isSelectedOn)
		{
			this.IsSelectedOn = isSelectedOn;
		}

		// Token: 0x0601CB94 RID: 117652 RVA: 0x008C450D File Offset: 0x008C270D
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0400F21C RID: 61980
		[Nullable(2)]
		private MapTravelTabItem NormalItem;

		// Token: 0x0400F21D RID: 61981
		[Nullable(2)]
		private MapTravelTabItemLock LockItem;

		// Token: 0x0400F21E RID: 61982
		[Nullable(2)]
		protected MapTravelAreaData Data;

		// Token: 0x0400F21F RID: 61983
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<MapTravelAreaData, int> SelectedCallBack;

		// Token: 0x0400F220 RID: 61984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Func<MapTravelAreaData, int, bool> IsSelectedOn;

		// Token: 0x0400F221 RID: 61985
		protected ActivityMapTravelData ActivityBaseData;

		// Token: 0x02008BEB RID: 35819
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402C52D RID: 181549
			public const int NormalItem = 0;

			// Token: 0x0402C52E RID: 181550
			public const int LockItem = 1;
		}
	}
}
