using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200201F RID: 8223
[NullableContext(2)]
[Nullable(0)]
public class SubPackageDownLoadItem : UiPanelBase, IDynamicScrollItem<SubPackageDownLoadDynamicData>
{
	// Token: 0x060145DC RID: 83420 RVA: 0x005F0414 File Offset: 0x005EE614
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		SubPackageDownLoadItem.<Init>d__7 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<SubPackageDownLoadItem.<Init>d__7>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060145DD RID: 83421 RVA: 0x005F0460 File Offset: 0x005EE660
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060145DE RID: 83422 RVA: 0x005F04BC File Offset: 0x005EE6BC
	[NullableContext(1)]
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(SubPackageDownLoadDynamicData data)
	{
		if (data.Type != null && data.Type.Value != (ESubPackageDownLoadVersionType)0)
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		if (data.VersionId != null && data.VersionId.Value != 0)
		{
			return base.GetItem(1).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(2).GetOwner() as AUIBaseActor;
	}

	// Token: 0x060145DF RID: 83423 RVA: 0x005F0534 File Offset: 0x005EE734
	[NullableContext(1)]
	public void Update(SubPackageDownLoadDynamicData data, int index)
	{
		this.Data = data;
		SubPackageDownLoadTitleItem subPackageDownLoadTitleItem = this.SubPackageDownLoadTitleItem;
		if (subPackageDownLoadTitleItem != null)
		{
			subPackageDownLoadTitleItem.SetUiActive(false);
		}
		SubPackageDownLoadVersionItem subPackageDownLoadVersionItem = this.SubPackageDownLoadVersionItem;
		if (subPackageDownLoadVersionItem != null)
		{
			subPackageDownLoadVersionItem.SetUiActive(false);
		}
		SubPackageDownLoadSubPackageItem subPackageDownLoadSubPackageItem = this.SubPackageDownLoadSubPackageItem;
		if (subPackageDownLoadSubPackageItem != null)
		{
			subPackageDownLoadSubPackageItem.SetUiActive(false);
		}
		if (data.Type != null && data.Type.Value != (ESubPackageDownLoadVersionType)0)
		{
			SubPackageDownLoadTitleItem subPackageDownLoadTitleItem2 = this.SubPackageDownLoadTitleItem;
			if (subPackageDownLoadTitleItem2 != null)
			{
				subPackageDownLoadTitleItem2.SetUiActive(true);
			}
			SubPackageDownLoadTitleItem subPackageDownLoadTitleItem3 = this.SubPackageDownLoadTitleItem;
			if (subPackageDownLoadTitleItem3 == null)
			{
				return;
			}
			subPackageDownLoadTitleItem3.RefreshItem(data.Type.Value);
			return;
		}
		else
		{
			if (data.VersionId == null || data.VersionId.Value == 0)
			{
				if (data.SubPackageId != null && data.SubPackageId.Value != 0)
				{
					SubPackageDownLoadSubPackageItem subPackageDownLoadSubPackageItem2 = this.SubPackageDownLoadSubPackageItem;
					if (subPackageDownLoadSubPackageItem2 != null)
					{
						subPackageDownLoadSubPackageItem2.SetUiActive(true);
					}
					SubPackageDownLoadSubPackageItem subPackageDownLoadSubPackageItem3 = this.SubPackageDownLoadSubPackageItem;
					if (subPackageDownLoadSubPackageItem3 == null)
					{
						return;
					}
					subPackageDownLoadSubPackageItem3.RefreshItem(data.SubPackageId.Value, data.IsDynamicRecall);
				}
				return;
			}
			SubPackageDownLoadVersionItem subPackageDownLoadVersionItem2 = this.SubPackageDownLoadVersionItem;
			if (subPackageDownLoadVersionItem2 != null)
			{
				subPackageDownLoadVersionItem2.SetUiActive(true);
			}
			SubPackageDownLoadVersionItem subPackageDownLoadVersionItem3 = this.SubPackageDownLoadVersionItem;
			if (subPackageDownLoadVersionItem3 == null)
			{
				return;
			}
			subPackageDownLoadVersionItem3.RefreshItem(data.VersionId.Value, data.IsShowItem);
			return;
		}
	}

	// Token: 0x060145E0 RID: 83424 RVA: 0x005F0664 File Offset: 0x005EE864
	private UniTask InitChildItem()
	{
		SubPackageDownLoadItem.<InitChildItem>d__11 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<SubPackageDownLoadItem.<InitChildItem>d__11>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x060145E1 RID: 83425 RVA: 0x005F06A7 File Offset: 0x005EE8A7
	public void RefreshDownLoadState()
	{
		SubPackageDownLoadVersionItem subPackageDownLoadVersionItem = this.SubPackageDownLoadVersionItem;
		if (subPackageDownLoadVersionItem != null)
		{
			subPackageDownLoadVersionItem.RefreshDownLoadStateByTime();
		}
		SubPackageDownLoadSubPackageItem subPackageDownLoadSubPackageItem = this.SubPackageDownLoadSubPackageItem;
		if (subPackageDownLoadSubPackageItem == null)
		{
			return;
		}
		subPackageDownLoadSubPackageItem.RefreshDownLoadStateByTime();
	}

	// Token: 0x060145E2 RID: 83426 RVA: 0x005F06CA File Offset: 0x005EE8CA
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x060145E3 RID: 83427 RVA: 0x005F06D3 File Offset: 0x005EE8D3
	public SubPackageDownLoadDynamicData GetData()
	{
		return this.Data;
	}

	// Token: 0x060145E4 RID: 83428 RVA: 0x005F06DC File Offset: 0x005EE8DC
	[NullableContext(1)]
	public UUIItem GetInteractItem()
	{
		SubPackageDownLoadDynamicData data = this.Data;
		if (data != null && data.VersionId != null && this.Data.VersionId.Value != 0)
		{
			return this.SubPackageDownLoadVersionItem.GetToggleItem();
		}
		return this.SubPackageDownLoadSubPackageItem.GetBtnItem();
	}

	// Token: 0x060145E5 RID: 83429 RVA: 0x005F072B File Offset: 0x005EE92B
	protected void OnChildItemClickBtn()
	{
		if (this.Data != null)
		{
			Action<SubPackageDownLoadDynamicData> onClickBtnCallBack = this.OnClickBtnCallBack;
			if (onClickBtnCallBack == null)
			{
				return;
			}
			onClickBtnCallBack(this.Data);
		}
	}

	// Token: 0x0400AC9D RID: 44189
	protected SubPackageDownLoadDynamicData Data;

	// Token: 0x0400AC9E RID: 44190
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SubPackageDownLoadDynamicData> OnClickBtnCallBack;

	// Token: 0x0400AC9F RID: 44191
	public Action<int, bool> OnClickCallBack;

	// Token: 0x0400ACA0 RID: 44192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIItem> OnClickHelpBtnCallBack;

	// Token: 0x0400ACA1 RID: 44193
	private SubPackageDownLoadTitleItem SubPackageDownLoadTitleItem;

	// Token: 0x0400ACA2 RID: 44194
	private SubPackageDownLoadVersionItem SubPackageDownLoadVersionItem;

	// Token: 0x0400ACA3 RID: 44195
	private SubPackageDownLoadSubPackageItem SubPackageDownLoadSubPackageItem;
}
