using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FoxGamePlay
{
	// Token: 0x02005FA2 RID: 24482
	public class FoxFailureTipsView : UiViewBase
	{
		// Token: 0x0603AD2B RID: 240939 RVA: 0x010A1736 File Offset: 0x0109F936
		[NullableContext(1)]
		public FoxFailureTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603AD2C RID: 240940 RVA: 0x010A1740 File Offset: 0x0109F940
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

		// Token: 0x0603AD2D RID: 240941 RVA: 0x010A1791 File Offset: 0x0109F991
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

		// Token: 0x0401EEBC RID: 126652
		private bool IsClosing;

		// Token: 0x0200B8CA RID: 47306
		private enum EChildCom
		{
			// Token: 0x0403909F RID: 233631
			BtnMask = 1
		}
	}
}
