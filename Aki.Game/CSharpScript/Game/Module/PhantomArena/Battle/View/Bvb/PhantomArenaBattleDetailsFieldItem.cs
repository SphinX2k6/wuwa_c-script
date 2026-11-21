using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x0200423F RID: 16959
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsFieldItem : UiPanelBase
	{
		// Token: 0x0602AE5D RID: 175709 RVA: 0x00C11A30 File Offset: 0x00C0FC30
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClick))
			};
		}

		// Token: 0x0602AE5E RID: 175710 RVA: 0x00C11A97 File Offset: 0x00C0FC97
		private void OnClick()
		{
		}

		// Token: 0x0602AE5F RID: 175711 RVA: 0x00C11A99 File Offset: 0x00C0FC99
		public void Refresh(PhantomArenaFieldData fieldData)
		{
		}

		// Token: 0x0602AE60 RID: 175712 RVA: 0x00C11A9B File Offset: 0x00C0FC9B
		public void RegisterProxy(PhantomArenaBattleDetailsViewProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0401735D RID: 95069
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x02009E97 RID: 40599
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040314B7 RID: 201911
			public const int Icon = 0;

			// Token: 0x040314B8 RID: 201912
			public const int Button = 1;
		}
	}
}
