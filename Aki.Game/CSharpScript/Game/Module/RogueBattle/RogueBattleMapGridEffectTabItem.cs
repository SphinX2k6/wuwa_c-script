using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E69 RID: 20073
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleMapGridEffectTabItem : GridProxyAbstract<IRogueBattleMapGridEffectInfo>
	{
		// Token: 0x06033AFF RID: 211711 RVA: 0x00C1A9A0 File Offset: 0x00C18BA0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x06033B00 RID: 211712 RVA: 0x00C1AA10 File Offset: 0x00C18C10
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06033B01 RID: 211713 RVA: 0x00C1AA24 File Offset: 0x00C18C24
		public override void Refresh(IRogueBattleMapGridEffectInfo data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.TagKey, Array.Empty<object>());
			string text;
			if (!data.IsRatio)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string newText = text;
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
		}
	}
}
