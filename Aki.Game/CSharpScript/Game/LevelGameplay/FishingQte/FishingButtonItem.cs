using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FBC RID: 24508
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingButtonItem : UiPanelBase
	{
		// Token: 0x0603AE4D RID: 241229 RVA: 0x010A45E8 File Offset: 0x010A27E8
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

		// Token: 0x0603AE4E RID: 241230 RVA: 0x010A4712 File Offset: 0x010A2912
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x0603AE4F RID: 241231 RVA: 0x010A4732 File Offset: 0x010A2932
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

		// Token: 0x0603AE50 RID: 241232 RVA: 0x010A476A File Offset: 0x010A296A
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x0603AE51 RID: 241233 RVA: 0x010A4773 File Offset: 0x010A2973
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x0603AE52 RID: 241234 RVA: 0x010A4785 File Offset: 0x010A2985
		public void SetEnableClick(bool state)
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(state);
		}

		// Token: 0x0603AE53 RID: 241235 RVA: 0x010A4799 File Offset: 0x010A2999
		public bool IsButtonEnable()
		{
			return base.GetButton(0).GetEnable();
		}

		// Token: 0x0603AE54 RID: 241236 RVA: 0x010A47A7 File Offset: 0x010A29A7
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x0603AE55 RID: 241237 RVA: 0x010A47B0 File Offset: 0x010A29B0
		public void SetPauseWithoutAnim(bool bPause)
		{
			base.GetSprite(1).SetUIActive(!bPause);
			base.GetSprite(2).SetUIActive(bPause);
		}

		// Token: 0x0603AE56 RID: 241238 RVA: 0x010A47D0 File Offset: 0x010A29D0
		public void SetPause(bool bPause)
		{
			string sequenceName = bPause ? "BtnChange" : "BtnChangeBack";
			this.LevelSequencePlayer.StopPlayingSequence(false, true);
			this.LevelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0603AE57 RID: 241239 RVA: 0x010A4814 File Offset: 0x010A2A14
		private void RefreshCdPanel()
		{
			float fillAmount = (this.TotalCdTime - this.CurrentCdTime) / this.TotalCdTime;
			float num = (this.TotalCdTime - this.CurrentCdTime) / (float)TimeUtil.Instance.InverseMillisecond;
			base.GetSprite(4).SetFillAmount(fillAmount);
			base.GetText(5).SetText(num.ToString("F" + 1.ToString()) ?? "", true);
		}

		// Token: 0x0603AE58 RID: 241240 RVA: 0x010A488D File Offset: 0x010A2A8D
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

		// Token: 0x0603AE59 RID: 241241 RVA: 0x010A48C4 File Offset: 0x010A2AC4
		private void SetForbiddenEnd()
		{
			this.SetEnableClick(true);
			this.TotalCdTime = 0f;
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x0401EF64 RID: 126820
		private const int FIXED_DIGITS = 1;

		// Token: 0x0401EF65 RID: 126821
		private const string ANIM_BUTTON_PAUSE = "BtnChange";

		// Token: 0x0401EF66 RID: 126822
		private const string ANIM_BUTTON_START = "BtnChangeBack";

		// Token: 0x0401EF67 RID: 126823
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401EF68 RID: 126824
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0401EF69 RID: 126825
		protected float CurrentCdTime;

		// Token: 0x0401EF6A RID: 126826
		protected float TotalCdTime;

		// Token: 0x0200B8DD RID: 47325
		[NullableContext(0)]
		private class EButtonItemDefine
		{
			// Token: 0x040390E9 RID: 233705
			public const int Button = 0;

			// Token: 0x040390EA RID: 233706
			public const int SpriteGoing = 1;

			// Token: 0x040390EB RID: 233707
			public const int SpriteStop = 2;

			// Token: 0x040390EC RID: 233708
			public const int PanelPause = 3;

			// Token: 0x040390ED RID: 233709
			public const int ProgressPause = 4;

			// Token: 0x040390EE RID: 233710
			public const int TxtPause = 5;
		}
	}
}
