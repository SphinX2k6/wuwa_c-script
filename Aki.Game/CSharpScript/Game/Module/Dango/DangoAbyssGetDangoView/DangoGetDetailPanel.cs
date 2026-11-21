using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango.DangoAbyssGetDangoView
{
	// Token: 0x02004ACD RID: 19149
	internal class DangoGetDetailPanel : UiPanelBase
	{
		// Token: 0x0602FE39 RID: 196153 RVA: 0x00D5D1E8 File Offset: 0x00D5B3E8
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

		// Token: 0x0602FE3A RID: 196154 RVA: 0x00D5D2BD File Offset: 0x00D5B4BD
		public void OnClickBtnConfirm()
		{
			Action onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback();
		}

		// Token: 0x0602FE3B RID: 196155 RVA: 0x00D5D2D0 File Offset: 0x00D5B4D0
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

		// Token: 0x040196CD RID: 104141
		[Nullable(2)]
		public Action OnClickCallback;
	}
}
