using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A53 RID: 19027
	public class FlagChallengeLockItem : UiPanelBase
	{
		// Token: 0x0602FA18 RID: 195096 RVA: 0x00D49B28 File Offset: 0x00D47D28
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
			};
		}

		// Token: 0x0602FA19 RID: 195097 RVA: 0x00D49B82 File Offset: 0x00D47D82
		[NullableContext(1)]
		public void SetText(string key)
		{
			base.GetText(1).ShowTextNew(key);
		}
	}
}
