using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200558F RID: 21903
	internal class ShipSkinItem : GridProxyAbstract<int>
	{
		// Token: 0x0603647C RID: 222332 RVA: 0x00F23408 File Offset: 0x00F21608
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603647D RID: 222333 RVA: 0x00F23534 File Offset: 0x00F21734
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.SkinId = data;
			FishingShipSkin fishingShipSkinConfig = FishingConfig.Instance.GetFishingShipSkinConfig(data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), fishingShipSkinConfig.Name, Array.Empty<object>());
			base.SetTextureByPath(fishingShipSkinConfig.BigTexture, base.GetTexture(1), null, null);
			bool flag = this.SkinId == FishingModel.Instance.GetShipData().GetCurrentSkinId();
			base.GetItem(3).SetUIActive(flag);
			base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			bool flag2 = FishingModel.Instance.UnlockShipSkin.Contains(this.SkinId);
			base.GetItem(4).SetUIActive(!flag2);
			bool flag3 = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.FishingShipSkinRecord, this.SkinId);
			if (flag2)
			{
				base.GetItem(5).SetUIActive(!flag3);
				return;
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0603647E RID: 222334 RVA: 0x00F23626 File Offset: 0x00F21826
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<UUIExtendToggle, int> clickFunc = this.ClickFunc;
			if (clickFunc != null)
			{
				clickFunc(base.GetExtendToggle(0), this.SkinId);
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0603647F RID: 222335 RVA: 0x00F23653 File Offset: 0x00F21853
		public void SelectToggle()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
			Action<UUIExtendToggle, int> clickFunc = this.ClickFunc;
			if (clickFunc != null)
			{
				clickFunc(base.GetExtendToggle(0), this.SkinId);
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x0401CA6C RID: 117356
		public int SkinId;

		// Token: 0x0401CA6D RID: 117357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<UUIExtendToggle, int> ClickFunc;

		// Token: 0x0200B203 RID: 45571
		private class EShipSkinItemComponent
		{
			// Token: 0x04037054 RID: 225364
			public const int Toggle = 0;

			// Token: 0x04037055 RID: 225365
			public const int Texture = 1;

			// Token: 0x04037056 RID: 225366
			public const int NameText = 2;

			// Token: 0x04037057 RID: 225367
			public const int CurrentItem = 3;

			// Token: 0x04037058 RID: 225368
			public const int LockItem = 4;

			// Token: 0x04037059 RID: 225369
			public const int RedDotItem = 5;
		}
	}
}
