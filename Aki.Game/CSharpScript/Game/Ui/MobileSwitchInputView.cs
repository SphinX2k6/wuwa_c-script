using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035E5 RID: 13797
	public class MobileSwitchInputView : UiViewBase
	{
		// Token: 0x06023232 RID: 143922 RVA: 0x009FC7AF File Offset: 0x009FA9AF
		[NullableContext(1)]
		public MobileSwitchInputView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06023233 RID: 143923 RVA: 0x009FC7B8 File Offset: 0x009FA9B8
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

		// Token: 0x06023234 RID: 143924 RVA: 0x009FC824 File Offset: 0x009FAA24
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

		// Token: 0x06023235 RID: 143925 RVA: 0x009FC865 File Offset: 0x009FAA65
		protected override void OnAfterPlayStartSequence()
		{
			base.CloseMe(new Action<bool>(MobileSwitchInputController.Instance.ReOpenBattleView));
		}

		// Token: 0x020092AE RID: 37550
		private class EComponentDefine
		{
			// Token: 0x0402DE63 RID: 188003
			public const int MobileTex = 0;

			// Token: 0x0402DE64 RID: 188004
			public const int GamepadTex = 1;
		}
	}
}
