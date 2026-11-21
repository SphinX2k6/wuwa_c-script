using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x02004183 RID: 16771
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectCardDetailTabItem : GridProxyAbstract<CollectCardDetailViewTabData>
	{
		// Token: 0x0602A7D1 RID: 174033 RVA: 0x00BFCB7C File Offset: 0x00BFAD7C
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

		// Token: 0x0602A7D2 RID: 174034 RVA: 0x00BFCBE3 File Offset: 0x00BFADE3
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

		// Token: 0x0602A7D3 RID: 174035 RVA: 0x00BFCC04 File Offset: 0x00BFAE04
		public override void Refresh(CollectCardDetailViewTabData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameId, Array.Empty<object>());
		}

		// Token: 0x0602A7D4 RID: 174036 RVA: 0x00BFCC29 File Offset: 0x00BFAE29
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A7D5 RID: 174037 RVA: 0x00BFCC3C File Offset: 0x00BFAE3C
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602A7D6 RID: 174038 RVA: 0x00BFCC4F File Offset: 0x00BFAE4F
		public override object GetKey(CollectCardDetailViewTabData data, int displayIndex)
		{
			return data.Index;
		}

		// Token: 0x04017117 RID: 94487
		private CollectCardDetailViewTabData Data;

		// Token: 0x04017118 RID: 94488
		public Action<ECollectCardDetailViewTab> CallbackOnClick;

		// Token: 0x02009D72 RID: 40306
		[NullableContext(0)]
		private static class ETabComponents
		{
			// Token: 0x04030F6F RID: 200559
			public const int ItemToggle = 0;

			// Token: 0x04030F70 RID: 200560
			public const int NameText = 1;
		}
	}
}
