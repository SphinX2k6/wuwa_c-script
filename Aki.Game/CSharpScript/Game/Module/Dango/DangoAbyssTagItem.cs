using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02005AE5 RID: 23269
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DangoAbyssTagItem : GridProxyAbstract<DangoAbyssDefine.DangoAbyssTagData>
	{
		// Token: 0x0603AEA1 RID: 241313 RVA: 0x00E0BF98 File Offset: 0x00E0A198
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0603AEA2 RID: 241314 RVA: 0x00E0C008 File Offset: 0x00E0A208
		public override void Refresh(DangoAbyssDefine.DangoAbyssTagData data, bool isSelected, int gridIndex)
		{
			AbyssPluginPropDesc value = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(data.TagId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			this.RefreshBgColor(value.BgColor);
			this.RefreshDescText(data);
			this.RefreshValueBg(data);
		}

		// Token: 0x0603AEA3 RID: 241315 RVA: 0x00E0C068 File Offset: 0x00E0A268
		private void RefreshDescText(DangoAbyssDefine.DangoAbyssTagData data)
		{
			string formatAttributeValueByTagId = DangoAbyssModel.Instance.GetFormatAttributeValueByTagId(data.Value, data.TagId, new bool?(true));
			base.GetText(2).SetText(formatAttributeValueByTagId, true);
			base.GetText(2).SetUIActive(true);
		}

		// Token: 0x0603AEA4 RID: 241316 RVA: 0x00E0C0B0 File Offset: 0x00E0A2B0
		private void RefreshBgColor(string color)
		{
			FColor color2 = FColor.FromHex(color);
			base.GetSprite(0).SetColor(color2);
		}

		// Token: 0x0603AEA5 RID: 241317 RVA: 0x00E0C0D1 File Offset: 0x00E0A2D1
		private void RefreshValueBg(DangoAbyssDefine.DangoAbyssTagData data)
		{
			base.GetItem(3).SetUIActive(true);
		}

		// Token: 0x0200BD3D RID: 48445
		[NullableContext(0)]
		private enum ETagComponent
		{
			// Token: 0x0403912C RID: 233772
			SpriteBg,
			// Token: 0x0403912D RID: 233773
			NameText,
			// Token: 0x0403912E RID: 233774
			DescText,
			// Token: 0x0403912F RID: 233775
			ValueBg
		}
	}
}
