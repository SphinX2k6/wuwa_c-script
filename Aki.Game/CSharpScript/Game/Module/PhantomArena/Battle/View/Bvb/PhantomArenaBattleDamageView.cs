using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x0200526D RID: 21101
	public class PhantomArenaBattleDamageView : UiViewBase
	{
		// Token: 0x06035F48 RID: 221000 RVA: 0x00CC3C9A File Offset: 0x00CC1E9A
		[NullableContext(1)]
		public PhantomArenaBattleDamageView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035F49 RID: 221001 RVA: 0x00CC3CA4 File Offset: 0x00CC1EA4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText))
			};
		}

		// Token: 0x06035F4A RID: 221002 RVA: 0x00CC3D00 File Offset: 0x00CC1F00
		protected override void OnStart()
		{
			int? num = this.OpenParam as int?;
			if (num != null)
			{
				UUIArtText artText = base.GetArtText(0);
				if (artText != null)
				{
					artText.SetText(num.Value.ToString());
				}
				UUIArtText artText2 = base.GetArtText(1);
				if (artText2 != null)
				{
					artText2.SetText(num.Value.ToString());
				}
				UUIArtText artText3 = base.GetArtText(2);
				if (artText3 == null)
				{
					return;
				}
				artText3.SetText(num.Value.ToString());
			}
		}

		// Token: 0x0200B457 RID: 46167
		private class EComponentDefine
		{
			// Token: 0x04036A41 RID: 223809
			public const int ArtText1 = 0;

			// Token: 0x04036A42 RID: 223810
			public const int ArtText2 = 1;

			// Token: 0x04036A43 RID: 223811
			public const int ArtText3 = 2;
		}
	}
}
