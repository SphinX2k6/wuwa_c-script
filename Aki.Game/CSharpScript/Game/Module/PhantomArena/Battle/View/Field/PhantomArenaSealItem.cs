using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Field
{
	// Token: 0x02004233 RID: 16947
	public class PhantomArenaSealItem : UiPanelBase
	{
		// Token: 0x0602ADC2 RID: 175554 RVA: 0x00C0FF31 File Offset: 0x00C0E131
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602ADC3 RID: 175555 RVA: 0x00C0FF54 File Offset: 0x00C0E154
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
		}

		// Token: 0x0602ADC4 RID: 175556 RVA: 0x00C0FF7E File Offset: 0x00C0E17E
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602ADC5 RID: 175557 RVA: 0x00C0FF8B File Offset: 0x00C0E18B
		[NullableContext(1)]
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "Unlock")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602ADC6 RID: 175558 RVA: 0x00C0FFA4 File Offset: 0x00C0E1A4
		public UniTask ShowSeal(int roundNum)
		{
			PhantomArenaSealItem.<ShowSeal>d__7 <ShowSeal>d__;
			<ShowSeal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowSeal>d__.<>4__this = this;
			<ShowSeal>d__.roundNum = roundNum;
			<ShowSeal>d__.<>1__state = -1;
			<ShowSeal>d__.<>t__builder.Start<PhantomArenaSealItem.<ShowSeal>d__7>(ref <ShowSeal>d__);
			return <ShowSeal>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADC7 RID: 175559 RVA: 0x00C0FFF0 File Offset: 0x00C0E1F0
		public UniTask HideSeal()
		{
			PhantomArenaSealItem.<HideSeal>d__8 <HideSeal>d__;
			<HideSeal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideSeal>d__.<>4__this = this;
			<HideSeal>d__.<>1__state = -1;
			<HideSeal>d__.<>t__builder.Start<PhantomArenaSealItem.<HideSeal>d__8>(ref <HideSeal>d__);
			return <HideSeal>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADC8 RID: 175560 RVA: 0x00C10034 File Offset: 0x00C0E234
		public UniTask SetSealText(int roundNum)
		{
			PhantomArenaSealItem.<SetSealText>d__9 <SetSealText>d__;
			<SetSealText>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSealText>d__.<>4__this = this;
			<SetSealText>d__.roundNum = roundNum;
			<SetSealText>d__.<>1__state = -1;
			<SetSealText>d__.<>t__builder.Start<PhantomArenaSealItem.<SetSealText>d__9>(ref <SetSealText>d__);
			return <SetSealText>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADC9 RID: 175561 RVA: 0x00C10080 File Offset: 0x00C0E280
		public UniTask RefreshSeal(bool active, int roundNum)
		{
			PhantomArenaSealItem.<RefreshSeal>d__10 <RefreshSeal>d__;
			<RefreshSeal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSeal>d__.<>4__this = this;
			<RefreshSeal>d__.active = active;
			<RefreshSeal>d__.roundNum = roundNum;
			<RefreshSeal>d__.<>1__state = -1;
			<RefreshSeal>d__.<>t__builder.Start<PhantomArenaSealItem.<RefreshSeal>d__10>(ref <RefreshSeal>d__);
			return <RefreshSeal>d__.<>t__builder.Task;
		}

		// Token: 0x04017335 RID: 95029
		[Nullable(1)]
		protected UiSequencePlayer Sequence;

		// Token: 0x04017336 RID: 95030
		protected bool IsInSeal;

		// Token: 0x02009E81 RID: 40577
		private class EComponentDefine
		{
			// Token: 0x04031454 RID: 201812
			public const int SealText = 0;
		}
	}
}
