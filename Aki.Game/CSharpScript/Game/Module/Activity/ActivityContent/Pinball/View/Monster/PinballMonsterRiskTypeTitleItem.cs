using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x020052A7 RID: 21159
	public class PinballMonsterRiskTypeTitleItem : SyncGridProxyAbstract<PinballMonsterRiskType>
	{
		// Token: 0x06034AA8 RID: 215720 RVA: 0x00EBB0A4 File Offset: 0x00EB92A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034AA9 RID: 215721 RVA: 0x00EBB130 File Offset: 0x00EB9330
		public override void Refresh(PinballMonsterRiskType data)
		{
			this.Data = new PinballMonsterRiskType?(data);
			this.SetSpriteByPath(data.Icon2, base.GetSprite(1), false, null, null);
			FColor color = FColor.FromHex(data.TitleColor);
			FColor fontOutlineColor = FColor.FromHex(data.TitleOutlineColor);
			UUIText text = base.GetText(2);
			LguiUtil.Instance.SetLocalTextNew(text, data.Name, Array.Empty<object>());
			text.SetColor(color);
			text.SetFontOutlineColor(fontOutlineColor);
			base.GetSprite(0).SetColor(color);
		}

		// Token: 0x0401BE50 RID: 114256
		private PinballMonsterRiskType? Data;

		// Token: 0x0200AF0F RID: 44815
		private enum EComponents
		{
			// Token: 0x0403617C RID: 221564
			BgSprite,
			// Token: 0x0403617D RID: 221565
			TypeIconSprite,
			// Token: 0x0403617E RID: 221566
			NameText
		}
	}
}
