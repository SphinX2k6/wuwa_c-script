using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C17 RID: 15383
	public class SheriffMainAnalysisClueItem : UiPanelBase
	{
		// Token: 0x060276B8 RID: 161464 RVA: 0x00B0D23C File Offset: 0x00B0B43C
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

		// Token: 0x060276B9 RID: 161465 RVA: 0x00B0D32C File Offset: 0x00B0B52C
		protected override void OnStart()
		{
			base.GetExtendToggle(0).SetActive(false, false);
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			base.GetButton(4).RootUIComp.Get().SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x060276BA RID: 161466 RVA: 0x00B0D38C File Offset: 0x00B0B58C
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

		// Token: 0x02009837 RID: 38967
		private static class EDefine
		{
			// Token: 0x0402F7A1 RID: 194465
			public const int Tog = 0;

			// Token: 0x0402F7A2 RID: 194466
			public const int TxtName = 1;

			// Token: 0x0402F7A3 RID: 194467
			public const int TxtIcon = 2;

			// Token: 0x0402F7A4 RID: 194468
			public const int PanelLock = 3;

			// Token: 0x0402F7A5 RID: 194469
			public const int BtnCommon = 4;

			// Token: 0x0402F7A6 RID: 194470
			public const int PanelHint = 5;
		}
	}
}
