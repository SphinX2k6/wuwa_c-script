using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02005286 RID: 21126
	public class PinballRoleBdItem : UiPanelBase
	{
		// Token: 0x0603496F RID: 215407 RVA: 0x00EB6718 File Offset: 0x00EB4918
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

		// Token: 0x06034970 RID: 215408 RVA: 0x00EB6781 File Offset: 0x00EB4981
		public void RefreshByBdId(int bdId)
		{
			this.BdId = bdId;
			this.Refresh();
		}

		// Token: 0x06034971 RID: 215409 RVA: 0x00EB6790 File Offset: 0x00EB4990
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

		// Token: 0x0401BDE6 RID: 114150
		private int BdId;

		// Token: 0x0200AEE8 RID: 44776
		private enum EComponent
		{
			// Token: 0x040360B2 RID: 221362
			BgSprite,
			// Token: 0x040360B3 RID: 221363
			IconTexture
		}
	}
}
