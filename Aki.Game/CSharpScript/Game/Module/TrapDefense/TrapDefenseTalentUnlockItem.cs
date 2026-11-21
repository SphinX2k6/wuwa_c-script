using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A81 RID: 14977
	public class TrapDefenseTalentUnlockItem : UiPanelBase
	{
		// Token: 0x0602679F RID: 157599 RVA: 0x00AC79BC File Offset: 0x00AC5BBC
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

		// Token: 0x060267A0 RID: 157600 RVA: 0x00AC7A46 File Offset: 0x00AC5C46
		protected override void OnStart()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ETrapDefenseTextKey.TalentNodeUnlocked.ToString(), Array.Empty<object>());
		}

		// Token: 0x02009679 RID: 38521
		private class EComponentDefine
		{
			// Token: 0x0402EFBB RID: 192443
			public const int SpriteLock = 0;

			// Token: 0x0402EFBC RID: 192444
			public const int TextUnlock = 1;

			// Token: 0x0402EFBD RID: 192445
			public const int BtnHelp = 2;
		}
	}
}
