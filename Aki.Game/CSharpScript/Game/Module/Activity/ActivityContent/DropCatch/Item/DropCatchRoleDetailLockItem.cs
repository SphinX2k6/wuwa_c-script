using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066E7 RID: 26343
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchRoleDetailLockItem : UiPanelBase
	{
		// Token: 0x06041D55 RID: 269653 RVA: 0x00FF72B0 File Offset: 0x00FF54B0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClicked))
			};
		}

		// Token: 0x06041D56 RID: 269654 RVA: 0x00FF732D File Offset: 0x00FF552D
		public void SetClicked(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06041D57 RID: 269655 RVA: 0x00FF7336 File Offset: 0x00FF5536
		public void OnClicked()
		{
			this.ClickCallback();
		}

		// Token: 0x040224AA RID: 140458
		private Action ClickCallback = delegate()
		{
		};
	}
}
