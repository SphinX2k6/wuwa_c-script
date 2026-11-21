using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014AC RID: 5292
[NullableContext(1)]
[Nullable(0)]
public class ViewModelBase<[Nullable(0)] T> where T : Enum
{
	// Token: 0x0600D3F3 RID: 54259 RVA: 0x003F0458 File Offset: 0x003EE658
	protected void SetData(T key, object value, bool? notNotify = false)
	{
		if (this.DataMap.ContainsKey(key))
		{
			this.DataMap[key] = value;
		}
		else
		{
			this.DataMap.Add(key, value);
		}
		bool? flag = notNotify;
		bool flag2 = false;
		if (flag.GetValueOrDefault() == flag2 & flag != null)
		{
			this.Notify(key);
		}
	}

	// Token: 0x0600D3F4 RID: 54260 RVA: 0x003F04B0 File Offset: 0x003EE6B0
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

	// Token: 0x0600D3F5 RID: 54261 RVA: 0x003F04D0 File Offset: 0x003EE6D0
	public void Bind(Action<T> callback)
	{
		if (!this.CallbackList.Contains(callback))
		{
			this.CallbackList.Add(callback);
		}
	}

	// Token: 0x0600D3F6 RID: 54262 RVA: 0x003F04EC File Offset: 0x003EE6EC
	public void UnBind(Action<T> callback)
	{
		int num = this.CallbackList.IndexOf(callback);
		if (num != -1)
		{
			this.CallbackList.RemoveAt(num);
		}
	}

	// Token: 0x0600D3F7 RID: 54263 RVA: 0x003F0516 File Offset: 0x003EE716
	public void Clear()
	{
		this.CallbackList = new List<Action<T>>();
	}

	// Token: 0x0600D3F8 RID: 54264 RVA: 0x003F0524 File Offset: 0x003EE724
	protected void Notify(T key)
	{
		foreach (Action<T> action in this.CallbackList)
		{
			action(key);
		}
	}

	// Token: 0x04007728 RID: 30504
	protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

	// Token: 0x04007729 RID: 30505
	protected List<Action<T>> CallbackList = new List<Action<T>>();
}
