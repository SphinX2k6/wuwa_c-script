using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Sequence.Seq_BP.BPSeqDissolve;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x0200223D RID: 8765
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class VideoBpModel : ModelBase
{
	// Token: 0x170020D5 RID: 8405
	// (get) Token: 0x06015A65 RID: 88677 RVA: 0x00647E53 File Offset: 0x00646053
	[Nullable(2)]
	public BP_MediaDissolveManagea_C VideoBp
	{
		[NullableContext(2)]
		get
		{
			return this.VideoBpInternal;
		}
	}

	// Token: 0x06015A66 RID: 88678 RVA: 0x00647E5B File Offset: 0x0064605B
	public void AddToPreloadMap(string name, UMediaSource source)
	{
		this.VideoPreloadMap[name] = source;
	}

	// Token: 0x06015A67 RID: 88679 RVA: 0x00647E6C File Offset: 0x0064606C
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

	// Token: 0x06015A68 RID: 88680 RVA: 0x00647E8C File Offset: 0x0064608C
	public void ClearPreloadMap()
	{
		this.VideoPreloadMap.Clear();
	}

	// Token: 0x06015A69 RID: 88681 RVA: 0x00647E99 File Offset: 0x00646099
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06015A6A RID: 88682 RVA: 0x00647E9C File Offset: 0x0064609C
	protected override bool OnClear()
	{
		this.RemoveOnVideoEnd();
		return true;
	}

	// Token: 0x06015A6B RID: 88683 RVA: 0x00647EA8 File Offset: 0x006460A8
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

	// Token: 0x06015A6C RID: 88684 RVA: 0x00647F28 File Offset: 0x00646128
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

	// Token: 0x06015A6D RID: 88685 RVA: 0x00647F78 File Offset: 0x00646178
	public void RemoveOnVideoEnd()
	{
		this.RemoveVideoBp();
		this.ClearPreloadMap();
	}

	// Token: 0x06015A6E RID: 88686 RVA: 0x00647F86 File Offset: 0x00646186
	public void RemovePreload()
	{
		this.ClearPreloadMap();
	}

	// Token: 0x170020D6 RID: 8406
	// (get) Token: 0x06015A6F RID: 88687 RVA: 0x00647F8E File Offset: 0x0064618E
	public static VideoBpModel Instance
	{
		get
		{
			return VideoBpModel._Instance;
		}
	}

	// Token: 0x06015A70 RID: 88688 RVA: 0x00647F95 File Offset: 0x00646195
	public static VideoBpModel GetOrCreateInstance()
	{
		if (VideoBpModel._Instance == null)
		{
			VideoBpModel.CreateInstance();
		}
		return VideoBpModel._Instance;
	}

	// Token: 0x06015A71 RID: 88689 RVA: 0x00647FA9 File Offset: 0x006461A9
	public static bool CreateInstance()
	{
		if (VideoBpModel._Instance != null)
		{
			return true;
		}
		VideoBpModel._Instance = new VideoBpModel();
		return true;
	}

	// Token: 0x06015A72 RID: 88690 RVA: 0x00647FBF File Offset: 0x006461BF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015A73 RID: 88691 RVA: 0x00647FC1 File Offset: 0x006461C1
	public static void ResetStaticDefaultValue()
	{
		VideoBpModel._Instance = null;
	}

	// Token: 0x06015A74 RID: 88692 RVA: 0x00647FC9 File Offset: 0x006461C9
	static VideoBpModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VideoBpModel.CreateStaticDefaultValue), new Action(VideoBpModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B6C8 RID: 46792
	private readonly Dictionary<string, UMediaSource> VideoPreloadMap = new Dictionary<string, UMediaSource>();

	// Token: 0x0400B6C9 RID: 46793
	[Nullable(2)]
	private BP_MediaDissolveManagea_C VideoBpInternal;

	// Token: 0x0400B6CA RID: 46794
	[Nullable(2)]
	private static VideoBpModel _Instance;
}
