using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005164 RID: 20836
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceShopTabItem : CommonTabItemBase
	{
		// Token: 0x0603544B RID: 218187 RVA: 0x00C9D510 File Offset: 0x00C9B710
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggleSpriteTransition)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick))
			};
		}

		// Token: 0x0603544C RID: 218188 RVA: 0x00C9D5A4 File Offset: 0x00C9B7A4
		protected override void OnStart()
		{
			base.OnStart();
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			Action callback = delegate()
			{
				Action onUndeterminedClick = this.OnUndeterminedClick;
				if (onUndeterminedClick == null)
				{
					return;
				}
				onUndeterminedClick();
			};
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(callback);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x0603544D RID: 218189 RVA: 0x00C9D5F4 File Offset: 0x00C9B7F4
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0603544E RID: 218190 RVA: 0x00C9D5FC File Offset: 0x00C9B7FC
		protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
		{
			PhantomArenaEntranceShopTabData phantomArenaEntranceShopTabData = data.Data as PhantomArenaEntranceShopTabData;
			this.UpdateIcon(phantomArenaEntranceShopTabData);
			this.UpdateTabTitle(phantomArenaEntranceShopTabData.GetRealTitle());
			this.UnBindRedDot();
			if (data.RedDotName != null)
			{
				this.BindRedDot(data.RedDotName.Value, data.RedDotUid.Value);
			}
		}

		// Token: 0x0603544F RID: 218191 RVA: 0x00C9D657 File Offset: 0x00C9B857
		private void ToggleClick(EToggleState toggleState)
		{
			if (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack(base.GridIndex);
			}
		}

		// Token: 0x06035450 RID: 218192 RVA: 0x00C9D67B File Offset: 0x00C9B87B
		public override void OnSelected(bool fireEvent)
		{
			this.SelectedCallBack(base.GridIndex);
		}

		// Token: 0x06035451 RID: 218193 RVA: 0x00C9D68E File Offset: 0x00C9B88E
		protected override void OnUpdateTabIcon(string iconPath)
		{
		}

		// Token: 0x06035452 RID: 218194 RVA: 0x00C9D690 File Offset: 0x00C9B890
		protected void UpdateIcon(PhantomArenaEntranceShopTabData data)
		{
			EUiTabViewName tabViewName = data.GetTabViewName();
			string[] array;
			if (!PhantomArenaDefine.phantomArenaEntranceShopTabIconMap.TryGetValue(tabViewName, out array))
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(array[0]);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(array[1]);
			ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(resourcePath, delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
			{
				if (sprite != null)
				{
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(2);
					if (uiExtendToggleSpriteTransition != null)
					{
						uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_UnCheckedUnHover, sprite, false);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition2 = base.GetUiExtendToggleSpriteTransition(2);
					if (uiExtendToggleSpriteTransition2 != null)
					{
						uiExtendToggleSpriteTransition2.SetStateSprite(EToggleTransitionState.ETT_UnCheckedHover, sprite, false);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition3 = base.GetUiExtendToggleSpriteTransition(2);
					if (uiExtendToggleSpriteTransition3 == null)
					{
						return;
					}
					uiExtendToggleSpriteTransition3.SetStateSprite(EToggleTransitionState.ETT_UnCheckedPressed, sprite, false);
				}
			}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
			ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(resourcePath2, delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
			{
				if (sprite != null)
				{
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(2);
					if (uiExtendToggleSpriteTransition != null)
					{
						uiExtendToggleSpriteTransition.SetStateSprite(EToggleTransitionState.ETT_CheckedUnHover, sprite, false);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition2 = base.GetUiExtendToggleSpriteTransition(2);
					if (uiExtendToggleSpriteTransition2 != null)
					{
						uiExtendToggleSpriteTransition2.SetStateSprite(EToggleTransitionState.ETT_CheckedHover, sprite, false);
					}
					UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition3 = base.GetUiExtendToggleSpriteTransition(2);
					if (uiExtendToggleSpriteTransition3 == null)
					{
						return;
					}
					uiExtendToggleSpriteTransition3.SetStateSprite(EToggleTransitionState.ETT_CheckedPressed, sprite, false);
				}
			}, ResourceSystem.EResourceLoadPriority.Default, this.MemoryTag);
		}

		// Token: 0x06035453 RID: 218195 RVA: 0x00C9D710 File Offset: 0x00C9B910
		protected void UpdateTabTitle(string titleId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), titleId, Array.Empty<object>());
		}

		// Token: 0x06035454 RID: 218196 RVA: 0x00C9D729 File Offset: 0x00C9B929
		public void SetToggleStateForce(EToggleState state, bool bFire)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, false);
		}

		// Token: 0x06035455 RID: 218197 RVA: 0x00C9D73B File Offset: 0x00C9B93B
		public void SetCanClickWhenDisable(bool state)
		{
			base.GetExtendToggle(0).SetCanClickWhenDisable(state);
		}

		// Token: 0x06035456 RID: 218198 RVA: 0x00C9D74A File Offset: 0x00C9B94A
		public void SetOnUndeterminedClick(Action call)
		{
			this.OnUndeterminedClick = call;
		}

		// Token: 0x06035457 RID: 218199 RVA: 0x00C9D753 File Offset: 0x00C9B953
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x06035458 RID: 218200 RVA: 0x00C9D766 File Offset: 0x00C9B966
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06035459 RID: 218201 RVA: 0x00C9D76F File Offset: 0x00C9B96F
		public void BindRedDot(ERedDotName redDotName, int uId = 0)
		{
			this.RedDotName = new ERedDotName?(redDotName);
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(redDotName, base.GetItem(3), null, uId);
			}
		}

		// Token: 0x0603545A RID: 218202 RVA: 0x00C9D79E File Offset: 0x00C9B99E
		public void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
				this.RedDotName = null;
			}
		}

		// Token: 0x0603545B RID: 218203 RVA: 0x00C9D7CE File Offset: 0x00C9B9CE
		protected void UnBindGivenUid(int uid = 0)
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(3), uid);
				this.RedDotName = null;
			}
		}

		// Token: 0x0603545C RID: 218204 RVA: 0x00C9D806 File Offset: 0x00C9BA06
		public void SetRedDotState(bool bVisible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0603545D RID: 218205 RVA: 0x00C9D81A File Offset: 0x00C9BA1A
		public UUISprite GetIconSprite()
		{
			return base.GetSprite(2);
		}

		// Token: 0x0603545E RID: 218206 RVA: 0x00C9D823 File Offset: 0x00C9BA23
		protected override void OnClear()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0401C568 RID: 116072
		[Nullable(2)]
		private Action OnUndeterminedClick;

		// Token: 0x0401C569 RID: 116073
		protected ERedDotName? RedDotName;

		// Token: 0x0200B2C5 RID: 45765
		[NullableContext(0)]
		private class ETabItem
		{
			// Token: 0x040362A8 RID: 221864
			public const int Toggle = 0;

			// Token: 0x040362A9 RID: 221865
			public const int TxtName = 1;

			// Token: 0x040362AA RID: 221866
			public const int Icon = 2;

			// Token: 0x040362AB RID: 221867
			public const int RedDot = 3;
		}
	}
}
