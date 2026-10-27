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
	// Token: 0x020060C9 RID: 24777
	internal class AbyssDangoLikeItem : UiPanelBase
	{
		// Token: 0x0603EA4A RID: 256586 RVA: 0x00F20E54 File Offset: 0x00F1F054
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

		// Token: 0x0603EA4B RID: 256587 RVA: 0x00F20F1C File Offset: 0x00F1F11C
		protected override UniTask OnBeforeStartAsync()
		{
			AbyssDangoLikeItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AbyssDangoLikeItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA4C RID: 256588 RVA: 0x00F20F5F File Offset: 0x00F1F15F
		private void OnClickLikeBtn()
		{
			DangoAbyssController.Instance.AbyssLikePlayer(this.CurrentPlayerId.Value);
		}

		// Token: 0x0603EA4D RID: 256589 RVA: 0x00F20F78 File Offset: 0x00F1F178
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

		// Token: 0x0603EA4E RID: 256590 RVA: 0x00F20FCB File Offset: 0x00F1F1CB
		public void RefreshLineState(bool isShow)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x04020C03 RID: 134147
		[Nullable(1)]
		private AbyssDangoLikeCountItem AbyssDangoLikeCountItem;

		// Token: 0x04020C04 RID: 134148
		private int? CurrentPlayerId;

		// Token: 0x0200C314 RID: 49940
		private enum ELikeItem
		{
			// Token: 0x0403AE7F RID: 241279
			LikeBtn,
			// Token: 0x0403AE80 RID: 241280
			LikeCountItem,
			// Token: 0x0403AE81 RID: 241281
			LikeLine
		}
	}
}
