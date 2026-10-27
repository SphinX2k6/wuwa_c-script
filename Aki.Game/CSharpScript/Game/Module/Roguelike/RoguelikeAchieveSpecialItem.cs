using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DB2 RID: 19890
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeAchieveSpecialItem : GridProxyAbstract<IRoguelikeAchieveTokenItemData>
	{
		// Token: 0x060335A5 RID: 210341 RVA: 0x00BFD458 File Offset: 0x00BFB658
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

		// Token: 0x060335A6 RID: 210342 RVA: 0x00BFD554 File Offset: 0x00BFB754
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

		// Token: 0x060335A7 RID: 210343 RVA: 0x00BFD5BD File Offset: 0x00BFB7BD
		protected override void OnStart()
		{
			base.GetTexture(0).SetUIActive(true);
			base.GetTexture(1).SetUIActive(false);
		}

		// Token: 0x0200AF29 RID: 44841
		private class EComponents
		{
			// Token: 0x04035310 RID: 217872
			public const int TexBg = 0;

			// Token: 0x04035311 RID: 217873
			public const int TexIcon = 1;
		}
	}
}
