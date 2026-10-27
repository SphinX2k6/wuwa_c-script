using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005607 RID: 22023
	public class PanelBar : UiPanelBase
	{
		// Token: 0x1700871D RID: 34589
		// (get) Token: 0x060380CD RID: 229581 RVA: 0x00D46451 File Offset: 0x00D44651
		protected bool IsActive
		{
			get
			{
				return (this.Direction > 0 && this.Current > 0) || (this.Direction < 0 && this.Current < 0);
			}
		}

		// Token: 0x060380CE RID: 229582 RVA: 0x00D4647C File Offset: 0x00D4467C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x060380CF RID: 229583 RVA: 0x00D464EC File Offset: 0x00D446EC
		protected override void OnStart()
		{
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x060380D0 RID: 229584 RVA: 0x00D464FB File Offset: 0x00D446FB
		public void SetDirection(int direction)
		{
			this.Direction = direction;
		}

		// Token: 0x060380D1 RID: 229585 RVA: 0x00D46504 File Offset: 0x00D44704
		public void SetLimit(int limit)
		{
			this.Limit = limit;
			base.GetText(0).SetText(limit.ToString(), true);
		}

		// Token: 0x060380D2 RID: 229586 RVA: 0x00D46524 File Offset: 0x00D44724
		public void SetCurrentValue(int current)
		{
			UUISprite sprite = base.GetSprite(2);
			UUIItem item = base.GetItem(3);
			this.Current = current;
			bool isActive = this.IsActive;
			item.SetUIActive(isActive);
			sprite.SetUIActive(isActive);
			if (!isActive)
			{
				return;
			}
			float num = MathUtils.Instance.Clamp((float)current / (float)this.Limit, 0f, 1f);
			sprite.SetFillAmount(num);
			float anchorOffsetX = sprite.GetWidth() * num * (float)this.Direction;
			item.SetAnchorOffsetX(anchorOffsetX);
		}

		// Token: 0x060380D3 RID: 229587 RVA: 0x00D465A4 File Offset: 0x00D447A4
		public void SetPreviewValue(int changeValue)
		{
			if (changeValue > 0)
			{
				return;
			}
			float num = this.IsActive ? ((float)this.Current / (float)this.Limit) : 0f;
			UUISprite sprite = base.GetSprite(2);
			UUISprite sprite2 = base.GetSprite(1);
			if (this.Direction > 0)
			{
				float num2 = (float)MathUtils.Instance.Clamp(this.Current + changeValue, 0, this.Limit) / (float)this.Limit;
				sprite.SetFillAmount(num2);
				sprite.SetUIActive(num2 > 0f);
				sprite2.SetFillAmount(num);
				sprite2.SetUIActive(num > 0f);
				return;
			}
			float num3 = (float)MathUtils.Instance.Clamp(this.Current + changeValue, this.Limit, 0) / (float)this.Limit;
			sprite.SetFillAmount(num);
			sprite.SetUIActive(num > 0f);
			sprite2.SetFillAmount(num3);
			sprite2.SetUIActive(num3 > 0f);
		}

		// Token: 0x060380D4 RID: 229588 RVA: 0x00D4668C File Offset: 0x00D4488C
		public void ClosePreviewValue()
		{
			base.GetSprite(1).SetUIActive(false);
			this.SetCurrentValue(this.Current);
		}

		// Token: 0x0401D762 RID: 120674
		protected int Direction = 1;

		// Token: 0x0401D763 RID: 120675
		protected int Limit;

		// Token: 0x0401D764 RID: 120676
		protected int Current;
	}
}
