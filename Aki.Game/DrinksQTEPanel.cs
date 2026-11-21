using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200041E RID: 1054
[NullableContext(1)]
[Nullable(0)]
public class DrinksQTEPanel : UiPanelBase
{
	// Token: 0x06003880 RID: 14464 RVA: 0x00148C08 File Offset: 0x00146E08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06003881 RID: 14465 RVA: 0x00148CBC File Offset: 0x00146EBC
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksQTEPanel.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksQTEPanel.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003882 RID: 14466 RVA: 0x00148D00 File Offset: 0x00146F00
	protected override void OnStart()
	{
		this.MaxTime = (float)DrinksConfig.Instance.GetQTETimeLimit();
		this.Speed = (float)DrinksConfig.Instance.GetQTESpeed();
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		FRotator frotator = this.CurRot.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06003883 RID: 14467 RVA: 0x00148D50 File Offset: 0x00146F50
	public void StartQTE()
	{
		this.IsFront = true;
		DrinksPlayProxy proxy = DrinksModel.Instance.GetProxy();
		proxy.HideClose();
		proxy.SetNeedTick(true);
		this.CurRot.Yaw = 45f;
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			FRotator frotator = this.CurRot.ToUeRotator();
			item.SetUIRelativeRotation(frotator);
		}
		this.CurTime = 0f;
		DrinksQTEButton button = this.Button;
		if (button != null)
		{
			button.SetSelfActive(true);
		}
		DrinksModel instance = DrinksModel.Instance;
		EDrinksPlayStep curStep = instance.GetCurStep();
		DrinksResultInfo currentPlayData = instance.GetCurrentPlayData();
		int id = (curStep == EDrinksPlayStep.Drink1) ? currentPlayData.DrinkBase[0] : currentPlayData.DrinkBase[1];
		DrinksSoftDrinkData drinksByBaseId = instance.GetDrinksByBaseId(id);
		this.QTEList = new List<int>(drinksByBaseId.GetAllBaseId());
		this.InitSectionItem();
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MakeDrinkQTEShow");
	}

	// Token: 0x06003884 RID: 14468 RVA: 0x00148E40 File Offset: 0x00147040
	protected void InitSectionItem()
	{
		this.ThreePart1.SetUiActive(this.QTEList.Count == 3);
		this.ThreePart2.SetUiActive(this.QTEList.Count == 3);
		this.ThreePart3.SetUiActive(this.QTEList.Count == 3);
		this.TwoPart1.SetUiActive(this.QTEList.Count == 2);
		this.TwoPart2.SetUiActive(this.QTEList.Count == 2);
		for (int i = 0; i < this.QTEList.Count; i++)
		{
			if (this.QTEList.Count == 3)
			{
				this.ThreePartList[i].ApplyDrinkData(this.QTEList[i]);
			}
			else
			{
				this.TwoPartList[i].ApplyDrinkData(this.QTEList[i]);
			}
		}
	}

	// Token: 0x06003885 RID: 14469 RVA: 0x00148F2C File Offset: 0x0014712C
	protected void UpdateSectionItem()
	{
		int endSection = this.GetEndSection();
		for (int i = 0; i < this.QTEList.Count; i++)
		{
			if (this.QTEList.Count == 3)
			{
				this.ThreePartList[i].SetIsSelected(i == endSection);
			}
			else
			{
				this.TwoPartList[i].SetIsSelected(i == endSection);
			}
		}
	}

	// Token: 0x06003886 RID: 14470 RVA: 0x00148F90 File Offset: 0x00147190
	protected void OnProcessEnd()
	{
		int endSection = this.GetEndSection();
		DrinksModel instance = DrinksModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OnDrinkBaseQTEEnd(this.QTEList[endSection]);
	}

	// Token: 0x06003887 RID: 14471 RVA: 0x00148FC0 File Offset: 0x001471C0
	protected int GetEndSection()
	{
		float num = this.CurRot.Yaw + 45f;
		float num2 = 90f / (float)this.QTEList.Count;
		int num3 = (int)Math.Max(1.0, Math.Ceiling((double)(num / num2)));
		return this.QTEList.Count - num3;
	}

	// Token: 0x06003888 RID: 14472 RVA: 0x00149018 File Offset: 0x00147218
	public void OnTick(float deltaTime)
	{
		this.CurTime += deltaTime;
		float num = 90f / this.Speed * deltaTime;
		float num2 = this.CurRot.Yaw + num * (float)(this.IsFront ? -1 : 1);
		if (this.IsFront && num2 <= -45f)
		{
			num2 = -45f;
			this.IsFront = false;
		}
		else if (!this.IsFront && num2 >= 45f)
		{
			num2 = 45f;
			this.IsFront = true;
		}
		this.CurRot.Yaw = num2;
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			FRotator frotator = this.CurRot.ToUeRotator();
			item.SetUIRelativeRotation(frotator);
		}
		this.Button.OnTick(1f - this.CurTime / this.MaxTime);
		if (this.CurTime >= this.MaxTime)
		{
			DrinksQTEButton button = this.Button;
			if (button == null)
			{
				return;
			}
			button.OnClickedBtn();
		}
	}

	// Token: 0x06003889 RID: 14473 RVA: 0x00149102 File Offset: 0x00147302
	private void OnClickedCb()
	{
		DrinksQTEButton button = this.Button;
		if (button != null)
		{
			button.SetSelfActive(false);
		}
		this.UpdateSectionItem();
		DrinksModel.Instance.GetProxy().SetNeedTick(false);
	}

	// Token: 0x0600388A RID: 14474 RVA: 0x0014912C File Offset: 0x0014732C
	public void OnFadeSequenceEnd()
	{
		this.OnProcessEnd();
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(false);
	}

	// Token: 0x04002E64 RID: 11876
	protected float MaxTime = 9f;

	// Token: 0x04002E65 RID: 11877
	protected float CurTime;

	// Token: 0x04002E66 RID: 11878
	protected float Speed;

	// Token: 0x04002E67 RID: 11879
	protected Rotator CurRot = Rotator.Create(0f, 45f, 0f);

	// Token: 0x04002E68 RID: 11880
	[Nullable(2)]
	protected DrinksQTEButton Button;

	// Token: 0x04002E69 RID: 11881
	protected List<int> QTEList = new List<int>();

	// Token: 0x04002E6A RID: 11882
	protected List<DrinksQTESectionItem> ThreePartList = new List<DrinksQTESectionItem>();

	// Token: 0x04002E6B RID: 11883
	protected DrinksQTESectionItem ThreePart1;

	// Token: 0x04002E6C RID: 11884
	protected DrinksQTESectionItem ThreePart2;

	// Token: 0x04002E6D RID: 11885
	protected DrinksQTESectionItem ThreePart3;

	// Token: 0x04002E6E RID: 11886
	protected List<DrinksQTESectionItem> TwoPartList = new List<DrinksQTESectionItem>();

	// Token: 0x04002E6F RID: 11887
	protected DrinksQTESectionItem TwoPart1;

	// Token: 0x04002E70 RID: 11888
	protected DrinksQTESectionItem TwoPart2;

	// Token: 0x04002E71 RID: 11889
	protected bool IsFront = true;

	// Token: 0x02006747 RID: 26439
	[NullableContext(0)]
	private static class EItem
	{
		// Token: 0x040221B2 RID: 139698
		public const int BtnItem = 0;

		// Token: 0x040221B3 RID: 139699
		public const int ThreePartItem1 = 1;

		// Token: 0x040221B4 RID: 139700
		public const int ThreePartItem2 = 2;

		// Token: 0x040221B5 RID: 139701
		public const int ThreePartItem3 = 3;

		// Token: 0x040221B6 RID: 139702
		public const int TwoPartItem1 = 4;

		// Token: 0x040221B7 RID: 139703
		public const int TwoPartItem2 = 5;

		// Token: 0x040221B8 RID: 139704
		public const int Pointer = 6;
	}
}
