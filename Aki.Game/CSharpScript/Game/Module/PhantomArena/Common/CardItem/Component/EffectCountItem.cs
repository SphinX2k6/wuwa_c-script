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
	// Token: 0x020051EC RID: 20972
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EffectCountItem : GridProxyAbstract<IEffectCountItemData>
	{
		// Token: 0x06035A5E RID: 219742 RVA: 0x00CB50E0 File Offset: 0x00CB32E0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06035A5F RID: 219743 RVA: 0x00CB513A File Offset: 0x00CB333A
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x06035A60 RID: 219744 RVA: 0x00CB5171 File Offset: 0x00CB3371
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035A61 RID: 219745 RVA: 0x00CB5180 File Offset: 0x00CB3380
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

		// Token: 0x06035A62 RID: 219746 RVA: 0x00CB51CF File Offset: 0x00CB33CF
		public override void Refresh(IEffectCountItemData data, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(data.IsActive);
		}

		// Token: 0x06035A63 RID: 219747 RVA: 0x00CB51E4 File Offset: 0x00CB33E4
		public UniTask ActiveSequence()
		{
			EffectCountItem.<ActiveSequence>d__6 <ActiveSequence>d__;
			<ActiveSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ActiveSequence>d__.<>4__this = this;
			<ActiveSequence>d__.<>1__state = -1;
			<ActiveSequence>d__.<>t__builder.Start<EffectCountItem.<ActiveSequence>d__6>(ref <ActiveSequence>d__);
			return <ActiveSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06035A64 RID: 219748 RVA: 0x00CB5228 File Offset: 0x00CB3428
		public UniTask ResetSequence()
		{
			EffectCountItem.<ResetSequence>d__7 <ResetSequence>d__;
			<ResetSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetSequence>d__.<>4__this = this;
			<ResetSequence>d__.<>1__state = -1;
			<ResetSequence>d__.<>t__builder.Start<EffectCountItem.<ResetSequence>d__7>(ref <ResetSequence>d__);
			return <ResetSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06035A65 RID: 219749 RVA: 0x00CB526C File Offset: 0x00CB346C
		public UniTask FullSequence()
		{
			EffectCountItem.<FullSequence>d__8 <FullSequence>d__;
			<FullSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FullSequence>d__.<>4__this = this;
			<FullSequence>d__.<>1__state = -1;
			<FullSequence>d__.<>t__builder.Start<EffectCountItem.<FullSequence>d__8>(ref <FullSequence>d__);
			return <FullSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0401C772 RID: 116594
		protected UiSequencePlayer Sequence;

		// Token: 0x0200B36E RID: 45934
		[NullableContext(0)]
		private static class EEffectCountItem
		{
			// Token: 0x04036618 RID: 222744
			public const int NormalItem = 0;

			// Token: 0x04036619 RID: 222745
			public const int ActiveItem = 1;

			// Token: 0x0403661A RID: 222746
			public const int FullItem = 2;
		}
	}
}
