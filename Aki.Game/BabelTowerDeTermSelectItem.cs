using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000603 RID: 1539
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerDeTermSelectItem : GridProxyAbstract<IBabelTowerDeTermSelectItemInfo>
{
	// Token: 0x060047DF RID: 18399 RVA: 0x00184B6C File Offset: 0x00182D6C
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

	// Token: 0x060047E0 RID: 18400 RVA: 0x00184C17 File Offset: 0x00182E17
	protected override void OnStart()
	{
		this.DeTermLayout = new GenericLayout<DeTermItem, int>(base.GetGridLayout(2), new Func<DeTermItem>(this.InitItem), null, false, true);
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x00184C3C File Offset: 0x00182E3C
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

	// Token: 0x060047E2 RID: 18402 RVA: 0x00184CBE File Offset: 0x00182EBE
	[NullableContext(1)]
	private DeTermItem InitItem()
	{
		return new DeTermItem
		{
			OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickToggleCallBack),
			CanClickCallBack = new Func<bool>(this.CanClickCallBack)
		};
	}

	// Token: 0x060047E3 RID: 18403 RVA: 0x00184CEC File Offset: 0x00182EEC
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

	// Token: 0x060047E4 RID: 18404 RVA: 0x00184DEE File Offset: 0x00182FEE
	private bool CanClickCallBack()
	{
		bool flag = !this.IsNecessary;
		if (!flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerNecessaryDeTerm", Array.Empty<object>());
		}
		return flag;
	}

	// Token: 0x060047E5 RID: 18405 RVA: 0x00184E10 File Offset: 0x00183010
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

	// Token: 0x060047E6 RID: 18406 RVA: 0x00184E70 File Offset: 0x00183070
	private void RefreshItemColor()
	{
		foreach (DeTermItem deTermItem in this.DeTermLayout.GetLayoutItemList())
		{
			IBabelTowerSelectInfo babelTowerSelectInfo;
			BabelTowerModel.Instance.DeTermSelectInfo.TryGetValue(deTermItem.DeTermId, out babelTowerSelectInfo);
			deTermItem.UseChangeColor(babelTowerSelectInfo != null && babelTowerSelectInfo.State == EBabelTowerDeTermState.Normal && this.CurrentToggle != null);
		}
	}

	// Token: 0x060047E7 RID: 18407 RVA: 0x00184EF8 File Offset: 0x001830F8
	public void ClearSelect()
	{
		this.CurrentToggle = null;
		this.CurrentDeTermId = 0;
		this.RefreshItemColor();
	}

	// Token: 0x04003627 RID: 13863
	private Action<int> OnChangeSelectDeTerm;

	// Token: 0x04003628 RID: 13864
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<DeTermItem, int> DeTermLayout;

	// Token: 0x04003629 RID: 13865
	private UUIExtendToggle CurrentToggle;

	// Token: 0x0400362A RID: 13866
	private bool IsNecessary;

	// Token: 0x0400362B RID: 13867
	private int CurrentDeTermId;

	// Token: 0x0200688F RID: 26767
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022764 RID: 141156
		public const int BgSprite = 0;

		// Token: 0x04022765 RID: 141157
		public const int NecessaryItem = 1;

		// Token: 0x04022766 RID: 141158
		public const int DeTermScrollView = 2;

		// Token: 0x04022767 RID: 141159
		public const int DeTermItem = 3;
	}
}
