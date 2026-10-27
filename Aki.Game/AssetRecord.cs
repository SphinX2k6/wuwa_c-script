using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003304 RID: 13060
[NullableContext(1)]
[Nullable(0)]
public class AssetRecord : IDbAssetElement
{
	// Token: 0x17002765 RID: 10085
	// (get) Token: 0x0601C759 RID: 116569 RVA: 0x007FC726 File Offset: 0x007FA926
	// (set) Token: 0x0601C75A RID: 116570 RVA: 0x007FC72E File Offset: 0x007FA92E
	public HashSet<string> AssetSet { get; set; } = new HashSet<string>();

	// Token: 0x17002766 RID: 10086
	// (get) Token: 0x0601C75B RID: 116571 RVA: 0x007FC737 File Offset: 0x007FA937
	// (set) Token: 0x0601C75C RID: 116572 RVA: 0x007FC73F File Offset: 0x007FA93F
	public List<string> ActorClass { get; set; } = new List<string>();

	// Token: 0x17002767 RID: 10087
	// (get) Token: 0x0601C75D RID: 116573 RVA: 0x007FC748 File Offset: 0x007FA948
	// (set) Token: 0x0601C75E RID: 116574 RVA: 0x007FC750 File Offset: 0x007FA950
	public List<string> Animations { get; set; } = new List<string>();

	// Token: 0x17002768 RID: 10088
	// (get) Token: 0x0601C75F RID: 116575 RVA: 0x007FC759 File Offset: 0x007FA959
	// (set) Token: 0x0601C760 RID: 116576 RVA: 0x007FC761 File Offset: 0x007FA961
	public List<string> Effects { get; set; } = new List<string>();

	// Token: 0x17002769 RID: 10089
	// (get) Token: 0x0601C761 RID: 116577 RVA: 0x007FC76A File Offset: 0x007FA96A
	// (set) Token: 0x0601C762 RID: 116578 RVA: 0x007FC772 File Offset: 0x007FA972
	public List<string> Audios { get; set; } = new List<string>();

	// Token: 0x1700276A RID: 10090
	// (get) Token: 0x0601C763 RID: 116579 RVA: 0x007FC77B File Offset: 0x007FA97B
	// (set) Token: 0x0601C764 RID: 116580 RVA: 0x007FC783 File Offset: 0x007FA983
	public List<string> Meshes { get; set; } = new List<string>();

	// Token: 0x1700276B RID: 10091
	// (get) Token: 0x0601C765 RID: 116581 RVA: 0x007FC78C File Offset: 0x007FA98C
	// (set) Token: 0x0601C766 RID: 116582 RVA: 0x007FC794 File Offset: 0x007FA994
	public List<string> Materials { get; set; } = new List<string>();

	// Token: 0x1700276C RID: 10092
	// (get) Token: 0x0601C767 RID: 116583 RVA: 0x007FC79D File Offset: 0x007FA99D
	// (set) Token: 0x0601C768 RID: 116584 RVA: 0x007FC7A5 File Offset: 0x007FA9A5
	public List<string> AnimationBlueprints { get; set; } = new List<string>();

	// Token: 0x1700276D RID: 10093
	// (get) Token: 0x0601C769 RID: 116585 RVA: 0x007FC7AE File Offset: 0x007FA9AE
	// (set) Token: 0x0601C76A RID: 116586 RVA: 0x007FC7B6 File Offset: 0x007FA9B6
	public List<string> Others { get; set; } = new List<string>();

	// Token: 0x0601C76B RID: 116587 RVA: 0x007FC7BF File Offset: 0x007FA9BF
	public bool AddActorClass(string path)
	{
		if (!this.AddAsset(path))
		{
			return false;
		}
		this.ActorClass.Add(path);
		return true;
	}

	// Token: 0x0601C76C RID: 116588 RVA: 0x007FC7D9 File Offset: 0x007FA9D9
	public void AddAnimation(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Animations.Add(path);
	}

	// Token: 0x0601C76D RID: 116589 RVA: 0x007FC7F4 File Offset: 0x007FA9F4
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

	// Token: 0x0601C76E RID: 116590 RVA: 0x007FC862 File Offset: 0x007FAA62
	public bool AddEffect(string path)
	{
		if (!this.AddAsset(path))
		{
			return false;
		}
		this.Effects.Add(path);
		return true;
	}

	// Token: 0x0601C76F RID: 116591 RVA: 0x007FC87C File Offset: 0x007FAA7C
	public void AddAudio(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Audios.Add(path);
	}

	// Token: 0x0601C770 RID: 116592 RVA: 0x007FC894 File Offset: 0x007FAA94
	public void AddMesh(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Meshes.Add(path);
	}

	// Token: 0x0601C771 RID: 116593 RVA: 0x007FC8AC File Offset: 0x007FAAAC
	public void AddMaterial(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.Materials.Add(path);
	}

	// Token: 0x0601C772 RID: 116594 RVA: 0x007FC8C4 File Offset: 0x007FAAC4
	public void AddAnimationBlueprint(string path)
	{
		if (!this.AddAsset(path))
		{
			return;
		}
		this.AnimationBlueprints.Add(path);
	}

	// Token: 0x0601C773 RID: 116595 RVA: 0x007FC8DC File Offset: 0x007FAADC
	public bool AddOther(string path)
	{
		if (!this.AddAsset(path))
		{
			return false;
		}
		this.Others.Add(path);
		return true;
	}

	// Token: 0x0601C774 RID: 116596 RVA: 0x007FC8F8 File Offset: 0x007FAAF8
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

	// Token: 0x0601C775 RID: 116597 RVA: 0x007FC958 File Offset: 0x007FAB58
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
