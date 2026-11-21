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
	// Token: 0x02003B04 RID: 15108
	public class TowerDefenseStrengthenTipsItem : UiPanelBase
	{
		// Token: 0x06026CC8 RID: 158920 RVA: 0x00ADBA04 File Offset: 0x00AD9C04
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

		// Token: 0x06026CC9 RID: 158921 RVA: 0x00ADBA4C File Offset: 0x00AD9C4C
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06026CCA RID: 158922 RVA: 0x00ADBA5F File Offset: 0x00AD9C5F
		[NullableContext(1)]
		public void SetTextByKey(string textKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textKey, Array.Empty<object>());
		}

		// Token: 0x06026CCB RID: 158923 RVA: 0x00ADBA78 File Offset: 0x00AD9C78
		public UniTask PlayStartSequenceAsync()
		{
			TowerDefenseStrengthenTipsItem.<PlayStartSequenceAsync>d__5 <PlayStartSequenceAsync>d__;
			<PlayStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequenceAsync>d__.<>4__this = this;
			<PlayStartSequenceAsync>d__.<>1__state = -1;
			<PlayStartSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsItem.<PlayStartSequenceAsync>d__5>(ref <PlayStartSequenceAsync>d__);
			return <PlayStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026CCC RID: 158924 RVA: 0x00ADBABC File Offset: 0x00AD9CBC
		public UniTask PlayCloseSequenceAsync()
		{
			TowerDefenseStrengthenTipsItem.<PlayCloseSequenceAsync>d__6 <PlayCloseSequenceAsync>d__;
			<PlayCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequenceAsync>d__.<>4__this = this;
			<PlayCloseSequenceAsync>d__.<>1__state = -1;
			<PlayCloseSequenceAsync>d__.<>t__builder.Start<TowerDefenseStrengthenTipsItem.<PlayCloseSequenceAsync>d__6>(ref <PlayCloseSequenceAsync>d__);
			return <PlayCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401537C RID: 86908
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x02009708 RID: 38664
		private class EItemComponent
		{
			// Token: 0x0402F24C RID: 193100
			public const int TipsText = 0;
		}
	}
}
