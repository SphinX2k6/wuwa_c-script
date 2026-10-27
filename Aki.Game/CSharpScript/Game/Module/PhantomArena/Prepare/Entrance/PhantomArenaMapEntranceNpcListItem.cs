using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005174 RID: 20852
	internal class PhantomArenaMapEntranceNpcListItem : GridProxyAbstract<int>
	{
		// Token: 0x060354F9 RID: 218361 RVA: 0x00CA0088 File Offset: 0x00C9E288
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

		// Token: 0x060354FA RID: 218362 RVA: 0x00CA018C File Offset: 0x00C9E38C
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

		// Token: 0x060354FB RID: 218363 RVA: 0x00CA01DC File Offset: 0x00C9E3DC
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

		// Token: 0x060354FC RID: 218364 RVA: 0x00CA0240 File Offset: 0x00C9E440
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

		// Token: 0x060354FD RID: 218365 RVA: 0x00CA03C6 File Offset: 0x00C9E5C6
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x060354FE RID: 218366 RVA: 0x00CA03DE File Offset: 0x00C9E5DE
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060354FF RID: 218367 RVA: 0x00CA03F6 File Offset: 0x00C9E5F6
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0401C597 RID: 116119
		private int ChallengeId;

		// Token: 0x0401C598 RID: 116120
		[Nullable(2)]
		private UUIItem CurrentStateUi;

		// Token: 0x0401C599 RID: 116121
		[Nullable(2)]
		public Action<int> SelectCallBack;

		// Token: 0x0200B2DC RID: 45788
		private static class EComponents
		{
			// Token: 0x04036311 RID: 221969
			public const int Toggle = 0;

			// Token: 0x04036312 RID: 221970
			public const int TexNPC = 1;

			// Token: 0x04036313 RID: 221971
			public const int PnlNor = 2;

			// Token: 0x04036314 RID: 221972
			public const int TextNameNor = 3;

			// Token: 0x04036315 RID: 221973
			public const int TextNum = 4;

			// Token: 0x04036316 RID: 221974
			public const int PnlDone = 5;

			// Token: 0x04036317 RID: 221975
			public const int TextNameDone = 6;

			// Token: 0x04036318 RID: 221976
			public const int PnlLock = 7;

			// Token: 0x04036319 RID: 221977
			public const int TextNameLock = 8;
		}
	}
}
