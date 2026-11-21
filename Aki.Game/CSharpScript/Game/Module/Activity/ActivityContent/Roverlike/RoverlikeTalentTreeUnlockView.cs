using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005126 RID: 20774
	public class RoverlikeTalentTreeUnlockView : UiViewBase
	{
		// Token: 0x06033F02 RID: 212738 RVA: 0x00E87C50 File Offset: 0x00E85E50
		[NullableContext(1)]
		public RoverlikeTalentTreeUnlockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033F03 RID: 212739 RVA: 0x00E87C5C File Offset: 0x00E85E5C
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

		// Token: 0x06033F04 RID: 212740 RVA: 0x00E87D24 File Offset: 0x00E85F24
		protected override void OnStart()
		{
			RoverlikeTalentUnlockViewParam roverlikeTalentUnlockViewParam = this.OpenParam as RoverlikeTalentUnlockViewParam;
			if (roverlikeTalentUnlockViewParam != null && !string.IsNullOrEmpty(roverlikeTalentUnlockViewParam.DescTextId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roverlikeTalentUnlockViewParam.DescTextId, roverlikeTalentUnlockViewParam.DescParams.ToArray());
			}
		}

		// Token: 0x06033F05 RID: 212741 RVA: 0x00E87D6F File Offset: 0x00E85F6F
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200ADE0 RID: 44512
		private class EComponentDefine
		{
			// Token: 0x04035BB8 RID: 220088
			public const int BtnClose = 0;

			// Token: 0x04035BB9 RID: 220089
			public const int TxtInfo = 1;

			// Token: 0x04035BBA RID: 220090
			public const int TxtTips = 2;
		}
	}
}
