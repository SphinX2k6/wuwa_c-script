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
	// Token: 0x0200437B RID: 17275
	public class MoraleAreaInfoFlagDescPanel : UiPanelBase
	{
		// Token: 0x0602BA0C RID: 178700 RVA: 0x00C3F7F8 File Offset: 0x00C3D9F8
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

		// Token: 0x0602BA0D RID: 178701 RVA: 0x00C3F844 File Offset: 0x00C3DA44
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

		// Token: 0x0602BA0E RID: 178702 RVA: 0x00C3F90B File Offset: 0x00C3DB0B
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

		// Token: 0x0602BA0F RID: 178703 RVA: 0x00C3F91F File Offset: 0x00C3DB1F
		private void OnBtnMask()
		{
			this.SetActive(false);
		}

		// Token: 0x0200A03A RID: 41018
		private enum EChildType
		{
			// Token: 0x04031C6E RID: 203886
			BtnMask,
			// Token: 0x04031C6F RID: 203887
			ItemRoot,
			// Token: 0x04031C70 RID: 203888
			TextDesc
		}
	}
}
