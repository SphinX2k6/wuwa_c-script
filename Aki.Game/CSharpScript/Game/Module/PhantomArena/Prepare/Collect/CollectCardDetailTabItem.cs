using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051B3 RID: 20915
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectCardDetailTabItem : GridProxyAbstract<CollectCardDetailViewTabData>
	{
		// Token: 0x060358D6 RID: 219350 RVA: 0x00CAF540 File Offset: 0x00CAD740
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemToggleStateChange))
			};
		}

		// Token: 0x060358D7 RID: 219351 RVA: 0x00CAF5A7 File Offset: 0x00CAD7A7
		private void OnItemToggleStateChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<ECollectCardDetailViewTab> callbackOnClick = this.CallbackOnClick;
				if (callbackOnClick == null)
				{
					return;
				}
				callbackOnClick(this.Data.Index);
			}
		}

		// Token: 0x060358D8 RID: 219352 RVA: 0x00CAF5C8 File Offset: 0x00CAD7C8
		public override void Refresh(CollectCardDetailViewTabData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameId, Array.Empty<object>());
		}

		// Token: 0x060358D9 RID: 219353 RVA: 0x00CAF5ED File Offset: 0x00CAD7ED
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x060358DA RID: 219354 RVA: 0x00CAF600 File Offset: 0x00CAD800
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060358DB RID: 219355 RVA: 0x00CAF613 File Offset: 0x00CAD813
		public override object GetKey(CollectCardDetailViewTabData data, int displayIndex)
		{
			return data.Index;
		}

		// Token: 0x0401C6E2 RID: 116450
		private CollectCardDetailViewTabData Data;

		// Token: 0x0401C6E3 RID: 116451
		public Action<ECollectCardDetailViewTab> CallbackOnClick;

		// Token: 0x0200B33A RID: 45882
		[NullableContext(0)]
		private static class ETabComponents
		{
			// Token: 0x0403651C RID: 222492
			public const int ItemToggle = 0;

			// Token: 0x0403651D RID: 222493
			public const int NameText = 1;
		}
	}
}
