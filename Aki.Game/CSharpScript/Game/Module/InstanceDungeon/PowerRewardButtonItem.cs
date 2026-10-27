using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200588C RID: 22668
	public class PowerRewardButtonItem : UiPanelBase
	{
		// Token: 0x06039AFB RID: 236283 RVA: 0x00DB5B78 File Offset: 0x00DB3D78
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

		// Token: 0x06039AFC RID: 236284 RVA: 0x00DB5C81 File Offset: 0x00DB3E81
		private void OnRewardButtonClick()
		{
			IPowerRewardButtonItemData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.RewardCallBack();
		}

		// Token: 0x06039AFD RID: 236285 RVA: 0x00DB5C98 File Offset: 0x00DB3E98
		protected override void OnStart()
		{
			base.SetItemIcon(base.GetTexture(3), 5, null, null);
		}

		// Token: 0x06039AFE RID: 236286 RVA: 0x00DB5CBD File Offset: 0x00DB3EBD
		[NullableContext(1)]
		public void Update(IPowerRewardButtonItemData data)
		{
			this.Data = data;
			this.Refresh();
		}

		// Token: 0x06039AFF RID: 236287 RVA: 0x00DB5CCC File Offset: 0x00DB3ECC
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

		// Token: 0x06039B00 RID: 236288 RVA: 0x00DB5D40 File Offset: 0x00DB3F40
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

		// Token: 0x06039B01 RID: 236289 RVA: 0x00DB5D93 File Offset: 0x00DB3F93
		public void SetIsEnable(bool isEnable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(isEnable);
		}

		// Token: 0x0401E23D RID: 123453
		[Nullable(2)]
		private IPowerRewardButtonItemData Data;

		// Token: 0x0200BAE9 RID: 47849
		private enum EComponent
		{
			// Token: 0x040387A5 RID: 231333
			RewardButton,
			// Token: 0x040387A6 RID: 231334
			RewardText,
			// Token: 0x040387A7 RID: 231335
			RedDotItem,
			// Token: 0x040387A8 RID: 231336
			PowerTexture,
			// Token: 0x040387A9 RID: 231337
			PowerNumText
		}
	}
}
