using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006308 RID: 25352
	public class PinballRoleBdItem : UiPanelBase
	{
		// Token: 0x0603FCAE RID: 261294 RVA: 0x00F6F7BC File Offset: 0x00F6D9BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FCAF RID: 261295 RVA: 0x00F6F825 File Offset: 0x00F6DA25
		public void RefreshByBdId(int bdId)
		{
			this.BdId = bdId;
			this.Refresh();
		}

		// Token: 0x0603FCB0 RID: 261296 RVA: 0x00F6F834 File Offset: 0x00F6DA34
		private void Refresh()
		{
			PinballBdConfig? pinballRoleBdConfigById = PinballConfig.Instance.GetPinballRoleBdConfigById(this.BdId);
			if (pinballRoleBdConfigById == null)
			{
				return;
			}
			base.GetSprite(0).SetColor(FColor.FromHex(pinballRoleBdConfigById.Value.BgColor));
			base.SetTextureByPath(pinballRoleBdConfigById.Value.Icon, base.GetTexture(1), null, null);
		}

		// Token: 0x040214B7 RID: 136375
		private int BdId;

		// Token: 0x0200C501 RID: 50433
		private enum EComponent
		{
			// Token: 0x0403B750 RID: 243536
			BgSprite,
			// Token: 0x0403B751 RID: 243537
			IconTexture
		}
	}
}
