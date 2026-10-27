using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200517B RID: 20859
	public class MatchGymItem : GridProxyAbstract<int>
	{
		// Token: 0x0603556F RID: 218479 RVA: 0x00CA2B08 File Offset: 0x00CA0D08
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x06035570 RID: 218480 RVA: 0x00CA2C50 File Offset: 0x00CA0E50
		protected override void OnStart()
		{
			base.GetItem(11).SetUIActive(false);
			this.LayoutStar = new GenericLayout<GymStarItem, GymChallengeData>(base.GetHorizontalLayout(5), new Func<GymStarItem>(this.CreateStarItem), null, false, true);
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x06035571 RID: 218481 RVA: 0x00CA2CA9 File Offset: 0x00CA0EA9
		[NullableContext(1)]
		private GymStarItem CreateStarItem()
		{
			return new GymStarItem();
		}

		// Token: 0x06035572 RID: 218482 RVA: 0x00CA2CB0 File Offset: 0x00CA0EB0
		public override void Refresh(int gymLevel, bool isSelected, int gridIndex)
		{
			this.Level = gymLevel;
			PhantomBattleGym? phantomBattleGymConfigByLevel = PhantomArenaModel.Instance.GetPhantomBattleGymConfigByLevel(gymLevel, this.ActivityId);
			if (phantomBattleGymConfigByLevel == null)
			{
				return;
			}
			bool flag = PhantomArenaModel.Instance.IsGymLock(this.Level, this.ActivityId);
			string path = flag ? phantomBattleGymConfigByLevel.Value.IconLock : phantomBattleGymConfigByLevel.Value.Icon;
			UUISprite sprite = base.GetSprite(4);
			this.SetSpriteByPath(path, sprite, false, null, null);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.SetSpriteByPath(phantomBattleGymConfigByLevel.Value.IconRoman, base.GetSprite(1), false, null, null);
			this.SetSpriteByPath(phantomBattleGymConfigByLevel.Value.IconRoman, base.GetSprite(2), false, null, null);
			this.SetSpriteByPath(phantomBattleGymConfigByLevel.Value.IconBg, base.GetSprite(3), false, null, null);
			this.SetSelected(isSelected);
			List<GymChallengeData> challengeStateListByGymLevel = PhantomArenaModel.Instance.GetChallengeStateListByGymLevel(this.Level, this.ActivityId);
			this.LayoutStar.RefreshByData(challengeStateListByGymLevel, null, false);
			this.LayoutStar.SetActive(!flag);
			this.RefreshRedDot();
		}

		// Token: 0x06035573 RID: 218483 RVA: 0x00CA2E10 File Offset: 0x00CA1010
		public void RefreshRedDot()
		{
			bool uiactive = this.Level > 0 && PhantomArenaModel.Instance.GetGymRedDotById(this.Level, this.ActivityId);
			base.GetItem(11).SetUIActive(uiactive);
		}

		// Token: 0x06035574 RID: 218484 RVA: 0x00CA2E50 File Offset: 0x00CA1050
		private void SetSelected(bool isSelected)
		{
			bool flag = PhantomArenaModel.Instance.IsGymLock(this.Level, this.ActivityId);
			EToggleState etoggleState = (!flag && isSelected) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			EToggleState state = flag ? EToggleState.ETT_UnDetermined : etoggleState;
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
			base.GetSprite(1).SetUIActive(!isSelected);
			base.GetSprite(2).SetUIActive(isSelected);
			base.GetSprite(3).SetUIActive(!flag && !isSelected);
			base.GetSprite(7).SetUIActive(flag);
			base.GetSprite(8).SetUIActive(flag);
			base.GetSprite(1).SetIsGray(true);
		}

		// Token: 0x06035575 RID: 218485 RVA: 0x00CA2EF4 File Offset: 0x00CA10F4
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x06035576 RID: 218486 RVA: 0x00CA2EFD File Offset: 0x00CA10FD
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x06035577 RID: 218487 RVA: 0x00CA2F08 File Offset: 0x00CA1108
		private void OnUndeterminedClicked()
		{
			if (this.CallbackOnClick != null && this.Level > 0)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.Level, base.GridIndex, toggleState);
			}
		}

		// Token: 0x06035578 RID: 218488 RVA: 0x00CA2F4C File Offset: 0x00CA114C
		private void OnClickToggle(EToggleState toggleState)
		{
			if (this.CallbackOnClick != null && this.Level > 0)
			{
				EToggleState toggleState2 = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.Level, base.GridIndex, toggleState2);
			}
		}

		// Token: 0x0401C5B6 RID: 116150
		public int Level = -1;

		// Token: 0x0401C5B7 RID: 116151
		public int ActivityId;

		// Token: 0x0401C5B8 RID: 116152
		[Nullable(2)]
		public Action<int, int, EToggleState> CallbackOnClick;

		// Token: 0x0401C5B9 RID: 116153
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GymStarItem, GymChallengeData> LayoutStar;

		// Token: 0x0200B2ED RID: 45805
		private class EComponent
		{
			// Token: 0x04036386 RID: 222086
			public const int ToggleLevel = 0;

			// Token: 0x04036387 RID: 222087
			public const int SpriteRoman = 1;

			// Token: 0x04036388 RID: 222088
			public const int SpriteRomanSel = 2;

			// Token: 0x04036389 RID: 222089
			public const int SpriteGate = 3;

			// Token: 0x0403638A RID: 222090
			public const int SpriteIcon = 4;

			// Token: 0x0403638B RID: 222091
			public const int LayoutStar = 5;

			// Token: 0x0403638C RID: 222092
			public const int ItemStar = 6;

			// Token: 0x0403638D RID: 222093
			public const int SpriteGateLock = 7;

			// Token: 0x0403638E RID: 222094
			public const int SpriteLock = 8;

			// Token: 0x0403638F RID: 222095
			public const int SpriteGray = 9;

			// Token: 0x04036390 RID: 222096
			public const int SpriteLight = 10;

			// Token: 0x04036391 RID: 222097
			public const int ItemRedDot = 11;
		}
	}
}
