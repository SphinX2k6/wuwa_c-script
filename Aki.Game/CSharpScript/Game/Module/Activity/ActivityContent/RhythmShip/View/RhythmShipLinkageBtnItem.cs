using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200621B RID: 25115
	internal class RhythmShipLinkageBtnItem : UiPanelBase
	{
		// Token: 0x0603F5B5 RID: 259509 RVA: 0x00F50564 File Offset: 0x00F4E764
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickLinkageBtn))
			};
		}

		// Token: 0x0603F5B6 RID: 259510 RVA: 0x00F505E4 File Offset: 0x00F4E7E4
		public void RefreshItem(bool isToLinkage)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(isToLinkage ? "T_IconRhythmShipLevelPic02" : "T_IconRhythmShipLevelPic01");
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), isToLinkage ? "RhythmShipLevelToLinkageArea" : "RhythmShipLevelToNormalArea", Array.Empty<object>());
		}

		// Token: 0x0603F5B7 RID: 259511 RVA: 0x00F50648 File Offset: 0x00F4E848
		private void OnClickLinkageBtn()
		{
			Action onClickLinkageBtnCallBack = this.OnClickLinkageBtnCallBack;
			if (onClickLinkageBtnCallBack == null)
			{
				return;
			}
			onClickLinkageBtnCallBack();
		}

		// Token: 0x040210FF RID: 135423
		[Nullable(2)]
		public Action OnClickLinkageBtnCallBack;
	}
}
