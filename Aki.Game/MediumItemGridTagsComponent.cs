using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001939 RID: 6457
[NullableContext(1)]
[Nullable(0)]
public class MediumItemGridTagsComponent : MediumItemGridComponent
{
	// Token: 0x0600BCD5 RID: 48341 RVA: 0x002ABA0C File Offset: 0x002A9C0C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BCD6 RID: 48342 RVA: 0x002ABA75 File Offset: 0x002A9C75
	protected override void OnStart()
	{
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x0600BCD7 RID: 48343 RVA: 0x002ABA89 File Offset: 0x002A9C89
	protected override string GetResourceId()
	{
		return "UiItem_EnemyItemState";
	}

	// Token: 0x0600BCD8 RID: 48344 RVA: 0x002ABA90 File Offset: 0x002A9C90
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		string[] array = data as string[];
		if (array == null)
		{
			return;
		}
		bool flag = array != null && array.Length != 0;
		this.SetActive(flag);
		if (flag)
		{
			this.Tags = array;
			this.UpdateTagList();
		}
	}

	// Token: 0x0600BCD9 RID: 48345 RVA: 0x002ABACC File Offset: 0x002A9CCC
	private void UpdateTagList()
	{
		for (int i = this.Tags.Length; i < this.SpriteList.Count; i++)
		{
			this.SpriteList[i].SetUIActive(false);
		}
		for (int j = 0; j < this.Tags.Length; j++)
		{
			string path = this.Tags[j];
			UUISprite uiSprite = this.GetSpriteItem(j);
			uiSprite.SetUIActive(true);
			uiSprite.SetAlpha(0f);
			base.SetSpriteAsync(path, uiSprite, false).ContinueWith(delegate()
			{
				uiSprite.SetAlpha(1f);
			}).Forget();
		}
	}

	// Token: 0x0600BCDA RID: 48346 RVA: 0x002ABB78 File Offset: 0x002A9D78
	private UUISprite GetSpriteItem(int index)
	{
		if (index < this.SpriteList.Count)
		{
			return this.SpriteList[index];
		}
		UUISprite sprite = base.GetSprite(1);
		UUILayoutBase layoutBase = base.GetLayoutBase(0);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (layoutBase != null) ? new TWeakObjectPtr<UUIItem>?(layoutBase.RootUIComp) : null;
		LguiUtil instance = LguiUtil.Instance;
		UUIItem item = sprite;
		TWeakObjectPtr<UUIItem>? tweakObjectPtr2 = tweakObjectPtr;
		UUISprite uuisprite = instance.CopyItem(item, (tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null) as UUISprite;
		this.SpriteList.Add(uuisprite);
		return uuisprite;
	}

	// Token: 0x04005546 RID: 21830
	private readonly List<UUISprite> SpriteList = new List<UUISprite>();

	// Token: 0x04005547 RID: 21831
	private string[] Tags = new string[0];

	// Token: 0x02007E9E RID: 32414
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402967D RID: 169597
		public const int LayoutIcon = 0;

		// Token: 0x0402967E RID: 169598
		public const int SpriteIconTemplate = 1;
	}
}
