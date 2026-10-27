using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029D3 RID: 10707
public class ShipTowerShowBuffView : UiTickViewBase
{
	// Token: 0x06016300 RID: 90880 RVA: 0x0059CA0D File Offset: 0x0059AC0D
	[NullableContext(1)]
	public ShipTowerShowBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016301 RID: 90881 RVA: 0x0059CA24 File Offset: 0x0059AC24
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnRoot))
		};
	}

	// Token: 0x06016302 RID: 90882 RVA: 0x0059CAB7 File Offset: 0x0059ACB7
	private void InitDataParam()
	{
		this.ShowBuffIdList = ShipTowerModel.Instance.ShowBuffIdList;
	}

	// Token: 0x06016303 RID: 90883 RVA: 0x0059CACC File Offset: 0x0059ACCC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerShowBuffView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerShowBuffView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016304 RID: 90884 RVA: 0x0059CB0F File Offset: 0x0059AD0F
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06016305 RID: 90885 RVA: 0x0059CB18 File Offset: 0x0059AD18
	private void UpdateData()
	{
		int num = 0;
		if (this.ShowBuffIdList.Count > 0)
		{
			num = this.ShowBuffIdList[0];
			this.ShowBuffIdList.RemoveAt(0);
		}
		ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(num);
		this.CurBuffId = new int?(num);
		if (buffDataByBuffId == null)
		{
			base.CloseMe(null);
			return;
		}
		this.TipCountDown = (float)CalabashConfig.Instance.MaxTipCd;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(buffDataByBuffId.ItemNameKey);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.ShowTextNew(buffDataByBuffId.ObtainedShowDescKey);
		}
		SmallItemGrid itemGrid = this.ItemGrid;
		if (itemGrid == null)
		{
			return;
		}
		itemGrid.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			ItemConfigId = new int?(buffDataByBuffId.ItemId),
			Data = null
		});
	}

	// Token: 0x06016306 RID: 90886 RVA: 0x0059CBDF File Offset: 0x0059ADDF
	protected override void OnTick(float delta)
	{
		if (this.TipCountDown <= 0f)
		{
			return;
		}
		this.TipCountDown -= delta;
		if (this.TipCountDown <= 0f)
		{
			this.CloseViewOrShowNextData();
		}
	}

	// Token: 0x06016307 RID: 90887 RVA: 0x0059CC10 File Offset: 0x0059AE10
	protected void CloseViewOrShowNextData()
	{
		if (this.ShowBuffIdList.Count > 0)
		{
			this.ShowNextBuff().Forget();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06016308 RID: 90888 RVA: 0x0059CC34 File Offset: 0x0059AE34
	private UniTask ShowNextBuff()
	{
		ShipTowerShowBuffView.<ShowNextBuff>d__13 <ShowNextBuff>d__;
		<ShowNextBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowNextBuff>d__.<>4__this = this;
		<ShowNextBuff>d__.<>1__state = -1;
		<ShowNextBuff>d__.<>t__builder.Start<ShipTowerShowBuffView.<ShowNextBuff>d__13>(ref <ShowNextBuff>d__);
		return <ShowNextBuff>d__.<>t__builder.Task;
	}

	// Token: 0x06016309 RID: 90889 RVA: 0x0059CC77 File Offset: 0x0059AE77
	private void OnClickBtnRoot()
	{
		EventSystem.Instance.Emit(EEventName.OpenActivityViewShipTower);
	}

	// Token: 0x0400A52F RID: 42287
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x0400A530 RID: 42288
	private float TipCountDown;

	// Token: 0x0400A531 RID: 42289
	[Nullable(1)]
	private List<int> ShowBuffIdList = new List<int>();

	// Token: 0x0400A532 RID: 42290
	public int? CurBuffId;

	// Token: 0x02008FFB RID: 36859
	private static class EChildType
	{
		// Token: 0x0402E9F6 RID: 190966
		public const int ItemGrid = 0;

		// Token: 0x0402E9F7 RID: 190967
		public const int TxtName = 1;

		// Token: 0x0402E9F8 RID: 190968
		public const int TxtDesc = 2;

		// Token: 0x0402E9F9 RID: 190969
		public const int BtnRoot = 3;
	}
}
