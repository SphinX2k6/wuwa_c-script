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
	// Token: 0x020053BF RID: 21439
	public class MoraleUnbreakableLvInfoItem : UiPanelBase
	{
		// Token: 0x06036C6F RID: 224367 RVA: 0x00CF6EF4 File Offset: 0x00CF50F4
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

		// Token: 0x06036C70 RID: 224368 RVA: 0x00CF6F3F File Offset: 0x00CF513F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06036C71 RID: 224369 RVA: 0x00CF6F78 File Offset: 0x00CF5178
		protected override void OnStart()
		{
			this.UpdateData();
		}

		// Token: 0x06036C72 RID: 224370 RVA: 0x00CF6F80 File Offset: 0x00CF5180
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

		// Token: 0x0200B669 RID: 46697
		private class EChildType
		{
			// Token: 0x04037433 RID: 226355
			public const int ArtTextUnbreakableLv = 0;

			// Token: 0x04037434 RID: 226356
			public const int TxtTitle = 1;
		}
	}
}
