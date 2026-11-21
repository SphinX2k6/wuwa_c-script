using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005998 RID: 22936
	public class SolarSchoolFestivalTips : UiPanelBase
	{
		// Token: 0x060388EE RID: 231662 RVA: 0x00FD30B8 File Offset: 0x00FD12B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060388EF RID: 231663 RVA: 0x00FD3100 File Offset: 0x00FD1300
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060388F0 RID: 231664 RVA: 0x00FD3113 File Offset: 0x00FD1313
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x060388F1 RID: 231665 RVA: 0x00FD3130 File Offset: 0x00FD1330
		public void PlayShow()
		{
			if (base.GetActive())
			{
				return;
			}
			base.SetUiActive(true);
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x060388F2 RID: 231666 RVA: 0x00FD316C File Offset: 0x00FD136C
		[NullableContext(1)]
		public void SetTipsText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, Array.Empty<object>());
		}

		// Token: 0x0401DC9B RID: 122011
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B541 RID: 46401
		private class EComponents
		{
			// Token: 0x040380AF RID: 229551
			public const int TxtTips = 0;
		}
	}
}
