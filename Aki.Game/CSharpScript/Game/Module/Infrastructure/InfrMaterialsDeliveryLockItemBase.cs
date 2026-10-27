using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x0200591A RID: 22810
	public class InfrMaterialsDeliveryLockItemBase : UiPanelBase
	{
		// Token: 0x06039EE5 RID: 237285 RVA: 0x00DC4670 File Offset: 0x00DC2870
		[NullableContext(1)]
		public void Refresh(InfrastructureDefine.IInfrMaterialsDeliveryLockData data)
		{
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(text, data.LockDescriptionTextId, data.LockDescriptionTextArgs ?? Array.Empty<string>());
		}

		// Token: 0x0200BBA2 RID: 48034
		private class EChildType
		{
			// Token: 0x04038A61 RID: 232033
			public const int LockSprite = 0;

			// Token: 0x04038A62 RID: 232034
			public const int LockDescriptionText = 1;

			// Token: 0x04038A63 RID: 232035
			public const int FunctionButton = 2;
		}
	}
}
