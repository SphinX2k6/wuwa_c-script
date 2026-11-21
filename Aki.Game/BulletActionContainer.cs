using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022DE RID: 8926
[NullableContext(1)]
[Nullable(0)]
public class BulletActionContainer
{
	// Token: 0x06016074 RID: 90228 RVA: 0x006617CC File Offset: 0x0065F9CC
	public void Init(EBulletAction type, Type actionInfoClass, Type actionClass, bool isPersistentAction = false)
	{
		this.Type = type;
		this.ActionInfoClass = actionInfoClass;
		this.ActionClass = actionClass;
		this.IsPersistentAction = isPersistentAction;
		this.IsSimpleActionInfo = (this.ActionInfoClass == typeof(BulletActionInfoSimple));
		this.AllActionInfoList = new List<BulletActionInfoBase>();
		this.ActionInfoList = new List<BulletActionInfoBase>();
		BulletActionInfoBase bulletActionInfoBase = this.CreateActionInfo();
		bulletActionInfoBase.IsInPool = true;
		this.ActionInfoList.Add(bulletActionInfoBase);
		this.AllActionList = new List<BulletActionBase>();
		this.ActionList = new List<BulletActionBase>();
		BulletActionBase bulletActionBase = this.CreateAction();
		bulletActionBase.IsInPool = true;
		this.ActionList.Add(bulletActionBase);
	}

	// Token: 0x17002176 RID: 8566
	// (get) Token: 0x06016075 RID: 90229 RVA: 0x00661871 File Offset: 0x0065FA71
	public EBulletAction ActionType
	{
		get
		{
			return this.Type;
		}
	}

	// Token: 0x06016076 RID: 90230 RVA: 0x0066187C File Offset: 0x0065FA7C
	public void InitAsOverride(BulletActionContainer baseContainer, Type actionClass, bool isPersistentAction)
	{
		this.Type = baseContainer.Type;
		this.ActionInfoClass = baseContainer.ActionInfoClass;
		this.ActionClass = actionClass;
		this.IsPersistentAction = isPersistentAction;
		this.IsSimpleActionInfo = baseContainer.IsSimpleActionInfo;
		this.AllActionInfoList = baseContainer.AllActionInfoList;
		this.ActionInfoList = baseContainer.ActionInfoList;
		this.AllActionList = new List<BulletActionBase>();
		this.ActionList = new List<BulletActionBase>();
		BulletActionBase bulletActionBase = this.CreateAction();
		bulletActionBase.IsInPool = true;
		this.ActionList.Add(bulletActionBase);
	}

	// Token: 0x06016077 RID: 90231 RVA: 0x00661904 File Offset: 0x0065FB04
	private BulletActionInfoBase CreateActionInfo()
	{
		BulletActionInfoBase bulletActionInfoBase = (BulletActionInfoBase)Activator.CreateInstance(this.ActionInfoClass, new object[]
		{
			this.Type
		});
		bulletActionInfoBase.Index = this.AllActionInfoList.Count;
		this.AllActionInfoList.Add(bulletActionInfoBase);
		return bulletActionInfoBase;
	}

	// Token: 0x06016078 RID: 90232 RVA: 0x00661954 File Offset: 0x0065FB54
	public BulletActionInfoBase GetActionInfo()
	{
		if (this.IsSimpleActionInfo)
		{
			return this.ActionInfoList[0];
		}
		if (this.ActionInfoList.Count <= 0)
		{
			return this.CreateActionInfo();
		}
		BulletActionInfoBase bulletActionInfoBase = this.ActionInfoList[this.ActionInfoList.Count - 1];
		this.ActionInfoList.RemoveAt(this.ActionInfoList.Count - 1);
		bulletActionInfoBase.IsInPool = false;
		return bulletActionInfoBase;
	}

	// Token: 0x06016079 RID: 90233 RVA: 0x006619C4 File Offset: 0x0065FBC4
	private BulletActionBase CreateAction()
	{
		BulletActionBase bulletActionBase = (BulletActionBase)Activator.CreateInstance(this.ActionClass, new object[]
		{
			this.Type
		});
		bulletActionBase.Index = this.AllActionList.Count;
		this.AllActionList.Add(bulletActionBase);
		return bulletActionBase;
	}

	// Token: 0x0601607A RID: 90234 RVA: 0x00661A14 File Offset: 0x0065FC14
	public BulletActionBase GetAction()
	{
		if (!this.IsPersistentAction)
		{
			return this.ActionList[0];
		}
		if (this.ActionList.Count <= 0)
		{
			return this.CreateAction();
		}
		BulletActionBase bulletActionBase = this.ActionList[this.ActionList.Count - 1];
		this.ActionList.RemoveAt(this.ActionList.Count - 1);
		bulletActionBase.IsInPool = false;
		return bulletActionBase;
	}

	// Token: 0x0601607B RID: 90235 RVA: 0x00661A84 File Offset: 0x0065FC84
	public void RecycleActionInfo(BulletActionInfoBase actionInfo)
	{
		if (this.IsSimpleActionInfo)
		{
			return;
		}
		if (actionInfo.IsInPool)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "BulletActionInfo重复入池", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		actionInfo.Clear();
		actionInfo.IsInPool = true;
		this.ActionInfoList.Add(this.AllActionInfoList[actionInfo.Index]);
	}

	// Token: 0x0601607C RID: 90236 RVA: 0x00661AE8 File Offset: 0x0065FCE8
	public void RecycleAction(BulletActionBase action)
	{
		BulletActionInfoBase actionInfo = action.GetActionInfo();
		this.RecycleActionInfo(actionInfo);
		action.Clear();
		if (!this.IsPersistentAction)
		{
			return;
		}
		if (action.IsInPool)
		{
			Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "BulletAction重复入池", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		action.IsInPool = true;
		this.ActionList.Add(this.AllActionList[action.Index]);
	}

	// Token: 0x0400B8F2 RID: 47346
	private EBulletAction Type;

	// Token: 0x0400B8F3 RID: 47347
	[Nullable(2)]
	private Type ActionInfoClass;

	// Token: 0x0400B8F4 RID: 47348
	[Nullable(2)]
	private Type ActionClass;

	// Token: 0x0400B8F5 RID: 47349
	private bool IsPersistentAction;

	// Token: 0x0400B8F6 RID: 47350
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionInfoBase> AllActionInfoList;

	// Token: 0x0400B8F7 RID: 47351
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionInfoBase> ActionInfoList;

	// Token: 0x0400B8F8 RID: 47352
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionBase> AllActionList;

	// Token: 0x0400B8F9 RID: 47353
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionBase> ActionList;

	// Token: 0x0400B8FA RID: 47354
	private bool IsSimpleActionInfo;
}
