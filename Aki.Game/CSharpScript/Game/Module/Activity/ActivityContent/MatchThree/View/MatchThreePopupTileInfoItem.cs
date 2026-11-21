using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02005419 RID: 21529
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MatchThreePopupTileInfoItem : GridProxyAbstract<MatchThreeInfoItemData>
	{
		// Token: 0x060357A2 RID: 219042 RVA: 0x00EEF2F8 File Offset: 0x00EED4F8
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

		// Token: 0x060357A3 RID: 219043 RVA: 0x00EEF3A3 File Offset: 0x00EED5A3
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.ResolveSequenceBindItem());
		}

		// Token: 0x060357A4 RID: 219044 RVA: 0x00EEF3B6 File Offset: 0x00EED5B6
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060357A5 RID: 219045 RVA: 0x00EEF3D0 File Offset: 0x00EED5D0
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

		// Token: 0x060357A6 RID: 219046 RVA: 0x00EEF43E File Offset: 0x00EED63E
		private static bool HasSequence([Nullable(2)] UUIItem item, string sequenceName)
		{
			return item != null && item.IsValid() && item.LevelSequences != null && item.LevelSequences.Contains(sequenceName);
		}

		// Token: 0x060357A7 RID: 219047 RVA: 0x00EEF464 File Offset: 0x00EED664
		public override void Refresh(MatchThreeInfoItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), data.Desc, Array.Empty<object>());
			this.RefreshIcon(data.IconPath);
			this.ResetHighlight();
		}

		// Token: 0x060357A8 RID: 219048 RVA: 0x00EEF4BC File Offset: 0x00EED6BC
		public void PlayStartSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x060357A9 RID: 219049 RVA: 0x00EEF4E8 File Offset: 0x00EED6E8
		public void PlayHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Tip", false, null);
		}

		// Token: 0x060357AA RID: 219050 RVA: 0x00EEF514 File Offset: 0x00EED714
		public void ResetHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.StopSequenceByKey("Tip", false, true);
		}

		// Token: 0x060357AB RID: 219051 RVA: 0x00EEF530 File Offset: 0x00EED730
		[NullableContext(2)]
		public UUIItem GetNavigationItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			return ((button != null) ? button.RootUIComp.Get() : null) ?? base.GetRootItem();
		}

		// Token: 0x060357AC RID: 219052 RVA: 0x00EEF564 File Offset: 0x00EED764
		private void RefreshIcon(string iconPath)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			base.TrySetSpriteByPath(string.IsNullOrEmpty(iconPath) ? null : iconPath, sprite, false, null, null);
		}

		// Token: 0x0401C3A8 RID: 115624
		private const string TipSequenceName = "Tip";

		// Token: 0x0401C3A9 RID: 115625
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
