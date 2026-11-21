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
	// Token: 0x02003C8F RID: 15503
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeDynScrollItem : UiPanelBase, IDynamicScrollItem<IAttributeInfo>
	{
		// Token: 0x06027A88 RID: 162440 RVA: 0x00B1B518 File Offset: 0x00B19718
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

		// Token: 0x06027A89 RID: 162441 RVA: 0x00B1B588 File Offset: 0x00B19788
		protected override void OnStart()
		{
			this.RoleAttributeItem = new RoleAttributeItem();
			this.RoleAttributeItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
		}

		// Token: 0x06027A8A RID: 162442 RVA: 0x00B1B5AD File Offset: 0x00B197AD
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06027A8B RID: 162443 RVA: 0x00B1B5AF File Offset: 0x00B197AF
		[return: Nullable(2)]
		public AUIBaseActor GetUsingItem(IAttributeInfo data)
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x06027A8C RID: 162444 RVA: 0x00B1B5C4 File Offset: 0x00B197C4
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

		// Token: 0x06027A8D RID: 162445 RVA: 0x00B1B610 File Offset: 0x00B19810
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

		// Token: 0x06027A8E RID: 162446 RVA: 0x00B1B690 File Offset: 0x00B19890
		private void RefreshBg(bool? bNormalBg)
		{
			bool valueOrDefault = bNormalBg.GetValueOrDefault(true);
			base.GetItem(1).SetUIActive(!valueOrDefault);
			base.GetItem(2).SetUIActive(valueOrDefault);
		}

		// Token: 0x06027A8F RID: 162447 RVA: 0x00B1B6C3 File Offset: 0x00B198C3
		public void ClearItem()
		{
			base.Destroy(null);
		}

		// Token: 0x04015A2D RID: 88621
		[Nullable(2)]
		private RoleAttributeItem RoleAttributeItem;

		// Token: 0x02009876 RID: 39030
		[NullableContext(0)]
		private enum ESlotComponent
		{
			// Token: 0x0402F8A0 RID: 194720
			AttributePanel,
			// Token: 0x0402F8A1 RID: 194721
			BgDark,
			// Token: 0x0402F8A2 RID: 194722
			BgNormal,
			// Token: 0x0402F8A3 RID: 194723
			Line
		}
	}
}
