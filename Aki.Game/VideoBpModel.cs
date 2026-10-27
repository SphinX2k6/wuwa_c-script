using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Sequence.Seq_BP.BPSeqDissolve;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x02002CE4 RID: 11492
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VideoBpModel : ModelBase
{
	// Token: 0x17002082 RID: 8322
	// (get) Token: 0x060181E6 RID: 98790 RVA: 0x006221DF File Offset: 0x006203DF
	[Nullable(2)]
	public BP_MediaDissolveManagea_C VideoBp
	{
		[NullableContext(2)]
		get
		{
			return this.VideoBpInternal;
		}
	}

	// Token: 0x060181E7 RID: 98791 RVA: 0x006221E7 File Offset: 0x006203E7
	public void AddToPreloadMap(string name, UMediaSource source)
	{
		this.VideoPreloadMap[name] = source;
	}

	// Token: 0x060181E8 RID: 98792 RVA: 0x006221F8 File Offset: 0x006203F8
	[return: Nullable(2)]
	public UMediaSource GetFromPreloadMap(string name)
	{
		UMediaSource result;
		if (this.VideoPreloadMap.TryGetValue(name, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060181E9 RID: 98793 RVA: 0x00622218 File Offset: 0x00620418
	public void ClearPreloadMap()
	{
		this.VideoPreloadMap.Clear();
	}

	// Token: 0x060181EA RID: 98794 RVA: 0x00622225 File Offset: 0x00620425
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060181EB RID: 98795 RVA: 0x00622228 File Offset: 0x00620428
	protected override bool OnClear()
	{
		this.RemoveOnVideoEnd();
		return true;
	}

	// Token: 0x060181EC RID: 98796 RVA: 0x00622234 File Offset: 0x00620434
	[NullableContext(2)]
	public BP_MediaDissolveManagea_C SpawnOrGetVideoBp()
	{
		if (this.VideoBpInternal != null)
		{
			return this.VideoBp;
		}
		FTransformDouble transform = Global.BaseCharacter.D_GetTransform();
		if (!transform.IsValid())
		{
			return null;
		}
		this.VideoBpInternal = (ActorSystem.Instance.Spawn(BP_MediaDissolveManagea_C.StaticClass(), transform, Global.BaseCharacter) as BP_MediaDissolveManagea_C);
		if (this.VideoBpInternal != null)
		{
			Log.Instance.Info(ELogModule.Preload, ELogAuthor.JYS, "[VideoBp]成功生成VideoBp蓝图", default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.VideoBpInternal;
		}
		return null;
	}

	// Token: 0x060181ED RID: 98797 RVA: 0x006222B4 File Offset: 0x006204B4
	public void RemoveVideoBp()
	{
		if (this.VideoBpInternal == null)
		{
			return;
		}
		Log.Instance.Info(ELogModule.Preload, ELogAuthor.JYS, "[VideoBp]成功移除VideoBp蓝图", default(ReadOnlySpan<ValueTuple<string, object>>));
		ActorSystem.Instance.Put("VideoBpModel", this.VideoBpInternal, null);
		this.VideoBpInternal = null;
	}

	// Token: 0x060181EE RID: 98798 RVA: 0x00622304 File Offset: 0x00620504
	public void RemoveOnVideoEnd()
	{
		this.RemoveVideoBp();
		this.ClearPreloadMap();
	}

	// Token: 0x060181EF RID: 98799 RVA: 0x00622312 File Offset: 0x00620512
	public void RemovePreload()
	{
		this.ClearPreloadMap();
	}

	// Token: 0x17002083 RID: 8323
	// (get) Token: 0x060181F0 RID: 98800 RVA: 0x0062231A File Offset: 0x0062051A
	public static VideoBpModel Instance
	{
		get
		{
			return VideoBpModel._Instance;
		}
	}

	// Token: 0x060181F1 RID: 98801 RVA: 0x00622321 File Offset: 0x00620521
	public static VideoBpModel GetOrCreateInstance()
	{
		if (VideoBpModel._Instance == null)
		{
			VideoBpModel.CreateInstance();
		}
		return VideoBpModel._Instance;
	}

	// Token: 0x060181F2 RID: 98802 RVA: 0x00622335 File Offset: 0x00620535
	public static bool CreateInstance()
	{
		if (VideoBpModel._Instance != null)
		{
			return true;
		}
		VideoBpModel._Instance = new VideoBpModel();
		return true;
	}

	// Token: 0x060181F3 RID: 98803 RVA: 0x0062234B File Offset: 0x0062054B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060181F4 RID: 98804 RVA: 0x0062234D File Offset: 0x0062054D
	public static void ResetStaticDefaultValue()
	{
		VideoBpModel._Instance = null;
	}

	// Token: 0x060181F5 RID: 98805 RVA: 0x00622355 File Offset: 0x00620555
	static VideoBpModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoBpModel.CreateStaticDefaultValue), new Action(VideoBpModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B35C RID: 45916
	private readonly Dictionary<string, UMediaSource> VideoPreloadMap = new Dictionary<string, UMediaSource>();

	// Token: 0x0400B35D RID: 45917
	[Nullable(2)]
	private BP_MediaDissolveManagea_C VideoBpInternal;

	// Token: 0x0400B35E RID: 45918
	[Nullable(2)]
	private static VideoBpModel _Instance;
}
