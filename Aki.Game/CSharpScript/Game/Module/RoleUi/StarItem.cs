using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C9B RID: 15515
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class StarItem : GridProxyAbstract<IStarItemData>
	{
		// Token: 0x06027B6F RID: 162671 RVA: 0x00B1EFCC File Offset: 0x00B1D1CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027B70 RID: 162672 RVA: 0x00B1F098 File Offset: 0x00B1D298
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SetImgStarLoopItemActive(false);
		}

		// Token: 0x06027B71 RID: 162673 RVA: 0x00B1F0B2 File Offset: 0x00B1D2B2
		public override void SetActive(bool active)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(active);
		}

		// Token: 0x06027B72 RID: 162674 RVA: 0x00B1F0C8 File Offset: 0x00B1D2C8
		[NullableContext(1)]
		public override void Refresh(IStarItemData data, bool isSelected, int gridIndex)
		{
			this.SetImgStarOnActive(data.StarOnActive);
			this.SetImgStarOffActive(data.StarOffActive);
			this.SetImgStarNextActive(data.StarNextActive);
			this.SetImgStarLoopItemActive(data.StarLoopActive);
			if (data.PlayActivateSequence)
			{
				this.PlayActiveSequence();
			}
			if (data.PlayLoopSequence)
			{
				this.PlayAutoLoopSequence();
			}
		}

		// Token: 0x06027B73 RID: 162675 RVA: 0x00B1F121 File Offset: 0x00B1D321
		public void SetImgStarOnActive(bool active)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06027B74 RID: 162676 RVA: 0x00B1F135 File Offset: 0x00B1D335
		public void SetImgStarOffActive(bool active)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06027B75 RID: 162677 RVA: 0x00B1F149 File Offset: 0x00B1D349
		public void SetImgStarNextActive(bool active)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06027B76 RID: 162678 RVA: 0x00B1F15D File Offset: 0x00B1D35D
		public void SetImgStarLoopItemActive(bool active)
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06027B77 RID: 162679 RVA: 0x00B1F174 File Offset: 0x00B1D374
		public void PlayAutoLoopSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
		}

		// Token: 0x06027B78 RID: 162680 RVA: 0x00B1F1A4 File Offset: 0x00B1D3A4
		public void PlayActiveSequence()
		{
			this.SetImgStarOnActive(true);
			this.SetImgStarOffActive(false);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Active", false, null, false);
		}

		// Token: 0x04015A67 RID: 88679
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200988E RID: 39054
		private class EStarItemDefine
		{
			// Token: 0x0402F8FE RID: 194814
			public const int ImgStarOnItem = 0;

			// Token: 0x0402F8FF RID: 194815
			public const int ImgStarOffItem = 1;

			// Token: 0x0402F900 RID: 194816
			public const int ImgStarNextItem = 2;

			// Token: 0x0402F901 RID: 194817
			public const int ActiveNiagara = 3;

			// Token: 0x0402F902 RID: 194818
			public const int ImgStarLoopItem = 4;
		}
	}
}
