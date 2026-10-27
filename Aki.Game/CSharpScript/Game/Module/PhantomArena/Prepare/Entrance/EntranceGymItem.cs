using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x0200515C RID: 20828
	public class EntranceGymItem : GymItemBase
	{
		// Token: 0x060353F4 RID: 218100 RVA: 0x00C9B9F0 File Offset: 0x00C99BF0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUISprite)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(base.OnClickLevel))
			};
		}

		// Token: 0x060353F5 RID: 218101 RVA: 0x00C9BB50 File Offset: 0x00C99D50
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.LayoutStar = new GenericLayout<GymStarItem, GymChallengeData>(base.GetHorizontalLayout(2), new Func<GymStarItem>(this.CreateStarItem), null, false, true);
			base.GetButton(0).SetSelectionState(EUISelectableSelectionState.Normal);
			base.GetButton(0).FocusListenerDelegate.Bind(new Action(base.OnFocus));
		}

		// Token: 0x060353F6 RID: 218102 RVA: 0x00C9BBB9 File Offset: 0x00C99DB9
		[NullableContext(1)]
		private GymStarItem CreateStarItem()
		{
			return new GymStarItem();
		}

		// Token: 0x060353F7 RID: 218103 RVA: 0x00C9BBC0 File Offset: 0x00C99DC0
		protected override void OnBeforeShow()
		{
			UUIButtonComponent button = base.GetButton(0);
			button.OnPointEnterCallBack.Bind(new Action(base.OnHover));
			button.OnPointExitCallBack.Bind(new Action(base.OnUnHover));
			this.Refresh();
		}

		// Token: 0x060353F8 RID: 218104 RVA: 0x00C9BBFC File Offset: 0x00C99DFC
		public override void Refresh()
		{
			if (this.Level < 0)
			{
				return;
			}
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			bool flag = instance.IsGymLock(this.Level, this.ActivityId) || !instance.IsGymUnlockChecked(this.Level, this.ActivityId);
			PhantomBattleGym? phantomBattleGymConfigByLevel = instance.GetPhantomBattleGymConfigByLevel(this.Level, this.ActivityId);
			if (phantomBattleGymConfigByLevel == null)
			{
				return;
			}
			base.GetSprite(4).SetUIActive(!flag);
			base.GetSprite(5).SetUIActive(flag);
			this.SetSpriteByPath(phantomBattleGymConfigByLevel.Value.IconBg, base.GetSprite(4), false, null, null);
			base.GetSprite(7).SetUIActive(flag);
			base.GetSprite(8).SetUIActive(!flag);
			base.GetSprite(9).SetUIActive(flag);
			base.GetItem(11).SetUIActive(!flag);
			string path = flag ? phantomBattleGymConfigByLevel.Value.IconLock : phantomBattleGymConfigByLevel.Value.Icon;
			this.SetSpriteByPath(path, base.GetSprite(6), false, null, null);
			this.SetSpriteByPath(phantomBattleGymConfigByLevel.Value.IconRoman, base.GetSprite(10), false, null, null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), (phantomBattleGymConfigByLevel != null) ? phantomBattleGymConfigByLevel.GetValueOrDefault().Name : null, Array.Empty<object>());
			List<GymChallengeData> challengeStateListByGymLevel = instance.GetChallengeStateListByGymLevel(this.Level, this.ActivityId);
			this.LayoutStar.RefreshByData(challengeStateListByGymLevel, null, false);
			this.LayoutStar.SetActive(!flag);
			this.RefreshRedDot();
		}

		// Token: 0x060353F9 RID: 218105 RVA: 0x00C9BDB9 File Offset: 0x00C99FB9
		public override void RefreshRedDot()
		{
			base.GetItem(12).SetUIActive(base.GetRedDotState());
		}

		// Token: 0x0401C555 RID: 116053
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GymStarItem, GymChallengeData> LayoutStar;

		// Token: 0x0200B2BC RID: 45756
		private class EComponent
		{
			// Token: 0x0403625E RID: 221790
			public const int BtnLevel = 0;

			// Token: 0x0403625F RID: 221791
			public const int TextName = 1;

			// Token: 0x04036260 RID: 221792
			public const int LayoutStar = 2;

			// Token: 0x04036261 RID: 221793
			public const int ItemStar = 3;

			// Token: 0x04036262 RID: 221794
			public const int SpriteBg = 4;

			// Token: 0x04036263 RID: 221795
			public const int SpriteBgLock = 5;

			// Token: 0x04036264 RID: 221796
			public const int SpriteIcon = 6;

			// Token: 0x04036265 RID: 221797
			public const int SpriteLock = 7;

			// Token: 0x04036266 RID: 221798
			public const int SpriteLight = 8;

			// Token: 0x04036267 RID: 221799
			public const int SpriteGray = 9;

			// Token: 0x04036268 RID: 221800
			public const int SpriteRoman = 10;

			// Token: 0x04036269 RID: 221801
			public const int PanelUnlock = 11;

			// Token: 0x0403626A RID: 221802
			public const int ItemRedDot = 12;
		}
	}
}
