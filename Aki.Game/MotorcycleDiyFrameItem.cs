using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002278 RID: 8824
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyFrameItem : GridProxyAbstract<MotorcycleDiyFrameItemData>
{
	// Token: 0x060113C2 RID: 70594 RVA: 0x0043449C File Offset: 0x0043269C
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

	// Token: 0x060113C3 RID: 70595 RVA: 0x004345A0 File Offset: 0x004327A0
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyFrameItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyFrameItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060113C4 RID: 70596 RVA: 0x004345E4 File Offset: 0x004327E4
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

	// Token: 0x060113C5 RID: 70597 RVA: 0x0043485C File Offset: 0x00432A5C
	public override void OnSelected(bool fireEvent)
	{
		this.OnClickToggleCallBack();
	}

	// Token: 0x060113C6 RID: 70598 RVA: 0x00434864 File Offset: 0x00432A64
	private void OnClickItem(EToggleState toggleState)
	{
		this.OnClickToggleCallBack();
	}

	// Token: 0x060113C7 RID: 70599 RVA: 0x0043486C File Offset: 0x00432A6C
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

	// Token: 0x04008321 RID: 33569
	private int FrameId;

	// Token: 0x04008322 RID: 33570
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008323 RID: 33571
	private EOutLookState? CurrentState;

	// Token: 0x04008324 RID: 33572
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<int, UUIExtendToggle, UUIItem> OnClickToggleBack;

	// Token: 0x020087BB RID: 34747
	private class EFrameItemComponent
	{
		// Token: 0x0402C1CA RID: 180682
		public const int TogFrame = 0;

		// Token: 0x0402C1CB RID: 180683
		public const int TexIcon = 1;

		// Token: 0x0402C1CC RID: 180684
		public const int TexQuality1 = 2;

		// Token: 0x0402C1CD RID: 180685
		public const int TexQuality2 = 3;

		// Token: 0x0402C1CE RID: 180686
		public const int PnlSelect = 4;

		// Token: 0x0402C1CF RID: 180687
		public const int Pnllock = 5;

		// Token: 0x0402C1D0 RID: 180688
		public const int NewItem = 6;

		// Token: 0x0402C1D1 RID: 180689
		public const int BanItem = 7;

		// Token: 0x0402C1D2 RID: 180690
		public const int PreviewItem = 8;
	}
}
