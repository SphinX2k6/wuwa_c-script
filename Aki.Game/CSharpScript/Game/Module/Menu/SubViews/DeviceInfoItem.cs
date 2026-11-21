using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x020043FA RID: 17402
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeviceInfoItem : GridProxyAbstract<DeviceInfoItemData>
	{
		// Token: 0x0602BF8F RID: 180111 RVA: 0x00C58AA8 File Offset: 0x00C56CA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602BF90 RID: 180112 RVA: 0x00C58B02 File Offset: 0x00C56D02
		public override void Refresh(DeviceInfoItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.UpdateDisplay();
		}

		// Token: 0x0602BF91 RID: 180113 RVA: 0x00C58B14 File Offset: 0x00C56D14
		private void UpdateDisplay()
		{
			if (this.Data == null || string.IsNullOrEmpty(this.Data.Name) || this.Data.GetInfoFunction == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.Name, Array.Empty<object>());
			ValueTuple<string, bool> valueTuple = this.Data.GetInfoFunction();
			string item = valueTuple.Item1;
			bool item2 = valueTuple.Item2;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(item, true);
			}
			if (!string.IsNullOrEmpty(this.Data.LowText))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.Data.LowText, Array.Empty<object>());
			}
			UUIText text2 = base.GetText(2);
			if (text2 != null)
			{
				text2.SetUIActive(item2);
			}
		}

		// Token: 0x04017AF7 RID: 97015
		[Nullable(2)]
		private DeviceInfoItemData Data;
	}
}
