using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200593B RID: 22843
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolScratchTicketCaptionItem : UiPanelBase
	{
		// Token: 0x060384B8 RID: 230584 RVA: 0x00FBD865 File Offset: 0x00FBBA65
		public void SetNavCallbacks(Action onBack, Action onClose)
		{
			this.CloseCallback = onClose;
		}

		// Token: 0x060384B9 RID: 230585 RVA: 0x00FBD870 File Offset: 0x00FBBA70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnCloseClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060384BA RID: 230586 RVA: 0x00FBD938 File Offset: 0x00FBBB38
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolScratchTicketCaptionItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolScratchTicketCaptionItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060384BB RID: 230587 RVA: 0x00FBD97B File Offset: 0x00FBBB7B
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060384BC RID: 230588 RVA: 0x00FBD98E File Offset: 0x00FBBB8E
		protected override void OnBeforeShow()
		{
			this.PlayStart(false);
		}

		// Token: 0x060384BD RID: 230589 RVA: 0x00FBD997 File Offset: 0x00FBBB97
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.CloseCallback = null;
			this.TipCost = null;
		}

		// Token: 0x060384BE RID: 230590 RVA: 0x00FBD9C0 File Offset: 0x00FBBBC0
		public void SetHelpGroupId(int helpGroupId)
		{
			UUIItem item = base.GetItem(0);
			bool flag = helpGroupId != 0;
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendButtonComponent.StaticClass()) : null);
			}
			UUIExtendButtonComponent uuiextendButtonComponent = obj as UUIExtendButtonComponent;
			if (uuiextendButtonComponent != null)
			{
				uuiextendButtonComponent.HelpGroupId = helpGroupId;
			}
		}

		// Token: 0x060384BF RID: 230591 RVA: 0x00FBDA1A File Offset: 0x00FBBC1A
		public void SetHelpActive(bool active)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x060384C0 RID: 230592 RVA: 0x00FBDA30 File Offset: 0x00FBBC30
		public void PlayStart(bool blockClick = false)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", blockClick, false, null, null, false);
		}

		// Token: 0x060384C1 RID: 230593 RVA: 0x00FBDA60 File Offset: 0x00FBBC60
		public void PlayClose(bool blockClick = false)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Close", blockClick, false, null, null, false);
		}

		// Token: 0x060384C2 RID: 230594 RVA: 0x00FBDA8F File Offset: 0x00FBBC8F
		private void OnBtnCloseClick()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x0401DA4B RID: 121419
		private SolarSchoolScratchTicketCostItem TipCost;

		// Token: 0x0401DA4C RID: 121420
		private Action CloseCallback;

		// Token: 0x0401DA4D RID: 121421
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B4F6 RID: 46326
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037F4A RID: 229194
			public const int BtnHelpInfo = 0;

			// Token: 0x04037F4B RID: 229195
			public const int BtnSolarSchoolTipCost = 1;

			// Token: 0x04037F4C RID: 229196
			public const int BtnSolarSchoolBack = 2;
		}
	}
}
