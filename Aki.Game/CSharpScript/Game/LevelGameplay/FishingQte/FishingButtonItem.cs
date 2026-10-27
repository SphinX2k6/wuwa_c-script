using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E3B RID: 28219
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingButtonItem : UiPanelBase
	{
		// Token: 0x06044CC0 RID: 281792 RVA: 0x010FA068 File Offset: 0x010F8268
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06044CC1 RID: 281793 RVA: 0x010FA192 File Offset: 0x010F8392
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x06044CC2 RID: 281794 RVA: 0x010FA1B2 File Offset: 0x010F83B2
		public void OnTick(float delta)
		{
			if (this.TotalCdTime <= 0f)
			{
				return;
			}
			this.CurrentCdTime += delta;
			this.RefreshCdPanel();
			if (this.CurrentCdTime >= this.TotalCdTime)
			{
				this.SetForbiddenEnd();
			}
		}

		// Token: 0x06044CC3 RID: 281795 RVA: 0x010FA1EA File Offset: 0x010F83EA
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x06044CC4 RID: 281796 RVA: 0x010FA1F3 File Offset: 0x010F83F3
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06044CC5 RID: 281797 RVA: 0x010FA205 File Offset: 0x010F8405
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x06044CC6 RID: 281798 RVA: 0x010FA219 File Offset: 0x010F8419
		public bool IsButtonEnable()
		{
			return base.GetButton(0).GetEnable();
		}

		// Token: 0x06044CC7 RID: 281799 RVA: 0x010FA227 File Offset: 0x010F8427
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06044CC8 RID: 281800 RVA: 0x010FA230 File Offset: 0x010F8430
		public void SetPauseWithoutAnim(bool bPause)
		{
			base.GetSprite(1).SetUIActive(!bPause);
			base.GetSprite(2).SetUIActive(bPause);
		}

		// Token: 0x06044CC9 RID: 281801 RVA: 0x010FA250 File Offset: 0x010F8450
		public void SetPause(bool bPause)
		{
			string sequenceName = bPause ? "BtnChange" : "BtnChangeBack";
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x06044CCA RID: 281802 RVA: 0x010FA294 File Offset: 0x010F8494
		private void RefreshCdPanel()
		{
			float fillAmount = (this.TotalCdTime - this.CurrentCdTime) / this.TotalCdTime;
			float num = (this.TotalCdTime - this.CurrentCdTime) / (float)TimeUtil.Instance.InverseMillisecond;
			base.GetSprite(4).SetFillAmount(fillAmount);
			base.GetText(5).SetText(num.ToString("F" + 1.ToString()) ?? "", true);
		}

		// Token: 0x06044CCB RID: 281803 RVA: 0x010FA30D File Offset: 0x010F850D
		public void SetForbiddenStart(float forbiddenTime)
		{
			if (forbiddenTime <= 0f)
			{
				return;
			}
			this.SetEnableClick(false);
			this.CurrentCdTime = 0f;
			this.TotalCdTime = forbiddenTime;
			this.RefreshCdPanel();
			base.GetItem(3).SetUIActive(true);
		}

		// Token: 0x06044CCC RID: 281804 RVA: 0x010FA344 File Offset: 0x010F8544
		private void SetForbiddenEnd()
		{
			this.SetEnableClick(true);
			this.TotalCdTime = 0f;
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x04023CAF RID: 146607
		private const int FIXED_DIGITS = 1;

		// Token: 0x04023CB0 RID: 146608
		private const string ANIM_BUTTON_PAUSE = "BtnChange";

		// Token: 0x04023CB1 RID: 146609
		private const string ANIM_BUTTON_START = "BtnChangeBack";

		// Token: 0x04023CB2 RID: 146610
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04023CB3 RID: 146611
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x04023CB4 RID: 146612
		protected float CurrentCdTime;

		// Token: 0x04023CB5 RID: 146613
		protected float TotalCdTime;

		// Token: 0x0200CCED RID: 52461
		[NullableContext(0)]
		private class EButtonItemDefine
		{
			// Token: 0x0403DCC7 RID: 253127
			public const int Button = 0;

			// Token: 0x0403DCC8 RID: 253128
			public const int SpriteGoing = 1;

			// Token: 0x0403DCC9 RID: 253129
			public const int SpriteStop = 2;

			// Token: 0x0403DCCA RID: 253130
			public const int PanelPause = 3;

			// Token: 0x0403DCCB RID: 253131
			public const int ProgressPause = 4;

			// Token: 0x0403DCCC RID: 253132
			public const int TxtPause = 5;
		}
	}
}
