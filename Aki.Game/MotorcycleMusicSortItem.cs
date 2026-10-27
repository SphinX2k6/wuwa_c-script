using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020022CC RID: 8908
public class MotorcycleMusicSortItem : DragSortGridAbstract<int>
{
	// Token: 0x060117E3 RID: 71651 RVA: 0x0044A1DD File Offset: 0x004483DD
	[NullableContext(2)]
	protected override UUIDraggableComponent GetDraggableComp()
	{
		return base.GetDraggable(5);
	}

	// Token: 0x060117E4 RID: 71652 RVA: 0x0044A1E8 File Offset: 0x004483E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIDraggableComponent))
		};
	}

	// Token: 0x060117E5 RID: 71653 RVA: 0x0044A284 File Offset: 0x00448484
	protected override void OnStartImplement()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(() => false);
	}

	// Token: 0x060117E6 RID: 71654 RVA: 0x0044A2BC File Offset: 0x004484BC
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(data) : null;
		if (phonographMusic == null)
		{
			return;
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(phonographMusic.Value.Title);
		}
		if (phonographMusic.Value.GetAlbumArray().Length != 0)
		{
			PhonographConfig instance2 = PhonographConfig.Instance;
			PhonographAlbum? phonographAlbum = (instance2 != null) ? instance2.GetMusicAlbumById(phonographMusic.Value.GetAlbumArray()[0]) : null;
			if (phonographAlbum != null)
			{
				base.GetText(3).ShowTextNew(phonographAlbum.Value.Title);
			}
		}
	}

	// Token: 0x02008846 RID: 34886
	private class ESortItemComponents
	{
		// Token: 0x0402C479 RID: 181369
		public const int Item = 0;

		// Token: 0x0402C47A RID: 181370
		public const int TogList = 1;

		// Token: 0x0402C47B RID: 181371
		public const int TxtName1 = 2;

		// Token: 0x0402C47C RID: 181372
		public const int TxtName2 = 3;

		// Token: 0x0402C47D RID: 181373
		public const int PanelItem = 4;

		// Token: 0x0402C47E RID: 181374
		public const int DragItem = 5;
	}
}
