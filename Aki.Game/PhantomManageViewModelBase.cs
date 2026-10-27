using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FDD RID: 8157
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageViewModelBase<[Nullable(0)] T> where T : Enum
{
	// Token: 0x0600FFB4 RID: 65460 RVA: 0x003E4808 File Offset: 0x003E2A08
	protected void SetData(T key, object value, bool notNotify = false)
	{
		if (this.DataMap.ContainsKey(key))
		{
			this.DataMap[key] = value;
		}
		else
		{
			this.DataMap.Add(key, value);
		}
		if (!notNotify)
		{
			this.Notify(key);
		}
	}

	// Token: 0x0600FFB5 RID: 65461 RVA: 0x003E4840 File Offset: 0x003E2A40
	[return: Nullable(2)]
	protected object GetData(T key)
	{
		object result;
		if (this.DataMap.TryGetValue(key, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600FFB6 RID: 65462 RVA: 0x003E4860 File Offset: 0x003E2A60
	public void Bind(Action<T> callback)
	{
		if (!this.CallbackList.Contains(callback))
		{
			this.CallbackList.Add(callback);
		}
	}

	// Token: 0x0600FFB7 RID: 65463 RVA: 0x003E487C File Offset: 0x003E2A7C
	public void UnBind(Action<T> callback)
	{
		int num = this.CallbackList.IndexOf(callback);
		if (num != -1)
		{
			this.CallbackList.RemoveAt(num);
		}
	}

	// Token: 0x0600FFB8 RID: 65464 RVA: 0x003E48A6 File Offset: 0x003E2AA6
	public void Clear()
	{
		this.CallbackList = new List<Action<T>>();
	}

	// Token: 0x0600FFB9 RID: 65465 RVA: 0x003E48B4 File Offset: 0x003E2AB4
	protected void Notify(T key)
	{
		foreach (Action<T> action in this.CallbackList)
		{
			action(key);
		}
	}

	// Token: 0x0400764E RID: 30286
	protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

	// Token: 0x0400764F RID: 30287
	protected List<Action<T>> CallbackList = new List<Action<T>>();
}
