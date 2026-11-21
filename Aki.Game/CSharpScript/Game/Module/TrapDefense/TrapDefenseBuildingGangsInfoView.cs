using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A8C RID: 14988
	public class TrapDefenseBuildingGangsInfoView : UiViewBase
	{
		// Token: 0x06026847 RID: 157767 RVA: 0x00ACBB32 File Offset: 0x00AC9D32
		[NullableContext(1)]
		public TrapDefenseBuildingGangsInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026848 RID: 157768 RVA: 0x00ACBB3C File Offset: 0x00AC9D3C
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

		// Token: 0x06026849 RID: 157769 RVA: 0x00ACBC24 File Offset: 0x00AC9E24
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

		// Token: 0x0602684A RID: 157770 RVA: 0x00ACBCBB File Offset: 0x00AC9EBB
		private void OnClickedMask()
		{
			base.CloseMe(null);
		}

		// Token: 0x02009696 RID: 38550
		internal class EMainDefine
		{
			// Token: 0x0402F04A RID: 192586
			public const int BtnMask = 0;

			// Token: 0x0402F04B RID: 192587
			public const int Icon = 1;

			// Token: 0x0402F04C RID: 192588
			public const int Title = 2;

			// Token: 0x0402F04D RID: 192589
			public const int Desc = 3;
		}
	}
}
