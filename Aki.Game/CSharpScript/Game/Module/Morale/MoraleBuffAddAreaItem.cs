using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053A5 RID: 21413
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MoraleBuffAddAreaItem : GridProxyAbstract<MoraleAreaData>
	{
		// Token: 0x06036B87 RID: 224135 RVA: 0x00CF37F0 File Offset: 0x00CF19F0
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

		// Token: 0x06036B88 RID: 224136 RVA: 0x00CF3860 File Offset: 0x00CF1A60
		public override void Refresh(MoraleAreaData data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x06036B89 RID: 224137 RVA: 0x00CF3869 File Offset: 0x00CF1A69
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

		// Token: 0x06036B8A RID: 224138 RVA: 0x00CF388C File Offset: 0x00CF1A8C
		public void SetActiveState()
		{
			this.SetSpriteActive(true);
			this.SetRedDotActive(false);
			this.SetTextName(this.ItemData.Config.BuffActiveDesc);
			this.SetAlpha(1f);
		}

		// Token: 0x06036B8B RID: 224139 RVA: 0x00CF38BD File Offset: 0x00CF1ABD
		public void SetLockState()
		{
			this.SetSpriteActive(false);
			this.SetRedDotActive(false);
			this.SetTextName(this.ItemData.Config.BuffLockDesc);
			this.SetAlpha(0.3f);
		}

		// Token: 0x06036B8C RID: 224140 RVA: 0x00CF38EE File Offset: 0x00CF1AEE
		private void SetSpriteActive(bool isActive)
		{
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(isActive);
		}

		// Token: 0x06036B8D RID: 224141 RVA: 0x00CF3902 File Offset: 0x00CF1B02
		private void SetTextName(string nameKey)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(nameKey);
		}

		// Token: 0x06036B8E RID: 224142 RVA: 0x00CF3916 File Offset: 0x00CF1B16
		private void SetAlpha(float alpha)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(alpha);
		}

		// Token: 0x06036B8F RID: 224143 RVA: 0x00CF392A File Offset: 0x00CF1B2A
		private void SetRedDotActive(bool isActive)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isActive);
		}

		// Token: 0x0401CE52 RID: 118354
		public MoraleAreaData ItemData;

		// Token: 0x0200B637 RID: 46647
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04037329 RID: 226089
			public const int ItemRoot = 0;

			// Token: 0x0403732A RID: 226090
			public const int TxtName = 1;

			// Token: 0x0403732B RID: 226091
			public const int SpriteActive = 2;

			// Token: 0x0403732C RID: 226092
			public const int ItemRedDot = 3;
		}
	}
}
