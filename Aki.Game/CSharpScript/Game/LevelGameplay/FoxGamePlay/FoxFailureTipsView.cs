using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FoxGamePlay
{
	// Token: 0x02006E22 RID: 28194
	public class FoxFailureTipsView : UiViewBase
	{
		// Token: 0x06044BC2 RID: 281538 RVA: 0x010F71FA File Offset: 0x010F53FA
		[NullableContext(1)]
		public FoxFailureTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06044BC3 RID: 281539 RVA: 0x010F7204 File Offset: 0x010F5404
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickMask))
			};
		}

		// Token: 0x06044BC4 RID: 281540 RVA: 0x010F7255 File Offset: 0x010F5455
		private void OnClickMask()
		{
			if (this.IsClosing)
			{
				return;
			}
			this.IsClosing = true;
			LevelLoadingController.Instance.OpenUiTransitionBlackScreen("FoxFailureTipsView", 1500f, 0.5f);
			base.CloseMe(null);
		}

		// Token: 0x04023C19 RID: 146457
		private bool IsClosing;

		// Token: 0x0200CCDA RID: 52442
		private enum EChildCom
		{
			// Token: 0x0403DC7D RID: 253053
			BtnMask = 1
		}
	}
}
