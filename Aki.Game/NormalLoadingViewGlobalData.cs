using System;
using System.Runtime.CompilerServices;

// Token: 0x02001542 RID: 5442
[NullableContext(2)]
[Nullable(0)]
public class NormalLoadingViewGlobalData : IStaticVariableResetter
{
	// Token: 0x0600D9EF RID: 55791 RVA: 0x00409799 File Offset: 0x00407999
	static NormalLoadingViewGlobalData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NormalLoadingViewGlobalData.CreateStaticDefaultValue), new Action(NormalLoadingViewGlobalData.ResetStaticDefaultValue));
	}

	// Token: 0x0600D9F0 RID: 55792 RVA: 0x004097B8 File Offset: 0x004079B8
	public static void CreateFirstProgressPromise()
	{
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal = new CustomPromise();
	}

	// Token: 0x0600D9F1 RID: 55793 RVA: 0x004097C4 File Offset: 0x004079C4
	public static void FinishFirstProgressPromise()
	{
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal.SetResult();
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal = null;
	}

	// Token: 0x17001457 RID: 5207
	// (get) Token: 0x0600D9F2 RID: 55794 RVA: 0x004097D6 File Offset: 0x004079D6
	public static CustomPromise FirstProgressPromise
	{
		get
		{
			return NormalLoadingViewGlobalData.FirstProgressPromiseInternal;
		}
	}

	// Token: 0x17001458 RID: 5208
	// (get) Token: 0x0600D9F3 RID: 55795 RVA: 0x004097DD File Offset: 0x004079DD
	public static CustomPromise FinishPromise
	{
		get
		{
			return NormalLoadingViewGlobalData.FinishPromiseInternal;
		}
	}

	// Token: 0x0600D9F4 RID: 55796 RVA: 0x004097E4 File Offset: 0x004079E4
	public static void CreateFinishPromisePromise()
	{
		NormalLoadingViewGlobalData.FinishPromiseInternal = new CustomPromise();
	}

	// Token: 0x0600D9F5 RID: 55797 RVA: 0x004097F0 File Offset: 0x004079F0
	public static void FinishEndPromise()
	{
		CustomPromise finishPromiseInternal = NormalLoadingViewGlobalData.FinishPromiseInternal;
		if (finishPromiseInternal != null)
		{
			finishPromiseInternal.SetResult();
		}
		NormalLoadingViewGlobalData.FinishPromiseInternal = null;
	}

	// Token: 0x17001459 RID: 5209
	// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x00409808 File Offset: 0x00407A08
	public static bool IsNotifyCloseView
	{
		get
		{
			return NormalLoadingViewGlobalData.IsNotifyCloseViewInternal;
		}
	}

	// Token: 0x0600D9F7 RID: 55799 RVA: 0x0040980F File Offset: 0x00407A0F
	public static void ResetNotifyCloseView()
	{
		NormalLoadingViewGlobalData.IsNotifyCloseViewInternal = false;
	}

	// Token: 0x0600D9F8 RID: 55800 RVA: 0x00409817 File Offset: 0x00407A17
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D9F9 RID: 55801 RVA: 0x00409819 File Offset: 0x00407A19
	public static void ResetStaticDefaultValue()
	{
		NormalLoadingViewGlobalData.FirstProgressPromiseInternal = null;
		NormalLoadingViewGlobalData.FinishPromiseInternal = null;
		NormalLoadingViewGlobalData.IsNotifyCloseViewInternal = false;
	}

	// Token: 0x040079AC RID: 31148
	private static CustomPromise FirstProgressPromiseInternal;

	// Token: 0x040079AD RID: 31149
	private static CustomPromise FinishPromiseInternal;

	// Token: 0x040079AE RID: 31150
	private static bool IsNotifyCloseViewInternal;
}
