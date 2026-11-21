using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045DD RID: 17885
	public class PanelBar : UiPanelBase
	{
		// Token: 0x17005AE4 RID: 23268
		// (get) Token: 0x0602CFCB RID: 184267 RVA: 0x00C94199 File Offset: 0x00C92399
		protected bool IsActive
		{
			get
			{
				return (this.Direction > 0 && this.Current > 0) || (this.Direction < 0 && this.Current < 0);
			}
		}

		// Token: 0x0602CFCC RID: 184268 RVA: 0x00C941C4 File Offset: 0x00C923C4
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

		// Token: 0x0602CFCD RID: 184269 RVA: 0x00C94234 File Offset: 0x00C92434
		protected override void OnStart()
		{
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0602CFCE RID: 184270 RVA: 0x00C94243 File Offset: 0x00C92443
		public void SetDirection(int direction)
		{
			this.Direction = direction;
		}

		// Token: 0x0602CFCF RID: 184271 RVA: 0x00C9424C File Offset: 0x00C9244C
		public void SetLimit(int limit)
		{
			this.Limit = limit;
			base.GetText(0).SetText(limit.ToString(), true);
		}

		// Token: 0x0602CFD0 RID: 184272 RVA: 0x00C9426C File Offset: 0x00C9246C
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

		// Token: 0x0602CFD1 RID: 184273 RVA: 0x00C942EC File Offset: 0x00C924EC
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

		// Token: 0x0602CFD2 RID: 184274 RVA: 0x00C943D4 File Offset: 0x00C925D4
		public void ClosePreviewValue()
		{
			base.GetSprite(1).SetUIActive(false);
			this.SetCurrentValue(this.Current);
		}

		// Token: 0x040181ED RID: 98797
		protected int Direction = 1;

		// Token: 0x040181EE RID: 98798
		protected int Limit;

		// Token: 0x040181EF RID: 98799
		protected int Current;
	}
}
