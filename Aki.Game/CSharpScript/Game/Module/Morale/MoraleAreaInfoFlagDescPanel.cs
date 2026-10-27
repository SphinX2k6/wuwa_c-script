using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02005398 RID: 21400
	public class MoraleAreaInfoFlagDescPanel : UiPanelBase
	{
		// Token: 0x06036AC6 RID: 223942 RVA: 0x00CF0750 File Offset: 0x00CEE950
		[NullableContext(1)]
		public UniTask Init(UUIItem item)
		{
			MoraleAreaInfoFlagDescPanel.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleAreaInfoFlagDescPanel.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036AC7 RID: 223943 RVA: 0x00CF079C File Offset: 0x00CEE99C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036AC8 RID: 223944 RVA: 0x00CF0863 File Offset: 0x00CEEA63
		[NullableContext(1)]
		public void UpdateDesc(string descKey)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(descKey);
		}

		// Token: 0x06036AC9 RID: 223945 RVA: 0x00CF0877 File Offset: 0x00CEEA77
		private void OnBtnMask()
		{
			this.SetActive(false);
		}

		// Token: 0x0200B602 RID: 46594
		private enum EChildType
		{
			// Token: 0x04037219 RID: 225817
			BtnMask,
			// Token: 0x0403721A RID: 225818
			ItemRoot,
			// Token: 0x0403721B RID: 225819
			TextDesc
		}
	}
}
