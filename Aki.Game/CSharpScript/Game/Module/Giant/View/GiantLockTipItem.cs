using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200597F RID: 22911
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantLockTipItem : UiPanelBase
	{
		// Token: 0x0603A241 RID: 238145 RVA: 0x00DD30E8 File Offset: 0x00DD12E8
		public UniTask Init(UUIItem item)
		{
			GiantLockTipItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GiantLockTipItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603A242 RID: 238146 RVA: 0x00DD3134 File Offset: 0x00DD1334
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A243 RID: 238147 RVA: 0x00DD31FB File Offset: 0x00DD13FB
		public void SetHelpCallback(Action call)
		{
			this.OnClickHelpCall = call;
		}

		// Token: 0x0603A244 RID: 238148 RVA: 0x00DD3204 File Offset: 0x00DD1404
		public void SetTipText(string text)
		{
			if (text.Length <= 0)
			{
				return;
			}
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0603A245 RID: 238149 RVA: 0x00DD3223 File Offset: 0x00DD1423
		private void OnClickHelpBtn()
		{
			Action onClickHelpCall = this.OnClickHelpCall;
			if (onClickHelpCall == null)
			{
				return;
			}
			onClickHelpCall();
		}

		// Token: 0x0401E55B RID: 124251
		[Nullable(2)]
		private Action OnClickHelpCall;
	}
}
