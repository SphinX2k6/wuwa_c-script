using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A18 RID: 10776
[NullableContext(1)]
[Nullable(0)]
public class SkeletalObserverManager : IStaticVariableResetter
{
	// Token: 0x060165E5 RID: 91621 RVA: 0x005A9500 File Offset: 0x005A7700
	static SkeletalObserverManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkeletalObserverManager.CreateStaticDefaultValue), new Action(SkeletalObserverManager.ResetStaticDefaultValue));
	}

	// Token: 0x060165E6 RID: 91622 RVA: 0x005A951F File Offset: 0x005A771F
	public static void CreateStaticDefaultValue()
	{
		SkeletalObserverManager.SkeletalObserverHandleList = new List<SkeletalObserverHandle>();
	}

	// Token: 0x060165E7 RID: 91623 RVA: 0x005A952B File Offset: 0x005A772B
	public static void ResetStaticDefaultValue()
	{
		SkeletalObserverManager.SkeletalObserverHandleList = null;
	}

	// Token: 0x060165E8 RID: 91624 RVA: 0x005A9534 File Offset: 0x005A7734
	public static SkeletalObserverHandle NewSkeletalObserver(EUiModelUseWay useWay)
	{
		SkeletalObserverHandle skeletalObserverHandle = new SkeletalObserverHandle();
		skeletalObserverHandle.CreateSkeletalObserverHandle(useWay);
		SkeletalObserverManager.SkeletalObserverHandleList.Add(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x060165E9 RID: 91625 RVA: 0x005A955A File Offset: 0x005A775A
	public static void DestroySkeletalObserver(SkeletalObserverHandle skeletalObserverHandle)
	{
		if (!SkeletalObserverManager.SkeletalObserverHandleList.Contains(skeletalObserverHandle))
		{
			return;
		}
		skeletalObserverHandle.ResetSkeletalObserverHandle();
		SkeletalObserverManager.SkeletalObserverHandleList.Remove(skeletalObserverHandle);
	}

	// Token: 0x060165EA RID: 91626 RVA: 0x005A957C File Offset: 0x005A777C
	public static void ClearAllSkeletalObserver()
	{
		foreach (SkeletalObserverHandle skeletalObserverHandle in SkeletalObserverManager.SkeletalObserverHandleList)
		{
			skeletalObserverHandle.ResetSkeletalObserverHandle();
		}
		SkeletalObserverManager.SkeletalObserverHandleList.Clear();
	}

	// Token: 0x060165EB RID: 91627 RVA: 0x005A95D8 File Offset: 0x005A77D8
	[NullableContext(2)]
	public static SkeletalObserverHandle GetLastSkeletalObserver()
	{
		int num = SkeletalObserverManager.SkeletalObserverHandleList.Count - 1;
		if (num < 0)
		{
			return null;
		}
		return SkeletalObserverManager.SkeletalObserverHandleList[num];
	}

	// Token: 0x0400A679 RID: 42617
	private static List<SkeletalObserverHandle> SkeletalObserverHandleList;
}
