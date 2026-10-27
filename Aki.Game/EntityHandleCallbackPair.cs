using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020034FE RID: 13566
[NullableContext(2)]
[Nullable(0)]
public class EntityHandleCallbackPair
{
	// Token: 0x170028FB RID: 10491
	// (get) Token: 0x0601DBDC RID: 121820 RVA: 0x00855491 File Offset: 0x00853691
	// (set) Token: 0x0601DBDD RID: 121821 RVA: 0x00855499 File Offset: 0x00853699
	public EntityHandle Handle { get; set; }

	// Token: 0x170028FC RID: 10492
	// (get) Token: 0x0601DBDE RID: 121822 RVA: 0x008554A2 File Offset: 0x008536A2
	// (set) Token: 0x0601DBDF RID: 121823 RVA: 0x008554AA File Offset: 0x008536AA
	public long CreatureDataId { get; set; }

	// Token: 0x170028FD RID: 10493
	// (get) Token: 0x0601DBE0 RID: 121824 RVA: 0x008554B3 File Offset: 0x008536B3
	// (set) Token: 0x0601DBE1 RID: 121825 RVA: 0x008554BB File Offset: 0x008536BB
	public int PbDataId { get; set; }

	// Token: 0x170028FE RID: 10494
	// (get) Token: 0x0601DBE2 RID: 121826 RVA: 0x008554C4 File Offset: 0x008536C4
	// (set) Token: 0x0601DBE3 RID: 121827 RVA: 0x008554CC File Offset: 0x008536CC
	public float AngleRatio { get; set; }

	// Token: 0x170028FF RID: 10495
	// (get) Token: 0x0601DBE4 RID: 121828 RVA: 0x008554D5 File Offset: 0x008536D5
	// (set) Token: 0x0601DBE5 RID: 121829 RVA: 0x008554DD File Offset: 0x008536DD
	public float Priority { get; set; }

	// Token: 0x17002900 RID: 10496
	// (get) Token: 0x0601DBE6 RID: 121830 RVA: 0x008554E6 File Offset: 0x008536E6
	// (set) Token: 0x0601DBE7 RID: 121831 RVA: 0x008554EE File Offset: 0x008536EE
	public int Order { get; set; }

	// Token: 0x17002901 RID: 10497
	// (get) Token: 0x0601DBE8 RID: 121832 RVA: 0x008554F7 File Offset: 0x008536F7
	// (set) Token: 0x0601DBE9 RID: 121833 RVA: 0x008554FF File Offset: 0x008536FF
	public int Version { get; set; }

	// Token: 0x0601DBEA RID: 121834 RVA: 0x00855508 File Offset: 0x00853708
	public void AddCallback(Action<ELoadResultType> callback)
	{
		if (callback != null)
		{
			this.Callbacks.Add(callback);
		}
	}

	// Token: 0x0601DBEB RID: 121835 RVA: 0x00855519 File Offset: 0x00853719
	public void ClearCallbacks()
	{
		this.Callbacks.Clear();
	}

	// Token: 0x0601DBEC RID: 121836 RVA: 0x00855528 File Offset: 0x00853728
	public void InvokeCallbacks(ELoadResultType result)
	{
		foreach (Action<ELoadResultType> action in this.Callbacks)
		{
			try
			{
				action(result);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Preload;
				ELogAuthor author = ELogAuthor.XY;
				string message = "预加载实体:加载回调异常";
				Exception error = ex;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", result);
				instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0400E97E RID: 59774
	[Nullable(1)]
	private readonly List<Action<ELoadResultType>> Callbacks = new List<Action<ELoadResultType>>();
}
