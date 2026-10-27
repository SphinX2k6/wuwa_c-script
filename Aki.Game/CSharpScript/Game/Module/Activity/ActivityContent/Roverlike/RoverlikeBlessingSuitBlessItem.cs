using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F4 RID: 24820
	public class RoverlikeBlessingSuitBlessItem : GridProxyAbstract<int>
	{
		// Token: 0x0603EC48 RID: 257096 RVA: 0x00F294CB File Offset: 0x00F276CB
		[NullableContext(1)]
		public void BindOnItemClick(Action<int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x0603EC49 RID: 257097 RVA: 0x00F294D4 File Offset: 0x00F276D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnTogBlessingStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EC4A RID: 257098 RVA: 0x00F2959B File Offset: 0x00F2779B
		protected override void OnStart()
		{
		}

		// Token: 0x0603EC4B RID: 257099 RVA: 0x00F295A0 File Offset: 0x00F277A0
		public override void Refresh(int blessId, bool isSelected, int gridIndex)
		{
			this.CurrentBlessId = blessId;
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(blessId);
			if (blessConfig == null)
			{
				return;
			}
			this.SetSpriteByPath(blessConfig.Value.Icon, base.GetSprite(1), false, null, null);
			RoverRogueQuality? qualityConfig = RoverlikeConfig.Instance.GetQualityConfig(blessConfig.Value.Quality);
			if (qualityConfig != null)
			{
				UUISprite sprite = base.GetSprite(0);
				if (sprite != null)
				{
					sprite.SetColor(FColor.FromHex(qualityConfig.Value.BlessSuitIcon));
				}
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603EC4C RID: 257100 RVA: 0x00F29656 File Offset: 0x00F27856
		private void OnTogBlessingStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.CurrentBlessId > 0)
			{
				Action<int> onItemClick = this.OnItemClick;
				if (onItemClick == null)
				{
					return;
				}
				onItemClick(this.CurrentBlessId);
			}
		}

		// Token: 0x0603EC4D RID: 257101 RVA: 0x00F2967B File Offset: 0x00F2787B
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603EC4E RID: 257102 RVA: 0x00F29692 File Offset: 0x00F27892
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603EC4F RID: 257103 RVA: 0x00F296A9 File Offset: 0x00F278A9
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x04020CCA RID: 134346
		private int CurrentBlessId;

		// Token: 0x04020CCB RID: 134347
		[Nullable(2)]
		private Action<int> OnItemClick;

		// Token: 0x0200C351 RID: 50001
		private class EComponents
		{
			// Token: 0x0403AF33 RID: 241459
			public const int SpriteBg = 0;

			// Token: 0x0403AF34 RID: 241460
			public const int SpriteBlessIcon = 1;

			// Token: 0x0403AF35 RID: 241461
			public const int TogBlessing = 2;
		}
	}
}
