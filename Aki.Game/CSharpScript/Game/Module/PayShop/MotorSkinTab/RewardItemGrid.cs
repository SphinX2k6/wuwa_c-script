using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PayShop.MotorSkinTab
{
	// Token: 0x0200535C RID: 21340
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardItemGrid : GridProxyAbstract<IRewardItemGridData>
	{
		// Token: 0x0603684B RID: 223307 RVA: 0x00CE8E44 File Offset: 0x00CE7044
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0603684C RID: 223308 RVA: 0x00CE8EA0 File Offset: 0x00CE70A0
		[NullableContext(1)]
		public override void Refresh(IRewardItemGridData data, bool isSelected, int gridIndex)
		{
			base.SetTextureByPath(data.IconPath, base.GetTexture(1), null, null);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("MotorShop_Xicon", "x");
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted(multiTextByKey);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0200B5C3 RID: 46531
		private enum ERewardItemComponents
		{
			// Token: 0x040370F3 RID: 225523
			BtnReward01,
			// Token: 0x040370F4 RID: 225524
			TexIcon,
			// Token: 0x040370F5 RID: 225525
			TxtNum
		}
	}
}
