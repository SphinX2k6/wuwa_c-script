using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B5C RID: 19292
	public class TowerDefenseStrengthenTipsItem : UiPanelBase
	{
		// Token: 0x06031F39 RID: 204601 RVA: 0x00B977C8 File Offset: 0x00B959C8
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

		// Token: 0x06031F3A RID: 204602 RVA: 0x00B97810 File Offset: 0x00B95A10
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06031F3B RID: 204603 RVA: 0x00B97823 File Offset: 0x00B95A23
		[NullableContext(1)]
		public void SetTextByKey(string textKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
		}

		// Token: 0x06031F3C RID: 204604 RVA: 0x00B9783C File Offset: 0x00B95A3C
		public UniTask PlayStartSequenceAsync()
		{
			TowerDefenseStrengthenTipsItem.<PlayStartSequenceAsync>d__5 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsItem.<PlayStartSequenceAsync>d__5>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F3D RID: 204605 RVA: 0x00B97880 File Offset: 0x00B95A80
		public UniTask PlayCloseSequenceAsync()
		{
			TowerDefenseStrengthenTipsItem.<PlayCloseSequenceAsync>d__6 <PlayCloseSequenceAsync>d__;
			<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequenceAsync>d__.<>4__this = this;
			<PlayCloseSequenceAsync>d__.<>1__state = -1;
			<PlayCloseSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsItem.<PlayCloseSequenceAsync>d__6>(ref <PlayCloseSequenceAsync>d__);
			return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401AA2A RID: 109098
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200ACE9 RID: 44265
		private class EItemComponent
		{
			// Token: 0x040348A3 RID: 215203
			public const int TipsText = 0;
		}
	}
}
