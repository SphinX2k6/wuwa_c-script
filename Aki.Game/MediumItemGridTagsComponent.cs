using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000DF5 RID: 3573
[NullableContext(1)]
[Nullable(0)]
public class MediumItemGridTagsComponent : MediumItemGridComponent
{
	// Token: 0x060090D0 RID: 37072 RVA: 0x002B64D8 File Offset: 0x002B46D8
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

	// Token: 0x060090D1 RID: 37073 RVA: 0x002B6541 File Offset: 0x002B4741
	protected override void OnStart()
	{
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x060090D2 RID: 37074 RVA: 0x002B6555 File Offset: 0x002B4755
	protected override string GetResourceId()
	{
		return "UiItem_EnemyItemState";
	}

	// Token: 0x060090D3 RID: 37075 RVA: 0x002B655C File Offset: 0x002B475C
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

	// Token: 0x060090D4 RID: 37076 RVA: 0x002B6598 File Offset: 0x002B4798
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

	// Token: 0x060090D5 RID: 37077 RVA: 0x002B6644 File Offset: 0x002B4844
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

	// Token: 0x040055F3 RID: 22003
	private readonly List<UUISprite> SpriteList = new List<UUISprite>();

	// Token: 0x040055F4 RID: 22004
	private string[] Tags = new string[0];

	// Token: 0x0200702B RID: 28715
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040249B5 RID: 149941
		public const int LayoutIcon = 0;

		// Token: 0x040249B6 RID: 149942
		public const int SpriteIconTemplate = 1;
	}
}
