using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020009B4 RID: 2484
public class SignRewardItemBase : UiPanelBase
{
	// Token: 0x06006D0D RID: 27917 RVA: 0x0021C158 File Offset: 0x0021A358
	public virtual void RefreshByData(OneItemConfig data, SignState state, int index)
	{
	}

	// Token: 0x06006D0E RID: 27918 RVA: 0x0021C15A File Offset: 0x0021A35A
	[NullableContext(1)]
	protected string GetRewardStateTextId(SignState state)
	{
		switch (state)
		{
		case SignState.Lock:
			return "NeedSign";
		case SignState.Unlock:
			return "CanGetReward";
		case SignState.IsReceive:
			return "CollectActivity_state_recived";
		default:
			return "NeedSign";
		}
	}

	// Token: 0x06006D0F RID: 27919 RVA: 0x0021C187 File Offset: 0x0021A387
	protected void OnClickToggle(EToggleState toggleState)
	{
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Index);
	}

	// Token: 0x06006D10 RID: 27920 RVA: 0x0021C19F File Offset: 0x0021A39F
	protected void OnClickButton()
	{
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Index);
	}

	// Token: 0x06006D11 RID: 27921 RVA: 0x0021C1B7 File Offset: 0x0021A3B7
	protected override void OnBeforeDestroyImplement()
	{
		this.OnClickToGet = null;
	}

	// Token: 0x04004406 RID: 17414
	protected int Index;

	// Token: 0x04004407 RID: 17415
	protected bool CanGetReward;

	// Token: 0x04004408 RID: 17416
	[Nullable(2)]
	public Action<int> OnClickToGet;
}
