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
	// Token: 0x02004CA2 RID: 19618
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseRouletteItemTips : UiPanelBase
	{
		// Token: 0x06032B3D RID: 207677 RVA: 0x00BD4B78 File Offset: 0x00BD2D78
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

		// Token: 0x06032B3E RID: 207678 RVA: 0x00BD4BC0 File Offset: 0x00BD2DC0
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06032B3F RID: 207679 RVA: 0x00BD4BD4 File Offset: 0x00BD2DD4
		protected override UniTask OnBeforeHideAsync()
		{
			TrapDefenseRouletteItemTips.<OnBeforeHideAsync>d__4 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<TrapDefenseRouletteItemTips.<OnBeforeHideAsync>d__4>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032B40 RID: 207680 RVA: 0x00BD4C17 File Offset: 0x00BD2E17
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06032B41 RID: 207681 RVA: 0x00BD4C24 File Offset: 0x00BD2E24
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

		// Token: 0x0401AFE0 RID: 110560
		[Nullable(1)]
		protected UiSequencePlayer Sequence;

		// Token: 0x0401AFE1 RID: 110561
		protected string Tips;
	}
}
