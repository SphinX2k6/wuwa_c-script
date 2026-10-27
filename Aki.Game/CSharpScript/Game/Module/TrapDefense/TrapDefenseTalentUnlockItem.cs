using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AD9 RID: 19161
	public class TrapDefenseTalentUnlockItem : UiPanelBase
	{
		// Token: 0x06031A0F RID: 203279 RVA: 0x00B83A08 File Offset: 0x00B81C08
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
		}

		// Token: 0x06031A10 RID: 203280 RVA: 0x00B83A92 File Offset: 0x00B81C92
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ETrapDefenseTextKey.TalentNodeUnlocked.ToString(), Array.Empty<object>());
		}

		// Token: 0x0200AC59 RID: 44121
		private class EComponentDefine
		{
			// Token: 0x0403460A RID: 214538
			public const int SpriteLock = 0;

			// Token: 0x0403460B RID: 214539
			public const int TextUnlock = 1;

			// Token: 0x0403460C RID: 214540
			public const int BtnHelp = 2;
		}
	}
}
