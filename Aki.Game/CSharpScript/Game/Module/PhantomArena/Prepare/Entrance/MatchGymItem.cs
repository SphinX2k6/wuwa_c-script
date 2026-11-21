using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200414B RID: 16715
	public class MatchGymItem : GridProxyAbstract<int>
	{
		// Token: 0x0602A46A RID: 173162 RVA: 0x00BF00C0 File Offset: 0x00BEE2C0
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

		// Token: 0x0602A46B RID: 173163 RVA: 0x00BF0208 File Offset: 0x00BEE408
		protected override void OnStart()
		{
			base.GetItem(11).SetUIActive(false);
			this.LayoutStar = new GenericLayout<GymStarItem, GymChallengeData>(base.GetHorizontalLayout(5), new Func<GymStarItem>(this.CreateStarItem), null, false, true);
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x0602A46C RID: 173164 RVA: 0x00BF0261 File Offset: 0x00BEE461
		[NullableContext(1)]
		private GymStarItem CreateStarItem()
		{
			return new GymStarItem();
		}

		// Token: 0x0602A46D RID: 173165 RVA: 0x00BF0268 File Offset: 0x00BEE468
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

		// Token: 0x0602A46E RID: 173166 RVA: 0x00BF03C8 File Offset: 0x00BEE5C8
		public void RefreshRedDot()
		{
			bool uiactive = this.Level > 0 && PhantomArenaModel.Instance.GetGymRedDotById(this.Level, this.ActivityId);
			base.GetItem(11).SetUIActive(uiactive);
		}

		// Token: 0x0602A46F RID: 173167 RVA: 0x00BF0408 File Offset: 0x00BEE608
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

		// Token: 0x0602A470 RID: 173168 RVA: 0x00BF04AC File Offset: 0x00BEE6AC
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true);
		}

		// Token: 0x0602A471 RID: 173169 RVA: 0x00BF04B5 File Offset: 0x00BEE6B5
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false);
		}

		// Token: 0x0602A472 RID: 173170 RVA: 0x00BF04C0 File Offset: 0x00BEE6C0
		private void OnUndeterminedClicked()
		{
			if (this.CallbackOnClick != null && this.Level > 0)
			{
				EToggleState toggleState = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.Level, base.GridIndex, toggleState);
			}
		}

		// Token: 0x0602A473 RID: 173171 RVA: 0x00BF0504 File Offset: 0x00BEE704
		private void OnClickToggle(EToggleState toggleState)
		{
			if (this.CallbackOnClick != null && this.Level > 0)
			{
				EToggleState toggleState2 = base.GetExtendToggle(0).GetToggleState();
				this.CallbackOnClick(this.Level, base.GridIndex, toggleState2);
			}
		}

		// Token: 0x04016FEB RID: 94187
		public int Level = -1;

		// Token: 0x04016FEC RID: 94188
		public int ActivityId;

		// Token: 0x04016FED RID: 94189
		[Nullable(2)]
		public Action<int, int, EToggleState> CallbackOnClick;

		// Token: 0x04016FEE RID: 94190
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GymStarItem, GymChallengeData> LayoutStar;

		// Token: 0x02009D26 RID: 40230
		private class EComponent
		{
			// Token: 0x04030DDB RID: 200155
			public const int ToggleLevel = 0;

			// Token: 0x04030DDC RID: 200156
			public const int SpriteRoman = 1;

			// Token: 0x04030DDD RID: 200157
			public const int SpriteRomanSel = 2;

			// Token: 0x04030DDE RID: 200158
			public const int SpriteGate = 3;

			// Token: 0x04030DDF RID: 200159
			public const int SpriteIcon = 4;

			// Token: 0x04030DE0 RID: 200160
			public const int LayoutStar = 5;

			// Token: 0x04030DE1 RID: 200161
			public const int ItemStar = 6;

			// Token: 0x04030DE2 RID: 200162
			public const int SpriteGateLock = 7;

			// Token: 0x04030DE3 RID: 200163
			public const int SpriteLock = 8;

			// Token: 0x04030DE4 RID: 200164
			public const int SpriteGray = 9;

			// Token: 0x04030DE5 RID: 200165
			public const int SpriteLight = 10;

			// Token: 0x04030DE6 RID: 200166
			public const int ItemRedDot = 11;
		}
	}
}
