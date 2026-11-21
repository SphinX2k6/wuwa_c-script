using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x0200541B RID: 21531
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MatchThreePopupEnvInfoItem : GridProxyAbstract<MatchThreeInfoItemData>
	{
		// Token: 0x060357AE RID: 219054 RVA: 0x00EEF5A4 File Offset: 0x00EED7A4
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

		// Token: 0x060357AF RID: 219055 RVA: 0x00EEF64F File Offset: 0x00EED84F
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.ResolveSequenceBindItem());
		}

		// Token: 0x060357B0 RID: 219056 RVA: 0x00EEF662 File Offset: 0x00EED862
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060357B1 RID: 219057 RVA: 0x00EEF67C File Offset: 0x00EED87C
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

		// Token: 0x060357B2 RID: 219058 RVA: 0x00EEF6EA File Offset: 0x00EED8EA
		private static bool HasSequence([Nullable(2)] UUIItem item, string sequenceName)
		{
			return item != null && item.IsValid() && item.LevelSequences != null && item.LevelSequences.Contains(sequenceName);
		}

		// Token: 0x060357B3 RID: 219059 RVA: 0x00EEF710 File Offset: 0x00EED910
		public override void Refresh(MatchThreeInfoItemData data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), data.Desc, Array.Empty<object>());
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), data.AddDesc, Array.Empty<object>());
			this.ResetHighlight();
		}

		// Token: 0x060357B4 RID: 219060 RVA: 0x00EEF778 File Offset: 0x00EED978
		public void PlayStartSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x060357B5 RID: 219061 RVA: 0x00EEF7A4 File Offset: 0x00EED9A4
		public void PlayHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Tip", false, null);
		}

		// Token: 0x060357B6 RID: 219062 RVA: 0x00EEF7D0 File Offset: 0x00EED9D0
		public void ResetHighlight()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.StopSequenceByKey("Tip", false, true);
		}

		// Token: 0x060357B7 RID: 219063 RVA: 0x00EEF7EC File Offset: 0x00EED9EC
		[NullableContext(2)]
		public UUIItem GetNavigationItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			return ((button != null) ? button.RootUIComp.Get() : null) ?? base.GetRootItem();
		}

		// Token: 0x0401C3AF RID: 115631
		private const string TipSequenceName = "Tip";

		// Token: 0x0401C3B0 RID: 115632
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
