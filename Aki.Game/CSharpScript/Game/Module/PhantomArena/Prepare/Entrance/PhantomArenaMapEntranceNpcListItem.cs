using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004144 RID: 16708
	internal class PhantomArenaMapEntranceNpcListItem : GridProxyAbstract<int>
	{
		// Token: 0x0602A3F5 RID: 173045 RVA: 0x00BED604 File Offset: 0x00BEB804
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
			};
		}

		// Token: 0x0602A3F6 RID: 173046 RVA: 0x00BED708 File Offset: 0x00BEB908
		private void OnClickItem(EToggleState toggleState)
		{
			if (base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_UnChecked)
			{
				return;
			}
			Action<int> selectCallBack = this.SelectCallBack;
			if (selectCallBack != null)
			{
				selectCallBack(this.ChallengeId);
			}
			IScrollViewDelegate<IGridProxy<int>, int> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}

		// Token: 0x0602A3F7 RID: 173047 RVA: 0x00BED758 File Offset: 0x00BEB958
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(delegate()
			{
				int gridIndex = base.GridIndex;
				IScrollViewDelegate<IGridProxy<int>, int> scrollViewDelegate = base.ScrollViewDelegate;
				int? num = (scrollViewDelegate != null) ? new int?(scrollViewDelegate.GetSelectedGridIndex()) : null;
				return !(gridIndex == num.GetValueOrDefault() & num != null);
			});
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			base.GetItem(2).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x0602A3F8 RID: 173048 RVA: 0x00BED7BC File Offset: 0x00BEB9BC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ChallengeId = data;
			EChallengeState permanentChallengeStateById = PhantomArenaModel.Instance.GetPermanentChallengeStateById(data);
			PhantomBattleChallenge phantomBattleChallengeConfig = PhantomArenaConfig.Instance.GetPhantomBattleChallengeConfig(data);
			PhantomBattleChallengeInfo permanentChallengeData = PhantomArenaModel.Instance.GetPermanentChallengeData(data);
			bool flag = ((permanentChallengeData != null) ? permanentChallengeData.FinishConditions : null) == null || PhantomArenaModel.Instance.GetPermanentChallengeData(data).IsUncover;
			string textStringId = flag ? phantomBattleChallengeConfig.NpcName : EPhantomArenaTextId.TextMysteryNpcName.ToString();
			UUIItem currentStateUi = this.CurrentStateUi;
			if (currentStateUi != null)
			{
				currentStateUi.SetUIActive(false);
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(phantomBattleChallengeConfig.NpcNumber, true);
			}
			switch (permanentChallengeStateById)
			{
			case EChallengeState.Lock:
				this.CurrentStateUi = base.GetItem(7);
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(8), textStringId, Array.Empty<object>());
				break;
			case EChallengeState.Pending:
				this.CurrentStateUi = base.GetItem(2);
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
				break;
			case EChallengeState.Finish:
				this.CurrentStateUi = base.GetItem(5);
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), textStringId, Array.Empty<object>());
				break;
			}
			UUIItem currentStateUi2 = this.CurrentStateUi;
			if (currentStateUi2 != null)
			{
				currentStateUi2.SetUIActive(true);
			}
			if (flag)
			{
				base.TrySetTextureByPath(phantomBattleChallengeConfig.NpcMapHead, base.GetTexture(1), null, null);
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("MysteryNpcHead");
			base.TrySetTextureByPath(resourcePath, base.GetTexture(1), null, null);
		}

		// Token: 0x0602A3F9 RID: 173049 RVA: 0x00BED942 File Offset: 0x00BEBB42
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A3FA RID: 173050 RVA: 0x00BED95A File Offset: 0x00BEBB5A
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602A3FB RID: 173051 RVA: 0x00BED972 File Offset: 0x00BEBB72
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x04016FCC RID: 94156
		private int ChallengeId;

		// Token: 0x04016FCD RID: 94157
		[Nullable(2)]
		private UUIItem CurrentStateUi;

		// Token: 0x04016FCE RID: 94158
		[Nullable(2)]
		public Action<int> SelectCallBack;

		// Token: 0x02009D16 RID: 40214
		private static class EComponents
		{
			// Token: 0x04030D68 RID: 200040
			public const int Toggle = 0;

			// Token: 0x04030D69 RID: 200041
			public const int TexNPC = 1;

			// Token: 0x04030D6A RID: 200042
			public const int PnlNor = 2;

			// Token: 0x04030D6B RID: 200043
			public const int TextNameNor = 3;

			// Token: 0x04030D6C RID: 200044
			public const int TextNum = 4;

			// Token: 0x04030D6D RID: 200045
			public const int PnlDone = 5;

			// Token: 0x04030D6E RID: 200046
			public const int TextNameDone = 6;

			// Token: 0x04030D6F RID: 200047
			public const int PnlLock = 7;

			// Token: 0x04030D70 RID: 200048
			public const int TextNameLock = 8;
		}
	}
}
