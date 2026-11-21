using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x0200423D RID: 16957
	public class PhantomArenaBattleDamageView : UiViewBase
	{
		// Token: 0x0602AE43 RID: 175683 RVA: 0x00C1139A File Offset: 0x00C0F59A
		[NullableContext(1)]
		public PhantomArenaBattleDamageView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602AE44 RID: 175684 RVA: 0x00C113A4 File Offset: 0x00C0F5A4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIArtText))
			};
		}

		// Token: 0x0602AE45 RID: 175685 RVA: 0x00C11400 File Offset: 0x00C0F600
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

		// Token: 0x02009E8F RID: 40591
		private class EComponentDefine
		{
			// Token: 0x04031494 RID: 201876
			public const int ArtText1 = 0;

			// Token: 0x04031495 RID: 201877
			public const int ArtText2 = 1;

			// Token: 0x04031496 RID: 201878
			public const int ArtText3 = 2;
		}
	}
}
