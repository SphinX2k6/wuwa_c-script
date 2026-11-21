using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020017B0 RID: 6064
public class MotorcycleMusicSortItem : DragSortGridAbstract<int>
{
	// Token: 0x0600EC7A RID: 60538 RVA: 0x00456F05 File Offset: 0x00455105
	[NullableContext(2)]
	protected override UUIDraggableComponent GetDraggableComp()
	{
		return base.GetDraggable(5);
	}

	// Token: 0x0600EC7B RID: 60539 RVA: 0x00456F10 File Offset: 0x00455110
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

	// Token: 0x0600EC7C RID: 60540 RVA: 0x00456FAC File Offset: 0x004551AC
	protected override void OnStartImplement()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(1);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(() => false);
	}

	// Token: 0x0600EC7D RID: 60541 RVA: 0x00456FE4 File Offset: 0x004551E4
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

	// Token: 0x020079CA RID: 31178
	private class ESortItemComponents
	{
		// Token: 0x0402777B RID: 161659
		public const int Item = 0;

		// Token: 0x0402777C RID: 161660
		public const int TogList = 1;

		// Token: 0x0402777D RID: 161661
		public const int TxtName1 = 2;

		// Token: 0x0402777E RID: 161662
		public const int TxtName2 = 3;

		// Token: 0x0402777F RID: 161663
		public const int PanelItem = 4;

		// Token: 0x04027780 RID: 161664
		public const int DragItem = 5;
	}
}
