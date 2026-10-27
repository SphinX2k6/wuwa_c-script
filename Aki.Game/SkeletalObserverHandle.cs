using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A17 RID: 10775
[NullableContext(2)]
[Nullable(0)]
public class SkeletalObserverHandle
{
	// Token: 0x17001DD2 RID: 7634
	// (get) Token: 0x060165E0 RID: 91616 RVA: 0x005A9441 File Offset: 0x005A7641
	public UiModelBase Model
	{
		get
		{
			TsSkeletalObserver skeletalObserver = this.SkeletalObserver;
			if (skeletalObserver == null)
			{
				return null;
			}
			return skeletalObserver.Model;
		}
	}

	// Token: 0x060165E1 RID: 91617 RVA: 0x005A9454 File Offset: 0x005A7654
	public void CreateSkeletalObserverHandle(EUiModelUseWay useWay)
	{
		this.SkeletalObserver = ActorSystem.Instance.Get<TsSkeletalObserver>(TsSkeletalObserver.StaticClass(), new FTransformDouble(), null, true);
		if (this.SkeletalObserver == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "创建SkeletalObserver失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("useWay", useWay);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SkeletalObserver.Init(useWay);
	}

	// Token: 0x060165E2 RID: 91618 RVA: 0x005A94BE File Offset: 0x005A76BE
	public void ResetSkeletalObserverHandle()
	{
		TsSkeletalObserver skeletalObserver = this.SkeletalObserver;
		if (skeletalObserver != null)
		{
			skeletalObserver.Destroy();
		}
		this.SkeletalObserver = null;
	}

	// Token: 0x060165E3 RID: 91619 RVA: 0x005A94D8 File Offset: 0x005A76D8
	public void AddUiShowRoomShowActor(bool includeFromChildActors)
	{
		AActor skeletalObserver = this.SkeletalObserver;
		UiSceneManager.Instance.AddUiShowRoomShowActor(skeletalObserver, includeFromChildActors);
	}

	// Token: 0x0400A678 RID: 42616
	private TsSkeletalObserver SkeletalObserver;
}
