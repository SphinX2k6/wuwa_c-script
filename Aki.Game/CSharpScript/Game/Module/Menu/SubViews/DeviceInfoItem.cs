using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02005417 RID: 21527
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeviceInfoItem : GridProxyAbstract<DeviceInfoItemData>
	{
		// Token: 0x06037046 RID: 225350 RVA: 0x00D09680 File Offset: 0x00D07880
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06037047 RID: 225351 RVA: 0x00D096DA File Offset: 0x00D078DA
		public override void Refresh(DeviceInfoItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.UpdateDisplay();
		}

		// Token: 0x06037048 RID: 225352 RVA: 0x00D096EC File Offset: 0x00D078EC
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

		// Token: 0x0401D05E RID: 118878
		[Nullable(2)]
		private DeviceInfoItemData Data;
	}
}
