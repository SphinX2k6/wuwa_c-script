using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014FC RID: 5372
public class SignRewardItemBase : UiPanelBase
{
	// Token: 0x06009933 RID: 39219 RVA: 0x0021243F File Offset: 0x0021063F
	public virtual void RefreshByData(OneItemConfig data, SignState state, int index)
	{
	}

	// Token: 0x06009934 RID: 39220 RVA: 0x00212441 File Offset: 0x00210641
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

	// Token: 0x06009935 RID: 39221 RVA: 0x0021246E File Offset: 0x0021066E
	protected void OnClickToggle(EToggleState toggleState)
	{
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Index);
	}

	// Token: 0x06009936 RID: 39222 RVA: 0x00212486 File Offset: 0x00210686
	protected void OnClickButton()
	{
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Index);
	}

	// Token: 0x06009937 RID: 39223 RVA: 0x0021249E File Offset: 0x0021069E
	protected override void OnBeforeDestroyImplement()
	{
		this.OnClickToGet = null;
	}

	// Token: 0x04004361 RID: 17249
	protected int Index;

	// Token: 0x04004362 RID: 17250
	protected bool CanGetReward;

	// Token: 0x04004363 RID: 17251
	[Nullable(2)]
	public Action<int> OnClickToGet;
}
