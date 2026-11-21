using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango
{
	// Token: 0x02004AC6 RID: 19142
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class DangoAbyssTagItem : GridProxyAbstract<DangoAbyssDefine.DangoAbyssTagData>
	{
		// Token: 0x0602FE13 RID: 196115 RVA: 0x00D5CC7C File Offset: 0x00D5AE7C
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

		// Token: 0x0602FE14 RID: 196116 RVA: 0x00D5CCEC File Offset: 0x00D5AEEC
		public override void Refresh(DangoAbyssDefine.DangoAbyssTagData data, bool isSelected, int gridIndex)
		{
			AbyssPluginPropDesc value = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(data.TagId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			this.RefreshBgColor(value.BgColor);
			this.RefreshDescText(data);
			this.RefreshValueBg(data);
		}

		// Token: 0x0602FE15 RID: 196117 RVA: 0x00D5CD4C File Offset: 0x00D5AF4C
		private void RefreshDescText(DangoAbyssDefine.DangoAbyssTagData data)
		{
			string formatAttributeValueByTagId = DangoAbyssModel.Instance.GetFormatAttributeValueByTagId(data.Value, data.TagId, new bool?(true));
			base.GetText(2).SetText(formatAttributeValueByTagId, true);
			base.GetText(2).SetUIActive(true);
		}

		// Token: 0x0602FE16 RID: 196118 RVA: 0x00D5CD94 File Offset: 0x00D5AF94
		private void RefreshBgColor(string color)
		{
			FColor color2 = FColor.FromHex(color);
			base.GetSprite(0).SetColor(color2);
		}

		// Token: 0x0602FE17 RID: 196119 RVA: 0x00D5CDB5 File Offset: 0x00D5AFB5
		private void RefreshValueBg(DangoAbyssDefine.DangoAbyssTagData data)
		{
			base.GetItem(3).SetUIActive(true);
		}

		// Token: 0x0200A745 RID: 42821
		[NullableContext(0)]
		private enum ETagComponent
		{
			// Token: 0x04033AF6 RID: 211702
			SpriteBg,
			// Token: 0x04033AF7 RID: 211703
			NameText,
			// Token: 0x04033AF8 RID: 211704
			DescText,
			// Token: 0x04033AF9 RID: 211705
			ValueBg
		}
	}
}
