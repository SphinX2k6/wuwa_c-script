using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E30 RID: 7728
[NullableContext(1)]
[Nullable(0)]
public class MonsterHandBookItem : UiPanelBase, IDynamicScrollItem<MonsterHandBookDynamicData>
{
	// Token: 0x0600EAFA RID: 60154 RVA: 0x0037ABE0 File Offset: 0x00378DE0
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

	// Token: 0x0600EAFB RID: 60155 RVA: 0x0037AC2B File Offset: 0x00378E2B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EAFC RID: 60156 RVA: 0x0037AC64 File Offset: 0x00378E64
	private UniTask InitChildItem()
	{
		MonsterHandBookItem.<InitChildItem>d__5 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<MonsterHandBookItem.<InitChildItem>d__5>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EAFD RID: 60157 RVA: 0x0037ACA7 File Offset: 0x00378EA7
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(MonsterHandBookDynamicData data)
	{
		if (!string.IsNullOrEmpty(data.TitleId))
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600EAFE RID: 60158 RVA: 0x0037ACD9 File Offset: 0x00378ED9
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600EAFF RID: 60159 RVA: 0x0037ACE4 File Offset: 0x00378EE4
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

	// Token: 0x04006D02 RID: 27906
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int, bool> OnClickCallBack;

	// Token: 0x04006D03 RID: 27907
	[Nullable(2)]
	private MonsterHandBookTitleItem MonsterHandBookTitleItem;

	// Token: 0x04006D04 RID: 27908
	[Nullable(2)]
	private MonsterHandBookLayoutItem MonsterHandBookLayoutItem;
}
