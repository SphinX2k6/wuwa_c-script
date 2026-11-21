using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005775 RID: 22389
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackBag : DangoBrawlOutBackpackItemBase
	{
		// Token: 0x17006A81 RID: 27265
		// (get) Token: 0x060373D9 RID: 226265 RVA: 0x00F6C62D File Offset: 0x00F6A82D
		private UUITexture SprIconMask02
		{
			get
			{
				return base.GetTexture(11);
			}
		}

		// Token: 0x17006A82 RID: 27266
		// (get) Token: 0x060373DA RID: 226266 RVA: 0x00F6C637 File Offset: 0x00F6A837
		private UUITexture SprIconMask03
		{
			get
			{
				return base.GetTexture(10);
			}
		}

		// Token: 0x060373DB RID: 226267 RVA: 0x00F6C641 File Offset: 0x00F6A841
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(10, typeof(UUITexture)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(11, typeof(UUITexture)));
		}

		// Token: 0x060373DC RID: 226268 RVA: 0x00F6C681 File Offset: 0x00F6A881
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

		// Token: 0x0200B392 RID: 45970
		[NullableContext(0)]
		private enum EBagComponents
		{
			// Token: 0x0403783C RID: 227388
			SprIconMask03 = 10,
			// Token: 0x0403783D RID: 227389
			SprIconMask02
		}
	}
}
