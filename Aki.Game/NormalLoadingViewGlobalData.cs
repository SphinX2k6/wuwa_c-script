using System;
using System.Runtime.CompilerServices;

// Token: 0x0200206F RID: 8303
[NullableContext(2)]
[Nullable(0)]
public class NormalLoadingViewGlobalData : IStaticVariableResetter
{
	// Token: 0x06010587 RID: 66951 RVA: 0x003FD351 File Offset: 0x003FB551
	static NormalLoadingViewGlobalData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NormalLoadingViewGlobalData.CreateStaticDefaultValue), new Action(NormalLoadingViewGlobalData.ResetStaticDefaultValue));
	}

	// Token: 0x06010588 RID: 66952 RVA: 0x003FD370 File Offset: 0x003FB570
	public static void CreateFirstProgressPromise()
	{
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal = new CustomPromise();
	}

	// Token: 0x06010589 RID: 66953 RVA: 0x003FD37C File Offset: 0x003FB57C
	public static void FinishFirstProgressPromise()
	{
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal.SetResult();
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal = null;
	}

	// Token: 0x1700142A RID: 5162
	// (get) Token: 0x0601058A RID: 66954 RVA: 0x003FD38E File Offset: 0x003FB58E
	public static CustomPromise FirstProgressPromise
	{
		get
		{
			return NormalLoadingViewGlobalData.FirstProgressPromiseInternal;
		}
	}

	// Token: 0x1700142B RID: 5163
	// (get) Token: 0x0601058B RID: 66955 RVA: 0x003FD395 File Offset: 0x003FB595
	public static CustomPromise FinishPromise
	{
		get
		{
			return NormalLoadingViewGlobalData.FinishPromiseInternal;
		}
	}

	// Token: 0x0601058C RID: 66956 RVA: 0x003FD39C File Offset: 0x003FB59C
	public static void CreateFinishPromisePromise()
	{
		NormalLoadingViewGlobalData.FinishPromiseInternal = new CustomPromise();
	}

	// Token: 0x0601058D RID: 66957 RVA: 0x003FD3A8 File Offset: 0x003FB5A8
	public static void FinishEndPromise()
	{
		CustomPromise finishPromiseInternal = NormalLoadingViewGlobalData.FinishPromiseInternal;
		if (finishPromiseInternal != null)
		{
			finishPromiseInternal.SetResult();
		}
		NormalLoadingViewGlobalData.FinishPromiseInternal = null;
	}

	// Token: 0x1700142C RID: 5164
	// (get) Token: 0x0601058E RID: 66958 RVA: 0x003FD3C0 File Offset: 0x003FB5C0
	public static bool IsNotifyCloseView
	{
		get
		{
			return NormalLoadingViewGlobalData.IsNotifyCloseViewInternal;
		}
	}

	// Token: 0x0601058F RID: 66959 RVA: 0x003FD3C7 File Offset: 0x003FB5C7
	public static void ResetNotifyCloseView()
	{
		NormalLoadingViewGlobalData.IsNotifyCloseViewInternal = false;
	}

	// Token: 0x06010590 RID: 66960 RVA: 0x003FD3CF File Offset: 0x003FB5CF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010591 RID: 66961 RVA: 0x003FD3D1 File Offset: 0x003FB5D1
	public static void ResetStaticDefaultValue()
	{
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal = null;
		NormalLoadingViewGlobalData.FinishPromiseInternal = null;
		NormalLoadingViewGlobalData.IsNotifyCloseViewInternal = false;
	}

	// Token: 0x040078C3 RID: 30915
	private static CustomPromise FirstProgressPromiseInternal;

	// Token: 0x040078C4 RID: 30916
	private static CustomPromise FinishPromiseInternal;

	// Token: 0x040078C5 RID: 30917
	private static bool IsNotifyCloseViewInternal;
}
