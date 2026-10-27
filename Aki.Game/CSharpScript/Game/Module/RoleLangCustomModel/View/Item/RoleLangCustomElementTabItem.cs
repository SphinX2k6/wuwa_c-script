using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02004D7E RID: 19838
	public class RoleLangCustomElementTabItem : GridProxyAbstract<int>
	{
		// Token: 0x06033492 RID: 210066 RVA: 0x00BF7880 File Offset: 0x00BF5A80
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

		// Token: 0x06033493 RID: 210067 RVA: 0x00BF794C File Offset: 0x00BF5B4C
		protected override void OnStart()
		{
			base.GetExtendToggle(1).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06033494 RID: 210068 RVA: 0x00BF796C File Offset: 0x00BF5B6C
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

		// Token: 0x06033495 RID: 210069 RVA: 0x00BF7A18 File Offset: 0x00BF5C18
		protected void RefreshTransition(bool _)
		{
			UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
			if (uiExtendToggleSpriteTransition != null)
			{
				uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
			}
		}

		// Token: 0x06033496 RID: 210070 RVA: 0x00BF7A42 File Offset: 0x00BF5C42
		public void RefreshSelected()
		{
			if (this.OnToggleSelectedCheck != null)
			{
				this.SetSelected(this.OnToggleSelectedCheck(this.CurElementId), false);
			}
		}

		// Token: 0x06033497 RID: 210071 RVA: 0x00BF7A64 File Offset: 0x00BF5C64
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			base.GetExtendToggle(1).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06033498 RID: 210072 RVA: 0x00BF7A7D File Offset: 0x00BF5C7D
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<int> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(this.CurElementId);
		}

		// Token: 0x0401B379 RID: 111481
		private const int FILTER_ALL_ID = 0;

		// Token: 0x0401B37A RID: 111482
		protected int CurElementId;

		// Token: 0x0401B37B RID: 111483
		[Nullable(1)]
		public Action<int> OnToggleStateChangedCallback;

		// Token: 0x0401B37C RID: 111484
		[Nullable(1)]
		public Func<int, bool> OnToggleSelectedCheck;

		// Token: 0x0200AEF4 RID: 44788
		private enum EDefine
		{
			// Token: 0x04035233 RID: 217651
			SpriteIcon,
			// Token: 0x04035234 RID: 217652
			TogItem,
			// Token: 0x04035235 RID: 217653
			RedDot,
			// Token: 0x04035236 RID: 217654
			SpriteIcon2,
			// Token: 0x04035237 RID: 217655
			SpriteSubIcon
		}
	}
}
