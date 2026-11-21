using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005B9 RID: 1465
[NullableContext(2)]
[Nullable(0)]
public class ArtemisQteRingSingleItem : UiPanelBase
{
	// Token: 0x06004538 RID: 17720 RVA: 0x0017C820 File Offset: 0x0017AA20
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

	// Token: 0x06004539 RID: 17721 RVA: 0x0017C890 File Offset: 0x0017AA90
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisQteRingSingleItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisQteRingSingleItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600453A RID: 17722 RVA: 0x0017C8D3 File Offset: 0x0017AAD3
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x0600453B RID: 17723 RVA: 0x0017C8F0 File Offset: 0x0017AAF0
	public void SetRotation(float angle)
	{
		FRotator frotator = Rotator.Create(0f, angle, 0f).ToUeRotator();
		ArtemisQteRingSingleAreaItem normalItem = this.NormalItem;
		if (normalItem != null)
		{
			normalItem.GetRootItem().SetUIRelativeRotation(frotator);
		}
		ArtemisQteRingSingleAreaItem missItem = this.MissItem;
		if (missItem != null)
		{
			missItem.GetRootItem().SetUIRelativeRotation(frotator);
		}
		ArtemisQteRingSingleAreaItem perfectItem = this.PerfectItem;
		if (perfectItem == null)
		{
			return;
		}
		perfectItem.GetRootItem().SetUIRelativeRotation(frotator);
	}

	// Token: 0x0600453C RID: 17724 RVA: 0x0017C95C File Offset: 0x0017AB5C
	public void InitItem()
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			FRotator frotator = Rotator.Create(0f, 0f, 0f).ToUeRotator();
			rootItem.SetUIRelativeRotation(frotator);
		}
		UUIItem rootItem2 = base.GetRootItem();
		if (rootItem2 != null)
		{
			rootItem2.SetUIItemScale(new FVector(1f, 1f, 1f));
		}
		UUIItem rootItem3 = base.GetRootItem();
		if (rootItem3 == null)
		{
			return;
		}
		rootItem3.SetAlpha(1f);
	}

	// Token: 0x0600453D RID: 17725 RVA: 0x0017C9D0 File Offset: 0x0017ABD0
	public void SetType(EArtemisAreaType type)
	{
		this.SetActive(true);
		ArtemisQteRingSingleAreaItem normalItem = this.NormalItem;
		if (normalItem != null)
		{
			normalItem.SetHighLight(type == EArtemisAreaType.PerfectArea);
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(type == EArtemisAreaType.BlankArea);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetAlpha(1f);
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 != null)
		{
			item3.SetAlpha(0f);
		}
		UUIItem item4 = base.GetItem(3);
		if (item4 == null)
		{
			return;
		}
		item4.SetAlpha(0f);
	}

	// Token: 0x0600453E RID: 17726 RVA: 0x0017CA54 File Offset: 0x0017AC54
	public void SetFill(float amount)
	{
		ArtemisQteRingSingleAreaItem normalItem = this.NormalItem;
		if (normalItem != null)
		{
			normalItem.SetFillAmount(amount);
		}
		ArtemisQteRingSingleAreaItem missItem = this.MissItem;
		if (missItem != null)
		{
			missItem.SetFillAmount(amount);
		}
		ArtemisQteRingSingleAreaItem perfectItem = this.PerfectItem;
		if (perfectItem != null)
		{
			perfectItem.SetFillAmount(amount);
		}
		ArtemisQteRingSingleAreaItem normalItem2 = this.NormalItem;
		if (normalItem2 != null)
		{
			normalItem2.SetCustomMaterialScalarParameter(amount);
		}
		ArtemisQteRingSingleAreaItem missItem2 = this.MissItem;
		if (missItem2 != null)
		{
			missItem2.SetCustomMaterialScalarParameter(amount);
		}
		ArtemisQteRingSingleAreaItem perfectItem2 = this.PerfectItem;
		if (perfectItem2 == null)
		{
			return;
		}
		perfectItem2.SetCustomMaterialScalarParameter(amount);
	}

	// Token: 0x0600453F RID: 17727 RVA: 0x0017CACC File Offset: 0x0017ACCC
	public void SetAlpha(float alpha)
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAlpha(alpha);
	}

	// Token: 0x06004540 RID: 17728 RVA: 0x0017CAE0 File Offset: 0x0017ACE0
	[NullableContext(1)]
	public void PlayAnim(string sequenceName)
	{
		if (this.SequencePlayer.GetCurrentSequence() == sequenceName)
		{
			this.SequencePlayer.ReplaySequenceByKey(sequenceName);
			return;
		}
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x06004541 RID: 17729 RVA: 0x0017CB34 File Offset: 0x0017AD34
	[NullableContext(1)]
	public void PlayLevelSequenceByName(string sequenceName)
	{
		this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x06004542 RID: 17730 RVA: 0x0017CB58 File Offset: 0x0017AD58
	[NullableContext(1)]
	public void StopPlayingSequence(string sequenceName)
	{
		if (this.SequencePlayer.GetCurrentSequence() == sequenceName)
		{
			this.SequencePlayer.StopPlayingSequence(false, true);
		}
	}

	// Token: 0x0400355E RID: 13662
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400355F RID: 13663
	private ArtemisQteRingSingleAreaItem NormalItem;

	// Token: 0x04003560 RID: 13664
	private ArtemisQteRingSingleAreaItem MissItem;

	// Token: 0x04003561 RID: 13665
	private ArtemisQteRingSingleAreaItem PerfectItem;

	// Token: 0x0200685B RID: 26715
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022680 RID: 140928
		public const int PanelCircleTop = 0;

		// Token: 0x04022681 RID: 140929
		public const int PanelAreaNormal = 1;

		// Token: 0x04022682 RID: 140930
		public const int PanelAreaMiss = 2;

		// Token: 0x04022683 RID: 140931
		public const int PanelAreaPerfect = 3;
	}
}
