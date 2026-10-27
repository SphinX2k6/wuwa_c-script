using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200536B RID: 21355
	public class GuqinModeToggleItem : UiPanelBase
	{
		// Token: 0x06036912 RID: 223506 RVA: 0x00CEC0A8 File Offset: 0x00CEA2A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036913 RID: 223507 RVA: 0x00CEC16F File Offset: 0x00CEA36F
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
			this.SetToggleState(EToggleState.ETT_UnChecked, true);
		}

		// Token: 0x06036914 RID: 223508 RVA: 0x00CEC186 File Offset: 0x00CEA386
		private void OnClickToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<EZitherAudioType> selectCallback = this.SelectCallback;
				if (selectCallback == null)
				{
					return;
				}
				selectCallback(this.AudioType);
			}
		}

		// Token: 0x06036915 RID: 223509 RVA: 0x00CEC1A2 File Offset: 0x00CEA3A2
		public void SetToggleState(EToggleState state, bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x0401CD85 RID: 118149
		public EZitherAudioType AudioType = EZitherAudioType.FundamentalTone;

		// Token: 0x0401CD86 RID: 118150
		[Nullable(2)]
		public Action<EZitherAudioType> SelectCallback;

		// Token: 0x0200B5E6 RID: 46566
		private enum EGuqinModeToggleItemComponent
		{
			// Token: 0x04037197 RID: 225687
			Toggle,
			// Token: 0x04037198 RID: 225688
			SpriteIcon,
			// Token: 0x04037199 RID: 225689
			TextureIcon
		}
	}
}
