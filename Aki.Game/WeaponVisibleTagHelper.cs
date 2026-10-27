using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020031B6 RID: 12726
[NullableContext(2)]
[Nullable(0)]
public class WeaponVisibleTagHelper
{
	// Token: 0x170025F4 RID: 9716
	// (get) Token: 0x0601B6F1 RID: 112369 RVA: 0x00780EEC File Offset: 0x0077F0EC
	// (set) Token: 0x0601B6F2 RID: 112370 RVA: 0x00780EF4 File Offset: 0x0077F0F4
	[Nullable(1)]
	public int[] Tags { [NullableContext(1)] get; [NullableContext(1)] private set; } = Array.Empty<int>();

	// Token: 0x170025F5 RID: 9717
	// (get) Token: 0x0601B6F3 RID: 112371 RVA: 0x00780EFD File Offset: 0x0077F0FD
	// (set) Token: 0x0601B6F4 RID: 112372 RVA: 0x00780F05 File Offset: 0x0077F105
	public BaseTagComponent TagComp { get; private set; }

	// Token: 0x170025F6 RID: 9718
	// (get) Token: 0x0601B6F5 RID: 112373 RVA: 0x00780F0E File Offset: 0x0077F10E
	// (set) Token: 0x0601B6F6 RID: 112374 RVA: 0x00780F16 File Offset: 0x0077F116
	public CharacterWeapon Owner { get; private set; }

	// Token: 0x0601B6F7 RID: 112375 RVA: 0x00780F1F File Offset: 0x0077F11F
	public WeaponVisibleTagHelper()
	{
		this.CountCallBack = delegate(int tagId, bool tagExist)
		{
			int tagCount = this.TagCount;
			if (tagExist)
			{
				this.TagCount++;
			}
			else
			{
				this.TagCount--;
			}
			if (tagCount == 0 && this.TagCount > 0)
			{
				this.WeaponCallBack(true, this.Owner);
				return;
			}
			if (tagCount > 0 && this.TagCount == 0)
			{
				this.WeaponCallBack(false, this.Owner);
			}
		};
	}

	// Token: 0x0601B6F8 RID: 112376 RVA: 0x00780F50 File Offset: 0x0077F150
	[NullableContext(1)]
	public void Init(CharacterWeapon owner, BaseTagComponent tagComp, [Nullable(new byte[]
	{
		2,
		1
	})] string[] tagNames, Action<bool, CharacterWeapon> callBack)
	{
		if (tagNames == null)
		{
			return;
		}
		this.Clear();
		this.TagCount = 0;
		this.TagComp = tagComp;
		this.WeaponCallBack = callBack;
		this.Owner = owner;
		List<int> list = new List<int>();
		foreach (string text in tagNames)
		{
			if (!string.IsNullOrEmpty(text))
			{
				int tagIdByName = GameplayTagUtils.GetTagIdByName(text);
				list.Add(tagIdByName);
			}
		}
		this.Tags = list.ToArray();
		foreach (int num in this.Tags)
		{
			if (tagComp.HasTag(num))
			{
				this.TagCount++;
			}
			ITagTask tagTask = tagComp.ListenForTagAddOrRemove(new int?(num), this.CountCallBack, null);
			if (tagTask != null)
			{
				this.TagListeners.Add(tagTask);
			}
		}
		if (this.TagCount > 0)
		{
			this.WeaponCallBack(true, this.Owner);
		}
	}

	// Token: 0x0601B6F9 RID: 112377 RVA: 0x0078103C File Offset: 0x0077F23C
	public void Clear()
	{
		this.Owner = null;
		this.TagComp = null;
		this.WeaponCallBack = null;
		foreach (ITagTask tagTask in this.TagListeners)
		{
			tagTask.EndTask();
		}
		this.TagListeners.Clear();
		this.Tags = Array.Empty<int>();
	}

	// Token: 0x0400D700 RID: 55040
	private int TagCount;

	// Token: 0x0400D701 RID: 55041
	[Nullable(1)]
	private readonly BaseTagComponent.TTagSwitchedCallback CountCallBack;

	// Token: 0x0400D704 RID: 55044
	[Nullable(1)]
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400D705 RID: 55045
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<bool, CharacterWeapon> WeaponCallBack;
}
