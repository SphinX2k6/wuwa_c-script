using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.View.Components;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005751 RID: 22353
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class WeaponGridItem : SyncGridProxyAbstract<IKurotatoMediumItemGridData>
	{
		// Token: 0x06038D04 RID: 232708 RVA: 0x00D7E5F0 File Offset: 0x00D7C7F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D05 RID: 232709 RVA: 0x00D7E659 File Offset: 0x00D7C859
		protected override void OnStart()
		{
			this.GridItem.CreateThenShowByActor(base.GetItem(0).GetOwner());
		}

		// Token: 0x06038D06 RID: 232710 RVA: 0x00D7E674 File Offset: 0x00D7C874
		public void SetSelected(bool selected, bool force = false)
		{
			this.GridItem.Refresh(this.Data, null);
			this.GridItem.SetSelected(selected, force);
		}

		// Token: 0x06038D07 RID: 232711 RVA: 0x00D7E6A8 File Offset: 0x00D7C8A8
		public override void Refresh(IKurotatoMediumItemGridData data)
		{
			this.Data = data;
			bool flag = data.Type == EKurotatoCardType.None;
			base.GetItem(0).SetUIActive(!flag);
			base.GetItem(1).SetUIActive(flag);
			if (flag)
			{
				this.SetSelected(false, true);
				return;
			}
			this.GridItem.Refresh(data, null);
			Func<IKurotatoMediumItemGridData, bool> isSelectedCb = this.IsSelectedCb;
			this.SetSelected(isSelectedCb != null && isSelectedCb(data), true);
			this.GridItem.BindCallback(delegate(EToggleState state)
			{
				Action<bool> onClickCb = this.OnClickCb;
				if (onClickCb == null)
				{
					return;
				}
				onClickCb(state == EToggleState.ETT_Checked);
			});
		}

		// Token: 0x0401DCBB RID: 122043
		public IKurotatoMediumItemGridData Data;

		// Token: 0x0401DCBC RID: 122044
		private readonly KurotatoWeaponMediumItemGrid GridItem = new KurotatoWeaponMediumItemGrid();

		// Token: 0x0401DCBD RID: 122045
		[Nullable(2)]
		public Action<bool> OnClickCb;

		// Token: 0x0401DCBE RID: 122046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IKurotatoMediumItemGridData, bool> IsSelectedCb;

		// Token: 0x0200B949 RID: 47433
		[NullableContext(0)]
		private enum EGridComp
		{
			// Token: 0x0403809D RID: 229533
			GridItem,
			// Token: 0x0403809E RID: 229534
			PanelEmpty
		}
	}
}
