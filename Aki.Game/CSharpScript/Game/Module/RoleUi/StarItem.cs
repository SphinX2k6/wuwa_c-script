using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CE9 RID: 19689
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class StarItem : GridProxyAbstract<IStarItemData>
	{
		// Token: 0x06032D94 RID: 208276 RVA: 0x00BD96C4 File Offset: 0x00BD78C4
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

		// Token: 0x06032D95 RID: 208277 RVA: 0x00BD9790 File Offset: 0x00BD7990
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SetImgStarLoopItemActive(false);
		}

		// Token: 0x06032D96 RID: 208278 RVA: 0x00BD97AA File Offset: 0x00BD79AA
		public override void SetActive(bool active)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(active);
		}

		// Token: 0x06032D97 RID: 208279 RVA: 0x00BD97C0 File Offset: 0x00BD79C0
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

		// Token: 0x06032D98 RID: 208280 RVA: 0x00BD9819 File Offset: 0x00BD7A19
		public void SetImgStarOnActive(bool active)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06032D99 RID: 208281 RVA: 0x00BD982D File Offset: 0x00BD7A2D
		public void SetImgStarOffActive(bool active)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06032D9A RID: 208282 RVA: 0x00BD9841 File Offset: 0x00BD7A41
		public void SetImgStarNextActive(bool active)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06032D9B RID: 208283 RVA: 0x00BD9855 File Offset: 0x00BD7A55
		public void SetImgStarLoopItemActive(bool active)
		{
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06032D9C RID: 208284 RVA: 0x00BD986C File Offset: 0x00BD7A6C
		public void PlayAutoLoopSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
		}

		// Token: 0x06032D9D RID: 208285 RVA: 0x00BD989C File Offset: 0x00BD7A9C
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

		// Token: 0x0401B0E2 RID: 110818
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AE70 RID: 44656
		private class EStarItemDefine
		{
			// Token: 0x04034F56 RID: 216918
			public const int ImgStarOnItem = 0;

			// Token: 0x04034F57 RID: 216919
			public const int ImgStarOffItem = 1;

			// Token: 0x04034F58 RID: 216920
			public const int ImgStarNextItem = 2;

			// Token: 0x04034F59 RID: 216921
			public const int ActiveNiagara = 3;

			// Token: 0x04034F5A RID: 216922
			public const int ImgStarLoopItem = 4;
		}
	}
}
