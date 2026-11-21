using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005160 RID: 20832
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabDynamicScrollItem : UiPanelBase, IDynamicScrollItem<RoadBookAreaData>
	{
		// Token: 0x060340DF RID: 213215 RVA: 0x00E900D2 File Offset: 0x00E8E2D2
		public RoadBookTabDynamicScrollItem(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x060340E0 RID: 213216 RVA: 0x00E900E4 File Offset: 0x00E8E2E4
		public UniTask Init(UUIItem actor)
		{
			RoadBookTabDynamicScrollItem.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoadBookTabDynamicScrollItem.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060340E1 RID: 213217 RVA: 0x00E9012F File Offset: 0x00E8E32F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060340E2 RID: 213218 RVA: 0x00E90168 File Offset: 0x00E8E368
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookTabDynamicScrollItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookTabDynamicScrollItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060340E3 RID: 213219 RVA: 0x00E901AB File Offset: 0x00E8E3AB
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(RoadBookAreaData data)
		{
			if (data.IsUnlock)
			{
				return this.GetItemActor(EComponents.LockItem);
			}
			return this.GetItemActor(EComponents.NormalItem);
		}

		// Token: 0x060340E4 RID: 213220 RVA: 0x00E901C4 File Offset: 0x00E8E3C4
		private AUIBaseActor GetItemActor(EComponents key)
		{
			return base.GetItem((int)key).GetOwner() as AUIBaseActor;
		}

		// Token: 0x060340E5 RID: 213221 RVA: 0x00E901D8 File Offset: 0x00E8E3D8
		public void Update(RoadBookAreaData data, int index)
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
			Func<RoadBookAreaData, int, bool> isSelectedOn = this.IsSelectedOn;
			if (isSelectedOn != null && isSelectedOn(data, index))
			{
				this.SetSelected(true, false);
				return;
			}
			this.SetSelected(false, false);
		}

		// Token: 0x060340E6 RID: 213222 RVA: 0x00E9025C File Offset: 0x00E8E45C
		public void SetSelected(bool bOn, bool bFireEvent)
		{
			this.LockItem.SetToggleState(bOn, bFireEvent && !this.Data.IsUnlock);
			this.NormalItem.SetToggleState(bOn, bFireEvent && this.Data.IsUnlock);
		}

		// Token: 0x060340E7 RID: 213223 RVA: 0x00E9029B File Offset: 0x00E8E49B
		public void BindSelectedCallBack(Action<RoadBookAreaData, int> selectCallback)
		{
			this.SelectedCallBack = selectCallback;
		}

		// Token: 0x060340E8 RID: 213224 RVA: 0x00E902A4 File Offset: 0x00E8E4A4
		public void BindIsSelectedOn(Func<RoadBookAreaData, int, bool> isSelectedOn)
		{
			this.IsSelectedOn = isSelectedOn;
		}

		// Token: 0x060340E9 RID: 213225 RVA: 0x00E902AD File Offset: 0x00E8E4AD
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0401B8F1 RID: 112881
		[Nullable(2)]
		private RoadBookTabItem NormalItem;

		// Token: 0x0401B8F2 RID: 112882
		[Nullable(2)]
		private RoadBookTabItemLock LockItem;

		// Token: 0x0401B8F3 RID: 112883
		[Nullable(2)]
		protected RoadBookAreaData Data;

		// Token: 0x0401B8F4 RID: 112884
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<RoadBookAreaData, int> SelectedCallBack;

		// Token: 0x0401B8F5 RID: 112885
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Func<RoadBookAreaData, int, bool> IsSelectedOn;

		// Token: 0x0401B8F6 RID: 112886
		protected ActivityRoadBookData ActivityBaseData;
	}
}
