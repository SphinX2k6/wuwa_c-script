using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Field
{
	// Token: 0x02005263 RID: 21091
	public class PhantomArenaSealItem : UiPanelBase
	{
		// Token: 0x06035EC7 RID: 220871 RVA: 0x00CC28A1 File Offset: 0x00CC0AA1
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035EC8 RID: 220872 RVA: 0x00CC28C4 File Offset: 0x00CC0AC4
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
		}

		// Token: 0x06035EC9 RID: 220873 RVA: 0x00CC28EE File Offset: 0x00CC0AEE
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035ECA RID: 220874 RVA: 0x00CC28FB File Offset: 0x00CC0AFB
		[NullableContext(1)]
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "Unlock")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035ECB RID: 220875 RVA: 0x00CC2914 File Offset: 0x00CC0B14
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

		// Token: 0x06035ECC RID: 220876 RVA: 0x00CC2960 File Offset: 0x00CC0B60
		public UniTask HideSeal()
		{
			PhantomArenaSealItem.<HideSeal>d__8 <HideSeal>d__;
			<HideSeal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideSeal>d__.<>4__this = this;
			<HideSeal>d__.<>1__state = -1;
			<HideSeal>d__.<>t__builder.Start<PhantomArenaSealItem.<HideSeal>d__8>(ref <HideSeal>d__);
			return <HideSeal>d__.<>t__builder.Task;
		}

		// Token: 0x06035ECD RID: 220877 RVA: 0x00CC29A4 File Offset: 0x00CC0BA4
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

		// Token: 0x06035ECE RID: 220878 RVA: 0x00CC29F0 File Offset: 0x00CC0BF0
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

		// Token: 0x0401C900 RID: 116992
		[Nullable(1)]
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C901 RID: 116993
		protected bool IsInSeal;

		// Token: 0x0200B449 RID: 46153
		private class EComponentDefine
		{
			// Token: 0x04036A01 RID: 223745
			public const int SealText = 0;
		}
	}
}
