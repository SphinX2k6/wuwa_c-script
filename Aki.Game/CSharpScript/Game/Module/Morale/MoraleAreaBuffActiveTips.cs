using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200437A RID: 17274
	public class MoraleAreaBuffActiveTips : UiTickViewBase
	{
		// Token: 0x0602BA05 RID: 178693 RVA: 0x00C3F56D File Offset: 0x00C3D76D
		[NullableContext(1)]
		public MoraleAreaBuffActiveTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BA06 RID: 178694 RVA: 0x00C3F578 File Offset: 0x00C3D778
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

		// Token: 0x0602BA07 RID: 178695 RVA: 0x00C3F70E File Offset: 0x00C3D90E
		private void InitDataParam()
		{
		}

		// Token: 0x0602BA08 RID: 178696 RVA: 0x00C3F710 File Offset: 0x00C3D910
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

		// Token: 0x0602BA09 RID: 178697 RVA: 0x00C3F750 File Offset: 0x00C3D950
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x0602BA0A RID: 178698 RVA: 0x00C3F758 File Offset: 0x00C3D958
		public void UpdateData()
		{
			this.TipCountDown = (float)MoraleConfig.Instance.GetMoraleBuffShowTime();
			MoraleAreaBuffActiveTipsParams moraleAreaBuffActiveTipsParams = this.OpenParam as MoraleAreaBuffActiveTipsParams;
			base.GetText(1).ShowTextNew(((moraleAreaBuffActiveTipsParams != null) ? moraleAreaBuffActiveTipsParams.TitleKey : null) ?? "not title key");
			base.GetText(2).ShowTextNew(((moraleAreaBuffActiveTipsParams != null) ? moraleAreaBuffActiveTipsParams.DescKey : null) ?? "not desc key");
		}

		// Token: 0x0602BA0B RID: 178699 RVA: 0x00C3F7C4 File Offset: 0x00C3D9C4
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

		// Token: 0x040178AD RID: 96429
		public float TipCountDown;

		// Token: 0x0200A039 RID: 41017
		private enum EChildType
		{
			// Token: 0x04031C62 RID: 203874
			TextTitle = 1,
			// Token: 0x04031C63 RID: 203875
			TextDes,
			// Token: 0x04031C64 RID: 203876
			PanelHaveTitle,
			// Token: 0x04031C65 RID: 203877
			PanelNoTitle,
			// Token: 0x04031C66 RID: 203878
			ItemTagNew,
			// Token: 0x04031C67 RID: 203879
			SpriteTagBg,
			// Token: 0x04031C68 RID: 203880
			PanelClockIcon,
			// Token: 0x04031C69 RID: 203881
			TxtNew,
			// Token: 0x04031C6A RID: 203882
			ItemCheck,
			// Token: 0x04031C6B RID: 203883
			ItemInvalid,
			// Token: 0x04031C6C RID: 203884
			ItemInvalidLine
		}
	}
}
