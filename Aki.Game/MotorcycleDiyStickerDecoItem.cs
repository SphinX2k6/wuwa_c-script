using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001765 RID: 5989
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyStickerDecoItem : GridProxyAbstract<MotorcycleDiyStickerDecoItemData>
{
	// Token: 0x0600E891 RID: 59537 RVA: 0x00442788 File Offset: 0x00440988
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
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

	// Token: 0x0600E892 RID: 59538 RVA: 0x0044288C File Offset: 0x00440A8C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyStickerDecoItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyStickerDecoItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E893 RID: 59539 RVA: 0x004428D0 File Offset: 0x00440AD0
	[NullableContext(1)]
	public override void Refresh(MotorcycleDiyStickerDecoItemData data, bool isSelected, int gridIndex)
	{
		if (data == null)
		{
			return;
		}
		bool flag = this.Data == null || this.Data.ItemId != data.ItemId;
		this.Data = data;
		UUISprite sprite = base.GetSprite(1);
		UUIItem item = base.GetItem(2);
		UUITexture texture = base.GetTexture(3);
		UUIItem item2 = base.GetItem(4);
		UUIItem item3 = base.GetItem(5);
		UUIItem item4 = base.GetItem(6);
		UUIItem item5 = base.GetItem(7);
		UUIItem item6 = base.GetItem(8);
		sprite.SetUIActive(false);
		item.SetUIActive(false);
		texture.SetUIActive(false);
		item2.SetUIActive(false);
		item4.SetUIActive(false);
		item5.SetUIActive(false);
		item6.SetUIActive(false);
		bool flag2 = (data.IsSticker ? MotorcycleDiyModel.Instance.GetSelectedStickerId(data.Part) : MotorcycleDiyModel.Instance.GetSelectedDecorationId(data.Part)) == data.ItemId;
		if (data.ItemId <= 0)
		{
			string path = data.IsSticker ? ConfigCommonParamById.GetStringConfig("MotorEmptyStickerIcon") : ConfigCommonParamById.GetStringConfig("MotorEmptyDecorationIcon");
			bool uiactive = data.IsSticker ? MotorcycleDiyModel.Instance.IsEquipDefaultSticker(data.Part) : MotorcycleDiyModel.Instance.IsEquipDefaultDecoration(data.Part);
			item.SetUIActive(true);
			base.SetTextureByPath(path, texture, null, null);
			item4.SetUIActive(uiactive);
			item3.SetUIActive(false);
			this.CurrentState = null;
		}
		else
		{
			string icon;
			int qualityId;
			if (data.IsSticker)
			{
				MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(data.ItemId);
				if (motorStickerConfig == null)
				{
					return;
				}
				icon = motorStickerConfig.Value.Icon;
				qualityId = motorStickerConfig.Value.QualityId;
			}
			else
			{
				MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(data.ItemId);
				if (motorDecorationConfig == null)
				{
					return;
				}
				icon = motorDecorationConfig.Value.Icon;
				qualityId = motorDecorationConfig.Value.QualityId;
			}
			sprite.SetUIActive(true);
			texture.SetUIActive(true);
			base.SetTextureByPath(icon, texture, null, null);
			MotorQuality? motorQualityConfig = MotorDiyConfig.Instance.GetMotorQualityConfig(qualityId);
			if (motorQualityConfig == null)
			{
				return;
			}
			this.SetSpriteByPath(motorQualityConfig.Value.Path, sprite, false, null, null);
			EOutLookState eoutLookState = data.IsSticker ? MotorcycleDiyModel.Instance.GetStickerState(data.ItemId) : MotorcycleDiyModel.Instance.GetDecorationState(data.ItemId);
			bool flag3 = this.CurrentState == null || this.CurrentState.Value != eoutLookState;
			this.CurrentState = new EOutLookState?(eoutLookState);
			switch (eoutLookState)
			{
			case EOutLookState.IsEquipped:
				item4.SetUIActive(true);
				break;
			case EOutLookState.IsLock:
				item6.SetUIActive(flag2);
				break;
			case EOutLookState.IsBan:
				item2.SetUIActive(true);
				break;
			}
			if (flag || flag3)
			{
				item3.SetUIActive(eoutLookState == EOutLookState.IsLock);
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
				if (eoutLookState != EOutLookState.IsEquipped && MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(data.ItemId))
				{
					MotorcycleDiyModel.Instance.RemoveRedDotInViewOpenCache(data.ItemId);
					item3.SetUIActive(true);
					this.SeqPlayer.PlayOrReplaySequenceByName("Unlock", false, null);
				}
			}
		}
		EToggleState state = flag2 ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600E894 RID: 59540 RVA: 0x00442C80 File Offset: 0x00440E80
	public override void OnSelected(bool fireEvent)
	{
		if (this.Data == null)
		{
			return;
		}
		Action<int, UUIExtendToggle, UUIItem> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Data.ItemId, base.GetExtendToggle(0), base.GetItem(7));
	}

	// Token: 0x0600E895 RID: 59541 RVA: 0x00442CB4 File Offset: 0x00440EB4
	private void OnClickItem(EToggleState toggleState)
	{
		if (this.Data == null)
		{
			return;
		}
		Action<int, UUIExtendToggle, UUIItem> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Data.ItemId, base.GetExtendToggle(0), base.GetItem(7));
	}

	// Token: 0x04008471 RID: 33905
	private MotorcycleDiyStickerDecoItemData Data;

	// Token: 0x04008472 RID: 33906
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008473 RID: 33907
	private EOutLookState? CurrentState;

	// Token: 0x04008474 RID: 33908
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<int, UUIExtendToggle, UUIItem> OnClickToggleBack;

	// Token: 0x0200794F RID: 31055
	[NullableContext(0)]
	private class EStickerDecoItemComponent
	{
		// Token: 0x04027518 RID: 161048
		public const int TogItem = 0;

		// Token: 0x04027519 RID: 161049
		public const int SprQuality = 1;

		// Token: 0x0402751A RID: 161050
		public const int PnlNone = 2;

		// Token: 0x0402751B RID: 161051
		public const int TexIcon = 3;

		// Token: 0x0402751C RID: 161052
		public const int PnlBan = 4;

		// Token: 0x0402751D RID: 161053
		public const int PnlLock = 5;

		// Token: 0x0402751E RID: 161054
		public const int PnlSelect = 6;

		// Token: 0x0402751F RID: 161055
		public const int NewItem = 7;

		// Token: 0x04027520 RID: 161056
		public const int PreviewItem = 8;
	}
}
