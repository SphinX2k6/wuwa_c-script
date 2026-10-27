using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F5D RID: 3933
[NullableContext(1)]
[Nullable(0)]
public class DrinksMenuFlavorItem : GridProxyAbstract<int>
{
	// Token: 0x0600649D RID: 25757 RVA: 0x0013EBE8 File Offset: 0x0013CDE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickedReduce))
		};
	}

	// Token: 0x0600649E RID: 25758 RVA: 0x0013ECC0 File Offset: 0x0013CEC0
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksMenuFlavorItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksMenuFlavorItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600649F RID: 25759 RVA: 0x0013ED03 File Offset: 0x0013CF03
	protected override void OnStart()
	{
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		base.GetExtendToggle(0).OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnClickedToggle));
	}

	// Token: 0x060064A0 RID: 25760 RVA: 0x0013ED40 File Offset: 0x0013CF40
	private void OnClickedReduce()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
		base.GetButton(5).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x060064A1 RID: 25761 RVA: 0x0013ED78 File Offset: 0x0013CF78
	private void OnClickedToggle(EToggleState _)
	{
		if (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_UnDetermined)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Drinks_ConfirmBox_hit", Array.Empty<object>());
		}
	}

	// Token: 0x060064A2 RID: 25762 RVA: 0x0013ED9D File Offset: 0x0013CF9D
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOnCb != null && this.Id != 0)
		{
			this.SetSelected(this.IsSelectOnCb(this.Id), false);
		}
	}

	// Token: 0x060064A3 RID: 25763 RVA: 0x0013EDC8 File Offset: 0x0013CFC8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.Id = data;
		int curStep = (int)DrinksModel.Instance.GetCurStep();
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (curStep == 2)
		{
			if (this.IsEnableCb != null)
			{
				if (!this.IsEnableCb(data))
				{
					extendToggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
				}
				else if (this.IsSelectOnCb != null)
				{
					this.SetSelected(this.IsSelectOnCb(data), false);
				}
			}
			extendToggle.bLockStateOnSelect = false;
			List<ITasteInfo> list = new List<ITasteInfo>();
			DrinksBatching? batching = DrinksConfig.Instance.GetBatching(data);
			foreach (KeyValuePair<int, int> keyValuePair in batching.Value.Flavor())
			{
				TasteInfo item = new TasteInfo
				{
					Type = (EDrinksFlavorType)keyValuePair.Key,
					Key = "+{0}",
					Value = new string[]
					{
						keyValuePair.Value.ToString()
					}
				};
				list.Add(item);
			}
			this.TasteItem1.Refresh((list.Count > 0) ? list[0] : null);
			this.TasteItem2.Refresh((list.Count > 1) ? list[1] : null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(batching.Value.Name);
			}
			base.SetTextureByPath(batching.Value.Icon, base.GetTexture(1), null, null);
			return;
		}
		if (this.IsSelectOnCb != null)
		{
			this.SetSelected(this.IsSelectOnCb(data), false);
		}
		extendToggle.SetSelfInteractive(true);
		extendToggle.bLockStateOnSelect = true;
		DrinksDrinkBase? drinkBase = DrinksConfig.Instance.GetDrinkBase(data);
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.ShowTextNew(drinkBase.Value.DrinkName);
		}
		base.SetTextureByPath(drinkBase.Value.DrinkIcon, base.GetTexture(1), null, null);
		List<ITasteInfo> flavorRange = this.GetFlavorRange(data);
		this.TasteItem1.Refresh((flavorRange.Count > 0) ? flavorRange[0] : null);
		this.TasteItem2.Refresh((flavorRange.Count > 1) ? flavorRange[1] : null);
	}

	// Token: 0x060064A4 RID: 25764 RVA: 0x0013F034 File Offset: 0x0013D234
	private List<ITasteInfo> GetFlavorRange(int configId)
	{
		DrinksDrinkBase? drinkBase = DrinksConfig.Instance.GetDrinkBase(configId);
		Dictionary<int, int[]> drinksFlavorRange = DrinksModel.Instance.GetDrinksFlavorRange(drinkBase.Value.DrinkId);
		List<ITasteInfo> list = new List<ITasteInfo>();
		foreach (KeyValuePair<int, int[]> keyValuePair in drinksFlavorRange)
		{
			int key = keyValuePair.Key;
			int[] value = keyValuePair.Value;
			int num = value[0];
			int num2 = value[1];
			TasteInfo item = new TasteInfo
			{
				Type = (EDrinksFlavorType)key,
				Key = "{0}~{1}",
				Value = new string[]
				{
					num.ToString(),
					num2.ToString()
				}
			};
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060064A5 RID: 25765 RVA: 0x0013F10C File Offset: 0x0013D30C
	private void SetSelected(bool bSelectOn, bool bFireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		base.GetButton(5).RootUIComp.Get().SetUIActive(bSelectOn && curStep == EDrinksPlayStep.Batching);
	}

	// Token: 0x060064A6 RID: 25766 RVA: 0x0013F160 File Offset: 0x0013D360
	private void OnToggleStateChange(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		base.GetButton(5).RootUIComp.Get().SetUIActive(flag);
		if (this.OnToggleStateChangeFunction != null)
		{
			this.OnToggleStateChangeFunction(base.GetExtendToggle(0), base.GetButton(5), this.Id, flag);
		}
	}

	// Token: 0x04002DAC RID: 11692
	private const string TXT_FLAVOR_DRINKS = "{0}~{1}";

	// Token: 0x04002DAD RID: 11693
	private const string TXT_FLAVOR_BATCHING = "+{0}";

	// Token: 0x04002DAE RID: 11694
	protected DrinksMenuFlavorTasteItem TasteItem1;

	// Token: 0x04002DAF RID: 11695
	protected DrinksMenuFlavorTasteItem TasteItem2;

	// Token: 0x04002DB0 RID: 11696
	public int Id;

	// Token: 0x04002DB1 RID: 11697
	[Nullable(2)]
	public Func<int, bool> IsSelectOnCb;

	// Token: 0x04002DB2 RID: 11698
	[Nullable(2)]
	public Func<int, bool> IsEnableCb;

	// Token: 0x04002DB3 RID: 11699
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<UUIExtendToggle, UUIButtonComponent, int, bool> OnToggleStateChangeFunction;

	// Token: 0x020075AA RID: 30122
	[NullableContext(0)]
	private static class EDefine
	{
		// Token: 0x04026E44 RID: 159300
		public const int Toggle = 0;

		// Token: 0x04026E45 RID: 159301
		public const int Icon = 1;

		// Token: 0x04026E46 RID: 159302
		public const int Name = 2;

		// Token: 0x04026E47 RID: 159303
		public const int PanelTasteList = 3;

		// Token: 0x04026E48 RID: 159304
		public const int TasteItem1 = 4;

		// Token: 0x04026E49 RID: 159305
		public const int BtnReduce = 5;

		// Token: 0x04026E4A RID: 159306
		public const int TasteItem2 = 6;
	}
}
