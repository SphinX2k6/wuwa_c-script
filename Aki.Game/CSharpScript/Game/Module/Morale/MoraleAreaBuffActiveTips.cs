using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02005397 RID: 21399
	public class MoraleAreaBuffActiveTips : UiTickViewBase
	{
		// Token: 0x06036ABF RID: 223935 RVA: 0x00CF04C5 File Offset: 0x00CEE6C5
		[NullableContext(1)]
		public MoraleAreaBuffActiveTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036AC0 RID: 223936 RVA: 0x00CF04D0 File Offset: 0x00CEE6D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036AC1 RID: 223937 RVA: 0x00CF0666 File Offset: 0x00CEE866
		private void InitDataParam()
		{
		}

		// Token: 0x06036AC2 RID: 223938 RVA: 0x00CF0668 File Offset: 0x00CEE868
		protected override void OnStart()
		{
			this.InitDataParam();
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x06036AC3 RID: 223939 RVA: 0x00CF06A8 File Offset: 0x00CEE8A8
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06036AC4 RID: 223940 RVA: 0x00CF06B0 File Offset: 0x00CEE8B0
		public void UpdateData()
		{
			this.TipCountDown = (float)MoraleConfig.Instance.GetMoraleBuffShowTime();
			MoraleAreaBuffActiveTipsParams moraleAreaBuffActiveTipsParams = this.OpenParam as MoraleAreaBuffActiveTipsParams;
			base.GetText(1).ShowTextNew(((moraleAreaBuffActiveTipsParams != null) ? moraleAreaBuffActiveTipsParams.TitleKey : null) ?? "not title key");
			base.GetText(2).ShowTextNew(((moraleAreaBuffActiveTipsParams != null) ? moraleAreaBuffActiveTipsParams.DescKey : null) ?? "not desc key");
		}

		// Token: 0x06036AC5 RID: 223941 RVA: 0x00CF071C File Offset: 0x00CEE91C
		protected override void OnTick(float delta)
		{
			if (this.TipCountDown <= 0f)
			{
				return;
			}
			this.TipCountDown -= delta;
			if (this.TipCountDown <= 0f)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0401CE15 RID: 118293
		public float TipCountDown;

		// Token: 0x0200B601 RID: 46593
		private enum EChildType
		{
			// Token: 0x0403720D RID: 225805
			TextTitle = 1,
			// Token: 0x0403720E RID: 225806
			TextDes,
			// Token: 0x0403720F RID: 225807
			PanelHaveTitle,
			// Token: 0x04037210 RID: 225808
			PanelNoTitle,
			// Token: 0x04037211 RID: 225809
			ItemTagNew,
			// Token: 0x04037212 RID: 225810
			SpriteTagBg,
			// Token: 0x04037213 RID: 225811
			PanelClockIcon,
			// Token: 0x04037214 RID: 225812
			TxtNew,
			// Token: 0x04037215 RID: 225813
			ItemCheck,
			// Token: 0x04037216 RID: 225814
			ItemInvalid,
			// Token: 0x04037217 RID: 225815
			ItemInvalidLine
		}
	}
}
