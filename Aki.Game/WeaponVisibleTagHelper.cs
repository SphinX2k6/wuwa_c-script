using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002725 RID: 10021
[NullableContext(2)]
[Nullable(0)]
public class WeaponVisibleTagHelper
{
	// Token: 0x170027F1 RID: 10225
	// (get) Token: 0x06019224 RID: 102948 RVA: 0x007A926C File Offset: 0x007A746C
	// (set) Token: 0x06019225 RID: 102949 RVA: 0x007A9274 File Offset: 0x007A7474
	[Nullable(1)]
	public int[] Tags { [NullableContext(1)] get; [NullableContext(1)] private set; } = Array.Empty<int>();

	// Token: 0x170027F2 RID: 10226
	// (get) Token: 0x06019226 RID: 102950 RVA: 0x007A927D File Offset: 0x007A747D
	// (set) Token: 0x06019227 RID: 102951 RVA: 0x007A9285 File Offset: 0x007A7485
	public BaseTagComponent TagComp { get; private set; }

	// Token: 0x170027F3 RID: 10227
	// (get) Token: 0x06019228 RID: 102952 RVA: 0x007A928E File Offset: 0x007A748E
	// (set) Token: 0x06019229 RID: 102953 RVA: 0x007A9296 File Offset: 0x007A7496
	public CharacterWeapon Owner { get; private set; }

	// Token: 0x0601922A RID: 102954 RVA: 0x007A929F File Offset: 0x007A749F
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

	// Token: 0x0601922B RID: 102955 RVA: 0x007A92D0 File Offset: 0x007A74D0
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

	// Token: 0x0601922C RID: 102956 RVA: 0x007A93BC File Offset: 0x007A75BC
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

	// Token: 0x0400DB87 RID: 56199
	private int TagCount;

	// Token: 0x0400DB88 RID: 56200
	[Nullable(1)]
	private readonly BaseTagComponent.TTagSwitchedCallback CountCallBack;

	// Token: 0x0400DB8B RID: 56203
	[Nullable(1)]
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400DB8C RID: 56204
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<bool, CharacterWeapon> WeaponCallBack;
}
