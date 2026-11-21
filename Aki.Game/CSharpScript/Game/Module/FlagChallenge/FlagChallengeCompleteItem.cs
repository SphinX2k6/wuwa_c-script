using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A55 RID: 19029
	public class FlagChallengeCompleteItem : UiPanelBase
	{
		// Token: 0x0602FA1B RID: 195099 RVA: 0x00D49B99 File Offset: 0x00D47D99
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602FA1C RID: 195100 RVA: 0x00D49BD2 File Offset: 0x00D47DD2
		[NullableContext(1)]
		public void SetText(string key)
		{
			base.GetText(1).ShowTextNew(key);
		}
	}
}
