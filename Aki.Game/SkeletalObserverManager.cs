using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F93 RID: 8083
[NullableContext(1)]
[Nullable(0)]
public class SkeletalObserverManager : IStaticVariableResetter
{
	// Token: 0x06013FEC RID: 81900 RVA: 0x005D44D8 File Offset: 0x005D26D8
	static SkeletalObserverManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkeletalObserverManager.CreateStaticDefaultValue), new Action(SkeletalObserverManager.ResetStaticDefaultValue));
	}

	// Token: 0x06013FED RID: 81901 RVA: 0x005D44F7 File Offset: 0x005D26F7
	public static void CreateStaticDefaultValue()
	{
		SkeletalObserverManager.SkeletalObserverHandleList = new List<SkeletalObserverHandle>();
	}

	// Token: 0x06013FEE RID: 81902 RVA: 0x005D4503 File Offset: 0x005D2703
	public static void ResetStaticDefaultValue()
	{
		SkeletalObserverManager.SkeletalObserverHandleList = null;
	}

	// Token: 0x06013FEF RID: 81903 RVA: 0x005D450C File Offset: 0x005D270C
	public static SkeletalObserverHandle NewSkeletalObserver(EUiModelUseWay useWay)
	{
		SkeletalObserverHandle skeletalObserverHandle = new SkeletalObserverHandle();
		skeletalObserverHandle.CreateSkeletalObserverHandle(useWay);
		SkeletalObserverManager.SkeletalObserverHandleList.Add(skeletalObserverHandle);
		return skeletalObserverHandle;
	}

	// Token: 0x06013FF0 RID: 81904 RVA: 0x005D4532 File Offset: 0x005D2732
	public static void DestroySkeletalObserver(SkeletalObserverHandle skeletalObserverHandle)
	{
		if (!SkeletalObserverManager.SkeletalObserverHandleList.Contains(skeletalObserverHandle))
		{
			return;
		}
		skeletalObserverHandle.ResetSkeletalObserverHandle();
		SkeletalObserverManager.SkeletalObserverHandleList.Remove(skeletalObserverHandle);
	}

	// Token: 0x06013FF1 RID: 81905 RVA: 0x005D4554 File Offset: 0x005D2754
	public static void ClearAllSkeletalObserver()
	{
		foreach (SkeletalObserverHandle skeletalObserverHandle in SkeletalObserverManager.SkeletalObserverHandleList)
		{
			skeletalObserverHandle.ResetSkeletalObserverHandle();
		}
		SkeletalObserverManager.SkeletalObserverHandleList.Clear();
	}

	// Token: 0x06013FF2 RID: 81906 RVA: 0x005D45B0 File Offset: 0x005D27B0
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

	// Token: 0x0400AA63 RID: 43619
	private static List<SkeletalObserverHandle> SkeletalObserverHandleList;
}
