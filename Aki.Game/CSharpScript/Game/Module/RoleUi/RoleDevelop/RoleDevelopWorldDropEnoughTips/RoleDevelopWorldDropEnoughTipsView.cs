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
	// Token: 0x02004D5A RID: 19802
	public class RoleDevelopWorldDropEnoughTipsView : UiTickViewBase
	{
		// Token: 0x060332AF RID: 209583 RVA: 0x00BEF71A File Offset: 0x00BED91A
		[NullableContext(1)]
		public RoleDevelopWorldDropEnoughTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060332B0 RID: 209584 RVA: 0x00BEF724 File Offset: 0x00BED924
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

		// Token: 0x060332B1 RID: 209585 RVA: 0x00BEF76C File Offset: 0x00BED96C
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x060332B2 RID: 209586 RVA: 0x00BEF774 File Offset: 0x00BED974
		protected override void OnAfterDestroy()
		{
			RoleDevelopWorldDropEnoughTipsController.TryShowNext();
		}

		// Token: 0x060332B3 RID: 209587 RVA: 0x00BEF77C File Offset: 0x00BED97C
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

		// Token: 0x060332B4 RID: 209588 RVA: 0x00BEF7CB File Offset: 0x00BED9CB
		protected override void OnAfterPlayStartSequence()
		{
			this.PlaySequenceStream().ContinueWith(delegate()
			{
				base.CloseMe(null);
			}).Forget();
		}

		// Token: 0x060332B5 RID: 209589 RVA: 0x00BEF7EC File Offset: 0x00BED9EC
		private UniTask PlaySequenceStream()
		{
			RoleDevelopWorldDropEnoughTipsView.<PlaySequenceStream>d__7 <PlaySequenceStream>d__;
			<PlaySequenceStream>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceStream>d__.<>1__state = -1;
			<PlaySequenceStream>d__.<>t__builder.Start<RoleDevelopWorldDropEnoughTipsView.<PlaySequenceStream>d__7>(ref <PlaySequenceStream>d__);
			return <PlaySequenceStream>d__.<>t__builder.Task;
		}

		// Token: 0x0200AED1 RID: 44753
		private class EComponent
		{
			// Token: 0x0403518B RID: 217483
			public const int TexIcon = 0;
		}
	}
}
