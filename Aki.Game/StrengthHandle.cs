using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;

// Token: 0x02001F3C RID: 7996
[NullableContext(1)]
[Nullable(0)]
public class StrengthHandle : HudUnitHandleBase
{
	// Token: 0x0600F6EF RID: 63215 RVA: 0x003BAA20 File Offset: 0x003B8C20
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

	// Token: 0x0600F6F0 RID: 63216 RVA: 0x003BAA51 File Offset: 0x003B8C51
	protected override void OnDestroyed()
	{
		this.StrengthUnit = null;
		if (this.CurrentEntity != null)
		{
			this.RemoveEntity(this.CurrentEntity);
		}
		base.OnDestroyed();
	}

	// Token: 0x0600F6F1 RID: 63217 RVA: 0x003BAA74 File Offset: 0x003B8C74
	public override void OnShowHud()
	{
	}

	// Token: 0x0600F6F2 RID: 63218 RVA: 0x003BAA78 File Offset: 0x003B8C78
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Add<EStrengthItemType>(EEventName.AddStrengthItem, new Action<EStrengthItemType>(this.OnAddStrengthItem));
		EventSystem.Instance.Add<EStrengthItemType>(EEventName.RemoveStrengthItem, new Action<EStrengthItemType>(this.OnRemoveStrengthItem));
	}

	// Token: 0x0600F6F3 RID: 63219 RVA: 0x003BAAF8 File Offset: 0x003B8CF8
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChangedNextTick, new Action<int, int>(this.OnChangeRole));
		EventSystem.Instance.Remove<EStrengthItemType>(EEventName.AddStrengthItem, new Action<EStrengthItemType>(this.OnAddStrengthItem));
		EventSystem.Instance.Remove<EStrengthItemType>(EEventName.RemoveStrengthItem, new Action<EStrengthItemType>(this.OnRemoveStrengthItem));
		EventSystem.Instance.RemoveAllTargetUseKey(this);
	}

	// Token: 0x0600F6F4 RID: 63220 RVA: 0x003BAB81 File Offset: 0x003B8D81
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

	// Token: 0x0600F6F5 RID: 63221 RVA: 0x003BABB4 File Offset: 0x003B8DB4
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

	// Token: 0x0600F6F6 RID: 63222 RVA: 0x003BABF4 File Offset: 0x003B8DF4
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

	// Token: 0x0600F6F7 RID: 63223 RVA: 0x003BAC58 File Offset: 0x003B8E58
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (this.CurrentEntityId != handle.Id)
		{
			return;
		}
		this.RemoveEntity(handle);
	}

	// Token: 0x0600F6F8 RID: 63224 RVA: 0x003BAC70 File Offset: 0x003B8E70
	private void RemoveEntity(EntityHandle handle)
	{
		this.RemoveEntityEvents(handle);
		this.CurrentEntityId = 0;
		this.CurrentEntity = null;
		this.TagComponent = null;
	}

	// Token: 0x0600F6F9 RID: 63225 RVA: 0x003BAC90 File Offset: 0x003B8E90
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

	// Token: 0x0600F6FA RID: 63226 RVA: 0x003BADB0 File Offset: 0x003B8FB0
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

	// Token: 0x0600F6FB RID: 63227 RVA: 0x003BAE44 File Offset: 0x003B9044
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

	// Token: 0x0600F6FC RID: 63228 RVA: 0x003BAE91 File Offset: 0x003B9091
	private void OnHideChanged(int tagId, bool tagExists)
	{
		StrengthUnit strengthUnit = this.StrengthUnit;
		if (strengthUnit == null)
		{
			return;
		}
		strengthUnit.SetVisible(!tagExists, 1);
	}

	// Token: 0x0600F6FD RID: 63229 RVA: 0x003BAEA8 File Offset: 0x003B90A8
	private void OnChangeToFirstPerson(int tagId, bool tagExists)
	{
		StrengthUnit strengthUnit = this.StrengthUnit;
		if (strengthUnit == null)
		{
			return;
		}
		strengthUnit.SetFirstPersonState(tagExists);
	}

	// Token: 0x0600F6FE RID: 63230 RVA: 0x003BAEBB File Offset: 0x003B90BB
	private void OnOverShoulderView(int tagId, bool tagExists)
	{
		StrengthUnit strengthUnit = this.StrengthUnit;
		if (strengthUnit == null)
		{
			return;
		}
		strengthUnit.SetOverShoulderState(tagExists);
	}

	// Token: 0x0600F6FF RID: 63231 RVA: 0x003BAECE File Offset: 0x003B90CE
	private void OnFlyTagChanged(int tagId, bool tagExists)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshFly();
	}

	// Token: 0x0600F700 RID: 63232 RVA: 0x003BAEDF File Offset: 0x003B90DF
	private void OnFlyStrengthTagChanged(int tagId, bool tagExists)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshFly();
	}

	// Token: 0x0600F701 RID: 63233 RVA: 0x003BAEF0 File Offset: 0x003B90F0
	private void OnMotorcycleStateChanged(bool isDriving)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshMotorcycle();
	}

	// Token: 0x0600F702 RID: 63234 RVA: 0x003BAF01 File Offset: 0x003B9101
	private void OnMotorcycleFlyTagChanged(int tagId, bool tagExists)
	{
		if (this.StrengthUnit == null)
		{
			return;
		}
		this.RefreshMotorcycleFly();
	}

	// Token: 0x0600F703 RID: 63235 RVA: 0x003BAF14 File Offset: 0x003B9114
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

	// Token: 0x0600F704 RID: 63236 RVA: 0x003BAF6C File Offset: 0x003B916C
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

	// Token: 0x0600F705 RID: 63237 RVA: 0x003BAF9F File Offset: 0x003B919F
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

	// Token: 0x0600F706 RID: 63238 RVA: 0x003BAFD4 File Offset: 0x003B91D4
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

	// Token: 0x0600F707 RID: 63239 RVA: 0x003BB038 File Offset: 0x003B9238
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

	// Token: 0x04007255 RID: 29269
	private readonly Stat ChangeRoleStat = Stat.Create("[ChangeRole]StrengthHandle", "", "");

	// Token: 0x04007256 RID: 29270
	private readonly Stat ListenTagStat = Stat.Create("[StrengthHandle]ListenTag", "", "");

	// Token: 0x04007257 RID: 29271
	private static readonly int FlyTag = GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"];

	// Token: 0x04007258 RID: 29272
	private static readonly int FlyStrengthTag = GameplayTagDefine.EGameplayTagId["功能.功能制作.翱翔体力显示"];

	// Token: 0x04007259 RID: 29273
	private static readonly int MotorcycleFlyTag = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态.翱翔"];

	// Token: 0x0400725A RID: 29274
	[Nullable(2)]
	private StrengthUnit StrengthUnit;

	// Token: 0x0400725B RID: 29275
	private int CurrentEntityId;

	// Token: 0x0400725C RID: 29276
	[Nullable(2)]
	private EntityHandle CurrentEntity;

	// Token: 0x0400725D RID: 29277
	[Nullable(2)]
	private BaseTagComponent TagComponent;

	// Token: 0x0400725E RID: 29278
	private readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x0400725F RID: 29279
	private readonly List<EStrengthItemType> ExtraStrengthItemList = new List<EStrengthItemType>();
}
