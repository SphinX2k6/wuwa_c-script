using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02003D47 RID: 15687
	public class RoleLangCustomElementTabItem : GridProxyAbstract<int>
	{
		// Token: 0x060282FF RID: 164607 RVA: 0x00B40E7C File Offset: 0x00B3F07C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06028300 RID: 164608 RVA: 0x00B40F48 File Offset: 0x00B3F148
		protected override void OnStart()
		{
			base.GetExtendToggle(1).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06028301 RID: 164609 RVA: 0x00B40F68 File Offset: 0x00B3F168
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.CurElementId = data;
			if (data == 0)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_TutorialIconAll");
				this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
			}
			else
			{
				string spriteIcon = ElementInfoConfig.Instance.GetElementInfo(data).Value.SpriteIcon1;
				this.SetSpriteByPath(spriteIcon, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
			}
			if (this.OnToggleSelectedCheck != null)
			{
				this.SetSelected(this.OnToggleSelectedCheck(data), false);
			}
		}

		// Token: 0x06028302 RID: 164610 RVA: 0x00B41014 File Offset: 0x00B3F214
		protected void RefreshTransition(bool _)
		{
			UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
			if (uiExtendToggleSpriteTransition != null)
			{
				uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
			}
		}

		// Token: 0x06028303 RID: 164611 RVA: 0x00B4103E File Offset: 0x00B3F23E
		public void RefreshSelected()
		{
			if (this.OnToggleSelectedCheck != null)
			{
				this.SetSelected(this.OnToggleSelectedCheck(this.CurElementId), false);
			}
		}

		// Token: 0x06028304 RID: 164612 RVA: 0x00B41060 File Offset: 0x00B3F260
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			base.GetExtendToggle(1).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06028305 RID: 164613 RVA: 0x00B41079 File Offset: 0x00B3F279
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(this.CurElementId);
		}

		// Token: 0x04015D4C RID: 89420
		private const int FILTER_ALL_ID = 0;

		// Token: 0x04015D4D RID: 89421
		protected int CurElementId;

		// Token: 0x04015D4E RID: 89422
		[Nullable(1)]
		public Action<int> OnToggleStateChangedCallback;

		// Token: 0x04015D4F RID: 89423
		[Nullable(1)]
		public Func<int, bool> OnToggleSelectedCheck;

		// Token: 0x02009928 RID: 39208
		private enum EDefine
		{
			// Token: 0x0402FC67 RID: 195687
			SpriteIcon,
			// Token: 0x0402FC68 RID: 195688
			TogItem,
			// Token: 0x0402FC69 RID: 195689
			RedDot,
			// Token: 0x0402FC6A RID: 195690
			SpriteIcon2,
			// Token: 0x0402FC6B RID: 195691
			SpriteSubIcon
		}
	}
}
