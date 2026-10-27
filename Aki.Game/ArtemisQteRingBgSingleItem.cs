using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001103 RID: 4355
[NullableContext(2)]
[Nullable(0)]
public class ArtemisQteRingBgSingleItem : UiPanelBase
{
	// Token: 0x06007196 RID: 29078 RVA: 0x00173BD4 File Offset: 0x00171DD4
	public ArtemisQteRingBgSingleItem(int startIndex, int endIndex, bool isWholeRing)
	{
		this.StartIndex = startIndex;
		this.EndIndex = endIndex;
		this.IsWholeRing = isWholeRing;
	}

	// Token: 0x06007197 RID: 29079 RVA: 0x00173BF4 File Offset: 0x00171DF4
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

	// Token: 0x06007198 RID: 29080 RVA: 0x00173C64 File Offset: 0x00171E64
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisQteRingBgSingleItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisQteRingBgSingleItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007199 RID: 29081 RVA: 0x00173CA7 File Offset: 0x00171EA7
	protected override void OnStart()
	{
		this.Init();
	}

	// Token: 0x0600719A RID: 29082 RVA: 0x00173CB0 File Offset: 0x00171EB0
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

	// Token: 0x0600719B RID: 29083 RVA: 0x00173D38 File Offset: 0x00171F38
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

	// Token: 0x040034BE RID: 13502
	protected int StartIndex;

	// Token: 0x040034BF RID: 13503
	protected int EndIndex;

	// Token: 0x040034C0 RID: 13504
	protected bool IsWholeRing;

	// Token: 0x040034C1 RID: 13505
	private ArtemisQteRingSingleAreaItem NormalItem;

	// Token: 0x040034C2 RID: 13506
	private ArtemisQteRingSingleAreaItem MissItem;

	// Token: 0x040034C3 RID: 13507
	private ArtemisQteRingSingleAreaItem PerfectItem;

	// Token: 0x020076C4 RID: 30404
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402732D RID: 160557
		public const int PanelCircleTop = 0;

		// Token: 0x0402732E RID: 160558
		public const int PanelAreaNormal = 1;

		// Token: 0x0402732F RID: 160559
		public const int PanelAreaMiss = 2;

		// Token: 0x04027330 RID: 160560
		public const int PanelAreaPerfect = 3;
	}
}
