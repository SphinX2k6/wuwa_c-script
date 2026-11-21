using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02004229 RID: 16937
	public class HpItem : UiPanelBase
	{
		// Token: 0x0602ACFF RID: 175359 RVA: 0x00C0D556 File Offset: 0x00C0B756
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602AD00 RID: 175360 RVA: 0x00C0D579 File Offset: 0x00C0B779
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0602AD01 RID: 175361 RVA: 0x00C0D5A3 File Offset: 0x00C0B7A3
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602AD02 RID: 175362 RVA: 0x00C0D5B0 File Offset: 0x00C0B7B0
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

		// Token: 0x0602AD03 RID: 175363 RVA: 0x00C0D5DA File Offset: 0x00C0B7DA
		public void RefreshHpNum(int cost)
		{
			base.GetText(0).SetText(cost.ToString(), true);
		}

		// Token: 0x0602AD04 RID: 175364 RVA: 0x00C0D5F0 File Offset: 0x00C0B7F0
		public UniTask PlayStart()
		{
			HpItem.<PlayStart>d__7 <PlayStart>d__;
			<PlayStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStart>d__.<>4__this = this;
			<PlayStart>d__.<>1__state = -1;
			<PlayStart>d__.<>t__builder.Start<HpItem.<PlayStart>d__7>(ref <PlayStart>d__);
			return <PlayStart>d__.<>t__builder.Task;
		}

		// Token: 0x0602AD05 RID: 175365 RVA: 0x00C0D633 File Offset: 0x00C0B833
		public void PlayClose()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x04017305 RID: 94981
		[Nullable(1)]
		protected UiSequencePlayer Sequence;

		// Token: 0x02009E4F RID: 40527
		private class EHpItem
		{
			// Token: 0x0403136A RID: 201578
			public const int NumText = 0;
		}
	}
}
