using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AD2 RID: 19154
	public class TrapDefenseTalentLockItem : UiPanelBase
	{
		// Token: 0x060319D4 RID: 203220 RVA: 0x00B82224 File Offset: 0x00B80424
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

		// Token: 0x060319D5 RID: 203221 RVA: 0x00B8228D File Offset: 0x00B8048D
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ETrapDefenseTextKey.TalentNodeNeedUnlockPre.ToString(), Array.Empty<object>());
		}

		// Token: 0x0200AC4C RID: 44108
		private class EComponentDefine
		{
			// Token: 0x040345B4 RID: 214452
			public const int SpriteLock = 0;

			// Token: 0x040345B5 RID: 214453
			public const int TextLock = 1;
		}
	}
}
