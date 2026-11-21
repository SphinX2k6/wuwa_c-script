using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PayShop.MotorSkinTab
{
	// Token: 0x0200433F RID: 17215
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RewardItemGrid : GridProxyAbstract<IRewardItemGridData>
	{
		// Token: 0x0602B791 RID: 178065 RVA: 0x00C37CCC File Offset: 0x00C35ECC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602B792 RID: 178066 RVA: 0x00C37D28 File Offset: 0x00C35F28
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

		// Token: 0x02009FFC RID: 40956
		private enum ERewardItemComponents
		{
			// Token: 0x04031B4B RID: 203595
			BtnReward01,
			// Token: 0x04031B4C RID: 203596
			TexIcon,
			// Token: 0x04031B4D RID: 203597
			TxtNum
		}
	}
}
