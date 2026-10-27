using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B4 RID: 18100
	public class MobileSwitchInputView : UiViewBase
	{
		// Token: 0x0602EAE6 RID: 191206 RVA: 0x00ACDEDB File Offset: 0x00ACC0DB
		[NullableContext(1)]
		public MobileSwitchInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602EAE7 RID: 191207 RVA: 0x00ACDEE4 File Offset: 0x00ACC0E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602EAE8 RID: 191208 RVA: 0x00ACDF50 File Offset: 0x00ACC150
		protected override void OnStart()
		{
			bool flag = (bool)this.OpenParam;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag);
		}

		// Token: 0x0602EAE9 RID: 191209 RVA: 0x00ACDF91 File Offset: 0x00ACC191
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(new Action<bool>(MobileSwitchInputController.Instance.ReOpenBattleView));
		}

		// Token: 0x0200A8F3 RID: 43251
		private class EComponentDefine
		{
			// Token: 0x040336CF RID: 210639
			public const int MobileTex = 0;

			// Token: 0x040336D0 RID: 210640
			public const int GamepadTex = 1;
		}
	}
}
