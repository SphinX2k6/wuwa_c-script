using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006825 RID: 26661
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackBag : DangoBrawlOutBackpackItemBase
	{
		// Token: 0x17009740 RID: 38720
		// (get) Token: 0x06042885 RID: 272517 RVA: 0x0102B0F1 File Offset: 0x010292F1
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(11);
			}
		}

		// Token: 0x17009741 RID: 38721
		// (get) Token: 0x06042886 RID: 272518 RVA: 0x0102B0FB File Offset: 0x010292FB
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(10);
			}
		}

		// Token: 0x06042887 RID: 272519 RVA: 0x0102B105 File Offset: 0x01029305
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUITexture)));
		}

		// Token: 0x06042888 RID: 272520 RVA: 0x0102B145 File Offset: 0x01029345
		[NullableContext(1)]
		protected override void CollectIconTextures(List<UUITexture> textures)
		{
			base.CollectIconTextures(textures);
			if (this.SprIconMask02 != null)
			{
				textures.Add(this.SprIconMask02);
			}
			if (this.SprIconMask03 != null)
			{
				textures.Add(this.SprIconMask03);
			}
		}

		// Token: 0x0200C9C6 RID: 51654
		[NullableContext(0)]
		private enum EBagComponents
		{
			// Token: 0x0403CF52 RID: 249682
			SprIconMask03 = 10,
			// Token: 0x0403CF53 RID: 249683
			SprIconMask02
		}
	}
}
