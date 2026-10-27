using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02004C66 RID: 19558
	public class SheriffMainAnalysisClueItem : UiPanelBase
	{
		// Token: 0x06032905 RID: 207109 RVA: 0x00BC85D0 File Offset: 0x00BC67D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032906 RID: 207110 RVA: 0x00BC86C0 File Offset: 0x00BC68C0
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetActive(false, false);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x06032907 RID: 207111 RVA: 0x00BC8720 File Offset: 0x00BC6920
		public void Refresh(int? clueId)
		{
			base.SetUiActive(clueId != null);
			if (clueId == null)
			{
				return;
			}
			SheriffClue value = SheriffConfig.Instance.GetClueConfigById(clueId.Value).Value;
			base.GetText(1).ShowTextNew(value.Name);
			base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
		}

		// Token: 0x0200AE19 RID: 44569
		private static class EDefine
		{
			// Token: 0x04034DFC RID: 216572
			public const int Tog = 0;

			// Token: 0x04034DFD RID: 216573
			public const int TxtName = 1;

			// Token: 0x04034DFE RID: 216574
			public const int TxtIcon = 2;

			// Token: 0x04034DFF RID: 216575
			public const int PanelLock = 3;

			// Token: 0x04034E00 RID: 216576
			public const int BtnCommon = 4;

			// Token: 0x04034E01 RID: 216577
			public const int PanelHint = 5;
		}
	}
}
