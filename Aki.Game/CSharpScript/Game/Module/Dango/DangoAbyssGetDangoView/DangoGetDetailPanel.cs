using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango.DangoAbyssGetDangoView
{
	// Token: 0x02005AEC RID: 23276
	internal class DangoGetDetailPanel : UiPanelBase
	{
		// Token: 0x0603AEC7 RID: 241351 RVA: 0x00E0C510 File Offset: 0x00E0A710
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnConfirm))
			};
		}

		// Token: 0x0603AEC8 RID: 241352 RVA: 0x00E0C5E5 File Offset: 0x00E0A7E5
		public void OnClickBtnConfirm()
		{
			Action onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback();
		}

		// Token: 0x0603AEC9 RID: 241353 RVA: 0x00E0C5F8 File Offset: 0x00E0A7F8
		[NullableContext(1)]
		public void RefreshView(DangoAbyssDefine.IDangoUnlockData data)
		{
			base.GetText(1).SetText(data.DetailName, true);
			bool flag = data.DetailDialog != "";
			base.GetText(3).SetUIActive(flag);
			if (flag)
			{
				base.GetText(3).SetText(data.DetailDialog, true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "AbyssDangoLV", new <>z__ReadOnlySingleElementList<object>(data.DangoLevel));
		}

		// Token: 0x0401EC11 RID: 125969
		[Nullable(2)]
		public Action OnClickCallback;
	}
}
