using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001F92 RID: 8082
[NullableContext(2)]
[Nullable(0)]
public class SkeletalObserverHandle
{
	// Token: 0x17001E2B RID: 7723
	// (get) Token: 0x06013FE7 RID: 81895 RVA: 0x005D4419 File Offset: 0x005D2619
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

	// Token: 0x06013FE8 RID: 81896 RVA: 0x005D442C File Offset: 0x005D262C
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

	// Token: 0x06013FE9 RID: 81897 RVA: 0x005D4496 File Offset: 0x005D2696
	public void ResetSkeletalObserverHandle()
	{
		TsSkeletalObserver skeletalObserver = this.SkeletalObserver;
		if (skeletalObserver != null)
		{
			skeletalObserver.Destroy();
		}
		this.SkeletalObserver = null;
	}

	// Token: 0x06013FEA RID: 81898 RVA: 0x005D44B0 File Offset: 0x005D26B0
	public void AddUiShowRoomShowActor(bool includeFromChildActors)
	{
		AActor skeletalObserver = this.SkeletalObserver;
		UiSceneManager.Instance.AddUiShowRoomShowActor(skeletalObserver, includeFromChildActors);
	}

	// Token: 0x0400AA62 RID: 43618
	private TsSkeletalObserver SkeletalObserver;
}
