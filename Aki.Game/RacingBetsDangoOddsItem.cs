using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001BFB RID: 7163
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoOddsItem : GridProxyAbstract<IRacingBetsDangoActorData>
{
	// Token: 0x06011CD8 RID: 72920 RVA: 0x0053C148 File Offset: 0x0053A348
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

	// Token: 0x06011CD9 RID: 72921 RVA: 0x0053C1DB File Offset: 0x0053A3DB
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x06011CDA RID: 72922 RVA: 0x0053C1FF File Offset: 0x0053A3FF
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
	}

	// Token: 0x06011CDB RID: 72923 RVA: 0x0053C220 File Offset: 0x0053A420
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

	// Token: 0x06011CDC RID: 72924 RVA: 0x0053C28E File Offset: 0x0053A48E
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnRacingBetsDangoOddsUpdate, new Action(this.OnRacingBetsDangoOddsUpdate));
	}

	// Token: 0x06011CDD RID: 72925 RVA: 0x0053C2AC File Offset: 0x0053A4AC
	public void RefreshOddsDango(int dangoId)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(dangoId == this.DangoOddsData.DangoId);
	}

	// Token: 0x06011CDE RID: 72926 RVA: 0x0053C2CD File Offset: 0x0053A4CD
	public override void OnSelected(bool fireEvent)
	{
		this.RefreshSelect(true);
	}

	// Token: 0x06011CDF RID: 72927 RVA: 0x0053C2D6 File Offset: 0x0053A4D6
	public override void OnDeselected(bool fireEvent)
	{
		this.RefreshSelect(false);
	}

	// Token: 0x06011CE0 RID: 72928 RVA: 0x0053C2DF File Offset: 0x0053A4DF
	private void RefreshSelect(bool isSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06011CE1 RID: 72929 RVA: 0x0053C2FC File Offset: 0x0053A4FC
	public void BindClickGearItemCallBack(Action<IRacingBetsDangoActorData> clickDangoOddsItemCallBack)
	{
		this.ClickDangoOddsItemCallBack = clickDangoOddsItemCallBack;
	}

	// Token: 0x06011CE2 RID: 72930 RVA: 0x0053C305 File Offset: 0x0053A505
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<IRacingBetsDangoActorData> clickDangoOddsItemCallBack = this.ClickDangoOddsItemCallBack;
		if (clickDangoOddsItemCallBack == null)
		{
			return;
		}
		clickDangoOddsItemCallBack(this.DangoOddsData);
	}

	// Token: 0x06011CE3 RID: 72931 RVA: 0x0053C31D File Offset: 0x0053A51D
	private bool CanToggleExecuteChange()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		return extendToggle == null || extendToggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x06011CE4 RID: 72932 RVA: 0x0053C338 File Offset: 0x0053A538
	private void OnRacingBetsDangoOddsUpdate()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText((this.DangoOddsData.Odds / 100).ToString(), true);
	}

	// Token: 0x04009B8F RID: 39823
	private IRacingBetsDangoActorData DangoOddsData;

	// Token: 0x04009B90 RID: 39824
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<IRacingBetsDangoActorData> ClickDangoOddsItemCallBack;

	// Token: 0x02007EE7 RID: 32487
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029111 RID: 168209
		Toggle,
		// Token: 0x04029112 RID: 168210
		OddsText,
		// Token: 0x04029113 RID: 168211
		DangoIcon,
		// Token: 0x04029114 RID: 168212
		OddsDangoItem
	}
}
