using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004388 RID: 17288
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleBuffAddAreaItem : GridProxyAbstract<MoraleAreaData>
	{
		// Token: 0x0602BACD RID: 178893 RVA: 0x00C42898 File Offset: 0x00C40A98
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0602BACE RID: 178894 RVA: 0x00C42908 File Offset: 0x00C40B08
		public override void Refresh(MoraleAreaData data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x0602BACF RID: 178895 RVA: 0x00C42911 File Offset: 0x00C40B11
		public void Refresh(MoraleAreaData data)
		{
			this.ItemData = data;
			if (this.ItemData.IsAreaBuffActive())
			{
				this.SetActiveState();
				return;
			}
			this.SetLockState();
		}

		// Token: 0x0602BAD0 RID: 178896 RVA: 0x00C42934 File Offset: 0x00C40B34
		public void SetActiveState()
		{
			this.SetSpriteActive(true);
			this.SetRedDotActive(false);
			this.SetTextName(this.ItemData.Config.BuffActiveDesc);
			this.SetAlpha(1f);
		}

		// Token: 0x0602BAD1 RID: 178897 RVA: 0x00C42965 File Offset: 0x00C40B65
		public void SetLockState()
		{
			this.SetSpriteActive(false);
			this.SetRedDotActive(false);
			this.SetTextName(this.ItemData.Config.BuffLockDesc);
			this.SetAlpha(0.3f);
		}

		// Token: 0x0602BAD2 RID: 178898 RVA: 0x00C42996 File Offset: 0x00C40B96
		private void SetSpriteActive(bool isActive)
		{
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isActive);
		}

		// Token: 0x0602BAD3 RID: 178899 RVA: 0x00C429AA File Offset: 0x00C40BAA
		private void SetTextName(string nameKey)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(nameKey);
		}

		// Token: 0x0602BAD4 RID: 178900 RVA: 0x00C429BE File Offset: 0x00C40BBE
		private void SetAlpha(float alpha)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(alpha);
		}

		// Token: 0x0602BAD5 RID: 178901 RVA: 0x00C429D2 File Offset: 0x00C40BD2
		private void SetRedDotActive(bool isActive)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isActive);
		}

		// Token: 0x040178EA RID: 96490
		public MoraleAreaData ItemData;

		// Token: 0x0200A06F RID: 41071
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031D7E RID: 204158
			public const int ItemRoot = 0;

			// Token: 0x04031D7F RID: 204159
			public const int TxtName = 1;

			// Token: 0x04031D80 RID: 204160
			public const int SpriteActive = 2;

			// Token: 0x04031D81 RID: 204161
			public const int ItemRedDot = 3;
		}
	}
}
