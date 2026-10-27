using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A77 RID: 23159
	public class FlagChallengeLockItem : UiPanelBase
	{
		// Token: 0x0603AACF RID: 240335 RVA: 0x00DF9594 File Offset: 0x00DF7794
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x0603AAD0 RID: 240336 RVA: 0x00DF95EE File Offset: 0x00DF77EE
		[NullableContext(1)]
		public void SetText(string key)
		{
			base.GetText(1).ShowTextNew(key);
		}
	}
}
