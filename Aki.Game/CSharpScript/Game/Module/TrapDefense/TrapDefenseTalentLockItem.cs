using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A7A RID: 14970
	public class TrapDefenseTalentLockItem : UiPanelBase
	{
		// Token: 0x06026764 RID: 157540 RVA: 0x00AC61D8 File Offset: 0x00AC43D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026765 RID: 157541 RVA: 0x00AC6241 File Offset: 0x00AC4441
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ETrapDefenseTextKey.TalentNodeNeedUnlockPre.ToString(), Array.Empty<object>());
		}

		// Token: 0x0200966C RID: 38508
		private class EComponentDefine
		{
			// Token: 0x0402EF65 RID: 192357
			public const int SpriteLock = 0;

			// Token: 0x0402EF66 RID: 192358
			public const int TextLock = 1;
		}
	}
}
