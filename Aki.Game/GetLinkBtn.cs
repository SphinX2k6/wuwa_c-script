using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A10 RID: 6672
public class GetLinkBtn : UiPanelBase
{
	// Token: 0x060106D0 RID: 67280 RVA: 0x004CD530 File Offset: 0x004CB730
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClicked))
		};
	}

	// Token: 0x060106D1 RID: 67281 RVA: 0x004CD5B0 File Offset: 0x004CB7B0
	public void RefreshByGetWayId(int getWayId)
	{
		this.CurGetWayId = getWayId;
		AccessPath? configById = GetWayConfig.Instance.GetConfigById(getWayId);
		if (configById == null)
		{
			return;
		}
		int type = configById.Value.Type;
		if (type != 1)
		{
			if (type == 2)
			{
				base.GetButton(0).SetSelfInteractive(true);
				base.GetSprite(1).SetUIActive(true);
			}
		}
		else
		{
			base.GetButton(0).SetSelfInteractive(false);
			base.GetSprite(1).SetUIActive(false);
		}
		this.SetLinkText(configById.Value.Description);
		this.OnClickGetLink = delegate()
		{
			SkipTaskManager.RunByConfigId(getWayId, null);
		};
	}

	// Token: 0x060106D2 RID: 67282 RVA: 0x004CD666 File Offset: 0x004CB866
	[NullableContext(1)]
	public void SetLinkText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
	}

	// Token: 0x060106D3 RID: 67283 RVA: 0x004CD67F File Offset: 0x004CB87F
	private void OnButtonClicked()
	{
		Action onClickGetLink = this.OnClickGetLink;
		if (onClickGetLink == null)
		{
			return;
		}
		onClickGetLink();
	}

	// Token: 0x040091C3 RID: 37315
	private int CurGetWayId;

	// Token: 0x040091C4 RID: 37316
	[Nullable(2)]
	private Action OnClickGetLink;

	// Token: 0x02007C3A RID: 31802
	private enum EBtnGetLinkComponent
	{
		// Token: 0x040283CC RID: 164812
		BtnLink,
		// Token: 0x040283CD RID: 164813
		SpriteTrackIcon,
		// Token: 0x040283CE RID: 164814
		TxtLink
	}
}
