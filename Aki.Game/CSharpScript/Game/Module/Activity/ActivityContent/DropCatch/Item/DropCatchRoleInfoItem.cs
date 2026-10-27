using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066E9 RID: 26345
	public class DropCatchRoleInfoItem : GridProxyAbstract<float>
	{
		// Token: 0x06041D59 RID: 269657 RVA: 0x00FF7370 File Offset: 0x00FF5570
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06041D5A RID: 269658 RVA: 0x00FF73E0 File Offset: 0x00FF55E0
		protected override void OnStart()
		{
			this.ValueLayout = new GenericLayout<DropCatchRoleBarItem, int>(base.GetGridLayout(2), new Func<DropCatchRoleBarItem>(this.InitBarItem), null, false, true);
		}

		// Token: 0x06041D5B RID: 269659 RVA: 0x00FF7403 File Offset: 0x00FF5603
		[NullableContext(1)]
		private DropCatchRoleBarItem InitBarItem()
		{
			return new DropCatchRoleBarItem();
		}

		// Token: 0x06041D5C RID: 269660 RVA: 0x00FF740C File Offset: 0x00FF560C
		public override void Refresh(float curValue, bool isSelected, int gridIndex)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 5; i++)
			{
				if ((float)i < curValue)
				{
					list.Add(i);
				}
			}
			string text = null;
			string text2 = null;
			switch (gridIndex)
			{
			case 0:
				text = UiResourceConfig.Instance.GetResourcePath("SP_GoldCatchIconSpeed");
				text2 = "CoinCatch_Character_Speed";
				break;
			case 1:
				text = UiResourceConfig.Instance.GetResourcePath("SP_GoldCatchIconRange");
				text2 = "CoinCatch_Character_Range";
				break;
			case 2:
				text = UiResourceConfig.Instance.GetResourcePath("SP_GoldCatchIconCharge");
				text2 = "CoinCatch_Character_Energy";
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				this.SetSpriteByPath(text, base.GetSprite(0), false, null, null);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				UUIText text3 = base.GetText(1);
				if (text3 != null)
				{
					text3.ShowTextNew(text2);
				}
			}
			GenericLayout<DropCatchRoleBarItem, int> valueLayout = this.ValueLayout;
			if (valueLayout == null)
			{
				return;
			}
			valueLayout.RefreshByData(list, null, false);
		}

		// Token: 0x040224B0 RID: 140464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DropCatchRoleBarItem, int> ValueLayout;

		// Token: 0x040224B1 RID: 140465
		private const int MAX_ROLE_INFO_VALUE = 5;
	}
}
