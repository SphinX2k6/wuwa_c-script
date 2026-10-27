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
	// Token: 0x020061E2 RID: 25058
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabDynamicScrollItem : UiPanelBase, IDynamicScrollItem<RoadBookAreaData>
	{
		// Token: 0x0603F41E RID: 259102 RVA: 0x00F4917A File Offset: 0x00F4737A
		public RoadBookTabDynamicScrollItem(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F41F RID: 259103 RVA: 0x00F4918C File Offset: 0x00F4738C
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

		// Token: 0x0603F420 RID: 259104 RVA: 0x00F491D7 File Offset: 0x00F473D7
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603F421 RID: 259105 RVA: 0x00F49210 File Offset: 0x00F47410
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookTabDynamicScrollItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookTabDynamicScrollItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F422 RID: 259106 RVA: 0x00F49253 File Offset: 0x00F47453
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(RoadBookAreaData data)
		{
			if (data.IsUnlock)
			{
				return this.GetItemActor(EComponents.LockItem);
			}
			return this.GetItemActor(EComponents.NormalItem);
		}

		// Token: 0x0603F423 RID: 259107 RVA: 0x00F4926C File Offset: 0x00F4746C
		private AUIBaseActor GetItemActor(EComponents key)
		{
			return base.GetItem((int)key).GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603F424 RID: 259108 RVA: 0x00F49280 File Offset: 0x00F47480
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

		// Token: 0x0603F425 RID: 259109 RVA: 0x00F49304 File Offset: 0x00F47504
		public void SetSelected(bool bOn, bool bFireEvent)
		{
			this.LockItem.SetToggleState(bOn, bFireEvent && !this.Data.IsUnlock);
			this.NormalItem.SetToggleState(bOn, bFireEvent && this.Data.IsUnlock);
		}

		// Token: 0x0603F426 RID: 259110 RVA: 0x00F49343 File Offset: 0x00F47543
		public void BindSelectedCallBack(Action<RoadBookAreaData, int> selectCallback)
		{
			this.SelectedCallBack = selectCallback;
		}

		// Token: 0x0603F427 RID: 259111 RVA: 0x00F4934C File Offset: 0x00F4754C
		public void BindIsSelectedOn(Func<RoadBookAreaData, int, bool> isSelectedOn)
		{
			this.IsSelectedOn = isSelectedOn;
		}

		// Token: 0x0603F428 RID: 259112 RVA: 0x00F49355 File Offset: 0x00F47555
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x04020FC2 RID: 135106
		[Nullable(2)]
		private RoadBookTabItem NormalItem;

		// Token: 0x04020FC3 RID: 135107
		[Nullable(2)]
		private RoadBookTabItemLock LockItem;

		// Token: 0x04020FC4 RID: 135108
		[Nullable(2)]
		protected RoadBookAreaData Data;

		// Token: 0x04020FC5 RID: 135109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<RoadBookAreaData, int> SelectedCallBack;

		// Token: 0x04020FC6 RID: 135110
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Func<RoadBookAreaData, int, bool> IsSelectedOn;

		// Token: 0x04020FC7 RID: 135111
		protected ActivityRoadBookData ActivityBaseData;
	}
}
