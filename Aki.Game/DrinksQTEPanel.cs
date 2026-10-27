using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F69 RID: 3945
[NullableContext(1)]
[Nullable(0)]
public class DrinksQTEPanel : UiPanelBase
{
	// Token: 0x060064E8 RID: 25832 RVA: 0x0014036C File Offset: 0x0013E56C
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

	// Token: 0x060064E9 RID: 25833 RVA: 0x00140420 File Offset: 0x0013E620
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksQTEPanel.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksQTEPanel.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060064EA RID: 25834 RVA: 0x00140464 File Offset: 0x0013E664
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

	// Token: 0x060064EB RID: 25835 RVA: 0x001404B4 File Offset: 0x0013E6B4
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
		this.QTEList = drinksByBaseId.GetAllBaseId().ToList<int>();
		this.InitSectionItem();
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MakeDrinkQTEShow");
	}

	// Token: 0x060064EC RID: 25836 RVA: 0x001405A4 File Offset: 0x0013E7A4
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

	// Token: 0x060064ED RID: 25837 RVA: 0x00140690 File Offset: 0x0013E890
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

	// Token: 0x060064EE RID: 25838 RVA: 0x001406F4 File Offset: 0x0013E8F4
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

	// Token: 0x060064EF RID: 25839 RVA: 0x00140724 File Offset: 0x0013E924
	protected int GetEndSection()
	{
		float num = this.CurRot.Yaw + 45f;
		float num2 = 90f / (float)this.QTEList.Count;
		int num3 = (int)Math.Max(1.0, Math.Ceiling((double)(num / num2)));
		return this.QTEList.Count - num3;
	}

	// Token: 0x060064F0 RID: 25840 RVA: 0x0014077C File Offset: 0x0013E97C
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

	// Token: 0x060064F1 RID: 25841 RVA: 0x00140866 File Offset: 0x0013EA66
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

	// Token: 0x060064F2 RID: 25842 RVA: 0x00140890 File Offset: 0x0013EA90
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

	// Token: 0x04002DCB RID: 11723
	protected float MaxTime = 9f;

	// Token: 0x04002DCC RID: 11724
	protected float CurTime;

	// Token: 0x04002DCD RID: 11725
	protected float Speed;

	// Token: 0x04002DCE RID: 11726
	protected Rotator CurRot = Rotator.Create(0f, 45f, 0f);

	// Token: 0x04002DCF RID: 11727
	[Nullable(2)]
	protected DrinksQTEButton Button;

	// Token: 0x04002DD0 RID: 11728
	protected List<int> QTEList = new List<int>();

	// Token: 0x04002DD1 RID: 11729
	protected List<DrinksQTESectionItem> ThreePartList = new List<DrinksQTESectionItem>();

	// Token: 0x04002DD2 RID: 11730
	protected DrinksQTESectionItem ThreePart1;

	// Token: 0x04002DD3 RID: 11731
	protected DrinksQTESectionItem ThreePart2;

	// Token: 0x04002DD4 RID: 11732
	protected DrinksQTESectionItem ThreePart3;

	// Token: 0x04002DD5 RID: 11733
	protected List<DrinksQTESectionItem> TwoPartList = new List<DrinksQTESectionItem>();

	// Token: 0x04002DD6 RID: 11734
	protected DrinksQTESectionItem TwoPart1;

	// Token: 0x04002DD7 RID: 11735
	protected DrinksQTESectionItem TwoPart2;

	// Token: 0x04002DD8 RID: 11736
	protected bool IsFront = true;

	// Token: 0x020075B3 RID: 30131
	[NullableContext(0)]
	private static class EItem
	{
		// Token: 0x04026E67 RID: 159335
		public const int BtnItem = 0;

		// Token: 0x04026E68 RID: 159336
		public const int ThreePartItem1 = 1;

		// Token: 0x04026E69 RID: 159337
		public const int ThreePartItem2 = 2;

		// Token: 0x04026E6A RID: 159338
		public const int ThreePartItem3 = 3;

		// Token: 0x04026E6B RID: 159339
		public const int TwoPartItem1 = 4;

		// Token: 0x04026E6C RID: 159340
		public const int TwoPartItem2 = 5;

		// Token: 0x04026E6D RID: 159341
		public const int Pointer = 6;
	}
}
