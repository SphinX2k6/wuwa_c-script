using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace Ui.WorldMap.View.Component
{
	// Token: 0x02002F51 RID: 12113
	public class WorldMapSubMapItem : GridProxyAbstract<MultiMap>
	{
		// Token: 0x0601CB62 RID: 117602 RVA: 0x008C35FC File Offset: 0x008C17FC
		public override void Refresh(MultiMap data, bool isSelected, int gridIndex)
		{
			this.MultiMapConfigId = data.Id;
			base.GridIndex = gridIndex;
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.FloorName, Array.Empty<object>());
			int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
			MultiMap? subMapConfigByAreaId = MapConfig.Instance.GetSubMapConfigByAreaId(currentAreaId);
			bool flag = data.GetAreaBytes().Contains(currentAreaId);
			if (flag || (!flag && data.Floor == 0 && subMapConfigByAreaId == null))
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_MultiMapCurrentAreaIcon");
				if (!StringUtils.IsEmpty(resourcePath))
				{
					UUISprite sprite = base.GetSprite(0);
					object obj;
					if (sprite == null)
					{
						obj = null;
					}
					else
					{
						AActor owner = sprite.GetOwner();
						obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) : null);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = obj as UUIExtendToggleSpriteTransition;
					base.SetExtendToggleSpriteTransitionByPath(resourcePath, uiExtendToggleSpriteTransition, null).Forget();
					this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
					return;
				}
			}
			else if (!StringUtils.IsEmpty(data.FloorIcon))
			{
				string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(data.FloorIcon);
				if (!StringUtils.IsEmpty(resourcePath2))
				{
					UUISprite sprite2 = base.GetSprite(0);
					object obj2;
					if (sprite2 == null)
					{
						obj2 = null;
					}
					else
					{
						AActor owner2 = sprite2.GetOwner();
						obj2 = ((owner2 != null) ? owner2.GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) : null);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition2 = obj2 as UUIExtendToggleSpriteTransition;
					base.SetExtendToggleSpriteTransitionByPath(resourcePath2, uiExtendToggleSpriteTransition2, null).Forget();
					this.SetSpriteByPath(resourcePath2, base.GetSprite(1), false, null, null);
				}
			}
		}

		// Token: 0x0601CB63 RID: 117603 RVA: 0x008C37BC File Offset: 0x008C19BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601CB64 RID: 117604 RVA: 0x008C3867 File Offset: 0x008C1A67
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		}

		// Token: 0x0601CB65 RID: 117605 RVA: 0x008C388C File Offset: 0x008C1A8C
		private void OnToggleStateChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				WorldMapModel.Instance.WorldMapCurrentMultiMapId = new int?(this.MultiMapConfigId);
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSelectMultiMap, this.MultiMapConfigId);
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChanged, base.GridIndex);
			}
		}

		// Token: 0x0601CB66 RID: 117606 RVA: 0x008C38DE File Offset: 0x008C1ADE
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0601CB67 RID: 117607 RVA: 0x008C38F6 File Offset: 0x008C1AF6
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0400F1BD RID: 61885
		public int MultiMapConfigId;

		// Token: 0x02008BE5 RID: 35813
		private enum EWorldMapSubMapItemDefine
		{
			// Token: 0x0402C519 RID: 181529
			SpriteIcon,
			// Token: 0x0402C51A RID: 181530
			SpriteAnimIcon,
			// Token: 0x0402C51B RID: 181531
			TextName,
			// Token: 0x0402C51C RID: 181532
			ExtendToggle
		}
	}
}
