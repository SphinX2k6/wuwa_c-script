using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x0200649D RID: 25757
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MatchThreePopupEnvInfoItem : GridProxyAbstract<MatchThreeInfoItemData>
	{
		// Token: 0x06040AEA RID: 264938 RVA: 0x00FA855C File Offset: 0x00FA675C
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040AEB RID: 264939 RVA: 0x00FA8607 File Offset: 0x00FA6807
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.ResolveSequenceBindItem());
		}

		// Token: 0x06040AEC RID: 264940 RVA: 0x00FA861A File Offset: 0x00FA681A
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06040AED RID: 264941 RVA: 0x00FA8634 File Offset: 0x00FA6834
		[NullableContext(2)]
		private UUIItem ResolveSequenceBindItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			UUIItem uuiitem = (button != null) ? button.RootUIComp.Get() : null;
			if (MatchThreePopupEnvInfoItem.HasSequence(uuiitem, "Tip") || MatchThreePopupEnvInfoItem.HasSequence(uuiitem, "Start"))
			{
				return uuiitem;
			}
			UUIItem rootItem = base.GetRootItem();
			if (MatchThreePopupEnvInfoItem.HasSequence(rootItem, "Tip") || MatchThreePopupEnvInfoItem.HasSequence(rootItem, "Start"))
			{
				return rootItem;
			}
			return uuiitem ?? rootItem;
		}

		// Token: 0x06040AEE RID: 264942 RVA: 0x00FA86A2 File Offset: 0x00FA68A2
		private static bool HasSequence([Nullable(2)] UUIItem item, string sequenceName)
		{
			return item != null && item.IsValid() && item.LevelSequences != null && item.LevelSequences.Contains(sequenceName);
		}

		// Token: 0x06040AEF RID: 264943 RVA: 0x00FA86C8 File Offset: 0x00FA68C8
		public override void Refresh(MatchThreeInfoItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), data.Desc, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), data.AddDesc, Array.Empty<object>());
			this.ResetHighlight();
		}

		// Token: 0x06040AF0 RID: 264944 RVA: 0x00FA8730 File Offset: 0x00FA6930
		public void PlayStartSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06040AF1 RID: 264945 RVA: 0x00FA875C File Offset: 0x00FA695C
		public void PlayHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Tip", false, null);
		}

		// Token: 0x06040AF2 RID: 264946 RVA: 0x00FA8788 File Offset: 0x00FA6988
		public void ResetHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.StopSequenceByKey("Tip", false, true);
		}

		// Token: 0x06040AF3 RID: 264947 RVA: 0x00FA87A4 File Offset: 0x00FA69A4
		[NullableContext(2)]
		public UUIItem GetNavigationItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			return ((button != null) ? button.RootUIComp.Get() : null) ?? base.GetRootItem();
		}

		// Token: 0x04021A7E RID: 137854
		private const string TipSequenceName = "Tip";

		// Token: 0x04021A7F RID: 137855
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
