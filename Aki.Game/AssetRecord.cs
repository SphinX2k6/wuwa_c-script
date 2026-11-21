using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002876 RID: 10358
[NullableContext(1)]
[Nullable(0)]
public class AssetRecord : IDbAssetElement
{
	// Token: 0x17002B02 RID: 11010
	// (get) Token: 0x0601A452 RID: 107602 RVA: 0x00822C92 File Offset: 0x00820E92
	// (set) Token: 0x0601A453 RID: 107603 RVA: 0x00822C9A File Offset: 0x00820E9A
	public HashSet<string> AssetSet { get; set; } = new HashSet<string>();

	// Token: 0x17002B03 RID: 11011
	// (get) Token: 0x0601A454 RID: 107604 RVA: 0x00822CA3 File Offset: 0x00820EA3
	// (set) Token: 0x0601A455 RID: 107605 RVA: 0x00822CAB File Offset: 0x00820EAB
	public List<string> ActorClass { get; set; } = new List<string>();

	// Token: 0x17002B04 RID: 11012
	// (get) Token: 0x0601A456 RID: 107606 RVA: 0x00822CB4 File Offset: 0x00820EB4
	// (set) Token: 0x0601A457 RID: 107607 RVA: 0x00822CBC File Offset: 0x00820EBC
	public List<string> Animations { get; set; } = new List<string>();

	// Token: 0x17002B05 RID: 11013
	// (get) Token: 0x0601A458 RID: 107608 RVA: 0x00822CC5 File Offset: 0x00820EC5
	// (set) Token: 0x0601A459 RID: 107609 RVA: 0x00822CCD File Offset: 0x00820ECD
	public List<string> Effects { get; set; } = new List<string>();

	// Token: 0x17002B06 RID: 11014
	// (get) Token: 0x0601A45A RID: 107610 RVA: 0x00822CD6 File Offset: 0x00820ED6
	// (set) Token: 0x0601A45B RID: 107611 RVA: 0x00822CDE File Offset: 0x00820EDE
	public List<string> Audios { get; set; } = new List<string>();

	// Token: 0x17002B07 RID: 11015
	// (get) Token: 0x0601A45C RID: 107612 RVA: 0x00822CE7 File Offset: 0x00820EE7
	// (set) Token: 0x0601A45D RID: 107613 RVA: 0x00822CEF File Offset: 0x00820EEF
	public List<string> Meshes { get; set; } = new List<string>();

	// Token: 0x17002B08 RID: 11016
	// (get) Token: 0x0601A45E RID: 107614 RVA: 0x00822CF8 File Offset: 0x00820EF8
	// (set) Token: 0x0601A45F RID: 107615 RVA: 0x00822D00 File Offset: 0x00820F00
	public List<string> Materials { get; set; } = new List<string>();

	// Token: 0x17002B09 RID: 11017
	// (get) Token: 0x0601A460 RID: 107616 RVA: 0x00822D09 File Offset: 0x00820F09
	// (set) Token: 0x0601A461 RID: 107617 RVA: 0x00822D11 File Offset: 0x00820F11
	public List<string> AnimationBlueprints { get; set; } = new List<string>();

	// Token: 0x17002B0A RID: 11018
	// (get) Token: 0x0601A462 RID: 107618 RVA: 0x00822D1A File Offset: 0x00820F1A
	// (set) Token: 0x0601A463 RID: 107619 RVA: 0x00822D22 File Offset: 0x00820F22
	public List<string> Others { get; set; } = new List<string>();

	// Token: 0x0601A464 RID: 107620 RVA: 0x00822D2B File Offset: 0x00820F2B
	public bool AddActorClass(string path)
	{
		if (!this.AddAsset(path))
		{
			return false;
		}
		this.ActorClass.Add(path);
		return true;
	}

	// Token: 0x0601A465 RID: 107621 RVA: 0x00822D45 File Offset: 0x00820F45
	public void AddAnimation(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Animations.Add(path);
	}

	// Token: 0x0601A466 RID: 107622 RVA: 0x00822D60 File Offset: 0x00820F60
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public ValueTuple<bool, bool, UObject> TryAddEffect(string path)
	{
		string path2 = path;
		if (path.Contains("GA_"))
		{
			path2 = path + "_C";
		}
		UObject uobject = ResourceSystem.Instance.Load<UObject>(path2, "js_undefined");
		if (uobject != null && uobject.IsValid() && uobject.IsA(UEffectModelBase.StaticClass()))
		{
			bool flag = this.AddEffect(path2);
			return new ValueTuple<bool, bool, UObject>(flag, flag, uobject);
		}
		return new ValueTuple<bool, bool, UObject>(this.AddOther(path2), false, uobject);
	}

	// Token: 0x0601A467 RID: 107623 RVA: 0x00822DCE File Offset: 0x00820FCE
	public bool AddEffect(string path)
	{
		if (!this.AddAsset(path))
		{
			return false;
		}
		this.Effects.Add(path);
		return true;
	}

	// Token: 0x0601A468 RID: 107624 RVA: 0x00822DE8 File Offset: 0x00820FE8
	public void AddAudio(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Audios.Add(path);
	}

	// Token: 0x0601A469 RID: 107625 RVA: 0x00822E00 File Offset: 0x00821000
	public void AddMesh(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Meshes.Add(path);
	}

	// Token: 0x0601A46A RID: 107626 RVA: 0x00822E18 File Offset: 0x00821018
	public void AddMaterial(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Materials.Add(path);
	}

	// Token: 0x0601A46B RID: 107627 RVA: 0x00822E30 File Offset: 0x00821030
	public void AddAnimationBlueprint(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.AnimationBlueprints.Add(path);
	}

	// Token: 0x0601A46C RID: 107628 RVA: 0x00822E48 File Offset: 0x00821048
	public bool AddOther(string path)
	{
		if (!this.AddAsset(path))
		{
			return false;
		}
		this.Others.Add(path);
		return true;
	}

	// Token: 0x0601A46D RID: 107629 RVA: 0x00822E64 File Offset: 0x00821064
	private bool AddAsset(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return false;
		}
		if (path.StartsWith("/Game/Aki/Scene/Assets/Temp"))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Preload;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[预加载] 不能搜集该目录的资源";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return this.AssetSet.Add(path);
	}

	// Token: 0x0601A46E RID: 107630 RVA: 0x00822EC4 File Offset: 0x008210C4
	public bool Copy(AssetRecord other)
	{
		foreach (string path in other.ActorClass)
		{
			this.AddActorClass(path);
		}
		foreach (string path2 in other.Animations)
		{
			this.AddAnimation(path2);
		}
		foreach (string path3 in other.Effects)
		{
			this.AddEffect(path3);
		}
		foreach (string path4 in other.Audios)
		{
			this.AddAudio(path4);
		}
		foreach (string path5 in other.Meshes)
		{
			this.AddMesh(path5);
		}
		foreach (string path6 in other.Materials)
		{
			this.AddMaterial(path6);
		}
		foreach (string path7 in other.AnimationBlueprints)
		{
			this.AddAnimationBlueprint(path7);
		}
		foreach (string path8 in other.Others)
		{
			this.AddOther(path8);
		}
		return true;
	}
}
