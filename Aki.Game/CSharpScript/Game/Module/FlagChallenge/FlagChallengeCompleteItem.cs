using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A79 RID: 23161
	public class FlagChallengeCompleteItem : UiPanelBase
	{
		// Token: 0x0603AAD2 RID: 240338 RVA: 0x00DF9605 File Offset: 0x00DF7805
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0603AAD3 RID: 240339 RVA: 0x00DF963E File Offset: 0x00DF783E
		[NullableContext(1)]
		public void SetText(string key)
		{
			base.GetText(1).ShowTextNew(key);
		}
	}
}
