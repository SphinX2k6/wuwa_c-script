using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002529 RID: 9513
public class GetLinkBtn : UiPanelBase
{
	// Token: 0x06013210 RID: 78352 RVA: 0x004BF824 File Offset: 0x004BDA24
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

	// Token: 0x06013211 RID: 78353 RVA: 0x004BF8A4 File Offset: 0x004BDAA4
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

	// Token: 0x06013212 RID: 78354 RVA: 0x004BF95A File Offset: 0x004BDB5A
	[NullableContext(1)]
	public void SetLinkText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
	}

	// Token: 0x06013213 RID: 78355 RVA: 0x004BF973 File Offset: 0x004BDB73
	private void OnButtonClicked()
	{
		Action onClickGetLink = this.OnClickGetLink;
		if (onClickGetLink == null)
		{
			return;
		}
		onClickGetLink();
	}

	// Token: 0x0400906E RID: 36974
	private int CurGetWayId;

	// Token: 0x0400906F RID: 36975
	[Nullable(2)]
	private Action OnClickGetLink;

	// Token: 0x02008AB3 RID: 35507
	private enum EBtnGetLinkComponent
	{
		// Token: 0x0402D0B8 RID: 184504
		BtnLink,
		// Token: 0x0402D0B9 RID: 184505
		SpriteTrackIcon,
		// Token: 0x0402D0BA RID: 184506
		TxtLink
	}
}
