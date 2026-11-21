using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041BC RID: 16828
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EffectCountItem : GridProxyAbstract<IEffectCountItemData>
	{
		// Token: 0x0602A959 RID: 174425 RVA: 0x00C0271C File Offset: 0x00C0091C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602A95A RID: 174426 RVA: 0x00C02776 File Offset: 0x00C00976
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x0602A95B RID: 174427 RVA: 0x00C027AD File Offset: 0x00C009AD
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602A95C RID: 174428 RVA: 0x00C027BC File Offset: 0x00C009BC
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "Use")
			{
				base.GetItem(2).SetUIActive(false);
				base.GetItem(0).SetUIActive(false);
				return;
			}
			if (sequenceName == "Full")
			{
				base.GetItem(0).SetUIActive(false);
			}
		}

		// Token: 0x0602A95D RID: 174429 RVA: 0x00C0280B File Offset: 0x00C00A0B
		public override void Refresh(IEffectCountItemData data, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(data.IsActive);
		}

		// Token: 0x0602A95E RID: 174430 RVA: 0x00C02820 File Offset: 0x00C00A20
		public UniTask ActiveSequence()
		{
			EffectCountItem.<ActiveSequence>d__6 <ActiveSequence>d__;
			<ActiveSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ActiveSequence>d__.<>4__this = this;
			<ActiveSequence>d__.<>1__state = -1;
			<ActiveSequence>d__.<>t__builder.Start<EffectCountItem.<ActiveSequence>d__6>(ref <ActiveSequence>d__);
			return <ActiveSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602A95F RID: 174431 RVA: 0x00C02864 File Offset: 0x00C00A64
		public UniTask ResetSequence()
		{
			EffectCountItem.<ResetSequence>d__7 <ResetSequence>d__;
			<ResetSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetSequence>d__.<>4__this = this;
			<ResetSequence>d__.<>1__state = -1;
			<ResetSequence>d__.<>t__builder.Start<EffectCountItem.<ResetSequence>d__7>(ref <ResetSequence>d__);
			return <ResetSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602A960 RID: 174432 RVA: 0x00C028A8 File Offset: 0x00C00AA8
		public UniTask FullSequence()
		{
			EffectCountItem.<FullSequence>d__8 <FullSequence>d__;
			<FullSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FullSequence>d__.<>4__this = this;
			<FullSequence>d__.<>1__state = -1;
			<FullSequence>d__.<>t__builder.Start<EffectCountItem.<FullSequence>d__8>(ref <FullSequence>d__);
			return <FullSequence>d__.<>t__builder.Task;
		}

		// Token: 0x040171A7 RID: 94631
		protected UiSequencePlayer Sequence;

		// Token: 0x02009DA6 RID: 40358
		[NullableContext(0)]
		private static class EEffectCountItem
		{
			// Token: 0x0403106B RID: 200811
			public const int NormalItem = 0;

			// Token: 0x0403106C RID: 200812
			public const int ActiveItem = 1;

			// Token: 0x0403106D RID: 200813
			public const int FullItem = 2;
		}
	}
}
