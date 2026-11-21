using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041F8 RID: 16888
	public class CardDetailTaskDescItem : UiPanelBase
	{
		// Token: 0x0602AB33 RID: 174899 RVA: 0x00C06C51 File Offset: 0x00C04E51
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602AB34 RID: 174900 RVA: 0x00C06C74 File Offset: 0x00C04E74
		[NullableContext(1)]
		public void Refresh(ICardDetailTaskData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Desc, new <>z__ReadOnlySingleElementList<object>(data.CurrentProgress));
		}

		// Token: 0x02009DF3 RID: 40435
		private static class EDescItemComponents
		{
			// Token: 0x040311E4 RID: 201188
			public const int DescText = 0;
		}
	}
}
