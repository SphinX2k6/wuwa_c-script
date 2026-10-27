using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02004CDD RID: 19677
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeDynScrollItem : UiPanelBase, IDynamicScrollItem<IAttributeInfo>
	{
		// Token: 0x06032CB3 RID: 208051 RVA: 0x00BD5E10 File Offset: 0x00BD4010
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06032CB4 RID: 208052 RVA: 0x00BD5E80 File Offset: 0x00BD4080
		protected override void OnStart()
		{
			this.RoleAttributeItem = new RoleAttributeItem();
			this.RoleAttributeItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
		}

		// Token: 0x06032CB5 RID: 208053 RVA: 0x00BD5EA5 File Offset: 0x00BD40A5
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06032CB6 RID: 208054 RVA: 0x00BD5EA7 File Offset: 0x00BD40A7
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(IAttributeInfo data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x06032CB7 RID: 208055 RVA: 0x00BD5EBC File Offset: 0x00BD40BC
		public UniTask Init(UUIItem actor)
		{
			AttributeDynScrollItem.<Init>d__6 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<AttributeDynScrollItem.<Init>d__6>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06032CB8 RID: 208056 RVA: 0x00BD5F08 File Offset: 0x00BD4108
		public void Update(IAttributeInfo data, int index)
		{
			if (data.IsLine.GetValueOrDefault())
			{
				base.GetItem(1).SetUIActive(false);
				base.GetItem(2).SetUIActive(false);
				base.GetItem(0).SetUIActive(false);
				UUIItem item = base.GetItem(3);
				item.SetUIActive(true);
				base.GetRootItem().SetHeight(item.GetHeight());
				return;
			}
			this.RoleAttributeItem.Refresh(data);
			this.RefreshBg(data.IsNormalBg);
		}

		// Token: 0x06032CB9 RID: 208057 RVA: 0x00BD5F88 File Offset: 0x00BD4188
		private void RefreshBg(bool? bNormalBg)
		{
			bool valueOrDefault = bNormalBg.GetValueOrDefault(true);
			base.GetItem(1).SetUIActive(!valueOrDefault);
			base.GetItem(2).SetUIActive(valueOrDefault);
		}

		// Token: 0x06032CBA RID: 208058 RVA: 0x00BD5FBB File Offset: 0x00BD41BB
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x0401B0A9 RID: 110761
		[Nullable(2)]
		private RoleAttributeItem RoleAttributeItem;

		// Token: 0x0200AE57 RID: 44631
		[NullableContext(0)]
		private enum ESlotComponent
		{
			// Token: 0x04034EF8 RID: 216824
			AttributePanel,
			// Token: 0x04034EF9 RID: 216825
			BgDark,
			// Token: 0x04034EFA RID: 216826
			BgNormal,
			// Token: 0x04034EFB RID: 216827
			Line
		}
	}
}
