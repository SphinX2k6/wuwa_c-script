using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x020062FF RID: 25343
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballAttributeDetailItem : GridProxyAbstract<IPinballAttributeDetailItemData>
	{
		// Token: 0x0603FC61 RID: 261217 RVA: 0x00F6E140 File Offset: 0x00F6C340
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnItemToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FC62 RID: 261218 RVA: 0x00F6E2D0 File Offset: 0x00F6C4D0
		[NullableContext(1)]
		public override void Refresh(IPinballAttributeDetailItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			PinballPropertyIndex attributeConfig = data.AttributeConfig;
			base.SetTextureByPath(attributeConfig.Icon, base.GetTexture(2), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), attributeConfig.Name, Array.Empty<object>());
			string formatAttributeValueString = PinballModel.Instance.GetFormatAttributeValueString(attributeConfig, (float)data.AttributeValue);
			base.GetText(4).SetText(formatAttributeValueString, true);
			base.GetSprite(1).SetUIActive(data.IsBgShow);
			base.GetText(5).SetUIActive(false);
			this.HasDesc = !StringUtils.IsBlank(attributeConfig.Desc);
			base.GetSprite(6).SetUIActive(this.HasDesc);
			if (this.HasDesc)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), attributeConfig.Desc, Array.Empty<object>());
			}
			base.GetExtendToggle(0).SetToggleState(data.IsExpanded ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshExpanded();
		}

		// Token: 0x0603FC63 RID: 261219 RVA: 0x00F6E3D4 File Offset: 0x00F6C5D4
		public void RefreshExpanded()
		{
			base.GetLayoutBase(7).RootUIComp.Get().SetUIActive(this.HasDesc && this.Data.IsExpanded);
		}

		// Token: 0x0603FC64 RID: 261220 RVA: 0x00F6E410 File Offset: 0x00F6C610
		private void OnItemToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.Data.IsExpanded = true;
			}
			else
			{
				this.Data.IsExpanded = false;
			}
			this.RefreshExpanded();
		}

		// Token: 0x0402149C RID: 136348
		[Nullable(2)]
		protected IPinballAttributeDetailItemData Data;

		// Token: 0x0402149D RID: 136349
		protected bool HasDesc;

		// Token: 0x0200C4F7 RID: 50423
		private enum EComponent
		{
			// Token: 0x0403B70C RID: 243468
			ItemToggle,
			// Token: 0x0403B70D RID: 243469
			BgSprite,
			// Token: 0x0403B70E RID: 243470
			AttrIconTexture,
			// Token: 0x0403B70F RID: 243471
			AttrNameText,
			// Token: 0x0403B710 RID: 243472
			AttrValueText,
			// Token: 0x0403B711 RID: 243473
			AttrAdditionValueText,
			// Token: 0x0403B712 RID: 243474
			ArrowSprite,
			// Token: 0x0403B713 RID: 243475
			DescLayout,
			// Token: 0x0403B714 RID: 243476
			DescText
		}
	}
}
