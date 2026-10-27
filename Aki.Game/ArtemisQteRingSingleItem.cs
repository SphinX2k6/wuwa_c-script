using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001105 RID: 4357
[NullableContext(2)]
[Nullable(0)]
public class ArtemisQteRingSingleItem : UiPanelBase
{
	// Token: 0x060071A2 RID: 29090 RVA: 0x00173E64 File Offset: 0x00172064
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

	// Token: 0x060071A3 RID: 29091 RVA: 0x00173ED4 File Offset: 0x001720D4
	protected override UniTask OnBeforeStartAsync()
	{
		ArtemisQteRingSingleItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ArtemisQteRingSingleItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060071A4 RID: 29092 RVA: 0x00173F17 File Offset: 0x00172117
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x060071A5 RID: 29093 RVA: 0x00173F34 File Offset: 0x00172134
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

	// Token: 0x060071A6 RID: 29094 RVA: 0x00173FA0 File Offset: 0x001721A0
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

	// Token: 0x060071A7 RID: 29095 RVA: 0x00174014 File Offset: 0x00172214
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

	// Token: 0x060071A8 RID: 29096 RVA: 0x00174098 File Offset: 0x00172298
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

	// Token: 0x060071A9 RID: 29097 RVA: 0x00174110 File Offset: 0x00172310
	public void SetAlpha(float alpha)
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAlpha(alpha);
	}

	// Token: 0x060071AA RID: 29098 RVA: 0x00174124 File Offset: 0x00172324
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

	// Token: 0x060071AB RID: 29099 RVA: 0x00174178 File Offset: 0x00172378
	[NullableContext(1)]
	public void PlayLevelSequenceByName(string sequenceName)
	{
		this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
	}

	// Token: 0x060071AC RID: 29100 RVA: 0x0017419C File Offset: 0x0017239C
	[NullableContext(1)]
	public void StopPlayingSequence(string sequenceName)
	{
		if (this.SequencePlayer.GetCurrentSequence() == sequenceName)
		{
			this.SequencePlayer.StopPlayingSequence(false, true);
		}
	}

	// Token: 0x040034C5 RID: 13509
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040034C6 RID: 13510
	private ArtemisQteRingSingleAreaItem NormalItem;

	// Token: 0x040034C7 RID: 13511
	private ArtemisQteRingSingleAreaItem MissItem;

	// Token: 0x040034C8 RID: 13512
	private ArtemisQteRingSingleAreaItem PerfectItem;

	// Token: 0x020076C7 RID: 30407
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027337 RID: 160567
		public const int PanelCircleTop = 0;

		// Token: 0x04027338 RID: 160568
		public const int PanelAreaNormal = 1;

		// Token: 0x04027339 RID: 160569
		public const int PanelAreaMiss = 2;

		// Token: 0x0402733A RID: 160570
		public const int PanelAreaPerfect = 3;
	}
}
