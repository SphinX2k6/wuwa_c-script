using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02005259 RID: 21081
	public class HpItem : UiPanelBase
	{
		// Token: 0x06035E04 RID: 220676 RVA: 0x00CBFEC6 File Offset: 0x00CBE0C6
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035E05 RID: 220677 RVA: 0x00CBFEE9 File Offset: 0x00CBE0E9
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06035E06 RID: 220678 RVA: 0x00CBFF13 File Offset: 0x00CBE113
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035E07 RID: 220679 RVA: 0x00CBFF20 File Offset: 0x00CBE120
		[NullableContext(1)]
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.PlayClose();
				return;
			}
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035E08 RID: 220680 RVA: 0x00CBFF4A File Offset: 0x00CBE14A
		public void RefreshHpNum(int cost)
		{
			base.GetText(0).SetText(cost.ToString(), true);
		}

		// Token: 0x06035E09 RID: 220681 RVA: 0x00CBFF60 File Offset: 0x00CBE160
		public UniTask PlayStart()
		{
			HpItem.<PlayStart>d__7 <PlayStart>d__;
			<PlayStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStart>d__.<>4__this = this;
			<PlayStart>d__.<>1__state = -1;
			<PlayStart>d__.<>t__builder.Start<HpItem.<PlayStart>d__7>(ref <PlayStart>d__);
			return <PlayStart>d__.<>t__builder.Task;
		}

		// Token: 0x06035E0A RID: 220682 RVA: 0x00CBFFA3 File Offset: 0x00CBE1A3
		public void PlayClose()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x0401C8D0 RID: 116944
		[Nullable(1)]
		protected UiSequencePlayer Sequence;

		// Token: 0x0200B417 RID: 46103
		private class EHpItem
		{
			// Token: 0x04036917 RID: 223511
			public const int NumText = 0;
		}
	}
}
