using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050F9 RID: 20729
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeRoleSelectTitlePanel : UiPanelBase
	{
		// Token: 0x06033DF4 RID: 212468 RVA: 0x00E84E6C File Offset: 0x00E8306C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033DF5 RID: 212469 RVA: 0x00E84F5C File Offset: 0x00E8315C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeRoleSelectTitlePanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeRoleSelectTitlePanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033DF6 RID: 212470 RVA: 0x00E84F9F File Offset: 0x00E8319F
		protected override void OnBeforeDestroy()
		{
			this.LightTagPanel = null;
			this.DarkTagPanel = null;
		}

		// Token: 0x06033DF7 RID: 212471 RVA: 0x00E84FB0 File Offset: 0x00E831B0
		public void RefreshElement(bool isLight, RoverRogueRoleType? cfg)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(isLight);
			}
			UUISprite sprite2 = base.GetSprite(2);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(!isLight);
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				if (!string.IsNullOrEmpty((cfg != null) ? cfg.GetValueOrDefault().Element : null))
				{
					LguiUtil.Instance.SetLocalTextNew(text, cfg.Value.Element, Array.Empty<object>());
				}
				else
				{
					text.SetText("", true);
				}
				if (cfg.Value.Id == 1)
				{
					text.useChangeColor = false;
				}
				else
				{
					text.useChangeColor = true;
				}
			}
			RoverlikeRoleEelmentTagPanel panel = isLight ? this.LightTagPanel : this.DarkTagPanel;
			RoverlikeRoleEelmentTagPanel panel2 = isLight ? this.DarkTagPanel : this.LightTagPanel;
			this.RefreshTagPanel(panel, cfg, 0);
			this.RefreshTagPanel(panel2, cfg, 1);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(isLight);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!isLight);
		}

		// Token: 0x06033DF8 RID: 212472 RVA: 0x00E850C0 File Offset: 0x00E832C0
		private void RefreshTagPanel(RoverlikeRoleEelmentTagPanel panel, RoverRogueRoleType? cfg, int tagIndex)
		{
			if (panel == null)
			{
				return;
			}
			if (cfg != null && cfg.Value.TagLength > tagIndex)
			{
				DicStringString? dicStringString = cfg.Value.Tag(tagIndex);
				panel.SetActive(true);
				panel.Refresh((dicStringString != null) ? dicStringString.GetValueOrDefault().Key : null, (dicStringString != null) ? dicStringString.GetValueOrDefault().Value : null);
				return;
			}
			panel.SetActive(false);
		}

		// Token: 0x0401B770 RID: 112496
		private RoverlikeRoleEelmentTagPanel LightTagPanel;

		// Token: 0x0401B771 RID: 112497
		private RoverlikeRoleEelmentTagPanel DarkTagPanel;

		// Token: 0x0200ADCC RID: 44492
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035B29 RID: 219945
			public const int TxtElementName = 0;

			// Token: 0x04035B2A RID: 219946
			public const int SprElementLight = 1;

			// Token: 0x04035B2B RID: 219947
			public const int SprElementDark = 2;

			// Token: 0x04035B2C RID: 219948
			public const int PnlTypeLight = 3;

			// Token: 0x04035B2D RID: 219949
			public const int PnlTypeDark = 4;

			// Token: 0x04035B2E RID: 219950
			public const int TxtType = 5;
		}
	}
}
