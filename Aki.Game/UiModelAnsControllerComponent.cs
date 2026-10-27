using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C82 RID: 11394
[NullableContext(1)]
[Nullable(0)]
public class UiModelAnsControllerComponent : UiModelComponentBase
{
	// Token: 0x06017CCF RID: 97487 RVA: 0x0060D83E File Offset: 0x0060BA3E
	protected override void OnInit()
	{
		this.NeedTick = true;
	}

	// Token: 0x06017CD0 RID: 97488 RVA: 0x0060D847 File Offset: 0x0060BA47
	public void RegisterAnsTrigger(string ansContextType, Action<UiAnsContextBase> ansBeginCallBack, Action<UiAnsContextBase> ansEndCallBack, [Nullable(new byte[]
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

	// Token: 0x06017CD1 RID: 97489 RVA: 0x0060D860 File Offset: 0x0060BA60
	public void AddAns<[Nullable(0)] T>(string type, T value) where T : UiAnsContextBase
	{
		AnsContextSet<UiAnsContextBase> ansContextSet;
		if (!this.AnsContextMap.TryGetValue(type, out ansContextSet))
		{
			ansContextSet = new AnsContextSet<UiAnsContextBase>();
			this.AnsContextMap[type] = ansContextSet;
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
		if (flag && uiAnsContextBase.ExistCount == 1 && UiModelUtil.NeedPreHideAnsEffectOnEnd(uiAnsContextBase) && this.AnsContextTriggerMap.TryGetValue(uiAnsContextBase.GetType().Name, out ansContextTrigger))
		{
			Action<UiAnsContextBase> onEffectPreHideRevert = ansContextTrigger.OnEffectPreHideRevert;
			if (onEffectPreHideRevert == null)
			{
				return;
			}
			onEffectPreHideRevert(uiAnsContextBase);
		}
	}

	// Token: 0x06017CD2 RID: 97490 RVA: 0x0060D90C File Offset: 0x0060BB0C
	public void ReduceAns<[Nullable(0)] TKey>(string type, TKey value) where TKey : UiAnsContextBase
	{
		AnsContextSet<UiAnsContextBase> ansContextSet;
		if (!this.AnsContextMap.TryGetValue(type, out ansContextSet))
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
		if (uiAnsContextBase.ExistCount == 0 && UiModelUtil.NeedPreHideAnsEffectOnEnd(uiAnsContextBase) && this.AnsContextTriggerMap.TryGetValue(uiAnsContextBase.GetType().Name, out ansContextTrigger))
		{
			Action<UiAnsContextBase> onEffectPreHide = ansContextTrigger.OnEffectPreHide;
			if (onEffectPreHide == null)
			{
				return;
			}
			onEffectPreHide(uiAnsContextBase);
		}
	}

	// Token: 0x06017CD3 RID: 97491 RVA: 0x0060D9FD File Offset: 0x0060BBFD
	private void TryPushAnsContext(UiAnsContextBase ansContext)
	{
		if (this.CurAnsSet.Has(ansContext) != null)
		{
			return;
		}
		this.CurAnsSet.Add(ansContext);
		ansContext.CacheCount = ansContext.ExistCount;
	}

	// Token: 0x06017CD4 RID: 97492 RVA: 0x0060DA28 File Offset: 0x0060BC28
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
					if (this.AnsContextTriggerMap.TryGetValue(uiAnsContextBase.GetType().Name, out ansContextTrigger))
					{
						ansContextTrigger.OnBegin(uiAnsContextBase);
					}
				}
				else if (cacheCount > 0 && existCount == 0)
				{
					string name = uiAnsContextBase.GetType().Name;
					AnsContextTrigger ansContextTrigger2;
					if (this.AnsContextTriggerMap.TryGetValue(name, out ansContextTrigger2))
					{
						ansContextTrigger2.OnEnd(uiAnsContextBase);
					}
					AnsContextSet<UiAnsContextBase> ansContextSet;
					if (this.AnsContextMap.TryGetValue(name, out ansContextSet))
					{
						ansContextSet.Delete(uiAnsContextBase);
					}
				}
			}
			this.CurAnsSet.Clear();
		}
	}

	// Token: 0x06017CD5 RID: 97493 RVA: 0x0060DB28 File Offset: 0x0060BD28
	public AnsContextSet<UiAnsContextBase> GetAnsContextSet(string type)
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

	// Token: 0x0400B160 RID: 45408
	private readonly Dictionary<string, AnsContextSet<UiAnsContextBase>> AnsContextMap = new Dictionary<string, AnsContextSet<UiAnsContextBase>>();

	// Token: 0x0400B161 RID: 45409
	private readonly Dictionary<string, AnsContextTrigger> AnsContextTriggerMap = new Dictionary<string, AnsContextTrigger>();

	// Token: 0x0400B162 RID: 45410
	private readonly AnsContextSet<UiAnsContextBase> CurAnsSet = new AnsContextSet<UiAnsContextBase>();
}
