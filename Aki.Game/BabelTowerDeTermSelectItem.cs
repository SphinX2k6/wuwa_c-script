using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200114F RID: 4431
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerDeTermSelectItem : GridProxyAbstract<IBabelTowerDeTermSelectItemInfo>
{
	// Token: 0x06007448 RID: 29768 RVA: 0x0017C020 File Offset: 0x0017A220
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007449 RID: 29769 RVA: 0x0017C0CB File Offset: 0x0017A2CB
	protected override void OnStart()
	{
		this.DeTermLayout = new GenericLayout<DeTermItem, int>(base.GetGridLayout(2), new Func<DeTermItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0600744A RID: 29770 RVA: 0x0017C0F0 File Offset: 0x0017A2F0
	[NullableContext(1)]
	public override void Refresh(IBabelTowerDeTermSelectItemInfo data, bool isSelected, int gridIndex)
	{
		this.IsNecessary = data.IsNecessary;
		base.GetItem(1).SetUIActive(data.IsNecessary);
		this.OnChangeSelectDeTerm = data.OnChangeSelectDeTerm;
		GenericLayout<DeTermItem, int> deTermLayout = this.DeTermLayout;
		if (deTermLayout == null)
		{
			return;
		}
		deTermLayout.RefreshByData(data.AllDeTerm, delegate
		{
			foreach (DeTermItem deTermItem in this.DeTermLayout.GetLayoutItemList())
			{
				IBabelTowerSelectInfo babelTowerSelectInfo;
				BabelTowerModel.Instance.DeTermSelectInfo.TryGetValue(deTermItem.DeTermId, out babelTowerSelectInfo);
				if (babelTowerSelectInfo != null && babelTowerSelectInfo.State == EBabelTowerDeTermState.Lock)
				{
					deTermItem.SetToggleState(EToggleState.ETT_UnDetermined);
				}
				if ((babelTowerSelectInfo != null && babelTowerSelectInfo.State == EBabelTowerDeTermState.Select) || (babelTowerSelectInfo != null && babelTowerSelectInfo.State == EBabelTowerDeTermState.StaticSelect))
				{
					this.CurrentDeTermId = deTermItem.DeTermId;
					this.CurrentToggle = deTermItem.GetDeTermToggle();
					deTermItem.SetToggleState(EToggleState.ETT_Checked);
				}
				if (babelTowerSelectInfo != null && babelTowerSelectInfo.State == EBabelTowerDeTermState.Normal)
				{
					deTermItem.SetToggleState(EToggleState.ETT_UnChecked);
				}
				deTermItem.SetDailyQuestItem(deTermItem.DeTermId != 0 && data.DailyDeTerm.Contains(deTermItem.DeTermId));
			}
			if (this.CurrentToggle != null)
			{
				this.RefreshItemColor();
			}
		}, false);
	}

	// Token: 0x0600744B RID: 29771 RVA: 0x0017C172 File Offset: 0x0017A372
	[NullableContext(1)]
	private DeTermItem InitItem()
	{
		return new DeTermItem
		{
			OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickToggleCallBack),
			CanClickCallBack = new Func<bool>(this.CanClickCallBack)
		};
	}

	// Token: 0x0600744C RID: 29772 RVA: 0x0017C1A0 File Offset: 0x0017A3A0
	private void OnClickToggleCallBack(int deTerm, UUIExtendToggle toggle)
	{
		UUIExtendToggle currentToggle = this.CurrentToggle;
		if (currentToggle != null)
		{
			currentToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentToggle = toggle;
		if (deTerm == 0)
		{
			BabelTowerSelectInfo babelTowerSelectInfo = new BabelTowerSelectInfo();
			babelTowerSelectInfo.State = EBabelTowerDeTermState.Normal;
			BabelTowerModel instance = BabelTowerModel.Instance;
			int deTermSelectIndex = instance.DeTermSelectIndex;
			instance.DeTermSelectIndex = deTermSelectIndex + 1;
			babelTowerSelectInfo.SelectIndex = deTermSelectIndex;
			BabelTowerSelectInfo value = babelTowerSelectInfo;
			BabelTowerModel.Instance.DeTermSelectInfo[this.CurrentDeTermId] = value;
		}
		else
		{
			BabelTowerSelectInfo babelTowerSelectInfo2 = new BabelTowerSelectInfo();
			babelTowerSelectInfo2.State = EBabelTowerDeTermState.Normal;
			BabelTowerModel instance2 = BabelTowerModel.Instance;
			int deTermSelectIndex = instance2.DeTermSelectIndex;
			instance2.DeTermSelectIndex = deTermSelectIndex + 1;
			babelTowerSelectInfo2.SelectIndex = deTermSelectIndex;
			BabelTowerSelectInfo value2 = babelTowerSelectInfo2;
			BabelTowerModel.Instance.DeTermSelectInfo[this.CurrentDeTermId] = value2;
			BabelTowerSelectInfo babelTowerSelectInfo3 = new BabelTowerSelectInfo();
			babelTowerSelectInfo3.State = EBabelTowerDeTermState.Select;
			BabelTowerModel instance3 = BabelTowerModel.Instance;
			deTermSelectIndex = instance3.DeTermSelectIndex;
			instance3.DeTermSelectIndex = deTermSelectIndex + 1;
			babelTowerSelectInfo3.SelectIndex = deTermSelectIndex;
			BabelTowerSelectInfo value3 = babelTowerSelectInfo3;
			BabelTowerModel.Instance.DeTermSelectInfo[deTerm] = value3;
		}
		this.RefreshItemColor();
		this.CurrentDeTermId = deTerm;
		Action<int> onChangeSelectDeTerm = this.OnChangeSelectDeTerm;
		if (onChangeSelectDeTerm == null)
		{
			return;
		}
		onChangeSelectDeTerm(deTerm);
	}

	// Token: 0x0600744D RID: 29773 RVA: 0x0017C2A2 File Offset: 0x0017A4A2
	private bool CanClickCallBack()
	{
		bool flag = !this.IsNecessary;
		if (!flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerNecessaryDeTerm", Array.Empty<object>());
		}
		return flag;
	}

	// Token: 0x0600744E RID: 29774 RVA: 0x0017C2C4 File Offset: 0x0017A4C4
	public void PlayPositionSequence(int deTerm)
	{
		foreach (DeTermItem deTermItem in this.DeTermLayout.GetLayoutItemList())
		{
			if (deTermItem.DeTermId == deTerm)
			{
				deTermItem.PlayPositionSequence();
			}
		}
	}

	// Token: 0x0600744F RID: 29775 RVA: 0x0017C324 File Offset: 0x0017A524
	private void RefreshItemColor()
	{
		foreach (DeTermItem deTermItem in this.DeTermLayout.GetLayoutItemList())
		{
			IBabelTowerSelectInfo babelTowerSelectInfo;
			BabelTowerModel.Instance.DeTermSelectInfo.TryGetValue(deTermItem.DeTermId, out babelTowerSelectInfo);
			deTermItem.UseChangeColor(babelTowerSelectInfo != null && babelTowerSelectInfo.State == EBabelTowerDeTermState.Normal && this.CurrentToggle != null);
		}
	}

	// Token: 0x06007450 RID: 29776 RVA: 0x0017C3AC File Offset: 0x0017A5AC
	public void ClearSelect()
	{
		this.CurrentToggle = null;
		this.CurrentDeTermId = 0;
		this.RefreshItemColor();
	}

	// Token: 0x0400358E RID: 13710
	private Action<int> OnChangeSelectDeTerm;

	// Token: 0x0400358F RID: 13711
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<DeTermItem, int> DeTermLayout;

	// Token: 0x04003590 RID: 13712
	private UUIExtendToggle CurrentToggle;

	// Token: 0x04003591 RID: 13713
	private bool IsNecessary;

	// Token: 0x04003592 RID: 13714
	private int CurrentDeTermId;

	// Token: 0x02007700 RID: 30464
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04027423 RID: 160803
		public const int BgSprite = 0;

		// Token: 0x04027424 RID: 160804
		public const int NecessaryItem = 1;

		// Token: 0x04027425 RID: 160805
		public const int DeTermScrollView = 2;

		// Token: 0x04027426 RID: 160806
		public const int DeTermItem = 3;
	}
}
