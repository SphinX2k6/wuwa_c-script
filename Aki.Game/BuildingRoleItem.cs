using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012F2 RID: 4850
public class BuildingRoleItem : UiPanelBase
{
	// Token: 0x06008627 RID: 34343 RVA: 0x001C981C File Offset: 0x001C7A1C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06008628 RID: 34344 RVA: 0x001C9876 File Offset: 0x001C7A76
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06008629 RID: 34345 RVA: 0x001C988C File Offset: 0x001C7A8C
	public UniTask RefreshSpine(int roleId)
	{
		BuildingRoleItem.<RefreshSpine>d__3 <RefreshSpine>d__;
		<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSpine>d__.<>4__this = this;
		<RefreshSpine>d__.roleId = roleId;
		<RefreshSpine>d__.<>1__state = -1;
		<RefreshSpine>d__.<>t__builder.Start<BuildingRoleItem.<RefreshSpine>d__3>(ref <RefreshSpine>d__);
		return <RefreshSpine>d__.<>t__builder.Task;
	}

	// Token: 0x02007920 RID: 31008
	private static class EComponentDefine
	{
		// Token: 0x04027E75 RID: 163445
		public const int Spine = 0;

		// Token: 0x04027E76 RID: 163446
		public const int DialogItem = 1;

		// Token: 0x04027E77 RID: 163447
		public const int Dialog = 2;
	}
}
