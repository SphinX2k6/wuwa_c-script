using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Field
{
	// Token: 0x02004231 RID: 16945
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaFieldEffectItem : UiPanelBase
	{
		// Token: 0x0602AD97 RID: 175511 RVA: 0x00C0F5B4 File Offset: 0x00C0D7B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602AD98 RID: 175512 RVA: 0x00C0F5D7 File Offset: 0x00C0D7D7
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0602AD99 RID: 175513 RVA: 0x00C0F601 File Offset: 0x00C0D801
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602AD9A RID: 175514 RVA: 0x00C0F60E File Offset: 0x00C0D80E
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602AD9B RID: 175515 RVA: 0x00C0F624 File Offset: 0x00C0D824
		public void SetName(string name)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), name, Array.Empty<object>());
		}

		// Token: 0x0602AD9C RID: 175516 RVA: 0x00C0F63D File Offset: 0x00C0D83D
		public void PlayStart()
		{
			this.SetActive(true);
			this.Sequence.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x0401732A RID: 95018
		protected UiSequencePlayer Sequence;

		// Token: 0x02009E79 RID: 40569
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031429 RID: 201769
			public const int Name = 0;
		}
	}
}
