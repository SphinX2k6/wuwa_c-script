using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063E4 RID: 25572
	public class MowingRiskInstanceDetailLockItem : UiPanelBase
	{
		// Token: 0x0604051B RID: 263451 RVA: 0x00F8EA54 File Offset: 0x00F8CC54
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x0604051C RID: 263452 RVA: 0x00F8EAB0 File Offset: 0x00F8CCB0
		[NullableContext(1)]
		public void RefreshExternalByData(IMowingRiskInstanceDetailLockItemData data)
		{
			UUIText text = base.GetText(1);
			if (!string.IsNullOrEmpty(data.LockDescriptionTextId))
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, data.LockDescriptionTextId, data.LockDescriptionTextArgs);
				return;
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
		}

		// Token: 0x0200C5FF RID: 50687
		private static class ELockComponent
		{
			// Token: 0x0403BC7B RID: 244859
			public const int LockSprite = 0;

			// Token: 0x0403BC7C RID: 244860
			public const int LockDescriptionText = 1;

			// Token: 0x0403BC7D RID: 244861
			public const int FunctionButton = 2;
		}
	}
}
