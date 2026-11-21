using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F4E RID: 8014
public class ShipTowerShowBuffView : UiTickViewBase
{
	// Token: 0x06013D06 RID: 81158 RVA: 0x005C79C5 File Offset: 0x005C5BC5
	[NullableContext(1)]
	public ShipTowerShowBuffView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013D07 RID: 81159 RVA: 0x005C79DC File Offset: 0x005C5BDC
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

	// Token: 0x06013D08 RID: 81160 RVA: 0x005C7A6F File Offset: 0x005C5C6F
	private void InitDataParam()
	{
		this.ShowBuffIdList = ShipTowerModel.Instance.ShowBuffIdList;
	}

	// Token: 0x06013D09 RID: 81161 RVA: 0x005C7A84 File Offset: 0x005C5C84
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerShowBuffView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerShowBuffView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D0A RID: 81162 RVA: 0x005C7AC7 File Offset: 0x005C5CC7
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06013D0B RID: 81163 RVA: 0x005C7AD0 File Offset: 0x005C5CD0
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

	// Token: 0x06013D0C RID: 81164 RVA: 0x005C7B97 File Offset: 0x005C5D97
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

	// Token: 0x06013D0D RID: 81165 RVA: 0x005C7BC8 File Offset: 0x005C5DC8
	protected void CloseViewOrShowNextData()
	{
		if (this.ShowBuffIdList.Count > 0)
		{
			this.ShowNextBuff().Forget();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06013D0E RID: 81166 RVA: 0x005C7BEC File Offset: 0x005C5DEC
	private UniTask ShowNextBuff()
	{
		ShipTowerShowBuffView.<ShowNextBuff>d__13 <ShowNextBuff>d__;
		<ShowNextBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowNextBuff>d__.<>4__this = this;
		<ShowNextBuff>d__.<>1__state = -1;
		<ShowNextBuff>d__.<>t__builder.Start<ShipTowerShowBuffView.<ShowNextBuff>d__13>(ref <ShowNextBuff>d__);
		return <ShowNextBuff>d__.<>t__builder.Task;
	}

	// Token: 0x06013D0F RID: 81167 RVA: 0x005C7C2F File Offset: 0x005C5E2F
	private void OnClickBtnRoot()
	{
		EventSystem.Instance.Emit(EEventName.OpenActivityViewShipTower);
	}

	// Token: 0x0400A919 RID: 43289
	[Nullable(2)]
	private SmallItemGrid ItemGrid;

	// Token: 0x0400A91A RID: 43290
	private float TipCountDown;

	// Token: 0x0400A91B RID: 43291
	[Nullable(1)]
	private List<int> ShowBuffIdList = new List<int>();

	// Token: 0x0400A91C RID: 43292
	public int? CurBuffId;

	// Token: 0x02008242 RID: 33346
	private static class EChildType
	{
		// Token: 0x0402A0EE RID: 172270
		public const int ItemGrid = 0;

		// Token: 0x0402A0EF RID: 172271
		public const int TxtName = 1;

		// Token: 0x0402A0F0 RID: 172272
		public const int TxtDesc = 2;

		// Token: 0x0402A0F1 RID: 172273
		public const int BtnRoot = 3;
	}
}
