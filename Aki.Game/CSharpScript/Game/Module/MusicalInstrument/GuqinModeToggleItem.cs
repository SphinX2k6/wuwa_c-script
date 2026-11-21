using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200434E RID: 17230
	public class GuqinModeToggleItem : UiPanelBase
	{
		// Token: 0x0602B858 RID: 178264 RVA: 0x00C3AF34 File Offset: 0x00C39134
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

		// Token: 0x0602B859 RID: 178265 RVA: 0x00C3AFFB File Offset: 0x00C391FB
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
			this.SetToggleState(EToggleState.ETT_UnChecked, true);
		}

		// Token: 0x0602B85A RID: 178266 RVA: 0x00C3B012 File Offset: 0x00C39212
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

		// Token: 0x0602B85B RID: 178267 RVA: 0x00C3B02E File Offset: 0x00C3922E
		public void SetToggleState(EToggleState state, bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x0401781B RID: 96283
		public EZitherAudioType AudioType = EZitherAudioType.FundamentalTone;

		// Token: 0x0401781C RID: 96284
		[Nullable(2)]
		public Action<EZitherAudioType> SelectCallback;

		// Token: 0x0200A01D RID: 40989
		private enum EGuqinModeToggleItemComponent
		{
			// Token: 0x04031BEA RID: 203754
			Toggle,
			// Token: 0x04031BEB RID: 203755
			SpriteIcon,
			// Token: 0x04031BEC RID: 203756
			TextureIcon
		}
	}
}
