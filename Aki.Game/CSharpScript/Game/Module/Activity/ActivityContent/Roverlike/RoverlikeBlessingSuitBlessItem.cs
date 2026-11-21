using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005072 RID: 20594
	public class RoverlikeBlessingSuitBlessItem : GridProxyAbstract<int>
	{
		// Token: 0x0603390A RID: 211210 RVA: 0x00E702DF File Offset: 0x00E6E4DF
		[NullableContext(1)]
		public void BindOnItemClick(Action<int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x0603390B RID: 211211 RVA: 0x00E702E8 File Offset: 0x00E6E4E8
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

		// Token: 0x0603390C RID: 211212 RVA: 0x00E703AF File Offset: 0x00E6E5AF
		protected override void OnStart()
		{
		}

		// Token: 0x0603390D RID: 211213 RVA: 0x00E703B4 File Offset: 0x00E6E5B4
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

		// Token: 0x0603390E RID: 211214 RVA: 0x00E7046A File Offset: 0x00E6E66A
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

		// Token: 0x0603390F RID: 211215 RVA: 0x00E7048F File Offset: 0x00E6E68F
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033910 RID: 211216 RVA: 0x00E704A6 File Offset: 0x00E6E6A6
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033911 RID: 211217 RVA: 0x00E704BD File Offset: 0x00E6E6BD
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0401B5F7 RID: 112119
		private int CurrentBlessId;

		// Token: 0x0401B5F8 RID: 112120
		[Nullable(2)]
		private Action<int> OnItemClick;

		// Token: 0x0200AD39 RID: 44345
		private class EComponents
		{
			// Token: 0x04035898 RID: 219288
			public const int SpriteBg = 0;

			// Token: 0x04035899 RID: 219289
			public const int SpriteBlessIcon = 1;

			// Token: 0x0403589A RID: 219290
			public const int TogBlessing = 2;
		}
	}
}
