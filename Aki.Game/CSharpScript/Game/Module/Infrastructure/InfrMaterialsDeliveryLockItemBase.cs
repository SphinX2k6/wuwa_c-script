using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F3 RID: 18675
	public class InfrMaterialsDeliveryLockItemBase : UiPanelBase
	{
		// Token: 0x0602EE08 RID: 192008 RVA: 0x00D13964 File Offset: 0x00D11B64
		[NullableContext(1)]
		public void Refresh(InfrastructureDefine.IInfrMaterialsDeliveryLockData data)
		{
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, data.LockDescriptionTextId, data.LockDescriptionTextArgs ?? Array.Empty<string>());
		}

		// Token: 0x0200A5B2 RID: 42418
		private class EChildType
		{
			// Token: 0x04033447 RID: 209991
			public const int LockSprite = 0;

			// Token: 0x04033448 RID: 209992
			public const int LockDescriptionText = 1;

			// Token: 0x04033449 RID: 209993
			public const int FunctionButton = 2;
		}
	}
}
