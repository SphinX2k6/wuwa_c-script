using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Monster
{
	// Token: 0x02006329 RID: 25385
	public class PinballMonsterRiskTypeTitleItem : SyncGridProxyAbstract<PinballMonsterRiskType>
	{
		// Token: 0x0603FDE7 RID: 261607 RVA: 0x00F74148 File Offset: 0x00F72348
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

		// Token: 0x0603FDE8 RID: 261608 RVA: 0x00F741D4 File Offset: 0x00F723D4
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

		// Token: 0x04021521 RID: 136481
		private PinballMonsterRiskType? Data;

		// Token: 0x0200C528 RID: 50472
		private enum EComponents
		{
			// Token: 0x0403B81A RID: 243738
			BgSprite,
			// Token: 0x0403B81B RID: 243739
			TypeIconSprite,
			// Token: 0x0403B81C RID: 243740
			NameText
		}
	}
}
