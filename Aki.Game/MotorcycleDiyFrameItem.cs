using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200175C RID: 5980
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyFrameItem : GridProxyAbstract<MotorcycleDiyFrameItemData>
{
	// Token: 0x0600E858 RID: 59480 RVA: 0x004410A8 File Offset: 0x0043F2A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
		};
	}

	// Token: 0x0600E859 RID: 59481 RVA: 0x004411AC File Offset: 0x0043F3AC
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyFrameItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyFrameItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E85A RID: 59482 RVA: 0x004411F0 File Offset: 0x0043F3F0
	[NullableContext(1)]
	public override void Refresh(MotorcycleDiyFrameItemData data, bool isSelected, int gridIndex)
	{
		bool flag = this.FrameId != data.ItemId;
		this.FrameId = data.ItemId;
		UUITexture texture = base.GetTexture(1);
		UUITexture texture2 = base.GetTexture(2);
		UUITexture texture3 = base.GetTexture(3);
		UUIItem item = base.GetItem(4);
		UUIItem item2 = base.GetItem(5);
		UUIItem item3 = base.GetItem(6);
		UUIItem item4 = base.GetItem(7);
		UUIItem item5 = base.GetItem(8);
		item.SetUIActive(false);
		item3.SetUIActive(false);
		item4.SetUIActive(false);
		item5.SetUIActive(false);
		bool flag2 = MotorcycleDiyModel.Instance.GetSelectedFrameId() == data.ItemId;
		EOutLookState frameState = MotorcycleDiyModel.Instance.GetFrameState(data.ItemId);
		bool flag3 = this.CurrentState == null || this.CurrentState.Value != frameState;
		this.CurrentState = new EOutLookState?(frameState);
		switch (frameState)
		{
		case EOutLookState.IsEquipped:
			item.SetUIActive(true);
			break;
		case EOutLookState.IsLock:
			item5.SetUIActive(flag2);
			break;
		case EOutLookState.IsBan:
			item4.SetUIActive(true);
			break;
		}
		if (flag || flag3)
		{
			item2.SetUIActive(frameState == EOutLookState.IsLock);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopCurrentSequence(false, true);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 != null)
			{
				seqPlayer2.PlayOrReplaySequenceByName("Lock", false, null);
			}
			if (frameState != EOutLookState.IsEquipped && MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(data.ItemId))
			{
				MotorcycleDiyModel.Instance.RemoveRedDotInViewOpenCache(data.ItemId);
				item2.SetUIActive(true);
				this.SeqPlayer.PlayOrReplaySequenceByName("Unlock", false, null);
			}
		}
		MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(data.ItemId);
		if (motorFrameConfig == null)
		{
			return;
		}
		MotorQuality? motorQualityConfig = MotorDiyConfig.Instance.GetMotorQualityConfig(motorFrameConfig.Value.QualityId);
		if (motorQualityConfig == null)
		{
			return;
		}
		base.SetTextureByPath(motorFrameConfig.Value.ModelIconPath, texture, null, null);
		base.SetTextureByPath(motorQualityConfig.Value.FramePath, texture2, null, null);
		base.SetTextureByPath(motorQualityConfig.Value.FrameShinePath, texture3, null, null);
		EToggleState state = flag2 ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600E85B RID: 59483 RVA: 0x00441468 File Offset: 0x0043F668
	public override void OnSelected(bool fireEvent)
	{
		this.OnClickToggleCallBack();
	}

	// Token: 0x0600E85C RID: 59484 RVA: 0x00441470 File Offset: 0x0043F670
	private void OnClickItem(EToggleState toggleState)
	{
		this.OnClickToggleCallBack();
	}

	// Token: 0x0600E85D RID: 59485 RVA: 0x00441478 File Offset: 0x0043F678
	private void OnClickToggleCallBack()
	{
		if (this.FrameId == 0)
		{
			return;
		}
		Action<int, UUIExtendToggle, UUIItem> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.FrameId, base.GetExtendToggle(0), base.GetItem(6));
	}

	// Token: 0x0400845F RID: 33887
	private int FrameId;

	// Token: 0x04008460 RID: 33888
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008461 RID: 33889
	private EOutLookState? CurrentState;

	// Token: 0x04008462 RID: 33890
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<int, UUIExtendToggle, UUIItem> OnClickToggleBack;

	// Token: 0x02007944 RID: 31044
	private class EFrameItemComponent
	{
		// Token: 0x040274E2 RID: 160994
		public const int TogFrame = 0;

		// Token: 0x040274E3 RID: 160995
		public const int TexIcon = 1;

		// Token: 0x040274E4 RID: 160996
		public const int TexQuality1 = 2;

		// Token: 0x040274E5 RID: 160997
		public const int TexQuality2 = 3;

		// Token: 0x040274E6 RID: 160998
		public const int PnlSelect = 4;

		// Token: 0x040274E7 RID: 160999
		public const int Pnllock = 5;

		// Token: 0x040274E8 RID: 161000
		public const int NewItem = 6;

		// Token: 0x040274E9 RID: 161001
		public const int BanItem = 7;

		// Token: 0x040274EA RID: 161002
		public const int PreviewItem = 8;
	}
}
