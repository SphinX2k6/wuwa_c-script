using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059C0 RID: 22976
	public class SolarSchoolMapCelebrateItem : UiPanelBase
	{
		// Token: 0x06038A0E RID: 231950 RVA: 0x00FD8738 File Offset: 0x00FD6938
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

		// Token: 0x06038A0F RID: 231951 RVA: 0x00FD8780 File Offset: 0x00FD6980
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038A10 RID: 231952 RVA: 0x00FD8793 File Offset: 0x00FD6993
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06038A11 RID: 231953 RVA: 0x00FD87B0 File Offset: 0x00FD69B0
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

		// Token: 0x06038A12 RID: 231954 RVA: 0x00FD87EC File Offset: 0x00FD69EC
		[NullableContext(1)]
		public void SetFestivalText(string txtId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), txtId, Array.Empty<object>());
		}

		// Token: 0x0401DD23 RID: 122147
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B56C RID: 46444
		private class EComponents
		{
			// Token: 0x04038184 RID: 229764
			public const int TxtContent = 0;
		}
	}
}
