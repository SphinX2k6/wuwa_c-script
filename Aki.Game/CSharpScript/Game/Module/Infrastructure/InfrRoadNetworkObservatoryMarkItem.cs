using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048FB RID: 18683
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkObservatoryMarkItem : UiPanelBase
	{
		// Token: 0x0602EE77 RID: 192119 RVA: 0x00D16900 File Offset: 0x00D14B00
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

		// Token: 0x0602EE78 RID: 192120 RVA: 0x00D169E8 File Offset: 0x00D14BE8
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.Refresh();
		}

		// Token: 0x0602EE79 RID: 192121 RVA: 0x00D16A1C File Offset: 0x00D14C1C
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

		// Token: 0x0602EE7A RID: 192122 RVA: 0x00D16A51 File Offset: 0x00D14C51
		public void Refresh()
		{
			this.RefreshIcon();
			this.RefreshStageName();
		}

		// Token: 0x0602EE7B RID: 192123 RVA: 0x00D16A5F File Offset: 0x00D14C5F
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

		// Token: 0x0602EE7C RID: 192124 RVA: 0x00D16A9C File Offset: 0x00D14C9C
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

		// Token: 0x0602EE7D RID: 192125 RVA: 0x00D16AFA File Offset: 0x00D14CFA
		public void SetOnClickToggleCb(Action cb)
		{
			this.OnClickToggleCb = cb;
		}

		// Token: 0x0602EE7E RID: 192126 RVA: 0x00D16B03 File Offset: 0x00D14D03
		public void SetNeedPlayFinishSeq(bool needPlayFinishSeq)
		{
			this.NeedPlayFinishSeq = needPlayFinishSeq;
		}

		// Token: 0x0602EE7F RID: 192127 RVA: 0x00D16B0C File Offset: 0x00D14D0C
		private void OnClickBtnToggle(EToggleState _)
		{
			Action onClickToggleCb = this.OnClickToggleCb;
			if (onClickToggleCb == null)
			{
				return;
			}
			onClickToggleCb();
		}

		// Token: 0x0602EE80 RID: 192128 RVA: 0x00D16B1E File Offset: 0x00D14D1E
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

		// Token: 0x0602EE81 RID: 192129 RVA: 0x00D16B50 File Offset: 0x00D14D50
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

		// Token: 0x0602EE82 RID: 192130 RVA: 0x00D16B78 File Offset: 0x00D14D78
		public void ShowMarkFinish(Action cb)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Finish", false, null, false);
			}
			this.OnFinishPlayEnd = cb;
		}

		// Token: 0x0602EE83 RID: 192131 RVA: 0x00D16BB0 File Offset: 0x00D14DB0
		public void ShowLevelUpSeq()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("LevelUp", false, null, false);
		}

		// Token: 0x04018E12 RID: 101906
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04018E13 RID: 101907
		private bool NeedPlayFinishSeq;

		// Token: 0x04018E14 RID: 101908
		private Action OnClickToggleCb;

		// Token: 0x04018E15 RID: 101909
		private Action OnFinishPlayEnd;

		// Token: 0x0200A5CF RID: 42447
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040334F5 RID: 210165
			public const int Toggle = 0;

			// Token: 0x040334F6 RID: 210166
			public const int PanelLock = 1;

			// Token: 0x040334F7 RID: 210167
			public const int PanelNor = 2;

			// Token: 0x040334F8 RID: 210168
			public const int TextStageName = 3;
		}
	}
}
