using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022DD RID: 8925
[NullableContext(1)]
[Nullable(0)]
public class BulletActionCenter
{
	// Token: 0x06016068 RID: 90216 RVA: 0x00661382 File Offset: 0x0065F582
	public void Init()
	{
		this.InitActions();
	}

	// Token: 0x06016069 RID: 90217 RVA: 0x0066138C File Offset: 0x0065F58C
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

	// Token: 0x0601606A RID: 90218 RVA: 0x006613F8 File Offset: 0x0065F5F8
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

	// Token: 0x0601606B RID: 90219 RVA: 0x00661494 File Offset: 0x0065F694
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

	// Token: 0x0601606C RID: 90220 RVA: 0x006614EC File Offset: 0x0065F6EC
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

	// Token: 0x0601606D RID: 90221 RVA: 0x00661744 File Offset: 0x0065F944
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

	// Token: 0x0601606E RID: 90222 RVA: 0x00661776 File Offset: 0x0065F976
	public BulletActionContainer GetBulletActionContainer(EBulletAction type)
	{
		return this.BulletActionContainerList[(int)type];
	}

	// Token: 0x0601606F RID: 90223 RVA: 0x00661780 File Offset: 0x0065F980
	public BulletActionInfoBase CreateBulletActionInfo(EBulletAction type)
	{
		return this.GetBulletActionContainer(type).GetActionInfo();
	}

	// Token: 0x06016070 RID: 90224 RVA: 0x0066178E File Offset: 0x0065F98E
	public void RecycleBulletActionInfo(BulletActionInfoBase actionInfo)
	{
		this.GetBulletActionContainer(actionInfo.Type).RecycleActionInfo(actionInfo);
	}

	// Token: 0x06016071 RID: 90225 RVA: 0x006617A2 File Offset: 0x0065F9A2
	public BulletActionBase CreateBulletAction(EBulletAction type)
	{
		return this.GetBulletActionContainer(type).GetAction();
	}

	// Token: 0x06016072 RID: 90226 RVA: 0x006617B0 File Offset: 0x0065F9B0
	public void RecycleBulletAction(BulletActionBase action)
	{
		this.GetBulletActionContainer(action.Type).RecycleAction(action);
	}

	// Token: 0x0400B8F0 RID: 47344
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private BulletActionContainer[] BulletActionContainerList;

	// Token: 0x0400B8F1 RID: 47345
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<List<BulletActionOverride>, BulletActionCenter> VariantCenterMap;
}
