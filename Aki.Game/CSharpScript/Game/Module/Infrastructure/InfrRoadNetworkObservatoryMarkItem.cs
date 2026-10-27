using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005922 RID: 22818
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkObservatoryMarkItem : UiPanelBase
	{
		// Token: 0x06039F54 RID: 237396 RVA: 0x00DC75D8 File Offset: 0x00DC57D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickBtnToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039F55 RID: 237397 RVA: 0x00DC76C0 File Offset: 0x00DC58C0
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.Refresh();
		}

		// Token: 0x06039F56 RID: 237398 RVA: 0x00DC76F4 File Offset: 0x00DC58F4
		protected override void OnAfterShow()
		{
			if (!this.NeedPlayFinishSeq)
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer == null)
				{
					return;
				}
				seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x06039F57 RID: 237399 RVA: 0x00DC7729 File Offset: 0x00DC5929
		public void Refresh()
		{
			this.RefreshIcon();
			this.RefreshStageName();
		}

		// Token: 0x06039F58 RID: 237400 RVA: 0x00DC7737 File Offset: 0x00DC5937
		private void RefreshIcon()
		{
			if (InfrastructureModel.Instance.FireLevel == InfrastructureConfig.Instance.GetMaxLevel())
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(true);
			}
		}

		// Token: 0x06039F59 RID: 237401 RVA: 0x00DC7774 File Offset: 0x00DC5974
		private void RefreshStageName()
		{
			InfrLevel? levelConfigById = InfrastructureConfig.Instance.GetLevelConfigById(InfrastructureModel.Instance.FireLevel);
			if (levelConfigById != null)
			{
				UUIText text = base.GetText(3);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew(levelConfigById.Value.Description);
				return;
			}
			else
			{
				UUIText text2 = base.GetText(3);
				if (text2 == null)
				{
					return;
				}
				text2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06039F5A RID: 237402 RVA: 0x00DC77D2 File Offset: 0x00DC59D2
		public void SetOnClickToggleCb(Action cb)
		{
			this.OnClickToggleCb = cb;
		}

		// Token: 0x06039F5B RID: 237403 RVA: 0x00DC77DB File Offset: 0x00DC59DB
		public void SetNeedPlayFinishSeq(bool needPlayFinishSeq)
		{
			this.NeedPlayFinishSeq = needPlayFinishSeq;
		}

		// Token: 0x06039F5C RID: 237404 RVA: 0x00DC77E4 File Offset: 0x00DC59E4
		private void OnClickBtnToggle(EToggleState _)
		{
			Action onClickToggleCb = this.OnClickToggleCb;
			if (onClickToggleCb == null)
			{
				return;
			}
			onClickToggleCb();
		}

		// Token: 0x06039F5D RID: 237405 RVA: 0x00DC77F6 File Offset: 0x00DC59F6
		public void SetSelected(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			if (selected)
			{
				Action onClickToggleCb = this.OnClickToggleCb;
				if (onClickToggleCb == null)
				{
					return;
				}
				onClickToggleCb();
			}
		}

		// Token: 0x06039F5E RID: 237406 RVA: 0x00DC7828 File Offset: 0x00DC5A28
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Finish")
			{
				Action onFinishPlayEnd = this.OnFinishPlayEnd;
				if (onFinishPlayEnd != null)
				{
					onFinishPlayEnd();
				}
				this.OnFinishPlayEnd = null;
			}
		}

		// Token: 0x06039F5F RID: 237407 RVA: 0x00DC7850 File Offset: 0x00DC5A50
		public void ShowMarkFinish(Action cb)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Finish", false, null, false);
			}
			this.OnFinishPlayEnd = cb;
		}

		// Token: 0x06039F60 RID: 237408 RVA: 0x00DC7888 File Offset: 0x00DC5A88
		public void ShowLevelUpSeq()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("LevelUp", false, null, false);
		}

		// Token: 0x0401E375 RID: 123765
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401E376 RID: 123766
		private bool NeedPlayFinishSeq;

		// Token: 0x0401E377 RID: 123767
		private Action OnClickToggleCb;

		// Token: 0x0401E378 RID: 123768
		private Action OnFinishPlayEnd;

		// Token: 0x0200BBC0 RID: 48064
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038B13 RID: 232211
			public const int Toggle = 0;

			// Token: 0x04038B14 RID: 232212
			public const int PanelLock = 1;

			// Token: 0x04038B15 RID: 232213
			public const int PanelNor = 2;

			// Token: 0x04038B16 RID: 232214
			public const int TextStageName = 3;
		}
	}
}
