using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A73 RID: 10867
[NullableContext(2)]
[Nullable(0)]
public class EntityHandleCallbackPair
{
	// Token: 0x17002C94 RID: 11412
	// (get) Token: 0x0601B8F3 RID: 112883 RVA: 0x0087D8E5 File Offset: 0x0087BAE5
	// (set) Token: 0x0601B8F4 RID: 112884 RVA: 0x0087D8ED File Offset: 0x0087BAED
	public EntityHandle Handle { get; set; }

	// Token: 0x17002C95 RID: 11413
	// (get) Token: 0x0601B8F5 RID: 112885 RVA: 0x0087D8F6 File Offset: 0x0087BAF6
	// (set) Token: 0x0601B8F6 RID: 112886 RVA: 0x0087D8FE File Offset: 0x0087BAFE
	public long CreatureDataId { get; set; }

	// Token: 0x17002C96 RID: 11414
	// (get) Token: 0x0601B8F7 RID: 112887 RVA: 0x0087D907 File Offset: 0x0087BB07
	// (set) Token: 0x0601B8F8 RID: 112888 RVA: 0x0087D90F File Offset: 0x0087BB0F
	public int PbDataId { get; set; }

	// Token: 0x17002C97 RID: 11415
	// (get) Token: 0x0601B8F9 RID: 112889 RVA: 0x0087D918 File Offset: 0x0087BB18
	// (set) Token: 0x0601B8FA RID: 112890 RVA: 0x0087D920 File Offset: 0x0087BB20
	public float AngleRatio { get; set; }

	// Token: 0x17002C98 RID: 11416
	// (get) Token: 0x0601B8FB RID: 112891 RVA: 0x0087D929 File Offset: 0x0087BB29
	// (set) Token: 0x0601B8FC RID: 112892 RVA: 0x0087D931 File Offset: 0x0087BB31
	public float Priority { get; set; }

	// Token: 0x17002C99 RID: 11417
	// (get) Token: 0x0601B8FD RID: 112893 RVA: 0x0087D93A File Offset: 0x0087BB3A
	// (set) Token: 0x0601B8FE RID: 112894 RVA: 0x0087D942 File Offset: 0x0087BB42
	public int Order { get; set; }

	// Token: 0x17002C9A RID: 11418
	// (get) Token: 0x0601B8FF RID: 112895 RVA: 0x0087D94B File Offset: 0x0087BB4B
	// (set) Token: 0x0601B900 RID: 112896 RVA: 0x0087D953 File Offset: 0x0087BB53
	public int Version { get; set; }

	// Token: 0x0601B901 RID: 112897 RVA: 0x0087D95C File Offset: 0x0087BB5C
	public void AddCallback(Action<ELoadResultType> callback)
	{
		if (callback != null)
		{
			this.Callbacks.Add(callback);
		}
	}

	// Token: 0x0601B902 RID: 112898 RVA: 0x0087D96D File Offset: 0x0087BB6D
	public void ClearCallbacks()
	{
		this.Callbacks.Clear();
	}

	// Token: 0x0601B903 RID: 112899 RVA: 0x0087D97C File Offset: 0x0087BB7C
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

	// Token: 0x0400EE39 RID: 60985
	[Nullable(1)]
	private readonly List<Action<ELoadResultType>> Callbacks = new List<Action<ELoadResultType>>();
}
