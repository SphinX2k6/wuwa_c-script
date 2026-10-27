using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x0200649B RID: 25755
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MatchThreePopupTileInfoItem : GridProxyAbstract<MatchThreeInfoItemData>
	{
		// Token: 0x06040ADE RID: 264926 RVA: 0x00FA82B0 File Offset: 0x00FA64B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040ADF RID: 264927 RVA: 0x00FA835B File Offset: 0x00FA655B
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.ResolveSequenceBindItem());
		}

		// Token: 0x06040AE0 RID: 264928 RVA: 0x00FA836E File Offset: 0x00FA656E
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06040AE1 RID: 264929 RVA: 0x00FA8388 File Offset: 0x00FA6588
		[NullableContext(2)]
		private UUIItem ResolveSequenceBindItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
			if (MatchThreePopupTileInfoItem.HasSequence(uuiitem, "Tip") || MatchThreePopupTileInfoItem.HasSequence(uuiitem, "Start"))
			{
				return uuiitem;
			}
			UUIItem rootItem = base.GetRootItem();
			if (MatchThreePopupTileInfoItem.HasSequence(rootItem, "Tip") || MatchThreePopupTileInfoItem.HasSequence(rootItem, "Start"))
			{
				return rootItem;
			}
			return uuiitem ?? rootItem;
		}

		// Token: 0x06040AE2 RID: 264930 RVA: 0x00FA83F6 File Offset: 0x00FA65F6
		private static bool HasSequence([Nullable(2)] UUIItem item, string sequenceName)
		{
			return item != null && item.IsValid() && item.LevelSequences != null && item.LevelSequences.Contains(sequenceName);
		}

		// Token: 0x06040AE3 RID: 264931 RVA: 0x00FA841C File Offset: 0x00FA661C
		public override void Refresh(MatchThreeInfoItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), data.Desc, Array.Empty<object>());
			this.RefreshIcon(data.IconPath);
			this.ResetHighlight();
		}

		// Token: 0x06040AE4 RID: 264932 RVA: 0x00FA8474 File Offset: 0x00FA6674
		public void PlayStartSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06040AE5 RID: 264933 RVA: 0x00FA84A0 File Offset: 0x00FA66A0
		public void PlayHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Tip", false, null);
		}

		// Token: 0x06040AE6 RID: 264934 RVA: 0x00FA84CC File Offset: 0x00FA66CC
		public void ResetHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.StopSequenceByKey("Tip", false, true);
		}

		// Token: 0x06040AE7 RID: 264935 RVA: 0x00FA84E8 File Offset: 0x00FA66E8
		[NullableContext(2)]
		public UUIItem GetNavigationItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			return ((button != null) ? button.RootUIComp.Get() : null) ?? base.GetRootItem();
		}

		// Token: 0x06040AE8 RID: 264936 RVA: 0x00FA851C File Offset: 0x00FA671C
		private void RefreshIcon(string iconPath)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			base.TrySetSpriteByPath(string.IsNullOrEmpty(iconPath) ? null : iconPath, sprite, false, null, null);
		}

		// Token: 0x04021A77 RID: 137847
		private const string TipSequenceName = "Tip";

		// Token: 0x04021A78 RID: 137848
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
