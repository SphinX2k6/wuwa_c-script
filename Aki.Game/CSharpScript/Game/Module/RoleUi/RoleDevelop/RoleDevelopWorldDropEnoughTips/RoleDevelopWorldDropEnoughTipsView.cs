using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.RoleDevelopWorldDropEnoughTips
{
	// Token: 0x02003D23 RID: 15651
	public class RoleDevelopWorldDropEnoughTipsView : UiTickViewBase
	{
		// Token: 0x06028119 RID: 164121 RVA: 0x00B3884E File Offset: 0x00B36A4E
		[NullableContext(1)]
		public RoleDevelopWorldDropEnoughTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602811A RID: 164122 RVA: 0x00B38858 File Offset: 0x00B36A58
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602811B RID: 164123 RVA: 0x00B388A0 File Offset: 0x00B36AA0
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x0602811C RID: 164124 RVA: 0x00B388A8 File Offset: 0x00B36AA8
		protected override void OnAfterDestroy()
		{
			RoleDevelopWorldDropEnoughTipsController.TryShowNext();
		}

		// Token: 0x0602811D RID: 164125 RVA: 0x00B388B0 File Offset: 0x00B36AB0
		private void Refresh()
		{
			int? currentDisplayItemId = RoleDevelopWorldDropEnoughTipsController.GetCurrentDisplayItemId();
			if (currentDisplayItemId == null)
			{
				return;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(currentDisplayItemId.Value);
			if (itemConfigData != null)
			{
				base.SetTextureByPath(itemConfigData.Icon, base.GetTexture(0), null, null);
			}
		}

		// Token: 0x0602811E RID: 164126 RVA: 0x00B388FF File Offset: 0x00B36AFF
		protected override void OnAfterPlayStartSequence()
		{
			this.PlaySequenceStream().ContinueWith(delegate()
			{
				base.CloseMe(null);
			}).Forget();
		}

		// Token: 0x0602811F RID: 164127 RVA: 0x00B38920 File Offset: 0x00B36B20
		private UniTask PlaySequenceStream()
		{
			RoleDevelopWorldDropEnoughTipsView.<PlaySequenceStream>d__7 <PlaySequenceStream>d__;
			<PlaySequenceStream>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceStream>d__.<>1__state = -1;
			<PlaySequenceStream>d__.<>t__builder.Start<RoleDevelopWorldDropEnoughTipsView.<PlaySequenceStream>d__7>(ref <PlaySequenceStream>d__);
			return <PlaySequenceStream>d__.<>t__builder.Task;
		}

		// Token: 0x02009904 RID: 39172
		private enum EComponentType
		{
			// Token: 0x0402FBBC RID: 195516
			TexIcon
		}
	}
}
