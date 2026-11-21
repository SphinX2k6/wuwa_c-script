using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005047 RID: 20551
	internal class AbyssDangoLikeItem : UiPanelBase
	{
		// Token: 0x0603370E RID: 210702 RVA: 0x00E67C24 File Offset: 0x00E65E24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickLikeBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603370F RID: 210703 RVA: 0x00E67CEC File Offset: 0x00E65EEC
		protected override UniTask OnBeforeStartAsync()
		{
			AbyssDangoLikeItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AbyssDangoLikeItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033710 RID: 210704 RVA: 0x00E67D2F File Offset: 0x00E65F2F
		private void OnClickLikeBtn()
		{
			DangoAbyssController.Instance.AbyssLikePlayer(this.CurrentPlayerId.Value);
		}

		// Token: 0x06033711 RID: 210705 RVA: 0x00E67D48 File Offset: 0x00E65F48
		public void Refresh(int data, int playerId, bool afterLike = false)
		{
			this.CurrentPlayerId = new int?(playerId);
			this.AbyssDangoLikeCountItem.Refresh(data);
			this.AbyssDangoLikeCountItem.SetActive(afterLike);
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(!afterLike);
		}

		// Token: 0x06033712 RID: 210706 RVA: 0x00E67D9B File Offset: 0x00E65F9B
		public void RefreshLineState(bool isShow)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x0401B530 RID: 111920
		[Nullable(1)]
		private AbyssDangoLikeCountItem AbyssDangoLikeCountItem;

		// Token: 0x0401B531 RID: 111921
		private int? CurrentPlayerId;

		// Token: 0x0200ACFF RID: 44287
		private enum ELikeItem
		{
			// Token: 0x040357E7 RID: 219111
			LikeBtn,
			// Token: 0x040357E8 RID: 219112
			LikeCountItem,
			// Token: 0x040357E9 RID: 219113
			LikeLine
		}
	}
}
