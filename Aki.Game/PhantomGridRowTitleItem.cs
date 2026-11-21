using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200195E RID: 6494
public class PhantomGridRowTitleItem : SyncGridProxyAbstract<int>
{
	// Token: 0x06010097 RID: 65687 RVA: 0x004AD280 File Offset: 0x004AB480
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(delegate()
			{
				Action clickRecommendBtnCb = this.ClickRecommendBtnCb;
				if (clickRecommendBtnCb == null)
				{
					return;
				}
				clickRecommendBtnCb();
			}))
		};
	}

	// Token: 0x06010098 RID: 65688 RVA: 0x004AD2E8 File Offset: 0x004AB4E8
	public override void Refresh(int data)
	{
		bool uiactive = false;
		string textStringId;
		if (data - 1 > 1)
		{
			if (data != 3)
			{
				textStringId = "";
			}
			else
			{
				textStringId = "PhantomDisplay_ElseTitle";
			}
		}
		else
		{
			uiactive = true;
			textStringId = "PhantomDisplay_RecommendingTitle";
		}
		bool selfInteractive = data != 2;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(uiactive);
		}
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(selfInteractive);
	}

	// Token: 0x04008E72 RID: 36466
	[Nullable(2)]
	public Action ClickRecommendBtnCb;
}
