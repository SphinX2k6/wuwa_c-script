using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200243B RID: 9275
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomFettersItem : GridProxyAbstract<PhantomFetterItemData>
{
	// Token: 0x06012990 RID: 76176 RVA: 0x00496834 File Offset: 0x00494A34
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

	// Token: 0x06012991 RID: 76177 RVA: 0x004968F4 File Offset: 0x00494AF4
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

	// Token: 0x06012992 RID: 76178 RVA: 0x00496952 File Offset: 0x00494B52
	public override void Refresh(PhantomFetterItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		this.RefreshName();
		this.RefreshSuitElement();
		this.RefreshUnlockText();
		this.RefreshLikeItemState();
		this.Selected(isSelected, false);
	}

	// Token: 0x06012993 RID: 76179 RVA: 0x0049697C File Offset: 0x00494B7C
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

	// Token: 0x06012994 RID: 76180 RVA: 0x00496A44 File Offset: 0x00494C44
	public void RefreshName()
	{
		base.GetText(1).ShowTextNew(this.ItemData.PhantomFetterGroup.Value.FetterGroupName);
	}

	// Token: 0x06012995 RID: 76181 RVA: 0x00496A78 File Offset: 0x00494C78
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

	// Token: 0x06012996 RID: 76182 RVA: 0x00496AEB File Offset: 0x00494CEB
	public void BindOnItemButtonClickedCallback(Action<PhantomFetterItemData> onItemButtonClicked)
	{
		this.OnItemButtonClickedCallback = onItemButtonClicked;
	}

	// Token: 0x06012997 RID: 76183 RVA: 0x00496AF4 File Offset: 0x00494CF4
	public override void OnSelected(bool fireEvent)
	{
		this.Selected(true, true);
	}

	// Token: 0x06012998 RID: 76184 RVA: 0x00496AFE File Offset: 0x00494CFE
	public override void OnDeselected(bool fireEvent)
	{
		this.Selected(false, true);
	}

	// Token: 0x06012999 RID: 76185 RVA: 0x00496B08 File Offset: 0x00494D08
	private void RefreshSuitElement()
	{
		this.VisionFetterSuitItem.Update(this.ItemData.PhantomFetterGroup);
	}

	// Token: 0x0601299A RID: 76186 RVA: 0x00496B20 File Offset: 0x00494D20
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

	// Token: 0x0601299B RID: 76187 RVA: 0x00496B4F File Offset: 0x00494D4F
	private void OnItemButtonClicked(EToggleState state)
	{
		if (this.OnItemButtonClickedCallback != null)
		{
			this.OnItemButtonClickedCallback(this.ItemData);
		}
	}

	// Token: 0x04008C39 RID: 35897
	[Nullable(2)]
	private PhantomFetterItemData ItemData;

	// Token: 0x04008C3A RID: 35898
	[Nullable(2)]
	private VisionFetterSuitItem VisionFetterSuitItem;

	// Token: 0x04008C3B RID: 35899
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomFetterItemData> OnItemButtonClickedCallback;
}
