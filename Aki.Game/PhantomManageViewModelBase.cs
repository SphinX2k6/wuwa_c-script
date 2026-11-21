using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014B0 RID: 5296
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageViewModelBase<[Nullable(0)] T> where T : Enum
{
	// Token: 0x0600D41C RID: 54300 RVA: 0x003F0E08 File Offset: 0x003EF008
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

	// Token: 0x0600D41D RID: 54301 RVA: 0x003F0E40 File Offset: 0x003EF040
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

	// Token: 0x0600D41E RID: 54302 RVA: 0x003F0E60 File Offset: 0x003EF060
	public void Bind(Action<T> callback)
	{
		if (!this.CallbackList.Contains(callback))
		{
			this.CallbackList.Add(callback);
		}
	}

	// Token: 0x0600D41F RID: 54303 RVA: 0x003F0E7C File Offset: 0x003EF07C
	public void UnBind(Action<T> callback)
	{
		int num = this.CallbackList.IndexOf(callback);
		if (num != -1)
		{
			this.CallbackList.RemoveAt(num);
		}
	}

	// Token: 0x0600D420 RID: 54304 RVA: 0x003F0EA6 File Offset: 0x003EF0A6
	public void Clear()
	{
		this.CallbackList = new List<Action<T>>();
	}

	// Token: 0x0600D421 RID: 54305 RVA: 0x003F0EB4 File Offset: 0x003EF0B4
	protected void Notify(T key)
	{
		foreach (Action<T> action in this.CallbackList)
		{
			action(key);
		}
	}

	// Token: 0x04007737 RID: 30519
	protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

	// Token: 0x04007738 RID: 30520
	protected List<Action<T>> CallbackList = new List<Action<T>>();
}
