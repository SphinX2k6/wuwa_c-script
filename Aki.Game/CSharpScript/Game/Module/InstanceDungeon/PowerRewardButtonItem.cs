using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004864 RID: 18532
	public class PowerRewardButtonItem : UiPanelBase
	{
		// Token: 0x0602EA1E RID: 191006 RVA: 0x00D04A90 File Offset: 0x00D02C90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnRewardButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EA1F RID: 191007 RVA: 0x00D04B99 File Offset: 0x00D02D99
		private void OnRewardButtonClick()
		{
			IPowerRewardButtonItemData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.RewardCallBack();
		}

		// Token: 0x0602EA20 RID: 191008 RVA: 0x00D04BB0 File Offset: 0x00D02DB0
		protected override void OnStart()
		{
			base.SetItemIcon(base.GetTexture(3), 5, null, null);
		}

		// Token: 0x0602EA21 RID: 191009 RVA: 0x00D04BD5 File Offset: 0x00D02DD5
		[NullableContext(1)]
		public void Update(IPowerRewardButtonItemData data)
		{
			this.Data = data;
			this.Refresh();
		}

		// Token: 0x0602EA22 RID: 191010 RVA: 0x00D04BE4 File Offset: 0x00D02DE4
		public void Refresh()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(this.Data.PowerNum.ToString(), true);
			}
			string[] args = this.Data.RewardTextArgs ?? Array.Empty<string>();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.RewardTextId, args);
			this.RefreshPowerState();
		}

		// Token: 0x0602EA23 RID: 191011 RVA: 0x00D04C58 File Offset: 0x00D02E58
		public void RefreshPowerState()
		{
			if (this.Data == null)
			{
				return;
			}
			int powerNum = this.Data.PowerNum;
			bool flag = PowerModel.Instance.IsPowerEnough(new int?(powerNum));
			UUIText text = base.GetText(4);
			UUIItem uuiitem = text;
			bool bUseChangeColor = !flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0602EA24 RID: 191012 RVA: 0x00D04CAB File Offset: 0x00D02EAB
		public void SetIsEnable(bool isEnable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(isEnable);
		}

		// Token: 0x04018CDA RID: 101594
		[Nullable(2)]
		private IPowerRewardButtonItemData Data;

		// Token: 0x0200A502 RID: 42242
		private enum EComponent
		{
			// Token: 0x040331A6 RID: 209318
			RewardButton,
			// Token: 0x040331A7 RID: 209319
			RewardText,
			// Token: 0x040331A8 RID: 209320
			RedDotItem,
			// Token: 0x040331A9 RID: 209321
			PowerTexture,
			// Token: 0x040331AA RID: 209322
			PowerNumText
		}
	}
}
