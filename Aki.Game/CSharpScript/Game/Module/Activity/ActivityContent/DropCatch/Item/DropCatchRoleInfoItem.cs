using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x02005639 RID: 22073
	public class DropCatchRoleInfoItem : GridProxyAbstract<float>
	{
		// Token: 0x060368A5 RID: 223397 RVA: 0x00F38774 File Offset: 0x00F36974
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

		// Token: 0x060368A6 RID: 223398 RVA: 0x00F387E4 File Offset: 0x00F369E4
		protected override void OnStart()
		{
			this.ValueLayout = new GenericLayout<DropCatchRoleBarItem, int>(base.GetGridLayout(2), new Func<DropCatchRoleBarItem>(this.InitBarItem), null, false, true);
		}

		// Token: 0x060368A7 RID: 223399 RVA: 0x00F38807 File Offset: 0x00F36A07
		[NullableContext(1)]
		private DropCatchRoleBarItem InitBarItem()
		{
			return new DropCatchRoleBarItem();
		}

		// Token: 0x060368A8 RID: 223400 RVA: 0x00F38810 File Offset: 0x00F36A10
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

		// Token: 0x0401CD09 RID: 118025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DropCatchRoleBarItem, int> ValueLayout;

		// Token: 0x0401CD0A RID: 118026
		private const int MAX_ROLE_INFO_VALUE = 5;
	}
}
