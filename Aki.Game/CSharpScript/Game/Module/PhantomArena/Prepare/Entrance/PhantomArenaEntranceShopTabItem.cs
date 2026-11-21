using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004134 RID: 16692
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaEntranceShopTabItem : CommonTabItemBase
	{
		// Token: 0x0602A347 RID: 172871 RVA: 0x00BEAA40 File Offset: 0x00BE8C40
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

		// Token: 0x0602A348 RID: 172872 RVA: 0x00BEAAD4 File Offset: 0x00BE8CD4
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

		// Token: 0x0602A349 RID: 172873 RVA: 0x00BEAB24 File Offset: 0x00BE8D24
		protected override void OnBeforeDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0602A34A RID: 172874 RVA: 0x00BEAB2C File Offset: 0x00BE8D2C
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

		// Token: 0x0602A34B RID: 172875 RVA: 0x00BEAB87 File Offset: 0x00BE8D87
		private void ToggleClick(EToggleState toggleState)
		{
			if (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack(base.GridIndex);
			}
		}

		// Token: 0x0602A34C RID: 172876 RVA: 0x00BEABAB File Offset: 0x00BE8DAB
		public override void OnSelected(bool fireEvent)
		{
			this.SelectedCallBack(base.GridIndex);
		}

		// Token: 0x0602A34D RID: 172877 RVA: 0x00BEABBE File Offset: 0x00BE8DBE
		protected override void OnUpdateTabIcon(string iconPath)
		{
		}

		// Token: 0x0602A34E RID: 172878 RVA: 0x00BEABC0 File Offset: 0x00BE8DC0
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

		// Token: 0x0602A34F RID: 172879 RVA: 0x00BEAC40 File Offset: 0x00BE8E40
		protected void UpdateTabTitle(string titleId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), titleId, Array.Empty<object>());
		}

		// Token: 0x0602A350 RID: 172880 RVA: 0x00BEAC59 File Offset: 0x00BE8E59
		public void SetToggleStateForce(EToggleState state, bool bFire)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, false);
		}

		// Token: 0x0602A351 RID: 172881 RVA: 0x00BEAC6B File Offset: 0x00BE8E6B
		public void SetCanClickWhenDisable(bool state)
		{
			base.GetExtendToggle(0).SetCanClickWhenDisable(state);
		}

		// Token: 0x0602A352 RID: 172882 RVA: 0x00BEAC7A File Offset: 0x00BE8E7A
		public void SetOnUndeterminedClick(Action call)
		{
			this.OnUndeterminedClick = call;
		}

		// Token: 0x0602A353 RID: 172883 RVA: 0x00BEAC83 File Offset: 0x00BE8E83
		protected override void OnSetToggleState(EToggleState state, bool bFire)
		{
			base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x0602A354 RID: 172884 RVA: 0x00BEAC96 File Offset: 0x00BE8E96
		protected override UUIExtendToggle GetTabToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0602A355 RID: 172885 RVA: 0x00BEAC9F File Offset: 0x00BE8E9F
		public void BindRedDot(ERedDotName redDotName, int uId = 0)
		{
			this.RedDotName = new ERedDotName?(redDotName);
			if (this.RedDotName != null)
			{
				RedDotController.Instance.BindRedDot(redDotName, base.GetItem(3), null, uId);
			}
		}

		// Token: 0x0602A356 RID: 172886 RVA: 0x00BEACCE File Offset: 0x00BE8ECE
		public void UnBindRedDot()
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
				this.RedDotName = null;
			}
		}

		// Token: 0x0602A357 RID: 172887 RVA: 0x00BEACFE File Offset: 0x00BE8EFE
		protected void UnBindGivenUid(int uid = 0)
		{
			if (this.RedDotName != null)
			{
				RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(3), uid);
				this.RedDotName = null;
			}
		}

		// Token: 0x0602A358 RID: 172888 RVA: 0x00BEAD36 File Offset: 0x00BE8F36
		public void SetRedDotState(bool bVisible)
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0602A359 RID: 172889 RVA: 0x00BEAD4A File Offset: 0x00BE8F4A
		public UUISprite GetIconSprite()
		{
			return base.GetSprite(2);
		}

		// Token: 0x0602A35A RID: 172890 RVA: 0x00BEAD53 File Offset: 0x00BE8F53
		protected override void OnClear()
		{
			this.UnBindRedDot();
		}

		// Token: 0x04016F9D RID: 94109
		[Nullable(2)]
		private Action OnUndeterminedClick;

		// Token: 0x04016F9E RID: 94110
		protected ERedDotName? RedDotName;

		// Token: 0x02009CFE RID: 40190
		[NullableContext(0)]
		private class ETabItem
		{
			// Token: 0x04030CFD RID: 199933
			public const int Toggle = 0;

			// Token: 0x04030CFE RID: 199934
			public const int TxtName = 1;

			// Token: 0x04030CFF RID: 199935
			public const int Icon = 2;

			// Token: 0x04030D00 RID: 199936
			public const int RedDot = 3;
		}
	}
}
