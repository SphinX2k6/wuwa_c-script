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
	// Token: 0x02004958 RID: 18776
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantLockTipItem : UiPanelBase
	{
		// Token: 0x0602F167 RID: 192871 RVA: 0x00D22578 File Offset: 0x00D20778
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

		// Token: 0x0602F168 RID: 192872 RVA: 0x00D225C4 File Offset: 0x00D207C4
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

		// Token: 0x0602F169 RID: 192873 RVA: 0x00D2268B File Offset: 0x00D2088B
		public void SetHelpCallback(Action call)
		{
			this.OnClickHelpCall = call;
		}

		// Token: 0x0602F16A RID: 192874 RVA: 0x00D22694 File Offset: 0x00D20894
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

		// Token: 0x0602F16B RID: 192875 RVA: 0x00D226B3 File Offset: 0x00D208B3
		private void OnClickHelpBtn()
		{
			Action onClickHelpCall = this.OnClickHelpCall;
			if (onClickHelpCall == null)
			{
				return;
			}
			onClickHelpCall();
		}

		// Token: 0x04018FF9 RID: 102393
		[Nullable(2)]
		private Action OnClickHelpCall;
	}
}
