using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005204 RID: 20996
	public class CardDetailActiveSkillItem : UiPanelBase
	{
		// Token: 0x06035B7D RID: 220029 RVA: 0x00CB80D1 File Offset: 0x00CB62D1
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035B7E RID: 220030 RVA: 0x00CB80F4 File Offset: 0x00CB62F4
		[NullableContext(1)]
		public void Refresh(ICardDetailActiveSkillData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.Params.ToArray());
		}

		// Token: 0x0200B3AB RID: 45995
		private static class EComponentDefine
		{
			// Token: 0x0403674C RID: 223052
			public const int DescText = 0;
		}
	}
}
