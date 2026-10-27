using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002710 RID: 10000
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoOddsItem : GridProxyAbstract<IRacingBetsDangoActorData>
{
	// Token: 0x060147F6 RID: 83958 RVA: 0x0052D42C File Offset: 0x0052B62C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060147F7 RID: 83959 RVA: 0x0052D4BF File Offset: 0x0052B6BF
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x060147F8 RID: 83960 RVA: 0x0052D4E3 File Offset: 0x0052B6E3
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
	}

	// Token: 0x060147F9 RID: 83961 RVA: 0x0052D504 File Offset: 0x0052B704
	public override void Refresh(IRacingBetsDangoActorData data, bool isSelected, int gridIndex)
	{
		this.DangoOddsData = data;
		DangoData dangoData = DangoManager.Instance.GetDangoData(this.DangoOddsData.DangoId);
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText((this.DangoOddsData.Odds / 100).ToString(), true);
		}
		base.SetTextureShowUntilLoaded(dangoData.Icon, base.GetTexture(2), null);
		this.RefreshSelect(false);
	}

	// Token: 0x060147FA RID: 83962 RVA: 0x0052D572 File Offset: 0x0052B772
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
	}

	// Token: 0x060147FB RID: 83963 RVA: 0x0052D590 File Offset: 0x0052B790
	public void RefreshOddsDango(int dangoId)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(dangoId == this.DangoOddsData.DangoId);
	}

	// Token: 0x060147FC RID: 83964 RVA: 0x0052D5B1 File Offset: 0x0052B7B1
	public override void OnSelected(bool fireEvent)
	{
		this.RefreshSelect(true);
	}

	// Token: 0x060147FD RID: 83965 RVA: 0x0052D5BA File Offset: 0x0052B7BA
	public override void OnDeselected(bool fireEvent)
	{
		this.RefreshSelect(false);
	}

	// Token: 0x060147FE RID: 83966 RVA: 0x0052D5C3 File Offset: 0x0052B7C3
	private void RefreshSelect(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060147FF RID: 83967 RVA: 0x0052D5E0 File Offset: 0x0052B7E0
	public void BindClickGearItemCallBack(Action<IRacingBetsDangoActorData> clickDangoOddsItemCallBack)
	{
		this.ClickDangoOddsItemCallBack = clickDangoOddsItemCallBack;
	}

	// Token: 0x06014800 RID: 83968 RVA: 0x0052D5E9 File Offset: 0x0052B7E9
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<IRacingBetsDangoActorData> clickDangoOddsItemCallBack = this.ClickDangoOddsItemCallBack;
		if (clickDangoOddsItemCallBack == null)
		{
			return;
		}
		clickDangoOddsItemCallBack(this.DangoOddsData);
	}

	// Token: 0x06014801 RID: 83969 RVA: 0x0052D601 File Offset: 0x0052B801
	private bool CanToggleExecuteChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x06014802 RID: 83970 RVA: 0x0052D61C File Offset: 0x0052B81C
	private void OnRacingBetsDangoOddsUpdate()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText((this.DangoOddsData.Odds / 100).ToString(), true);
	}

	// Token: 0x04009A37 RID: 39479
	private IRacingBetsDangoActorData DangoOddsData;

	// Token: 0x04009A38 RID: 39480
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<IRacingBetsDangoActorData> ClickDangoOddsItemCallBack;

	// Token: 0x02008D5E RID: 36190
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DDFA RID: 187898
		Toggle,
		// Token: 0x0402DDFB RID: 187899
		OddsText,
		// Token: 0x0402DDFC RID: 187900
		DangoIcon,
		// Token: 0x0402DDFD RID: 187901
		OddsDangoItem
	}
}
