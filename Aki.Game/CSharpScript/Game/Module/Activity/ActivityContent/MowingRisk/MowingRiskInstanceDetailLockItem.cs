using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005362 RID: 21346
	public class MowingRiskInstanceDetailLockItem : UiPanelBase
	{
		// Token: 0x060351DC RID: 217564 RVA: 0x00ED59EC File Offset: 0x00ED3BEC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x060351DD RID: 217565 RVA: 0x00ED5A48 File Offset: 0x00ED3C48
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

		// Token: 0x0200AFE6 RID: 45030
		private static class ELockComponent
		{
			// Token: 0x040365DA RID: 222682
			public const int LockSprite = 0;

			// Token: 0x040365DB RID: 222683
			public const int LockDescriptionText = 1;

			// Token: 0x040365DC RID: 222684
			public const int FunctionButton = 2;
		}
	}
}
