using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.View.Components;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004728 RID: 18216
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class WeaponGridItem : SyncGridProxyAbstract<IKurotatoMediumItemGridData>
	{
		// Token: 0x0602DC14 RID: 187412 RVA: 0x00CCCFD0 File Offset: 0x00CCB1D0
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

		// Token: 0x0602DC15 RID: 187413 RVA: 0x00CCD039 File Offset: 0x00CCB239
		protected override void OnStart()
		{
			this.GridItem.CreateThenShowByActor(base.GetItem(0).GetOwner());
		}

		// Token: 0x0602DC16 RID: 187414 RVA: 0x00CCD054 File Offset: 0x00CCB254
		public void SetSelected(bool selected, bool force = false)
		{
			this.GridItem.Refresh(this.Data, null);
			this.GridItem.SetSelected(selected, force);
		}

		// Token: 0x0602DC17 RID: 187415 RVA: 0x00CCD088 File Offset: 0x00CCB288
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

		// Token: 0x04018751 RID: 100177
		public IKurotatoMediumItemGridData Data;

		// Token: 0x04018752 RID: 100178
		private readonly KurotatoWeaponMediumItemGrid GridItem = new KurotatoWeaponMediumItemGrid();

		// Token: 0x04018753 RID: 100179
		[Nullable(2)]
		public Action<bool> OnClickCb;

		// Token: 0x04018754 RID: 100180
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IKurotatoMediumItemGridData, bool> IsSelectedCb;

		// Token: 0x0200A367 RID: 41831
		[NullableContext(0)]
		private enum EGridComp
		{
			// Token: 0x04032AA3 RID: 207523
			GridItem,
			// Token: 0x04032AA4 RID: 207524
			PanelEmpty
		}
	}
}
