using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061A8 RID: 25000
	public class RoverlikeTalentTreeUnlockView : UiViewBase
	{
		// Token: 0x0603F242 RID: 258626 RVA: 0x00F40D88 File Offset: 0x00F3EF88
		[NullableContext(1)]
		public RoverlikeTalentTreeUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F243 RID: 258627 RVA: 0x00F40D94 File Offset: 0x00F3EF94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F244 RID: 258628 RVA: 0x00F40E5C File Offset: 0x00F3F05C
		protected override void OnStart()
		{
			RoverlikeTalentUnlockViewParam roverlikeTalentUnlockViewParam = this.OpenParam as RoverlikeTalentUnlockViewParam;
			if (roverlikeTalentUnlockViewParam != null && !string.IsNullOrEmpty(roverlikeTalentUnlockViewParam.DescTextId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roverlikeTalentUnlockViewParam.DescTextId, roverlikeTalentUnlockViewParam.DescParams.ToArray());
			}
		}

		// Token: 0x0603F245 RID: 258629 RVA: 0x00F40EA7 File Offset: 0x00F3F0A7
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200C3F9 RID: 50169
		private class EComponentDefine
		{
			// Token: 0x0403B257 RID: 242263
			public const int BtnClose = 0;

			// Token: 0x0403B258 RID: 242264
			public const int TxtInfo = 1;

			// Token: 0x0403B259 RID: 242265
			public const int TxtTips = 2;
		}
	}
}
