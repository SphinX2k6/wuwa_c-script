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
	// Token: 0x02005170 RID: 20848
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AreaLayout : GridProxyAbstract<AreaLayoutItemData>, IDynamicScrollItem<AreaLayoutItemData>
	{
		// Token: 0x06034130 RID: 213296 RVA: 0x00E91704 File Offset: 0x00E8F904
		public AreaLayout(ActivityRoadBookData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x06034131 RID: 213297 RVA: 0x00E91714 File Offset: 0x00E8F914
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

		// Token: 0x06034132 RID: 213298 RVA: 0x00E917DC File Offset: 0x00E8F9DC
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

		// Token: 0x06034133 RID: 213299 RVA: 0x00E91827 File Offset: 0x00E8FA27
		public void Update(AreaLayoutItemData data, int index)
		{
			this.Refresh(data, false, index);
		}

		// Token: 0x06034134 RID: 213300 RVA: 0x00E91832 File Offset: 0x00E8FA32
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

		// Token: 0x06034135 RID: 213301 RVA: 0x00E91864 File Offset: 0x00E8FA64
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

		// Token: 0x06034136 RID: 213302 RVA: 0x00E91A08 File Offset: 0x00E8FC08
		private void RefreshTask(ActivityTaskData taskData)
		{
			base.GetItem(4).SetUIActive(false);
			base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(true);
			this.NormalItem.Refresh(taskData, false, 0);
		}

		// Token: 0x06034137 RID: 213303 RVA: 0x00E91A4C File Offset: 0x00E8FC4C
		public void PlayUnlockAnim()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Unlock", true, null, false);
		}

		// Token: 0x06034138 RID: 213304 RVA: 0x00E91A74 File Offset: 0x00E8FC74
		[NullableContext(2)]
		public UUIItem GetFirstItem()
		{
			return this.TaskLayout.GetItemByIndex(0);
		}

		// Token: 0x06034139 RID: 213305 RVA: 0x00E91A82 File Offset: 0x00E8FC82
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(AreaLayoutItemData data)
		{
			if (data.IsTitle)
			{
				return base.GetItem(4).GetOwner() as AUIBaseActor;
			}
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0603413A RID: 213306 RVA: 0x00E91AAE File Offset: 0x00E8FCAE
		public void ClearItem()
		{
		}

		// Token: 0x0603413B RID: 213307 RVA: 0x00E91AB0 File Offset: 0x00E8FCB0
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

		// Token: 0x0401B937 RID: 112951
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RoadBookTaskNormalItem, ActivityTaskData> TaskLayout;

		// Token: 0x0401B938 RID: 112952
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B939 RID: 112953
		[Nullable(2)]
		private RoadBookTaskLockItem LockItem;

		// Token: 0x0401B93A RID: 112954
		[Nullable(2)]
		private RoadBookTaskNormalItem NormalItem;

		// Token: 0x0401B93B RID: 112955
		[Nullable(2)]
		private RoadBookAreaData AreaData;

		// Token: 0x0401B93C RID: 112956
		protected ActivityRoadBookData ActivityBaseData;
	}
}
