using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005B7 RID: 1463
[NullableContext(2)]
[Nullable(0)]
public class ArtemisQteRingBgSingleItem : UiPanelBase
{
	// Token: 0x0600452C RID: 17708 RVA: 0x0017C590 File Offset: 0x0017A790
	public ArtemisQteRingBgSingleItem(int startIndex, int endIndex, bool isWholeRing)
	{
		this.StartIndex = startIndex;
		this.EndIndex = endIndex;
		this.IsWholeRing = isWholeRing;
	}

	// Token: 0x0600452D RID: 17709 RVA: 0x0017C5B0 File Offset: 0x0017A7B0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600452E RID: 17710 RVA: 0x0017C620 File Offset: 0x0017A820
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisQteRingBgSingleItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisQteRingBgSingleItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600452F RID: 17711 RVA: 0x0017C663 File Offset: 0x0017A863
	protected override void OnStart()
	{
		this.Init();
	}

	// Token: 0x06004530 RID: 17712 RVA: 0x0017C66C File Offset: 0x0017A86C
	private void Init()
	{
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(2);
		int num = Math.Max(this.StartIndex - 1, 0) * 10;
		FRotator frotator = Rotator.Create(0f, (float)(-(float)num), 0f).ToUeRotator();
		item.SetUIRelativeRotation(frotator);
		item2.SetUIRelativeRotation(frotator);
		float fillAmount = (float)ArtemisQteDefine.CalculateCellSize(this.StartIndex, this.EndIndex) / 36f;
		this.NormalItem.SetFillAmount(fillAmount);
		this.MissItem.SetFillAmount(fillAmount);
	}

	// Token: 0x06004531 RID: 17713 RVA: 0x0017C6F4 File Offset: 0x0017A8F4
	public void SetType(EArtemisAreaType type)
	{
		switch (type)
		{
		case EArtemisAreaType.BlankArea:
			base.GetItem(1).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(0).SetUIActive(true);
			break;
		case EArtemisAreaType.QteArea:
		case EArtemisAreaType.PerfectArea:
			break;
		default:
			return;
		}
	}

	// Token: 0x04003557 RID: 13655
	protected int StartIndex;

	// Token: 0x04003558 RID: 13656
	protected int EndIndex;

	// Token: 0x04003559 RID: 13657
	protected bool IsWholeRing;

	// Token: 0x0400355A RID: 13658
	private ArtemisQteRingSingleAreaItem NormalItem;

	// Token: 0x0400355B RID: 13659
	private ArtemisQteRingSingleAreaItem MissItem;

	// Token: 0x0400355C RID: 13660
	private ArtemisQteRingSingleAreaItem PerfectItem;

	// Token: 0x02006858 RID: 26712
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022676 RID: 140918
		public const int PanelCircleTop = 0;

		// Token: 0x04022677 RID: 140919
		public const int PanelAreaNormal = 1;

		// Token: 0x04022678 RID: 140920
		public const int PanelAreaMiss = 2;

		// Token: 0x04022679 RID: 140921
		public const int PanelAreaPerfect = 3;
	}
}
