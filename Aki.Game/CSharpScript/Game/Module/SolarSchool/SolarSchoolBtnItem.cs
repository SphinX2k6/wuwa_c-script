using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005990 RID: 22928
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolBtnItem : UiPanelBase
	{
		// Token: 0x06038881 RID: 231553 RVA: 0x00FD13AC File Offset: 0x00FCF5AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038882 RID: 231554 RVA: 0x00FD1473 File Offset: 0x00FCF673
		public void SetClickCallback(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06038883 RID: 231555 RVA: 0x00FD147C File Offset: 0x00FCF67C
		public void SetEnable(bool enable)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(enable);
		}

		// Token: 0x06038884 RID: 231556 RVA: 0x00FD1490 File Offset: 0x00FCF690
		public void SetTextByTextId(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x06038885 RID: 231557 RVA: 0x00FD14A9 File Offset: 0x00FCF6A9
		public void SetRedDotVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x06038886 RID: 231558 RVA: 0x00FD14C0 File Offset: 0x00FCF6C0
		public void PlaySequenceByName(string sequenceName)
		{
			if (this.SequencePlayer == null)
			{
				this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			}
			this.SequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x06038887 RID: 231559 RVA: 0x00FD14FD File Offset: 0x00FCF6FD
		private void OnBtnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x06038888 RID: 231560 RVA: 0x00FD150F File Offset: 0x00FCF70F
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06038889 RID: 231561 RVA: 0x00FD1523 File Offset: 0x00FCF723
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.ClickCallback = null;
		}

		// Token: 0x0401DC7C RID: 121980
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x0401DC7D RID: 121981
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B535 RID: 46389
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403806F RID: 229487
			public const int Btn = 0;

			// Token: 0x04038070 RID: 229488
			public const int Text = 1;

			// Token: 0x04038071 RID: 229489
			public const int RedDot = 2;
		}
	}
}
