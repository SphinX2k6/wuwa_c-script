using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE4 RID: 19172
	public class TrapDefenseBuildingGangsInfoView : UiViewBase
	{
		// Token: 0x06031AB7 RID: 203447 RVA: 0x00B87B7E File Offset: 0x00B85D7E
		[NullableContext(1)]
		public TrapDefenseBuildingGangsInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031AB8 RID: 203448 RVA: 0x00B87B88 File Offset: 0x00B85D88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedMask));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031AB9 RID: 203449 RVA: 0x00B87C70 File Offset: 0x00B85E70
		protected override void OnStart()
		{
			int key = (int)this.OpenParam;
			TrapDefenseBdData valueOrDefault = TrapDefenseModel.Instance.RougeModeData.BdDataMap.GetValueOrDefault(key);
			if (valueOrDefault == null)
			{
				return;
			}
			base.SetTextureByPath(valueOrDefault.Config.Icon, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), valueOrDefault.Config.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), valueOrDefault.Config.Desc, Array.Empty<object>());
		}

		// Token: 0x06031ABA RID: 203450 RVA: 0x00B87D07 File Offset: 0x00B85F07
		private void OnClickedMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200AC76 RID: 44150
		internal class EMainDefine
		{
			// Token: 0x04034699 RID: 214681
			public const int BtnMask = 0;

			// Token: 0x0403469A RID: 214682
			public const int Icon = 1;

			// Token: 0x0403469B RID: 214683
			public const int Title = 2;

			// Token: 0x0403469C RID: 214684
			public const int Desc = 3;
		}
	}
}
