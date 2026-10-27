using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001937 RID: 6455
public class MediumItemGridStarLevelComponent : MediumItemGridComponent
{
	// Token: 0x0600BCC9 RID: 48329 RVA: 0x002AB768 File Offset: 0x002A9968
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BCCA RID: 48330 RVA: 0x002AB7D1 File Offset: 0x002A99D1
	protected override void OnActivate()
	{
		this.VerticalItem = base.GetItem(0);
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x0600BCCB RID: 48331 RVA: 0x002AB7F2 File Offset: 0x002A99F2
	protected override void OnDeactivate()
	{
		this.StarSpriteActorList.Clear();
		this.VerticalItem = null;
	}

	// Token: 0x0600BCCC RID: 48332 RVA: 0x002AB806 File Offset: 0x002A9A06
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagStar";
	}

	// Token: 0x0600BCCD RID: 48333 RVA: 0x002AB810 File Offset: 0x002A9A10
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (!(data is int))
		{
			return;
		}
		int num = (int)data;
		if (this.StarLevel == num)
		{
			this.SetActive(true);
			return;
		}
		this.StarLevel = num;
		UUISprite sprite = base.GetSprite(1);
		AUIBaseActor actor = ((sprite != null) ? sprite.GetOwner() : null) as AUIBaseActor;
		this.HiddenAllStar();
		for (int i = 0; i < num; i++)
		{
			AUIBaseActor auibaseActor = null;
			if (i < this.StarSpriteActorList.Count)
			{
				auibaseActor = this.StarSpriteActorList[i];
			}
			if (auibaseActor == null || !auibaseActor.IsValid())
			{
				auibaseActor = (LguiUtil.Instance.DuplicateActor(actor, this.VerticalItem) as AUIBaseActor);
				if (i < this.StarSpriteActorList.Count)
				{
					this.StarSpriteActorList[i] = auibaseActor;
				}
				else
				{
					this.StarSpriteActorList.Add(auibaseActor);
				}
			}
			if (auibaseActor != null)
			{
				UUIItem uiitem = auibaseActor.GetUIItem();
				if (uiitem != null)
				{
					uiitem.SetUIActive(true);
				}
			}
		}
		this.SetActive(true);
	}

	// Token: 0x0600BCCE RID: 48334 RVA: 0x002AB8FC File Offset: 0x002A9AFC
	private void HiddenAllStar()
	{
		foreach (AUIBaseActor auibaseActor in this.StarSpriteActorList)
		{
			if (auibaseActor != null)
			{
				UUIItem uiitem = auibaseActor.GetUIItem();
				if (uiitem != null)
				{
					uiitem.SetUIActive(false);
				}
			}
		}
	}

	// Token: 0x04005543 RID: 21827
	[Nullable(2)]
	private UUIItem VerticalItem;

	// Token: 0x04005544 RID: 21828
	[Nullable(1)]
	private readonly List<AUIBaseActor> StarSpriteActorList = new List<AUIBaseActor>();

	// Token: 0x04005545 RID: 21829
	private int StarLevel;

	// Token: 0x02007E9C RID: 32412
	private class EChildType
	{
		// Token: 0x0402967A RID: 169594
		public const int VerticalItem = 0;

		// Token: 0x0402967B RID: 169595
		public const int StarSprite = 1;
	}
}
