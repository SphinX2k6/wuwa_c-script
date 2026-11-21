using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020043A2 RID: 17314
	public class MoraleUnbreakableLvInfoItem : UiPanelBase
	{
		// Token: 0x0602BBB5 RID: 179125 RVA: 0x00C45F9C File Offset: 0x00C4419C
		[NullableContext(1)]
		public UniTask Init(UUIItem item)
		{
			MoraleUnbreakableLvInfoItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleUnbreakableLvInfoItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BBB6 RID: 179126 RVA: 0x00C45FE7 File Offset: 0x00C441E7
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602BBB7 RID: 179127 RVA: 0x00C46020 File Offset: 0x00C44220
		protected override void OnStart()
		{
			this.UpdateData();
		}

		// Token: 0x0602BBB8 RID: 179128 RVA: 0x00C46028 File Offset: 0x00C44228
		public void UpdateData()
		{
			base.GetArtText(0).SetText(MoraleBattleModel.Instance.GetMoraleIndomitableLevel().ToString());
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("Morale_title_3");
		}

		// Token: 0x0200A0A1 RID: 41121
		private class EChildType
		{
			// Token: 0x04031E88 RID: 204424
			public const int ArtTextUnbreakableLv = 0;

			// Token: 0x04031E89 RID: 204425
			public const int TxtTitle = 1;
		}
	}
}
