using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061F2 RID: 25074
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AreaLayout : GridProxyAbstract<AreaLayoutItemData>, IDynamicScrollItem<AreaLayoutItemData>
	{
		// Token: 0x0603F46F RID: 259183 RVA: 0x00F4A7AC File Offset: 0x00F489AC
		public AreaLayout(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x0603F470 RID: 259184 RVA: 0x00F4A7BC File Offset: 0x00F489BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUITexture))
			};
		}

		// Token: 0x0603F471 RID: 259185 RVA: 0x00F4A884 File Offset: 0x00F48A84
		public UniTask Init(UUIItem actor)
		{
			AreaLayout.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<AreaLayout.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603F472 RID: 259186 RVA: 0x00F4A8CF File Offset: 0x00F48ACF
		public void Update(AreaLayoutItemData data, int index)
		{
			this.Refresh(data, false, index);
		}

		// Token: 0x0603F473 RID: 259187 RVA: 0x00F4A8DA File Offset: 0x00F48ADA
		public override void Refresh(AreaLayoutItemData data, bool isSelected, int gridIndex)
		{
			this.AreaData = data.AreaData;
			if (data.IsTitle)
			{
				this.RefreshTitle(data.AreaData);
				return;
			}
			this.RefreshTask(data.TaskData);
		}

		// Token: 0x0603F474 RID: 259188 RVA: 0x00F4A90C File Offset: 0x00F48B0C
		private void RefreshTitle(RoadBookAreaData areaData)
		{
			Area value = AreaConfig.Instance.GetAreaInfo(areaData.AreaId).Value;
			base.GetItem(4).SetUIActive(true);
			base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Title, Array.Empty<object>());
			bool uiactive = true;
			foreach (int key in areaData.TravelTaskIdSet)
			{
				ActivityTaskData activityTaskData;
				if (this.ActivityBaseData.AreaTaskMap.TryGetValue(key, out activityTaskData) && activityTaskData.Status != EActivityTaskState.FinishedAndClaimed)
				{
					uiactive = false;
					break;
				}
			}
			UUIItem text = base.GetText(0);
			bool bUseChangeColor = !areaData.IsUnlock;
			FColor? fcolor = new FColor?(base.GetText(0).changeColor);
			text.SetChangeColor(bUseChangeColor, fcolor);
			UUIItem texture = base.GetTexture(7);
			bool bUseChangeColor2 = !areaData.IsUnlock;
			fcolor = new FColor?(base.GetTexture(7).changeColor);
			texture.SetChangeColor(bUseChangeColor2, fcolor);
			base.GetItem(3).SetUIActive(!areaData.IsUnlock);
			base.GetItem(6).SetUIActive(uiactive);
			if (!areaData.IsUnlock)
			{
				RoadBookLockAreaData roadBookLockAreaData = new RoadBookLockAreaData(areaData.AreaId);
				RoadBookArea value2 = ActivityRoadBookConfig.Instance.GetAreaConfig(areaData.AreaId).Value;
				roadBookLockAreaData.ConditionGroupId = value2.UnLockCondition;
				roadBookLockAreaData.JumpId = value2.UnlockAccessId;
				this.LockItem.Refresh(roadBookLockAreaData, false, 0);
			}
		}

		// Token: 0x0603F475 RID: 259189 RVA: 0x00F4AAB0 File Offset: 0x00F48CB0
		private void RefreshTask(ActivityTaskData taskData)
		{
			base.GetItem(4).SetUIActive(false);
			base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(true);
			this.NormalItem.Refresh(taskData, false, 0);
		}

		// Token: 0x0603F476 RID: 259190 RVA: 0x00F4AAF4 File Offset: 0x00F48CF4
		public void PlayUnlockAnim()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Unlock", true, null, false);
		}

		// Token: 0x0603F477 RID: 259191 RVA: 0x00F4AB1C File Offset: 0x00F48D1C
		[NullableContext(2)]
		public UUIItem GetFirstItem()
		{
			return this.TaskLayout.GetItemByIndex(0);
		}

		// Token: 0x0603F478 RID: 259192 RVA: 0x00F4AB2A File Offset: 0x00F48D2A
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(AreaLayoutItemData data)
		{
			if (data.IsTitle)
			{
				return base.GetItem(4).GetOwner() as AUIBaseActor;
			}
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603F479 RID: 259193 RVA: 0x00F4AB56 File Offset: 0x00F48D56
		public void ClearItem()
		{
		}

		// Token: 0x0603F47A RID: 259194 RVA: 0x00F4AB58 File Offset: 0x00F48D58
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			this.LockItem = null;
			this.NormalItem = null;
			this.AreaData = null;
		}

		// Token: 0x04021008 RID: 135176
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RoadBookTaskNormalItem, ActivityTaskData> TaskLayout;

		// Token: 0x04021009 RID: 135177
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0402100A RID: 135178
		[Nullable(2)]
		private RoadBookTaskLockItem LockItem;

		// Token: 0x0402100B RID: 135179
		[Nullable(2)]
		private RoadBookTaskNormalItem NormalItem;

		// Token: 0x0402100C RID: 135180
		[Nullable(2)]
		private RoadBookAreaData AreaData;

		// Token: 0x0402100D RID: 135181
		protected ActivityRoadBookData ActivityBaseData;
	}
}
