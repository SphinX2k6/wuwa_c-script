using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;

// Token: 0x020013FE RID: 5118
[NullableContext(1)]
[Nullable(0)]
public class StrengthHandle : HudUnitHandleBase
{
	// Token: 0x0600CB0E RID: 51982 RVA: 0x003C650C File Offset: 0x003C470C
	protected override void OnInitialize()
	{
		base.OnInitialize();
		base.NewHudUnit<StrengthUnit>(typeof(StrengthUnit), "UiItem_PhysicalBar", true, false).ContinueWith(delegate(StrengthUnit unit)
		{
			this.StrengthUnit = unit;
			if (this.StrengthUnit == null)
			{
				return;
			}
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData == null)
			{
				this.StrengthUnit.SetVisible(false, 0);
				return;
			}
			this.RefreshAfterStrengthUnitCreate();
			this.AddEntityEvents(curRoleData);
			this.StrengthUnit.RefreshRoleData(curRoleData);
			this.UpdateStrengthUnitByRole(curRoleData);
		});
	}

	// Token: 0x0600CB0F RID: 51983 RVA: 0x003C653D File Offset: 0x003C473D
	protected override void OnDestroyed()
	{
		this.StrengthUnit = null;
		if (this.CurrentEntity != null)
		{
			this.RemoveEntity(this.CurrentEntity);
		}
		base.OnDestroyed();
	}

	// Token: 0x0600CB10 RID: 51984 RVA: 0x003C6560 File Offset: 0x003C4760
	public override void OnShowHud()
	{
	}

	// Token: 0x0600CB11 RID: 51985 RVA: 0x003C6564 File Offset: 0x003C4764
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Add<EStrengthItemType>(EEventName.AddStrengthItem, new Action<EStrengthItemType>(this.OnAddStrengthItem));
		EventSystem.Instance.Add<EStrengthItemType>(EEventName.RemoveStrengthItem, new Action<EStrengthItemType>(this.OnRemoveStrengthItem));
	}

	// Token: 0x0600CB12 RID: 51986 RVA: 0x003C65E4 File Offset: 0x003C47E4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Remove<EStrengthItemType>(EEventName.AddStrengthItem, new Action<EStrengthItemType>(this.OnAddStrengthItem));
		EventSystem.Instance.Remove<EStrengthItemType>(EEventName.RemoveStrengthItem, new Action<EStrengthItemType>(this.OnRemoveStrengthItem));
		EventSystem.Instance.RemoveAllTargetUseKey(this);
	}

	// Token: 0x0600CB13 RID: 51987 RVA: 0x003C666D File Offset: 0x003C486D
	private void OnAddStrengthItem(EStrengthItemType strengthItemType)
	{
		if (!this.ExtraStrengthItemList.Contains(strengthItemType))
		{
			this.ExtraStrengthItemList.Add(strengthItemType);
		}
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.StrengthUnit.AddStrengthItem(strengthItemType);
	}

	// Token: 0x0600CB14 RID: 51988 RVA: 0x003C66A0 File Offset: 0x003C48A0
	private void OnRemoveStrengthItem(EStrengthItemType strengthItemType)
	{
		int num = this.ExtraStrengthItemList.IndexOf(strengthItemType);
		if (num >= 0)
		{
			this.ExtraStrengthItemList.RemoveAt(num);
		}
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.StrengthUnit.RemoveStrengthItem(strengthItemType);
	}

	// Token: 0x0600CB15 RID: 51989 RVA: 0x003C66E0 File Offset: 0x003C48E0
	private void OnChangeRole(int newEntityId, int oldEntityId)
	{
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (this.CurrentEntity != null)
		{
			this.RemoveEntity(this.CurrentEntity);
		}
		else
		{
			StrengthUnit strengthUnit = this.StrengthUnit;
			if (strengthUnit != null)
			{
				strengthUnit.SetVisible(true, 0);
			}
		}
		this.AddEntityEvents(curRoleData);
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.StrengthUnit.RefreshRoleData(curRoleData);
		this.UpdateStrengthUnitByRole(curRoleData);
	}

	// Token: 0x0600CB16 RID: 51990 RVA: 0x003C6744 File Offset: 0x003C4944
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (this.CurrentEntityId != handle.Id)
		{
			return;
		}
		this.RemoveEntity(handle);
	}

	// Token: 0x0600CB17 RID: 51991 RVA: 0x003C675C File Offset: 0x003C495C
	private void RemoveEntity(EntityHandle handle)
	{
		this.RemoveEntityEvents(handle);
		this.CurrentEntityId = 0;
		this.CurrentEntity = null;
		this.TagComponent = null;
	}

	// Token: 0x0600CB18 RID: 51992 RVA: 0x003C677C File Offset: 0x003C497C
	private void AddEntityEvents(BattleUiRoleData roleData)
	{
		int id = roleData.EntityHandle.Id;
		if (this.CurrentEntityId == id)
		{
			return;
		}
		this.CurrentEntityId = id;
		this.CurrentEntity = roleData.EntityHandle;
		EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, roleData.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		BaseTagComponent gameplayTagComponent = roleData.GameplayTagComponent;
		this.TagComponent = gameplayTagComponent;
		if (gameplayTagComponent == null)
		{
			return;
		}
		this.ListenForTagAddOrRemove(gameplayTagComponent, StrengthHandle.FlyTag, new Action<int, bool>(this.OnFlyTagChanged), false);
		this.ListenForTagAddOrRemove(gameplayTagComponent, StrengthHandle.FlyStrengthTag, new Action<int, bool>(this.OnFlyStrengthTagChanged), false);
		this.ListenForTagAddOrRemove(gameplayTagComponent, StrengthHandle.MotorcycleFlyTag, new Action<int, bool>(this.OnMotorcycleFlyTagChanged), false);
		this.ListenForTagAddOrRemove(gameplayTagComponent, GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏体力条"], new Action<int, bool>(this.OnHideChanged), true);
		this.ListenForTagAddOrRemove(gameplayTagComponent, GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.第一人称"], new Action<int, bool>(this.OnChangeToFirstPerson), true);
		this.ListenForTagAddOrRemove(gameplayTagComponent, GameplayTagDefine.EGameplayTagId["功能.功能制作.越肩模式"], new Action<int, bool>(this.OnOverShoulderView), true);
	}

	// Token: 0x0600CB19 RID: 51993 RVA: 0x003C689C File Offset: 0x003C4A9C
	private void RemoveEntityEvents(EntityHandle handle)
	{
		if (!handle.Valid)
		{
			return;
		}
		if (this.CurrentEntityId != handle.Id)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTargetUseKey<ERemoveEntityType, EntityHandle>(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0600CB1A RID: 51994 RVA: 0x003C6930 File Offset: 0x003C4B30
	private void ListenForTagAddOrRemove(BaseTagComponent tagComponent, int tagId, Action<int, bool> callback, bool checkExistImmediately = false)
	{
		if (checkExistImmediately)
		{
			callback(tagId, tagComponent.HasTag(tagId));
		}
		ITagTask tagTask = tagComponent.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), this.ListenTagStat);
		if (tagTask != null)
		{
			this.TagTaskList.Add(tagTask);
		}
	}

	// Token: 0x0600CB1B RID: 51995 RVA: 0x003C697D File Offset: 0x003C4B7D
	private void OnHideChanged(int tagId, bool tagExists)
	{
		StrengthUnit strengthUnit = this.StrengthUnit;
		if (strengthUnit == null)
		{
			return;
		}
		strengthUnit.SetVisible(!tagExists, 1);
	}

	// Token: 0x0600CB1C RID: 51996 RVA: 0x003C6994 File Offset: 0x003C4B94
	private void OnChangeToFirstPerson(int tagId, bool tagExists)
	{
		StrengthUnit strengthUnit = this.StrengthUnit;
		if (strengthUnit == null)
		{
			return;
		}
		strengthUnit.SetFirstPersonState(tagExists);
	}

	// Token: 0x0600CB1D RID: 51997 RVA: 0x003C69A7 File Offset: 0x003C4BA7
	private void OnOverShoulderView(int tagId, bool tagExists)
	{
		StrengthUnit strengthUnit = this.StrengthUnit;
		if (strengthUnit == null)
		{
			return;
		}
		strengthUnit.SetOverShoulderState(tagExists);
	}

	// Token: 0x0600CB1E RID: 51998 RVA: 0x003C69BA File Offset: 0x003C4BBA
	private void OnFlyTagChanged(int tagId, bool tagExists)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshFly();
	}

	// Token: 0x0600CB1F RID: 51999 RVA: 0x003C69CB File Offset: 0x003C4BCB
	private void OnFlyStrengthTagChanged(int tagId, bool tagExists)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshFly();
	}

	// Token: 0x0600CB20 RID: 52000 RVA: 0x003C69DC File Offset: 0x003C4BDC
	private void OnMotorcycleStateChanged(bool isDriving)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshMotorcycle();
	}

	// Token: 0x0600CB21 RID: 52001 RVA: 0x003C69ED File Offset: 0x003C4BED
	private void OnMotorcycleFlyTagChanged(int tagId, bool tagExists)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshMotorcycleFly();
	}

	// Token: 0x0600CB22 RID: 52002 RVA: 0x003C6A00 File Offset: 0x003C4C00
	private void RefreshFly()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent == null || !tagComponent.HasTag(StrengthHandle.FlyTag))
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 == null || !tagComponent2.HasTag(StrengthHandle.FlyStrengthTag))
			{
				this.StrengthUnit.RemoveStrengthItem(EStrengthItemType.Fly);
				return;
			}
		}
		this.StrengthUnit.AddStrengthItem(EStrengthItemType.Fly);
	}

	// Token: 0x0600CB23 RID: 52003 RVA: 0x003C6A58 File Offset: 0x003C4C58
	private void RefreshMotorcycle()
	{
		BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
		if (motorcycleData != null && motorcycleData.LastDriving)
		{
			this.StrengthUnit.AddStrengthItem(EStrengthItemType.Motorcycle);
			return;
		}
		this.StrengthUnit.RemoveStrengthItem(EStrengthItemType.Motorcycle);
	}

	// Token: 0x0600CB24 RID: 52004 RVA: 0x003C6A8B File Offset: 0x003C4C8B
	private void RefreshMotorcycleFly()
	{
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(StrengthHandle.MotorcycleFlyTag))
		{
			this.StrengthUnit.AddStrengthItem(EStrengthItemType.MotorcycleFly);
			return;
		}
		this.StrengthUnit.RemoveStrengthItem(EStrengthItemType.MotorcycleFly);
	}

	// Token: 0x0600CB25 RID: 52005 RVA: 0x003C6AC0 File Offset: 0x003C4CC0
	private void RefreshAfterStrengthUnitCreate()
	{
		if (this.TagComponent == null)
		{
			return;
		}
		foreach (EStrengthItemType strengthItemType in this.ExtraStrengthItemList)
		{
			this.StrengthUnit.AddStrengthItem(strengthItemType);
		}
	}

	// Token: 0x0600CB26 RID: 52006 RVA: 0x003C6B24 File Offset: 0x003C4D24
	private void UpdateStrengthUnitByRole(BattleUiRoleData roleData)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshFly();
		this.RefreshMotorcycle();
		this.RefreshMotorcycleFly();
	}

	// Token: 0x04007336 RID: 29494
	private readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]StrengthHandle", "", "");

	// Token: 0x04007337 RID: 29495
	private readonly Stat ListenTagStat = Stat.Create("[StrengthHandle]ListenTag", "", "");

	// Token: 0x04007338 RID: 29496
	private static readonly int FlyTag = GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"];

	// Token: 0x04007339 RID: 29497
	private static readonly int FlyStrengthTag = GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力显示"];

	// Token: 0x0400733A RID: 29498
	private static readonly int MotorcycleFlyTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态.翱翔"];

	// Token: 0x0400733B RID: 29499
	[Nullable(2)]
	private StrengthUnit StrengthUnit;

	// Token: 0x0400733C RID: 29500
	private int CurrentEntityId;

	// Token: 0x0400733D RID: 29501
	[Nullable(2)]
	private EntityHandle CurrentEntity;

	// Token: 0x0400733E RID: 29502
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400733F RID: 29503
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x04007340 RID: 29504
	private readonly List<EStrengthItemType> ExtraStrengthItemList = new List<EStrengthItemType>();
}
