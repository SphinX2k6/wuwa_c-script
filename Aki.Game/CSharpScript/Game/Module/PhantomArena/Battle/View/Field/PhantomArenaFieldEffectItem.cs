using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Field
{
	// Token: 0x02005261 RID: 21089
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldEffectItem : UiPanelBase
	{
		// Token: 0x06035E9C RID: 220828 RVA: 0x00CC1F24 File Offset: 0x00CC0124
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x06035E9D RID: 220829 RVA: 0x00CC1F47 File Offset: 0x00CC0147
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06035E9E RID: 220830 RVA: 0x00CC1F71 File Offset: 0x00CC0171
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035E9F RID: 220831 RVA: 0x00CC1F7E File Offset: 0x00CC017E
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035EA0 RID: 220832 RVA: 0x00CC1F94 File Offset: 0x00CC0194
		public void SetName(string name)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), name, Array.Empty<object>());
		}

		// Token: 0x06035EA1 RID: 220833 RVA: 0x00CC1FAD File Offset: 0x00CC01AD
		public void PlayStart()
		{
			this.SetActive(true);
			this.Sequence.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x0401C8F5 RID: 116981
		protected UiSequencePlayer Sequence;

		// Token: 0x0200B441 RID: 46145
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040369D6 RID: 223702
			public const int Name = 0;
		}
	}
}
