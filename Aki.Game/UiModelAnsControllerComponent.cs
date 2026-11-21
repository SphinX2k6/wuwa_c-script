using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021DB RID: 8667
[NullableContext(1)]
[Nullable(0)]
public class UiModelAnsControllerComponent : UiModelComponentBase
{
	// Token: 0x06015542 RID: 87362 RVA: 0x00633322 File Offset: 0x00631522
	protected override void OnInit()
	{
		this.NeedTick = true;
	}

	// Token: 0x06015543 RID: 87363 RVA: 0x0063332B File Offset: 0x0063152B
	public void RegisterAnsTrigger(Type ansContextType, Action<UiAnsContextBase> ansBeginCallBack, Action<UiAnsContextBase> ansEndCallBack, [Nullable(new byte[]
	{
		2,
		1
	})] Action<UiAnsContextBase> ansEffectPreHideCallBack = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<UiAnsContextBase> ansEffectPreHideRevertCallBack = null)
	{
		this.AnsContextTriggerMap[ansContextType] = new AnsContextTrigger(ansBeginCallBack, ansEndCallBack, ansEffectPreHideCallBack, ansEffectPreHideRevertCallBack);
	}

	// Token: 0x06015544 RID: 87364 RVA: 0x00633344 File Offset: 0x00631544
	public void AddAns(UiAnsContextBase value)
	{
		AnsContextSet<UiAnsContextBase> ansContextSet;
		if (!this.AnsContextMap.TryGetValue(value.GetType(), out ansContextSet))
		{
			ansContextSet = new AnsContextSet<UiAnsContextBase>();
			this.AnsContextMap[value.GetType()] = ansContextSet;
		}
		UiAnsContextBase uiAnsContextBase = ansContextSet.Has(value);
		bool flag = uiAnsContextBase != null;
		if (uiAnsContextBase == null)
		{
			ansContextSet.Add(value);
			uiAnsContextBase = value;
		}
		this.TryPushAnsContext(uiAnsContextBase);
		uiAnsContextBase.ExistCount++;
		AnsContextTrigger ansContextTrigger;
		if (flag && uiAnsContextBase.ExistCount == 1 && UiModelUtil.NeedPreHideAnsEffectOnEnd(uiAnsContextBase) && this.AnsContextTriggerMap.TryGetValue(uiAnsContextBase.GetType(), out ansContextTrigger))
		{
			Action<UiAnsContextBase> onEffectPreHideRevert = ansContextTrigger.OnEffectPreHideRevert;
			if (onEffectPreHideRevert == null)
			{
				return;
			}
			onEffectPreHideRevert(uiAnsContextBase);
		}
	}

	// Token: 0x06015545 RID: 87365 RVA: 0x006333E4 File Offset: 0x006315E4
	public void ReduceAns(UiAnsContextBase value)
	{
		AnsContextSet<UiAnsContextBase> ansContextSet;
		if (!this.AnsContextMap.TryGetValue(value.GetType(), out ansContextSet))
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LZK, "Ans不成对,Set不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiAnsContextBase uiAnsContextBase = ansContextSet.Has(value);
		if (uiAnsContextBase == null)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LZK, "Ans不成对,查找不到对应的AnsContext", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int existCount = uiAnsContextBase.ExistCount;
		if (existCount <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "Ans不成对,Ans数量为0,无法减少";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AnsCount", existCount);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.TryPushAnsContext(uiAnsContextBase);
		uiAnsContextBase.ExistCount--;
		AnsContextTrigger ansContextTrigger;
		if (uiAnsContextBase.ExistCount == 0 && UiModelUtil.NeedPreHideAnsEffectOnEnd(uiAnsContextBase) && this.AnsContextTriggerMap.TryGetValue(uiAnsContextBase.GetType(), out ansContextTrigger))
		{
			Action<UiAnsContextBase> onEffectPreHide = ansContextTrigger.OnEffectPreHide;
			if (onEffectPreHide == null)
			{
				return;
			}
			onEffectPreHide(uiAnsContextBase);
		}
	}

	// Token: 0x06015546 RID: 87366 RVA: 0x006334D0 File Offset: 0x006316D0
	private void TryPushAnsContext(UiAnsContextBase ansContext)
	{
		if (this.CurAnsSet.Has(ansContext) != null)
		{
			return;
		}
		this.CurAnsSet.Add(ansContext);
		ansContext.CacheCount = ansContext.ExistCount;
	}

	// Token: 0x06015547 RID: 87367 RVA: 0x006334FC File Offset: 0x006316FC
	public override void Tick(float deltaTime)
	{
		HashSet<UiAnsContextBase> contextSet = this.CurAnsSet.ContextSet;
		if (contextSet.Count > 0)
		{
			foreach (UiAnsContextBase uiAnsContextBase in contextSet)
			{
				int cacheCount = uiAnsContextBase.CacheCount;
				int existCount = uiAnsContextBase.ExistCount;
				if (cacheCount == 0 && existCount > 0)
				{
					AnsContextTrigger ansContextTrigger;
					if (this.AnsContextTriggerMap.TryGetValue(uiAnsContextBase.GetType(), out ansContextTrigger))
					{
						ansContextTrigger.OnBegin(uiAnsContextBase);
					}
				}
				else if (cacheCount > 0 && existCount == 0)
				{
					Type type = uiAnsContextBase.GetType();
					AnsContextTrigger ansContextTrigger2;
					if (this.AnsContextTriggerMap.TryGetValue(type, out ansContextTrigger2))
					{
						ansContextTrigger2.OnEnd(uiAnsContextBase);
					}
					AnsContextSet<UiAnsContextBase> ansContextSet;
					if (this.AnsContextMap.TryGetValue(type, out ansContextSet))
					{
						ansContextSet.Delete(uiAnsContextBase);
					}
				}
			}
			this.CurAnsSet.Clear();
		}
	}

	// Token: 0x06015548 RID: 87368 RVA: 0x006335F0 File Offset: 0x006317F0
	public AnsContextSet<UiAnsContextBase> GetAnsContextSet(Type type)
	{
		AnsContextSet<UiAnsContextBase> result;
		if (!this.AnsContextMap.TryGetValue(type, out result))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "获取AnsContextSet失败, Set不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new AnsContextSet<UiAnsContextBase>();
		}
		return result;
	}

	// Token: 0x0400B4CB RID: 46283
	private readonly Dictionary<Type, AnsContextSet<UiAnsContextBase>> AnsContextMap = new Dictionary<Type, AnsContextSet<UiAnsContextBase>>();

	// Token: 0x0400B4CC RID: 46284
	private readonly Dictionary<Type, AnsContextTrigger> AnsContextTriggerMap = new Dictionary<Type, AnsContextTrigger>();

	// Token: 0x0400B4CD RID: 46285
	private readonly AnsContextSet<UiAnsContextBase> CurAnsSet = new AnsContextSet<UiAnsContextBase>();
}
