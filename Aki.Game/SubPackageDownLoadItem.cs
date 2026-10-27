using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AA3 RID: 10915
[NullableContext(2)]
[Nullable(0)]
public class SubPackageDownLoadItem : UiPanelBase, IDynamicScrollItem<SubPackageDownLoadDynamicData>
{
	// Token: 0x06016BAD RID: 93101 RVA: 0x005C3974 File Offset: 0x005C1B74
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

	// Token: 0x06016BAE RID: 93102 RVA: 0x005C39C0 File Offset: 0x005C1BC0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06016BAF RID: 93103 RVA: 0x005C3A1C File Offset: 0x005C1C1C
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

	// Token: 0x06016BB0 RID: 93104 RVA: 0x005C3A94 File Offset: 0x005C1C94
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

	// Token: 0x06016BB1 RID: 93105 RVA: 0x005C3BC4 File Offset: 0x005C1DC4
	private UniTask InitChildItem()
	{
		SubPackageDownLoadItem.<InitChildItem>d__11 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<SubPackageDownLoadItem.<InitChildItem>d__11>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x06016BB2 RID: 93106 RVA: 0x005C3C07 File Offset: 0x005C1E07
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

	// Token: 0x06016BB3 RID: 93107 RVA: 0x005C3C2A File Offset: 0x005C1E2A
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x06016BB4 RID: 93108 RVA: 0x005C3C33 File Offset: 0x005C1E33
	public SubPackageDownLoadDynamicData GetData()
	{
		return this.Data;
	}

	// Token: 0x06016BB5 RID: 93109 RVA: 0x005C3C3C File Offset: 0x005C1E3C
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

	// Token: 0x06016BB6 RID: 93110 RVA: 0x005C3C8B File Offset: 0x005C1E8B
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

	// Token: 0x0400A897 RID: 43159
	protected SubPackageDownLoadDynamicData Data;

	// Token: 0x0400A898 RID: 43160
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<SubPackageDownLoadDynamicData> OnClickBtnCallBack;

	// Token: 0x0400A899 RID: 43161
	public Action<int, bool> OnClickCallBack;

	// Token: 0x0400A89A RID: 43162
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIItem> OnClickHelpBtnCallBack;

	// Token: 0x0400A89B RID: 43163
	private SubPackageDownLoadTitleItem SubPackageDownLoadTitleItem;

	// Token: 0x0400A89C RID: 43164
	private SubPackageDownLoadVersionItem SubPackageDownLoadVersionItem;

	// Token: 0x0400A89D RID: 43165
	private SubPackageDownLoadSubPackageItem SubPackageDownLoadSubPackageItem;
}
