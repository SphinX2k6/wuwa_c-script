using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x02005637 RID: 22071
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchRoleDetailLockItem : UiPanelBase
	{
		// Token: 0x060368A1 RID: 223393 RVA: 0x00F386B4 File Offset: 0x00F368B4
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

		// Token: 0x060368A2 RID: 223394 RVA: 0x00F38731 File Offset: 0x00F36931
		public void SetClicked(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x060368A3 RID: 223395 RVA: 0x00F3873A File Offset: 0x00F3693A
		public void OnClicked()
		{
			this.ClickCallback();
		}

		// Token: 0x0401CD03 RID: 118019
		private Action ClickCallback = delegate()
		{
		};
	}
}
