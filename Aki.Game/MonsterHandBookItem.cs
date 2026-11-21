using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012F2 RID: 4850
[NullableContext(1)]
[Nullable(0)]
public class MonsterHandBookItem : UiPanelBase, IDynamicScrollItem<MonsterHandBookDynamicData>
{
	// Token: 0x0600BF19 RID: 48921 RVA: 0x0038686C File Offset: 0x00384A6C
	public UniTask Init(UUIItem actor)
	{
		MonsterHandBookItem.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<MonsterHandBookItem.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600BF1A RID: 48922 RVA: 0x003868B7 File Offset: 0x00384AB7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BF1B RID: 48923 RVA: 0x003868F0 File Offset: 0x00384AF0
	private UniTask InitChildItem()
	{
		MonsterHandBookItem.<InitChildItem>d__5 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<MonsterHandBookItem.<InitChildItem>d__5>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600BF1C RID: 48924 RVA: 0x00386933 File Offset: 0x00384B33
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(MonsterHandBookDynamicData data)
	{
		if (!string.IsNullOrEmpty(data.TitleId))
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600BF1D RID: 48925 RVA: 0x00386965 File Offset: 0x00384B65
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600BF1E RID: 48926 RVA: 0x00386970 File Offset: 0x00384B70
	public void Update(MonsterHandBookDynamicData data, int gridIndex)
	{
		if (this.MonsterHandBookTitleItem != null)
		{
			this.MonsterHandBookTitleItem.SetUiActive(false);
		}
		if (this.MonsterHandBookLayoutItem != null)
		{
			this.MonsterHandBookLayoutItem.SetUiActive(false);
		}
		if (!string.IsNullOrEmpty(data.TitleId))
		{
			if (this.MonsterHandBookTitleItem != null)
			{
				this.MonsterHandBookTitleItem.SetUiActive(true);
				this.MonsterHandBookTitleItem.Update(data.TitleId);
				return;
			}
		}
		else if (data.MonsterList != null && this.MonsterHandBookLayoutItem != null)
		{
			this.MonsterHandBookLayoutItem.SetUiActive(true);
			this.MonsterHandBookLayoutItem.Update(data.MonsterList);
		}
	}

	// Token: 0x04006DE3 RID: 28131
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int, bool> OnClickCallBack;

	// Token: 0x04006DE4 RID: 28132
	[Nullable(2)]
	private MonsterHandBookTitleItem MonsterHandBookTitleItem;

	// Token: 0x04006DE5 RID: 28133
	[Nullable(2)]
	private MonsterHandBookLayoutItem MonsterHandBookLayoutItem;
}
