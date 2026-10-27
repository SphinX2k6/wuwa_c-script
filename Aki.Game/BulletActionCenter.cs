using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002D83 RID: 11651
[NullableContext(1)]
[Nullable(0)]
public class BulletActionCenter
{
	// Token: 0x060187C6 RID: 100294 RVA: 0x0063B372 File Offset: 0x00639572
	public void Init()
	{
		this.InitActions();
	}

	// Token: 0x060187C7 RID: 100295 RVA: 0x0063B37C File Offset: 0x0063957C
	public void Clear()
	{
		if (this.VariantCenterMap != null)
		{
			foreach (BulletActionCenter bulletActionCenter in this.VariantCenterMap.Values)
			{
				bulletActionCenter.Clear();
			}
			this.VariantCenterMap = null;
		}
		this.BulletActionContainerList = null;
	}

	// Token: 0x060187C8 RID: 100296 RVA: 0x0063B3E8 File Offset: 0x006395E8
	private void InitAsVariant(BulletActionCenter baseCenter, List<BulletActionOverride> overrides)
	{
		BulletActionContainer[] bulletActionContainerList = baseCenter.BulletActionContainerList;
		this.BulletActionContainerList = new BulletActionContainer[bulletActionContainerList.Length];
		Array.Copy(bulletActionContainerList, this.BulletActionContainerList, bulletActionContainerList.Length);
		foreach (BulletActionOverride bulletActionOverride in overrides)
		{
			BulletActionContainer bulletActionContainer = new BulletActionContainer();
			bulletActionContainer.InitAsOverride(bulletActionContainerList[(int)bulletActionOverride.Type], bulletActionOverride.ActionClass, bulletActionOverride.IsPersistentAction);
			this.BulletActionContainerList[(int)bulletActionOverride.Type] = bulletActionContainer;
		}
	}

	// Token: 0x060187C9 RID: 100297 RVA: 0x0063B484 File Offset: 0x00639684
	public BulletActionCenter GetVariant(List<BulletActionOverride> overrides)
	{
		BulletActionCenter result;
		if (this.VariantCenterMap != null && this.VariantCenterMap.TryGetValue(overrides, out result))
		{
			return result;
		}
		if (this.VariantCenterMap == null)
		{
			this.VariantCenterMap = new Dictionary<List<BulletActionOverride>, BulletActionCenter>();
		}
		BulletActionCenter bulletActionCenter = new BulletActionCenter();
		bulletActionCenter.InitAsVariant(this, overrides);
		this.VariantCenterMap[overrides] = bulletActionCenter;
		return bulletActionCenter;
	}

	// Token: 0x060187CA RID: 100298 RVA: 0x0063B4DC File Offset: 0x006396DC
	private void InitActions()
	{
		this.BulletActionContainerList = new BulletActionContainer[20];
		this.InitAction(EBulletAction.Test, typeof(BulletActionInfoSimple), typeof(BulletActionTest), false);
		this.InitAction(EBulletAction.InitBullet, typeof(BulletActionInfoSimple), typeof(BulletActionInitBullet), false);
		this.InitAction(EBulletAction.InitHit, typeof(BulletActionInfoSimple), typeof(BulletActionInitHit), false);
		this.InitAction(EBulletAction.InitMove, typeof(BulletActionInfoSimple), typeof(BulletActionInitMove), false);
		this.InitAction(EBulletAction.InitRender, typeof(BulletActionInfoSimple), typeof(BulletActionInitRender), true);
		this.InitAction(EBulletAction.TimeScale, typeof(BulletActionInfoSimple), typeof(BulletActionTimeScale), true);
		this.InitAction(EBulletAction.AfterInit, typeof(BulletActionInfoSimple), typeof(BulletActionAfterInit), false);
		this.InitAction(EBulletAction.InitCollision, typeof(BulletActionInfoSimple), typeof(BulletActionInitCollision), false);
		this.InitAction(EBulletAction.UpdateEffect, typeof(BulletActionInfoSimple), typeof(BulletActionUpdateEffect), true);
		this.InitAction(EBulletAction.UpdateAttackerFrozen, typeof(BulletActionInfoSimple), typeof(BulletActionUpdateAttackerFrozen), true);
		this.InitAction(EBulletAction.UpdateLiveTime, typeof(BulletActionInfoSimple), typeof(BulletActionUpdateLiveTime), true);
		this.InitAction(EBulletAction.Child, typeof(BulletActionInfoSimple), typeof(BulletActionChild), true);
		this.InitAction(EBulletAction.SummonBullet, typeof(BulletActionInfoSummonBullet), typeof(BulletActionSummonBullet), false);
		this.InitAction(EBulletAction.SummonEntity, typeof(BulletActionInfoSimple), typeof(BulletActionSummonEntity), false);
		this.InitAction(EBulletAction.DestroyBullet, typeof(BulletActionInfoDestroyBullet), typeof(BulletActionDestroyBullet), false);
		this.InitAction(EBulletAction.AttachActor, typeof(BulletActionInfoAttachActor), typeof(BulletActionAttachActor), false);
		this.InitAction(EBulletAction.AttachParentEffect, typeof(BulletActionInfoSimple), typeof(BulletActionAttachParentEffect), true);
		this.InitAction(EBulletAction.DelayDestroyBullet, typeof(BulletActionInfoDelayDestroyBullet), typeof(BulletActionDelayDestroyBullet), true);
		this.InitAction(EBulletAction.SceneInteract, typeof(BulletActionInfoSimple), typeof(BulletActionSceneInteract), true);
		this.InitAction(EBulletAction.UpdateKfc, typeof(BulletActionInfoSimple), typeof(BulletActionUpdateKfc), true);
	}

	// Token: 0x060187CB RID: 100299 RVA: 0x0063B734 File Offset: 0x00639934
	private void InitAction(EBulletAction type, Type actionInfoClass, Type actionClass, bool isPersistentAction = false)
	{
		if (this.BulletActionContainerList[(int)type] != null)
		{
			return;
		}
		BulletActionContainer bulletActionContainer = new BulletActionContainer();
		bulletActionContainer.Init(type, actionInfoClass, actionClass, isPersistentAction);
		this.BulletActionContainerList[(int)type] = bulletActionContainer;
	}

	// Token: 0x060187CC RID: 100300 RVA: 0x0063B766 File Offset: 0x00639966
	public BulletActionContainer GetBulletActionContainer(EBulletAction type)
	{
		return this.BulletActionContainerList[(int)type];
	}

	// Token: 0x060187CD RID: 100301 RVA: 0x0063B770 File Offset: 0x00639970
	public BulletActionInfoBase CreateBulletActionInfo(EBulletAction type)
	{
		return this.GetBulletActionContainer(type).GetActionInfo();
	}

	// Token: 0x060187CE RID: 100302 RVA: 0x0063B77E File Offset: 0x0063997E
	public void RecycleBulletActionInfo(BulletActionInfoBase actionInfo)
	{
		this.GetBulletActionContainer(actionInfo.Type).RecycleActionInfo(actionInfo);
	}

	// Token: 0x060187CF RID: 100303 RVA: 0x0063B792 File Offset: 0x00639992
	public BulletActionBase CreateBulletAction(EBulletAction type)
	{
		return this.GetBulletActionContainer(type).GetAction();
	}

	// Token: 0x060187D0 RID: 100304 RVA: 0x0063B7A0 File Offset: 0x006399A0
	public void RecycleBulletAction(BulletActionBase action)
	{
		this.GetBulletActionContainer(action.Type).RecycleAction(action);
	}

	// Token: 0x0400B57B RID: 46459
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private BulletActionContainer[] BulletActionContainerList;

	// Token: 0x0400B57C RID: 46460
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<List<BulletActionOverride>, BulletActionCenter> VariantCenterMap;
}
