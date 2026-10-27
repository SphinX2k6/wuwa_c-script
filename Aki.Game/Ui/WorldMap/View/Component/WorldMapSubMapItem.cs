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
	// Token: 0x020044C4 RID: 17604
	public class WorldMapSubMapItem : GridProxyAbstract<MultiMap>
	{
		// Token: 0x0602D624 RID: 185892 RVA: 0x00A3D99C File Offset: 0x00A3BB9C
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

		// Token: 0x0602D625 RID: 185893 RVA: 0x00A3DB5C File Offset: 0x00A3BD5C
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

		// Token: 0x0602D626 RID: 185894 RVA: 0x00A3DC07 File Offset: 0x00A3BE07
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		}

		// Token: 0x0602D627 RID: 185895 RVA: 0x00A3DC2C File Offset: 0x00A3BE2C
		private void OnToggleStateChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				WorldMapModel.Instance.WorldMapCurrentMultiMapId = new int?(this.MultiMapConfigId);
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSelectMultiMap, this.MultiMapConfigId);
				EventSystem.Instance.Emit<int>(EEventName.WorldMapSubMapChanged, base.GridIndex);
			}
		}

		// Token: 0x0602D628 RID: 185896 RVA: 0x00A3DC7E File Offset: 0x00A3BE7E
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602D629 RID: 185897 RVA: 0x00A3DC96 File Offset: 0x00A3BE96
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x04018415 RID: 99349
		public int MultiMapConfigId;

		// Token: 0x0200A70F RID: 42767
		private enum EWorldMapSubMapItemDefine
		{
			// Token: 0x0403274B RID: 206667
			SpriteIcon,
			// Token: 0x0403274C RID: 206668
			SpriteAnimIcon,
			// Token: 0x0403274D RID: 206669
			TextName,
			// Token: 0x0403274E RID: 206670
			ExtendToggle
		}
	}
}
