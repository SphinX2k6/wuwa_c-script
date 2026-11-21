using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041D4 RID: 16852
	public class CardDetailActiveSkillItem : UiPanelBase
	{
		// Token: 0x0602AA78 RID: 174712 RVA: 0x00C0570D File Offset: 0x00C0390D
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602AA79 RID: 174713 RVA: 0x00C05730 File Offset: 0x00C03930
		[NullableContext(1)]
		public void Refresh(ICardDetailActiveSkillData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, data.Params.ToArray());
		}

		// Token: 0x02009DE3 RID: 40419
		private static class EComponentDefine
		{
			// Token: 0x0403119F RID: 201119
			public const int DescText = 0;
		}
	}
}
