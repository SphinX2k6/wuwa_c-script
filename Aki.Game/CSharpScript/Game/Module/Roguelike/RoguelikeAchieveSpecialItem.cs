using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D7B RID: 15739
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchieveSpecialItem : GridProxyAbstract<IRoguelikeAchieveTokenItemData>
	{
		// Token: 0x06028412 RID: 164882 RVA: 0x00B46988 File Offset: 0x00B44B88
		[NullableContext(1)]
		public override void Refresh(IRoguelikeAchieveTokenItemData data, bool isSelected, int gridIndex)
		{
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RougeMiraclecreation? rougeMiraclecreation = (instance != null) ? instance.GetRoguelikeSpecialConfig(data.GainEntry.ConfigId) : null;
			if (rougeMiraclecreation == null)
			{
				base.GetTexture(0).SetUIActive(false);
				base.GetTexture(1).SetUIActive(false);
				return;
			}
			base.SetTextureByPath(rougeMiraclecreation.Value.Icon, base.GetTexture(1), null, null);
			RougeMiraclecreationColor? roguelikeMiraclecreationColorConfig = RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(rougeMiraclecreation.Value.ColorType);
			if (roguelikeMiraclecreationColorConfig != null && !string.IsNullOrEmpty(roguelikeMiraclecreationColorConfig.Value.SmallBg))
			{
				base.SetTextureByPath(roguelikeMiraclecreationColorConfig.Value.SmallBg, base.GetTexture(0), null, null);
			}
			base.GetTexture(0).SetUIActive(true);
			base.GetTexture(1).SetUIActive(true);
		}

		// Token: 0x06028413 RID: 164883 RVA: 0x00B46A84 File Offset: 0x00B44C84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028414 RID: 164884 RVA: 0x00B46AED File Offset: 0x00B44CED
		protected override void OnStart()
		{
			base.GetTexture(0).SetUIActive(true);
			base.GetTexture(1).SetUIActive(false);
		}

		// Token: 0x0200995E RID: 39262
		private class EComponents
		{
			// Token: 0x0402FD45 RID: 195909
			public const int TexBg = 0;

			// Token: 0x0402FD46 RID: 195910
			public const int TexIcon = 1;
		}
	}
}
