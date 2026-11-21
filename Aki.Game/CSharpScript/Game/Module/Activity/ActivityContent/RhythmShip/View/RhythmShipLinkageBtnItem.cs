using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02005199 RID: 20889
	internal class RhythmShipLinkageBtnItem : UiPanelBase
	{
		// Token: 0x06034276 RID: 213622 RVA: 0x00E974BC File Offset: 0x00E956BC
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

		// Token: 0x06034277 RID: 213623 RVA: 0x00E9753C File Offset: 0x00E9573C
		public void RefreshItem(bool isToLinkage)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(isToLinkage ? "T_IconRhythmShipLevelPic02" : "T_IconRhythmShipLevelPic01");
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), isToLinkage ? "RhythmShipLevelToLinkageArea" : "RhythmShipLevelToNormalArea", Array.Empty<object>());
		}

		// Token: 0x06034278 RID: 213624 RVA: 0x00E975A0 File Offset: 0x00E957A0
		private void OnClickLinkageBtn()
		{
			Action onClickLinkageBtnCallBack = this.OnClickLinkageBtnCallBack;
			if (onClickLinkageBtnCallBack == null)
			{
				return;
			}
			onClickLinkageBtnCallBack();
		}

		// Token: 0x0401BA2E RID: 113198
		[Nullable(2)]
		public Action OnClickLinkageBtnCallBack;
	}
}
