using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02003C53 RID: 15443
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseRouletteItemTips : UiPanelBase
	{
		// Token: 0x060278F1 RID: 162033 RVA: 0x00B19910 File Offset: 0x00B17B10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060278F2 RID: 162034 RVA: 0x00B19958 File Offset: 0x00B17B58
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x060278F3 RID: 162035 RVA: 0x00B1996C File Offset: 0x00B17B6C
		protected override UniTask OnBeforeHideAsync()
		{
			TrapDefenseRouletteItemTips.<OnBeforeHideAsync>d__4 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseRouletteItemTips.<OnBeforeHideAsync>d__4>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060278F4 RID: 162036 RVA: 0x00B199AF File Offset: 0x00B17BAF
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x060278F5 RID: 162037 RVA: 0x00B199BC File Offset: 0x00B17BBC
		public void RefreshTips(string tips)
		{
			if (tips != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), tips, Array.Empty<object>());
				this.SetActive(true);
				if (this.Tips != null)
				{
					this.Sequence.PlaySequencePurely("UiSwitch", false, false);
				}
				else
				{
					this.Sequence.PlaySequencePurely("UiIn", false, false);
				}
			}
			else
			{
				this.SetActive(false);
			}
			this.Tips = tips;
		}

		// Token: 0x04015941 RID: 88385
		[Nullable(1)]
		protected UiSequencePlayer Sequence;

		// Token: 0x04015942 RID: 88386
		protected string Tips;
	}
}
