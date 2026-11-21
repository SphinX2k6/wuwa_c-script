using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059FB RID: 23035
	public sealed class SolarSchoolRewardTipAttrItem : SolarSchoolRewardTipItemBase
	{
		// Token: 0x06038BAA RID: 232362 RVA: 0x00FE02CC File Offset: 0x00FDE4CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038BAB RID: 232363 RVA: 0x00FE03BC File Offset: 0x00FDE5BC
		public override void InitData()
		{
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			SolarSchoolAttr? solarSchoolAttr = (this.Data == null) ? null : SolarSchoolConfig.Instance.GetAttr(this.Data.TargetId);
			if (solarSchoolAttr == null)
			{
				return;
			}
			ESolarSchoolSecondAttr attrType = (ESolarSchoolSecondAttr)solarSchoolAttr.Value.AttrType;
			if (sprite != null)
			{
				sprite.SetUIActive(SolarSchoolGamePlayModel.Instance.PlayerData.IsAttrImportant(attrType));
			}
			bool flag = this.Data.Delta > 0;
			bool flag2 = attrType == ESolarSchoolSecondAttr.Fatigue;
			string resourceId = flag2 ? (flag ? "SP_SolarSchoolAcquireUpB" : "SP_SolarSchoolAcquireDownB") : (flag ? "SP_SolarSchoolAcquireUp" : "SP_SolarSchoolAcquireDown");
			string resourceId2 = flag2 ? (flag ? "T_SolarSchoolAcquireDownBg" : "T_SolarSchoolAcquireBg") : (flag ? "T_SolarSchoolAcquireBg" : "T_SolarSchoolAcquireDownBg");
			base.SetTextureByPath(solarSchoolAttr.Value.YellowIconSmall, base.GetTexture(0), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), solarSchoolAttr.Value.Name, Array.Empty<object>());
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(SolarSchoolUtils.GetAttrDeltaText(attrType, this.Data.Delta), true);
			}
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), base.GetSprite(4), false, null, null);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(resourceId2), base.GetTexture(3), null, null);
		}

		// Token: 0x06038BAC RID: 232364 RVA: 0x00FE0556 File Offset: 0x00FDE756
		[NullableContext(1)]
		protected override string GetStartSequenceName()
		{
			if (!(this.Data != null) || this.Data.Delta >= 0)
			{
				return "Start01";
			}
			return "Start02";
		}

		// Token: 0x0200B5A7 RID: 46503
		private enum EComponent
		{
			// Token: 0x040382C5 RID: 230085
			Icon,
			// Token: 0x040382C6 RID: 230086
			Name,
			// Token: 0x040382C7 RID: 230087
			Number,
			// Token: 0x040382C8 RID: 230088
			Bg,
			// Token: 0x040382C9 RID: 230089
			State,
			// Token: 0x040382CA RID: 230090
			SprScratch
		}
	}
}
