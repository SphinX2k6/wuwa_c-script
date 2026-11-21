using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C9D RID: 19613
	public class CommonTopButtonPanel : BattleEntranceButton
	{
		// Token: 0x06030F67 RID: 200551 RVA: 0x00DA8C54 File Offset: 0x00DA6E54
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickedOnlineButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030F68 RID: 200552 RVA: 0x00DA8D1C File Offset: 0x00DA6F1C
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			if (param == null)
			{
				return;
			}
			EntranceButtonParameter entranceButtonParameter = (EntranceButtonParameter)param;
			if (!string.IsNullOrEmpty(entranceButtonParameter.IconPath))
			{
				this.SetSpriteByPath(entranceButtonParameter.IconPath, base.GetSprite(2), false, null, null);
			}
			base.Initialize(param);
		}

		// Token: 0x0200A8B1 RID: 43185
		private enum EBtn
		{
			// Token: 0x040341BF RID: 213439
			Btn,
			// Token: 0x040341C0 RID: 213440
			RedDot,
			// Token: 0x040341C1 RID: 213441
			Icon
		}
	}
}
