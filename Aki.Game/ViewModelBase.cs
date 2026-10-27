using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001FD9 RID: 8153
[NullableContext(1)]
[Nullable(0)]
public class ViewModelBase<[Nullable(0)] T> where T : Enum
{
	// Token: 0x0600FF8B RID: 65419 RVA: 0x003E3E58 File Offset: 0x003E2058
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

	// Token: 0x0600FF8C RID: 65420 RVA: 0x003E3EB0 File Offset: 0x003E20B0
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

	// Token: 0x0600FF8D RID: 65421 RVA: 0x003E3ED0 File Offset: 0x003E20D0
	public void Bind(Action<T> callback)
	{
		if (!this.CallbackList.Contains(callback))
		{
			this.CallbackList.Add(callback);
		}
	}

	// Token: 0x0600FF8E RID: 65422 RVA: 0x003E3EEC File Offset: 0x003E20EC
	public void UnBind(Action<T> callback)
	{
		int num = this.CallbackList.IndexOf(callback);
		if (num != -1)
		{
			this.CallbackList.RemoveAt(num);
		}
	}

	// Token: 0x0600FF8F RID: 65423 RVA: 0x003E3F16 File Offset: 0x003E2116
	public void Clear()
	{
		this.CallbackList = new List<Action<T>>();
	}

	// Token: 0x0600FF90 RID: 65424 RVA: 0x003E3F24 File Offset: 0x003E2124
	protected void Notify(T key)
	{
		foreach (Action<T> action in this.CallbackList)
		{
			action(key);
		}
	}

	// Token: 0x0400763F RID: 30271
	protected readonly Dictionary<T, object> DataMap = new Dictionary<T, object>();

	// Token: 0x04007640 RID: 30272
	protected List<Action<T>> CallbackList = new List<Action<T>>();
}
