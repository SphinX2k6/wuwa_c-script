using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x0200526F RID: 21103
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsFieldItem : UiPanelBase
	{
		// Token: 0x06035F62 RID: 221026 RVA: 0x00CC4330 File Offset: 0x00CC2530
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

		// Token: 0x06035F63 RID: 221027 RVA: 0x00CC4397 File Offset: 0x00CC2597
		private void OnClick()
		{
		}

		// Token: 0x06035F64 RID: 221028 RVA: 0x00CC4399 File Offset: 0x00CC2599
		public void Refresh(PhantomArenaFieldData fieldData)
		{
		}

		// Token: 0x06035F65 RID: 221029 RVA: 0x00CC439B File Offset: 0x00CC259B
		public void RegisterProxy(PhantomArenaBattleDetailsViewProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0401C928 RID: 117032
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x0200B45F RID: 46175
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036A64 RID: 223844
			public const int Icon = 0;

			// Token: 0x04036A65 RID: 223845
			public const int Button = 1;
		}
	}
}
