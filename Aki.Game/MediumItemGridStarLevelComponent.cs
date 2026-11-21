using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DF3 RID: 3571
public class MediumItemGridStarLevelComponent : MediumItemGridComponent
{
	// Token: 0x060090C4 RID: 37060 RVA: 0x002B6234 File Offset: 0x002B4434
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

	// Token: 0x060090C5 RID: 37061 RVA: 0x002B629D File Offset: 0x002B449D
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

	// Token: 0x060090C6 RID: 37062 RVA: 0x002B62BE File Offset: 0x002B44BE
	protected override void OnDeactivate()
	{
		this.StarSpriteActorList.Clear();
		this.VerticalItem = null;
	}

	// Token: 0x060090C7 RID: 37063 RVA: 0x002B62D2 File Offset: 0x002B44D2
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagStar";
	}

	// Token: 0x060090C8 RID: 37064 RVA: 0x002B62DC File Offset: 0x002B44DC
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

	// Token: 0x060090C9 RID: 37065 RVA: 0x002B63C8 File Offset: 0x002B45C8
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

	// Token: 0x040055F0 RID: 22000
	[Nullable(2)]
	private UUIItem VerticalItem;

	// Token: 0x040055F1 RID: 22001
	[Nullable(1)]
	private readonly List<AUIBaseActor> StarSpriteActorList = new List<AUIBaseActor>();

	// Token: 0x040055F2 RID: 22002
	private int StarLevel;

	// Token: 0x02007029 RID: 28713
	private class EChildType
	{
		// Token: 0x040249B2 RID: 149938
		public const int VerticalItem = 0;

		// Token: 0x040249B3 RID: 149939
		public const int StarSprite = 1;
	}
}
