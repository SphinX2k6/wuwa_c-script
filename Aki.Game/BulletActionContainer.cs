using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02002D84 RID: 11652
[NullableContext(1)]
[Nullable(0)]
public class BulletActionContainer
{
	// Token: 0x060187D2 RID: 100306 RVA: 0x0063B7BC File Offset: 0x006399BC
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

	// Token: 0x1700211B RID: 8475
	// (get) Token: 0x060187D3 RID: 100307 RVA: 0x0063B861 File Offset: 0x00639A61
	public EBulletAction ActionType
	{
		get
		{
			return this.Type;
		}
	}

	// Token: 0x060187D4 RID: 100308 RVA: 0x0063B86C File Offset: 0x00639A6C
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

	// Token: 0x060187D5 RID: 100309 RVA: 0x0063B8F4 File Offset: 0x00639AF4
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

	// Token: 0x060187D6 RID: 100310 RVA: 0x0063B944 File Offset: 0x00639B44
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

	// Token: 0x060187D7 RID: 100311 RVA: 0x0063B9B4 File Offset: 0x00639BB4
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

	// Token: 0x060187D8 RID: 100312 RVA: 0x0063BA04 File Offset: 0x00639C04
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

	// Token: 0x060187D9 RID: 100313 RVA: 0x0063BA74 File Offset: 0x00639C74
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

	// Token: 0x060187DA RID: 100314 RVA: 0x0063BAD8 File Offset: 0x00639CD8
	public unsafe void RecycleAction(BulletActionBase action)
	{
		BulletActionInfoBase actionInfo = action.GetActionInfo();
		this.RecycleActionInfo(actionInfo);
		action.Clear();
		if (BulletConstant.Instance.OpenClearCheck)
		{
			foreach (PropertyInfo propertyInfo in actionInfo.GetType().GetProperties())
			{
				object value = propertyInfo.GetValue(actionInfo);
				Type propertyType = propertyInfo.PropertyType;
				if ((!(propertyType == typeof(int)) || (int)value != 0) && (!(propertyType == typeof(bool)) || (bool)value) && value != null && !(propertyInfo.Name == "Type") && !(propertyInfo.Name == "Index") && !(propertyInfo.Name == "IsInPool") && !(propertyInfo.Name == "Stat") && !(propertyInfo.Name == "TickStat") && !(propertyType.GetMethod("Invoke") != null))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Bullet;
					ELogAuthor author = ELogAuthor.CFT;
					string message = "BulletActionInfo回收时，该变量不为undefined";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", actionInfo.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", propertyInfo.Name);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			foreach (PropertyInfo propertyInfo2 in action.GetType().GetProperties())
			{
				object value2 = propertyInfo2.GetValue(action);
				Type propertyType2 = propertyInfo2.PropertyType;
				if ((!(propertyType2 == typeof(int)) || (int)value2 != 0) && (!(propertyType2 == typeof(bool)) || (bool)value2) && value2 != null && !(propertyInfo2.Name == "Type") && !(propertyInfo2.Name == "Index") && !(propertyInfo2.Name == "IsInPool") && !(propertyInfo2.Name == "Stat") && !(propertyInfo2.Name == "TickStat") && !(propertyType2.GetMethod("Invoke") != null))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Bullet;
					ELogAuthor author2 = ELogAuthor.CFT;
					string message2 = "BulletAction回收时，该变量不为undefined";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("type", action.Type);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("key", propertyInfo2.Name);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
			}
		}
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

	// Token: 0x0400B57D RID: 46461
	private EBulletAction Type;

	// Token: 0x0400B57E RID: 46462
	[Nullable(2)]
	private Type ActionInfoClass;

	// Token: 0x0400B57F RID: 46463
	[Nullable(2)]
	private Type ActionClass;

	// Token: 0x0400B580 RID: 46464
	private bool IsPersistentAction;

	// Token: 0x0400B581 RID: 46465
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionInfoBase> AllActionInfoList;

	// Token: 0x0400B582 RID: 46466
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionInfoBase> ActionInfoList;

	// Token: 0x0400B583 RID: 46467
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionBase> AllActionList;

	// Token: 0x0400B584 RID: 46468
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletActionBase> ActionList;

	// Token: 0x0400B585 RID: 46469
	private bool IsSimpleActionInfo;
}
