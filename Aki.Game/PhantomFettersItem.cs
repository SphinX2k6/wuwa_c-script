using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001920 RID: 6432
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomFettersItem : GridProxyAbstract<PhantomFetterItemData>
{
	// Token: 0x0600FE46 RID: 65094 RVA: 0x004A3E00 File Offset: 0x004A2000
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemButtonClicked))
		};
	}

	// Token: 0x0600FE47 RID: 65095 RVA: 0x004A3EC0 File Offset: 0x004A20C0
	protected override void OnStart()
	{
		this.VisionFetterSuitItem = new VisionFetterSuitItem(base.GetItem(2));
		this.VisionFetterSuitItem.Init().ContinueWith(delegate()
		{
			this.VisionFetterSuitItem.SetActive(true);
		}).Forget();
		base.GetItem(3).SetUIActive(false);
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600FE48 RID: 65096 RVA: 0x004A3F1E File Offset: 0x004A211E
	public override void Refresh(PhantomFetterItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		this.RefreshName();
		this.RefreshSuitElement();
		this.RefreshUnlockText();
		this.RefreshLikeItemState();
		this.Selected(isSelected, false);
	}

	// Token: 0x0600FE49 RID: 65097 RVA: 0x004A3F48 File Offset: 0x004A2148
	private void RefreshLikeItemState()
	{
		int id = this.ItemData.PhantomFetterGroup.Value.Id;
		if (this.ItemData.RecommendGroupIds.Count > 0)
		{
			base.GetItem(5).SetUIActive(this.ItemData.RecommendGroupIds.Contains(id));
			return;
		}
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.ItemData.RoleId);
		bool uiactive = false;
		if (roleFetterRecommendInfo != null)
		{
			using (List<VisionFetterRecommendInfo>.Enumerator enumerator = roleFetterRecommendInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetRecommendFetterGroupId() == id)
					{
						uiactive = true;
						break;
					}
				}
			}
		}
		base.GetItem(5).SetUIActive(uiactive);
	}

	// Token: 0x0600FE4A RID: 65098 RVA: 0x004A4010 File Offset: 0x004A2210
	public void RefreshName()
	{
		base.GetText(1).ShowTextNew(this.ItemData.PhantomFetterGroup.Value.FetterGroupName);
	}

	// Token: 0x0600FE4B RID: 65099 RVA: 0x004A4044 File Offset: 0x004A2244
	public void RefreshUnlockText()
	{
		int id = this.ItemData.PhantomFetterGroup.Value.Id;
		int[] fetterGroupMonsterIdArray = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(id);
		int monsterFindCountByMonsterIdArray = PhantomBattleModel.Instance.GetMonsterFindCountByMonsterIdArray(fetterGroupMonsterIdArray);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Illustration_Progress_Iteration", new <>z__ReadOnlyArray<object>(new object[]
		{
			monsterFindCountByMonsterIdArray,
			fetterGroupMonsterIdArray.Length
		}));
	}

	// Token: 0x0600FE4C RID: 65100 RVA: 0x004A40B7 File Offset: 0x004A22B7
	public void BindOnItemButtonClickedCallback(Action<PhantomFetterItemData> onItemButtonClicked)
	{
		this.OnItemButtonClickedCallback = onItemButtonClicked;
	}

	// Token: 0x0600FE4D RID: 65101 RVA: 0x004A40C0 File Offset: 0x004A22C0
	public override void OnSelected(bool fireEvent)
	{
		this.Selected(true, true);
	}

	// Token: 0x0600FE4E RID: 65102 RVA: 0x004A40CA File Offset: 0x004A22CA
	public override void OnDeselected(bool fireEvent)
	{
		this.Selected(false, true);
	}

	// Token: 0x0600FE4F RID: 65103 RVA: 0x004A40D4 File Offset: 0x004A22D4
	private void RefreshSuitElement()
	{
		this.VisionFetterSuitItem.Update(this.ItemData.PhantomFetterGroup);
	}

	// Token: 0x0600FE50 RID: 65104 RVA: 0x004A40EC File Offset: 0x004A22EC
	private void Selected(bool bSelected, bool fire = true)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (bSelected)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fire, false, false);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600FE51 RID: 65105 RVA: 0x004A411B File Offset: 0x004A231B
	private void OnItemButtonClicked(EToggleState state)
	{
		if (this.OnItemButtonClickedCallback != null)
		{
			this.OnItemButtonClickedCallback(this.ItemData);
		}
	}

	// Token: 0x04008D80 RID: 36224
	[Nullable(2)]
	private PhantomFetterItemData ItemData;

	// Token: 0x04008D81 RID: 36225
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x04008D82 RID: 36226
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomFetterItemData> OnItemButtonClickedCallback;
}
